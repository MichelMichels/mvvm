using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MichelMichels.MVVM
{
    public abstract class BaseValidatedPropertyChanged : BasePropertyChanged, IDataErrorInfo
    {
        public virtual bool IsValid => string.IsNullOrEmpty(this.Error);
        public virtual string Error => this[null]?.Trim();
        public virtual string this[string columnName] => string.Empty;

        protected virtual void SetValidatedProperty<T>(ref T innerValue, T value, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(innerValue, value))
            {
                innerValue = value;
                OnValidatedPropertyChanged(propertyName);
            }
        }
        protected virtual void OnValidatedPropertyChanged([CallerMemberName] string propertyName = null)
        {
            OnPropertyChanged(propertyName);

            switch (propertyName)
            {
                case nameof(Error):
                    OnPropertyChanged(nameof(IsValid));
                    break;
                default:
                    OnValidatedPropertyChanged(nameof(Error));
                    break;
            }
        }
    }
}