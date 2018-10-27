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

namespace CheckList.iOS
{
    [Register ("CheckListTableViewCell")]
    partial class CheckListTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel DataVencimentoLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PetLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ResponsavelLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView StatusContainerView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView VencimentoContainerView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DataVencimentoLabel != null) {
                DataVencimentoLabel.Dispose ();
                DataVencimentoLabel = null;
            }

            if (PetLabel != null) {
                PetLabel.Dispose ();
                PetLabel = null;
            }

            if (ResponsavelLabel != null) {
                ResponsavelLabel.Dispose ();
                ResponsavelLabel = null;
            }

            if (StatusContainerView != null) {
                StatusContainerView.Dispose ();
                StatusContainerView = null;
            }

            if (VencimentoContainerView != null) {
                VencimentoContainerView.Dispose ();
                VencimentoContainerView = null;
            }
        }
    }
}