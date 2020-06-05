using Foundation;
using System;
using UIKit;

namespace Starbox.iOS
{
    public partial class ProfileViewController : UIViewController
    {
        public static int userScore { get; set; }
        public ProfileViewController (IntPtr handle) : base (handle)
        {
        }

        public ProfileViewController()
           
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            NavigationController.NavigationBar.TopItem.Title = "Profile";
            if (AppDelegate.user.Id == "4788eabf-0fe0-4cf4-b12a-b1272063a55e")
            {
                infoLabel.Text = "Total coffee you sold today:";
                scoreLabel.Text = (userScore).ToString();
            }
            else
            {
                infoLabel.Text = "Your score is:";
                scoreLabel.Text = (userScore * 10).ToString();
            }
        }
    }
}