using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Binomo_Clone.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShellHomePage : Shell
    {
        public ShellHomePage()
        {
            InitializeComponent();
        }

        private void logout(object sender, EventArgs e)
        {
            App.Current.MainPage = new Pages.LoadingScreen();
        }

        
    }
}