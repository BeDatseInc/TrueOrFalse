using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TrueOrFalse.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Object.Equals(storage, value))
            return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        
        protected void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            var handler = PropertyChanged;

            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        
    }
}
