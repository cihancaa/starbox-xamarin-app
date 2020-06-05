using Foundation;
using Starbox.Model;
using System;
using UIKit;

namespace Starbox.iOS
{
    public partial class NewDeliveryViewController : UIViewController
    {
        public NewDeliveryViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SaveBarButtonItem.Clicked += SaveBarButtonItem_Clicked; 
        }

        private async void SaveBarButtonItem_Clicked(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery()
            {
                Name = packageNameTextField.Text,
                Status = 0,
                UserId = AppDelegate.user.Id,
                Username = AppDelegate.user.Email,
                Size = sizeTextField.Text,
                Extras = extrasTextField.Text
                
            };

            await Delivery.InsertDelivery(delivery);
            var alert = UIAlertController.Create("Success", "Your order is getting ready", UIAlertControllerStyle.Alert);

            alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            PresentViewController(alert, true, null);

        }
    }
}