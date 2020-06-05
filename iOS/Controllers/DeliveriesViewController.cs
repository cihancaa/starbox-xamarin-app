using Foundation;
using Starbox.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using UIKit;

namespace Starbox.iOS
{
    public partial class DeliveriesViewController : UITableViewController
    {
        List<Delivery> deliveries;
        public DeliveriesViewController (IntPtr handle) : base (handle)
        {
            deliveries = new List<Delivery>();
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
            deliveries = await Delivery.GetDeliveries();
            TableView.ReloadData();

        }

        public override async void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            deliveries = await Delivery.GetDeliveries();
            TableView.ReloadData();

            if (AppDelegate.user.Id == "4788eabf-0fe0-4cf4-b12a-b1272063a55e")
            {
                NavigationController.NavigationBar.TopItem.Title = "Welcome to Admin Panel";
            }
            else
            {
                NavigationController.NavigationBar.TopItem.Title = "Welcome again, " + AppDelegate.user.Email;
            }
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return deliveries.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("deliveryCell") as OrderTableViewCell;
            var delivery = deliveries[indexPath.Row];
            cell.orderNameLabel.Text = delivery.Name + "  " + delivery.Size + "  " + delivery.Extras;
            if (AppDelegate.user.Id == "4788eabf-0fe0-4cf4-b12a-b1272063a55e")
            {
                cell.usernameLabel.Text = "Customer:  " + delivery.Username;
            }
            else
            {
                cell.usernameLabel.Text = "";
            }

            switch (delivery.Status)
            {
                case 0:
                    cell.statusLabel.Text = "Order is waiting";
                    break;
                case 2:
                    cell.statusLabel.Text = "Order is ready";
                    break;
            }
            return cell;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 100;
        }

        public override async void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, Foundation.NSIndexPath indexPath)
        {
            switch (editingStyle)
            {
                case UITableViewCellEditingStyle.Delete:
                    var delivery = (await AppDelegate.MobileService.GetTable<Delivery>().Where(d => d.Id == deliveries[indexPath.Row].Id).ToListAsync()).FirstOrDefault();
                    await Delivery.MarkAsDelivered(delivery);
                    // remove the item from the underlying data source
                    deliveries.RemoveAt(indexPath.Row);
                    // delete the row from the table
                    tableView.DeleteRows(new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);
                    break;
                case UITableViewCellEditingStyle.None:
                    Console.WriteLine("CommitEditingStyle:None called");
                    break;
            }
        }
    }
}
