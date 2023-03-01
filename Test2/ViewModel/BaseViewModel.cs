using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected bool Set<T>(ref T field, T value, string propName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propName);
            return true;
        }
        protected virtual void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(PropertyChanged, new PropertyChangedEventArgs(propName));
        }

    }
}
