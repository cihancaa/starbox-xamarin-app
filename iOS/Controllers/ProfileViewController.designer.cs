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
    [Register ("ProfileViewController")]
    partial class ProfileViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel infoLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel scoreLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (infoLabel != null) {
                infoLabel.Dispose ();
                infoLabel = null;
            }

            if (scoreLabel != null) {
                scoreLabel.Dispose ();
                scoreLabel = null;
            }
        }
    }
}