using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MichelMichels.MVVM
{
    public abstract class BasePropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected virtual void SetProperty<T>(ref T innerValue, T value, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(innerValue, value))
            {
                innerValue = value;
                OnPropertyChanged(propertyName);
            }            
        }
    }
}