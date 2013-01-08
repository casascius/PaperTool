// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace PaperTool
{
	[Register ("DecryptionToolViewController")]
	partial class DecryptionToolViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIImageView imageCaptureView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblResult { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIActivityIndicatorView activityIndicator { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnDetails { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (imageCaptureView != null) {
				imageCaptureView.Dispose ();
				imageCaptureView = null;
			}

			if (lblResult != null) {
				lblResult.Dispose ();
				lblResult = null;
			}

			if (activityIndicator != null) {
				activityIndicator.Dispose ();
				activityIndicator = null;
			}

			if (btnDetails != null) {
				btnDetails.Dispose ();
				btnDetails = null;
			}
		}
	}
}
