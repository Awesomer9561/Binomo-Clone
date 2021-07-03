using Android.Widget;
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
    public partial class Login : ContentPage
    {
    public Login()
        {
            InitializeComponent();
        }

        private void LoginUser(object sender, EventArgs e)
        {
            App.Current.MainPage = new ShellHomePage();
        }

        private void resetpass(object sender, EventArgs e)
        {
            Toast.MakeText(Android.App.Application.Context, "Sorry this feature is not available right now!", ToastLength.Long).Show();
        }
    }
}