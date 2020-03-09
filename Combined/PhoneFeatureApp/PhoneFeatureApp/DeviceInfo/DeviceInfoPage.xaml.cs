using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PhoneFeatureApp.DeviceInfo
{
    public partial class DeviceInfoPage : ContentPage
    {
        public DeviceInfoPage()
        {
            InitializeComponent();

            //For this example, IconImageSource is set in XAML
            //this.IconImageSource = "device.png";

            BindingContext = new DeviceInfoPageViewModel(this.Navigation);

        }
    }
}
