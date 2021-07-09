using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChildDevApp2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Diet : ContentPage
    {
        public Diet()
        {
            InitializeComponent();
        }

        private void DietPlansTapped (object sender, EventArgs e)
        {
            Xamarin.Essentials.Browser.OpenAsync("https://www.babycentre.co.uk/a1046500/pregnancy-meal-planners-trimester-by-trimester", Xamarin.Essentials.BrowserLaunchMode.SystemPreferred); 
        }
    }
}