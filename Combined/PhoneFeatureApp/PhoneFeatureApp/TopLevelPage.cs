﻿using System;
using PhoneFeatureApp.DeviceInfo;
using PhoneFeatureApp.Location;
using PhoneFeatureApp.Motion;
using Xamarin.Forms;

namespace PhoneFeatureApp
{
    public class TopLevelPage : TabbedPage
    {
        public TopLevelPage()
        {
            Title = "Phone Feature App";

            var info = new DeviceInfoPage();
            var nav = new NavigationPage(info);
            nav.Title = info.Title;
            nav.IconImageSource = info.IconImageSource;

            Children.Add(nav);
            Children.Add(new LocationPage());
            Children.Add(new MotionPage());

            if (Device.RuntimePlatform == Device.Android)
            {
                //BarBackgroundColor = new Color(1.0, 1.0, 1.0);
               // BarTextColor = new Color(0.0, 0.0, 1.0);

                //Try this instead
                Xamarin.Forms.PlatformConfiguration.AndroidSpecific.TabbedPage.SetToolbarPlacement(this, Xamarin.Forms.PlatformConfiguration.AndroidSpecific.ToolbarPlacement.Bottom);
            }
        }
    }
}

