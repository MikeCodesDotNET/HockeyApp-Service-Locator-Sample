using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using HockeyApp.iOS;
using UIKit;

namespace HockeyAppSample.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{

			var manager = BITHockeyManager.SharedHockeyManager;
			manager.Configure("266b3657c18643bdb33b1b5004f0fb77");
			manager.StartManager();

			ServiceLocator.Instance.Add<IHockeyAppService, HockeyAppService>();

			global::Xamarin.Forms.Forms.Init();
			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
