using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BIT_MOBILE
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();
            var browser = new WebView();
            browser.Source = "http://bitxchange.azurewebsites.net/";
            Content = browser;
        }
    }
}
