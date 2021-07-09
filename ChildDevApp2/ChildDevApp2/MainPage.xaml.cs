using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChildDevApp2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;


        }

        void Handle_Clicked_Home_PageBtn(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;
            HomePageBtn.TextColor = Color.FromHex("#FBDCC3");
            Page1Btn.TextColor = Color.White;
            Page2Btn.TextColor = Color.White;
            Page3Btn.TextColor = Color.White;
            Page4Btn.TextColor = Color.White;
            Page5Btn.TextColor = Color.White;
            Page6Btn.TextColor = Color.White;


        }

        void Handle_Clicked_Page1(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new DateTracker());
            IsPresented = false;
            Page1Btn.TextColor = Color.FromHex("#FBDCC3");
            HomePageBtn.TextColor = Color.White;           
            Page2Btn.TextColor = Color.White;
            Page3Btn.TextColor = Color.White;
            Page4Btn.TextColor = Color.White;
            Page5Btn.TextColor = Color.White;
            Page6Btn.TextColor = Color.White;
        }

        void Handle_Clicked_Page2(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new MonthlyInfo());
            IsPresented = false;
            Page2Btn.TextColor = Color.FromHex("#FBDCC3");
            HomePageBtn.TextColor = Color.White;
            Page1Btn.TextColor = Color.White;
            Page3Btn.TextColor = Color.White;
            Page4Btn.TextColor = Color.White;
            Page5Btn.TextColor = Color.White;
            Page6Btn.TextColor = Color.White;
        }

        void Handle_Clicked_Page3(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Diet());
            IsPresented = false;
            Page3Btn.TextColor = Color.FromHex("#FBDCC3");
            HomePageBtn.TextColor = Color.White;
            Page1Btn.TextColor = Color.White;
            Page2Btn.TextColor = Color.White;
            Page4Btn.TextColor = Color.White;
            Page5Btn.TextColor = Color.White;
            Page6Btn.TextColor = Color.White;
        }

        void Handle_Clicked_Page4(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Vaccines());
            IsPresented = false;
            Page4Btn.TextColor = Color.FromHex("#FBDCC3");
            HomePageBtn.TextColor = Color.White;
            Page1Btn.TextColor = Color.White;
            Page2Btn.TextColor = Color.White;
            Page3Btn.TextColor = Color.White;
            Page5Btn.TextColor = Color.White;
            Page6Btn.TextColor = Color.White;
        }

        void Handle_Clicked_Page5(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Health());
            IsPresented = false;
            Page5Btn.TextColor = Color.FromHex("#FBDCC3");
            HomePageBtn.TextColor = Color.White;
            Page1Btn.TextColor = Color.White;
            Page2Btn.TextColor = Color.White;
            Page3Btn.TextColor = Color.White;
            Page4Btn.TextColor = Color.White;
            Page6Btn.TextColor = Color.White;
        }

        void Handle_Clicked_Page6(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new CareMap());
            IsPresented = false;
            HomePageBtn.TextColor = Color.White;
            Page1Btn.TextColor = Color.White;
            Page2Btn.TextColor = Color.White;
            Page3Btn.TextColor = Color.White;
            Page4Btn.TextColor = Color.White;
            Page5Btn.TextColor = Color.White;
            Page6Btn.TextColor = Color.FromHex("#FBDCC3");
        }
    }

    
}
