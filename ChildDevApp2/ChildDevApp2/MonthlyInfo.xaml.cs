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
    public partial class MonthlyInfo : ContentPage
    {
        public MonthlyInfo()
        {
            InitializeComponent();
        }

        private void Handle_Clicked_MonthlyPage1 (object sender, EventArgs e)
        {
            Navigation.PushAsync(new MonthlyInfoPage1());
        }

        private void Handle_Clicked_MonthlyPage2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MonthlyInfoPage2());
        }

        private void Handle_Clicked_MonthlyPage3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MonthlyInfoPage3());
        }
    }
}