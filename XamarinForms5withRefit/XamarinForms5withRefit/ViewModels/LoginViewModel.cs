using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms5withRefit.ViewModels
{
    public class LoginViewModel : BindableObject
    {
        public LoginViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
        }

        int counter = 0;
        string counterText = "Hello";

        public ICommand IncreaseCount { get; }

        private void OnIncrease()
        {
            counter++;
            CounterLbl = $"You clicked button {counter} times.";
        }

        public string CounterLbl
        {
            get => counterText;
            set
            {
                if (value.Equals(counterText))
                    return;

                counterText = value;
                OnPropertyChanged();
            }
        }
    }
}
