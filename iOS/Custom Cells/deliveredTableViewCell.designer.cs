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
    [Register ("deliveredTableViewCell")]
    partial class deliveredTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UILabel orderTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UILabel statusTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UILabel usernameTextField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (orderTextField != null) {
                orderTextField.Dispose ();
                orderTextField = null;
            }

            if (statusTextField != null) {
                statusTextField.Dispose ();
                statusTextField = null;
            }

            if (usernameTextField != null) {
                usernameTextField.Dispose ();
                usernameTextField = null;
            }
        }
    }
}