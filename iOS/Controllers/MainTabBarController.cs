using Foundation;
using System;
using UIKit;

namespace Starbox.iOS
{
    public partial class MainTabBarController : UITabBarController
    {
        public MainTabBarController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            NavigationItem.SetHidesBackButton(true, false);
        }
    }
}