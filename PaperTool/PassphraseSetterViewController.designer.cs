// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace PaperTool
{
	[Register ("PassphraseSetterViewController")]
	partial class PassphraseSetterViewController
	{
		[Outlet]
		MonoTouch.UIKit.UISwitch switchShow { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISwitch switchSave { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txtPassphrase { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (switchShow != null) {
				switchShow.Dispose ();
				switchShow = null;
			}

			if (switchSave != null) {
				switchSave.Dispose ();
				switchSave = null;
			}

			if (txtPassphrase != null) {
				txtPassphrase.Dispose ();
				txtPassphrase = null;
			}
		}
	}
}
