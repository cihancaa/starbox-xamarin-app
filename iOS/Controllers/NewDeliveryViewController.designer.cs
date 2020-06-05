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
    [Register ("NewDeliveryViewController")]
    partial class NewDeliveryViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField extrasTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField packageNameTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem SaveBarButtonItem { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField sizeTextField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (extrasTextField != null) {
                extrasTextField.Dispose ();
                extrasTextField = null;
            }

            if (packageNameTextField != null) {
                packageNameTextField.Dispose ();
                packageNameTextField = null;
            }

            if (SaveBarButtonItem != null) {
                SaveBarButtonItem.Dispose ();
                SaveBarButtonItem = null;
            }

            if (sizeTextField != null) {
                sizeTextField.Dispose ();
                sizeTextField = null;
            }
        }
    }
}