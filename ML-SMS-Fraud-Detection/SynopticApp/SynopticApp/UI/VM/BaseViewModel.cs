using SynopticApp.UI.Pages;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SynopticApp.UI.VM
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        
        public Dictionary<string, ICommand> Commands {  get; protected set; } 

        // Definiting the isBusy boolean value, which will be used for
        // toggle the busy state of the model. Ensures the user can't run
        // the scan more than once.
        bool isBusy = false;   
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value);  }
        }


        // Function for the property change and to set property values..
        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChange = null)
        {
            // is new value the same?
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            // changes the stored value to new value 
            backingStore = value;
            onChange?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var handler = PropertyChanged;
            if (handler == null) return;

            handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
