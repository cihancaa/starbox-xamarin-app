using Foundation;
using Starbox.Model;
using System;
using System.Collections.Generic;
using UIKit;
using Starbox.iOS;

namespace Starbox.iOS
{
    public partial class DeliveredViewController : UITableViewController
    {
        List<Delivery> delivered;

        public DeliveredViewController (IntPtr handle) : base (handle)
        {
            delivered = new List<Delivery>();
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
            delivered = await Delivery.GetDelivered();
            TableView.ReloadData();
        }

        public override async void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            NavigationController.NavigationBar.TopItem.Title = "History";
            delivered = await Delivery.GetDelivered();
            TableView.ReloadData();
            ProfileViewController.userScore = delivered.Count;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return delivered.Count;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 100;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("deliveredCell") as deliveredTableViewCell;
            var deliveredValue = delivered[indexPath.Row];

            cell.orderTextField.Text = deliveredValue.Name + "  " + deliveredValue.Size + "  " + deliveredValue.Extras;
            if (AppDelegate.user.Id == "4788eabf-0fe0-4cf4-b12a-b1272063a55e")
            {
                cell.usernameTextField.Text = "Customer:  " + deliveredValue.Username;
            } else
            {
                cell.usernameTextField.Text = "";
            }

            

            switch (deliveredValue.Status)
            {
                case 0:
                    cell.statusTextField.Text = "Order is waiting";
                    break;
                case 2:
                    cell.statusTextField.Text = "Order is delivered";
                    break;
            }
            return cell;
        }
    }
}