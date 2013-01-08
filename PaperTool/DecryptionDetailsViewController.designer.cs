// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace PaperTool
{
	[Register ("DecryptionDetailsViewController")]
	partial class DecryptionDetailsViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIImageView imgQRCode { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblDetails { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (imgQRCode != null) {
				imgQRCode.Dispose ();
				imgQRCode = null;
			}

			if (lblDetails != null) {
				lblDetails.Dispose ();
				lblDetails = null;
			}
		}
	}
}
