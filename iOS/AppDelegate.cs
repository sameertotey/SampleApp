using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Foundation;
using UIKit;


namespace sampleapp.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
			MobileCenter.Start("f2a3c3e3-dfe7-489e-bc28-f0a1ed5bcae9",
				   typeof(Analytics), typeof(Crashes));

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

			

            return base.FinishedLaunching(app, options);
        }
    }
}
