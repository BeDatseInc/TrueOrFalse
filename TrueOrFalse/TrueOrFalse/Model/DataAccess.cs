

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
using Xamarin.Forms;

namespace TrueOrFalse.Model
{

    class DataAccess<T> where T:Phrases
    {
        public MobileServiceClient MobileService{ get; set; }
        IMobileServiceSyncTable<T> table;
        bool isInitialized;

        public async Task Initialize()
        {
            if (isInitialized) 
                return;

            var watch = new Stopwatch();
            watch.Start();
            MobileService = new MobileServiceClient("https://trueorfalsebedatse.azurewebsites.net");
            
            string path = "syncstore.db";
            var store = new MobileServiceSQLiteStore(path);
            store.DefineTable<T>();
            await MobileService.SyncContext.InitializeAsync(store, new MobileServiceSyncHandler());
            table = MobileService.GetSyncTable<T>();

            isInitialized = true;
            watch.Stop();
            Debug.WriteLine("Time to load phrases was " + watch.ElapsedMilliseconds);
        }

        public async Task<IList<T>> GetPhrases()
        {
            return await table.ToListAsync();
        }
        public async Task<IList<Phrases>> GetPhrases(int num)
        {
            await Initialize();
            IList<T> list = await table.ToListAsync();

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
                await table.PullAsync("allPhrases", table.CreateQuery());
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

    //public class DataAccess<T> : IDisposable where T:Phrases, new ()
    //{
    //    private SQLite.SQLiteConnection _connection;

    //    public DataAccess()
    //    {
    //        var config = DependencyService.Get<IConfig>();
    //        _connection = new SQLite.SQLiteConnection(System.IO.Path.Combine(config.DBDirectory, "main.db3"));

    //        _connection.CreateTable<T>();
    //    }

    //    public void Insert(T phrase)
    //    {
    //        _connection.Insert(phrase);
    //    }
    //    public void InsertAll(List<T> phrases)
    //    {
    //        _connection.InsertAll(phrases);
    //    }

    //    public void Delete(T phrase)
    //    {
    //        _connection.Delete(phrase);
    //    }
    //    public void DeleteAll()
    //    {
    //        _connection.DeleteAll<T>();
    //    }

    //    public T GetTByID(string id)
    //    {
    //        return _connection.Table<T>().FirstOrDefault(p => p.Id == id);
    //    }

    //    public void Update(T T)
    //    {
    //        _connection.Update(T);
    //    }

    //    public int Count()
    //    {
    //        return _connection.Table<T>().Count();
    //    }
    //    public IList<T> GetPhrasesList()
    //    {
    //        return _connection.Table<T>().ToList();
    //    }
    //    public IList<Phrases> GetPhrasesList(int num)
    //    {
    //        IList<T> list = _connection.Table<T>().ToList();
    //        IList<Phrases> returnList = new List<Phrases>();
    //        Random random = new Random();

    //        for (int i = 0; i < num; i++)
    //        {
    //            int j = random.Next(list.Count);
    //            while (returnList.Contains(list[j]) || String.IsNullOrEmpty(list[j].Phrase))
    //            {
    //                j = random.Next(list.Count);
    //            }
    //            returnList.Add(list[j]);
    //        }
    //        return returnList;

    //    }

    //    public void Dispose()
    //    {
    //        _connection.Dispose();
    //    }
    //}
}