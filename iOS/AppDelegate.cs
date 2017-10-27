using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Foundation;
using UIKit;

namespace demo171028.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            MobileCenter.Start("38fd8461-e873-4e71-94e7-e17418ddc514",
                   typeof(Analytics), typeof(Crashes));

            return base.FinishedLaunching(app, options);
        }
    }
}
