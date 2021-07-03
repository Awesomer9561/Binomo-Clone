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
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpUser(object sender, EventArgs e)
        {
            App.Current.MainPage = new ShellHomePage();
        }

        private void LoginPage(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Login());
        }
    }
}