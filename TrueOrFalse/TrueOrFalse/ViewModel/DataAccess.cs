using System;
using System.Linq;
using Xamarin.Forms;
using System.Collections.Generic;

namespace TrueOrFalse
{
    public class DataAccess<T> : IDisposable where T:Phrases, new ()
    {
        private SQLite.SQLiteConnection _connection;

        public DataAccess()
        {
            var config = DependencyService.Get<IConfig>();
            _connection = new SQLite.SQLiteConnection(System.IO.Path.Combine(config.DBDirectory, "main.db3"));

            _connection.CreateTable<T>();
        }

        public void Insert(T phrase)
        {
            _connection.Insert(phrase);
        }
        public void InsertAll(List<T> phrases)
        {
            _connection.InsertAll(phrases);
        }

        public void Delete(T phrase)
        {
            _connection.Delete(phrase);
        }

        public T GetTByID(int id)
        {
            return _connection.Table<T>().FirstOrDefault(p => p.Id == id);
        }

        public void Update(T T)
        {
            _connection.Update(T);
        }

        public int Count()
        {
            return _connection.Table<T>().Count();
        }
        public IList<T> GetPhrasesList()
        {
            return _connection.Table<T>().ToList();
        }
        public IList<Phrases> GetPhrasesList(int num)
        {
            IList<T> list = _connection.Table<T>().ToList();
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
        
        public void Dispose()
        {
            _connection.Dispose();
        }
    }
}