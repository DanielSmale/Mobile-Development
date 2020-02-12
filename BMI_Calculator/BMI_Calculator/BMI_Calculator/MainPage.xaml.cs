using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI_Calculator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        enum entrySource
        {
            weight,
            height
        }



        private BMIModel model = new BMIModel();
        public MainPage()
        {
            InitializeComponent();
            BmiLabel.IsVisible = false;
            OutputLabel.IsVisible = false;
        }

        private async Task SyncViewAndModelAsync(entrySource src, string newValueAsString)
        {
            bool success;
            string errorString;

            if (src == entrySource.height)
            {
                success = model.SetHeightAsString(newValueAsString, out errorString);
                HeightErrorLabel.IsVisible = !success;
            }
            else
            {
                success = model.SetWeightAsString(newValueAsString, out errorString);
                WeightErrorLabel.IsVisible = !success;
            }

            if (model.BMIValue != null)
            {
                BmiLabel.IsVisible = true;
                OutputLabel.IsVisible = true;
                OutputLabel.Text = string.Format("{0:f1}", model.BMIValue);

            }
            else
            {
                BmiLabel.IsVisible = false;
                OutputLabel.IsVisible = false;

            }
            if (!success)
            {
                await GiveFeedback(errorString);
            }
        }

        private async Task GiveFeedback(string messageString)
        {
            ErrorLabel.Text = messageString;
            await ErrorLabel.FadeTo(1.0, 500);
            await Task.Delay(2000);
            await ErrorLabel.FadeTo(0.0, 500);
        }
        private async void Handle_HeightAsync(object sender, TextChangedEventArgs e)
        {
            await SyncViewAndModelAsync(entrySource.height, e.NewTextValue);

        }
        private async void Handle_WeightAsync(object sender, TextChangedEventArgs e)
        {
            await SyncViewAndModelAsync(entrySource.weight, e.NewTextValue);
        }
    }
}
