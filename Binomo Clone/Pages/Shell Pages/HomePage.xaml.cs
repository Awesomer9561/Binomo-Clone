using Android.Widget;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Binomo_Clone.Pages.Shell_Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void refreshAmount(object sender, EventArgs e)
        {
            await refreshBtn.RotateTo(720, 2000, Easing.Linear);
            refreshBtn.Rotation = 0;

            Toast.MakeText(Android.App.Application.Context, "Amount refreshed!", ToastLength.Short).Show();
        }

        private void openFlyout(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = true;
        }

        private void activeRedArrow(object sender, EventArgs e)
        {
            redArrow.BackgroundColor = Color.FromHex("#e74c3c");
            greenArrow.BackgroundColor = Color.FromHex("#303033");
        }

        private void activeGreenArrow(object sender, EventArgs e)
        {
            greenArrow.BackgroundColor = Color.FromHex("#20bf6b");
            redArrow.BackgroundColor = Color.FromHex("#303033");
        }

        private void gotoLogin(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new LoginOrSignUp());
        }
    }
}