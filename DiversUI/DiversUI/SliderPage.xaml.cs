using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiversUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SliderPage : ContentPage
    {
        public SliderPage()
        {
            InitializeComponent();

        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            lbldisp.Text = String.Format("Slider value is {0:F1}", e.NewValue);
            if (e.NewValue == 0)
            {
                Switcher.IsToggled = false;
            }
            if (e.NewValue == 100)
            {
                Switcher.IsToggled = true;
            }


        }
        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            date.Text = "Date : " + e.NewDate.ToShortDateString();
            time.Text = "Time : " + e.NewDate.ToLongTimeString();
        }
        void SwitchToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == true)
            {
                SDemo.Value = 100;
            }
            else
            {
                SDemo.Value = 0;
            }

        }






    }
}