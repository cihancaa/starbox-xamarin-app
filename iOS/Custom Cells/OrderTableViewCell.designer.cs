// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Starbox.iOS
{
    [Register ("OrderTableViewCell")]
    partial class OrderTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UILabel orderNameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UILabel statusLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UILabel usernameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (orderNameLabel != null) {
                orderNameLabel.Dispose ();
                orderNameLabel = null;
            }

            if (statusLabel != null) {
                statusLabel.Dispose ();
                statusLabel = null;
            }

            if (usernameLabel != null) {
                usernameLabel.Dispose ();
                usernameLabel = null;
            }
        }
    }
}