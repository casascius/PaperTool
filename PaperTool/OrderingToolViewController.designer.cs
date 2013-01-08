// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace PaperTool
{
	[Register ("OrderingToolViewController")]
	partial class OrderingToolViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIStepper stepCodeCount { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblCodeCount { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnGenerate { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIActivityIndicatorView actIndicator { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (stepCodeCount != null) {
				stepCodeCount.Dispose ();
				stepCodeCount = null;
			}

			if (lblCodeCount != null) {
				lblCodeCount.Dispose ();
				lblCodeCount = null;
			}

			if (btnGenerate != null) {
				btnGenerate.Dispose ();
				btnGenerate = null;
			}

			if (actIndicator != null) {
				actIndicator.Dispose ();
				actIndicator = null;
			}
		}
	}
}
