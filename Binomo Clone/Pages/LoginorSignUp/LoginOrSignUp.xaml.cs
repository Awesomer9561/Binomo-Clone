using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Binomo_Clone.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginOrSignUp : ContentPage
    {
        public LoginOrSignUp()
        {
            InitializeComponent();
        }

        private void gotoSignUp(object sender, EventArgs e)
        {
            //Application.Current.MainPage = new NavigationPage(new SignUp());
            Navigation.PushAsync(new SignUp());
            
        }

        private void gotoLogin(object sender, EventArgs e)
        {
            //Application.Current.MainPage = new NavigationPage(new Login());
            Navigation.PushAsync(new Login());
        }
    }
}