using Binomo_Clone.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Binomo_Clone.Pages.Shell_Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Trades : ContentPage
    {
        ObservableCollection<investmentCFD> CFDs;
        public Trades()
        {
            InitializeComponent();
            setCFDs();
        }

        private void setCFDs()
        {
            CFDs = new ObservableCollection<investmentCFD>();
            CFDs.Add(new investmentCFD
            {
                InvestImage = "gold.png",
                Name = "Gold"
            });
            CFDs.Add(new investmentCFD
            {
                InvestImage = "eth.png",
                Name = "Ethereum"
            });
            CFDs.Add(new investmentCFD
            {
                InvestImage = "btc.png",
                Name = "Bitcoin"
            });
            CFDs.Add(new investmentCFD
            {
                InvestImage = "gold.png",
                Name = "Gold"
            });
            CFDs.Add(new investmentCFD
            {
                InvestImage = "eth.png",
                Name = "Ethereum"
            });
            CFDs.Add(new investmentCFD
            {
                InvestImage = "btc.png",
                Name = "Bitcoin"
            });
            CFDs.Add(new investmentCFD
            {
                InvestImage = "gold.png",
                Name = "Gold"
            });
            CFDs.Add(new investmentCFD
            {
                InvestImage = "eth.png",
                Name = "Ethereum"
            });
            CFDs.Add(new investmentCFD
            {
                InvestImage = "btc.png",
                Name = "Bitcoin"
            });
            CFDs.Add(new investmentCFD
            {
                InvestImage = "gold.png",
                Name = "Gold"
            });
            CFDs.Add(new investmentCFD
            {
                InvestImage = "eth.png",
                Name = "Ethereum"
            });
            CFDs.Add(new investmentCFD
            {
                InvestImage = "btc.png",
                Name = "Bitcoin"
            });
            investmentList.ItemsSource = CFDs;
        }

        private void activeCFD(object sender, EventArgs e)
        {
            activeTab.SetValue(Grid.ColumnProperty, 1);
            CFD.TextColor = Color.Black;
            Standard.TextColor = Color.White;
            CFDView.IsVisible = true;
            StandardView.IsVisible = false;
        }
        private void activeStandard(object sender, EventArgs e)
        {
            activeTab.SetValue(Grid.ColumnProperty, 0);
            CFD.TextColor = Color.White;
            Standard.TextColor = Color.Black;
            CFDView.IsVisible = false;
            StandardView.IsVisible = true;
        }

        private void openFlyout(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = true;
        }
    }
}