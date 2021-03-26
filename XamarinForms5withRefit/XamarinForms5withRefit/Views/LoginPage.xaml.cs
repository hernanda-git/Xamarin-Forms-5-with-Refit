using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms5withRefit.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            CounterLabel.Text = "Hello!";
        }

        int counter = 0;

        private void CounterBtn_Clicked(object sender, EventArgs e)
        {
            counter++;
            CounterLabel.Text = $"You clicked button {counter} times.";
        }
    }
}