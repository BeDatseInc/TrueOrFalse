using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(TrueOrFalse.Droid.Config))]
namespace TrueOrFalse.Droid
{
    public class Config : IConfig
    {
        private string _dbdirectory;

        

        public string DBDirectory
        {
            get
            {
                if (string.IsNullOrEmpty(_dbdirectory))
                {
                    _dbdirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                }
                return _dbdirectory;
            }
        }
    }
}