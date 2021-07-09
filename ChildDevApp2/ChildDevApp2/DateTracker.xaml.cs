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
    public partial class DateTracker : ContentPage
    {
        public DateTracker()
        {
            InitializeComponent();
            Recalculate();
            //Setup();
            
        }

        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
           // Recalculate();
            Setup();
        }

        public void Recalculate()
        {
            
           // var diff2 = (endDatePicker.Date - DateTime.Now).TotalDays.ToString();
            //LabelDaysLeft.Text = diff2;

           // var TotalDays = endDatePicker.Date - DateTime.Now;
        }

        private List<Event> AllEvents { get; set; }
        public string diff2 { get; private set; }
        //public int TotalDays { get; private set; }

        private List<Event> GetEvents()
        {
           var totalDays = (endDatePicker.Date - DateTime.Now).TotalDays;
           int totalDaysint = Convert.ToInt32(totalDays);
            return new List<Event>()
            {
           
            new Event { EventTitle = "Birth Day", BgColor = "#FE9C8F", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(totalDaysint, 0, 0, 0).Ticks) },
            };
        }

       

            private void Setup()
        {
            AllEvents = GetEvents();
            eventList.ItemsSource = AllEvents;

            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
                foreach (var evt in AllEvents)
                {
                    var timespan = evt.Date - DateTime.Now;
                    evt.Timespan = timespan;
                }

                eventList.ItemsSource = null;
                eventList.ItemsSource = AllEvents;

                return true;
            });
        }

        public class Event
        {
            public DateTime Date { get; set; }
            public string EventTitle { get; set; }
            public TimeSpan Timespan { get; set; }       
            public string Days => Timespan.Days.ToString("00");
            public string Hours => Timespan.Hours.ToString("00");
            public string Minutes => Timespan.Minutes.ToString("00");
            public string Seconds => Timespan.Seconds.ToString("00");
            public string BgColor { get; set; }
        }
    }

}
