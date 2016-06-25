using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;

namespace TrueOrFalse.Services
{

    class DataAccess<T> where T:Phrases
    {
        public MobileServiceClient MobileService{ get; set; }
        private IMobileServiceSyncTable<T> _table;
        private bool _isInitialized;

        public async Task Initialize()
        {
            if (_isInitialized) 
                return;

            var watch = new Stopwatch();
            watch.Start();
            MobileService = new MobileServiceClient("https://trueorfalsebedatse.azurewebsites.net");
            
            string path = "syncstore.db";
            var store = new MobileServiceSQLiteStore(path);
            store.DefineTable<T>();
            await MobileService.SyncContext.InitializeAsync(store, new MobileServiceSyncHandler());
            _table = MobileService.GetSyncTable<T>();

            _isInitialized = true;
            watch.Stop();
            Debug.WriteLine("Time to load phrases was " + watch.ElapsedMilliseconds);
        }

        public async Task<IList<T>> GetPhrases()
        {
            return await _table.ToListAsync();
        }
        public async Task<IList<Phrases>> GetPhrases(int num)
        {
            await Initialize();
            IList<T> list = await _table.ToListAsync();

            IList<Phrases> returnList = new List<Phrases>();
            Random random = new Random();

            for (int i = 0; i < num; i++)
            {
                int j = random.Next(list.Count);
                while (returnList.Contains(list[j]) || String.IsNullOrEmpty(list[j].Phrase))
                {
                    j = random.Next(list.Count);
                }
                returnList.Add(list[j]);
            }
            return returnList;
        }

        public async Task Sync()
        {
            var watch = new Stopwatch();
            watch.Start();
            try
            {
                await _table.PullAsync("allPhrases", _table.CreateQuery());
                await MobileService.SyncContext.PushAsync();
            }
            catch (Exception ex)
            {

                Debug.WriteLine("Unable to sync phrases, that is alright as we have offline capabilities: " + ex);
            }
            watch.Stop();
            Debug.WriteLine("Time to sync phrases was " + watch.ElapsedMilliseconds);
        }
      


    }
    
}