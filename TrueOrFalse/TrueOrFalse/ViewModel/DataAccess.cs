using System;
using System.Linq;
using Xamarin.Forms;
using System.Collections.Generic;

namespace TrueOrFalse
{
    public class DataAccess : IDisposable
    {
        private SQLite.SQLiteConnection _connection;

        public DataAccess()
        {
            var config = DependencyService.Get<IConfig>();
            _connection = new SQLite.SQLiteConnection(System.IO.Path.Combine(config.DBDirectory, "main.db3"));

            _connection.CreateTable<Phrases>();
        }

        public void Insert(Phrases phrases)
        {
            _connection.Insert(phrases);
        }

        public void Delete(Phrases phrases)
        {
            _connection.Delete(phrases);
        }

        public Phrases GetPhrasesByID(int id)
        {
            return _connection.Table<Phrases>().FirstOrDefault(p => p.Id == id);
        }

        public void Update(Phrases phrases)
        {
            _connection.Update(phrases);
        }

        public int Count()
        {
            return _connection.Table<Phrases>().Count();
        }
        public List<Phrases> GetListPhrases()
        {
            return _connection.Table<Phrases>().ToList();
        }
        public List<Phrases> GetListPhrases(int num)
        {
            List<Phrases> list = _connection.Table<Phrases>().ToList();
            List<Phrases> returnList = new List<Phrases>();
            Random random = new Random();

            for (int i = 0; i < num; i++)
            {
                int j = random.Next(list.Count);
                while (returnList.Contains(list[j]))
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