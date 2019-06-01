// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Scattergories
{
	[Register ("Dash_Controller")]
	partial class Dash_Controller
	{
		[Outlet]
		UIKit.UILabel _letterLabel { get; set; }

		[Outlet]
		UIKit.UILabel _letterTitleLabel { get; set; }

		[Outlet]
		UIKit.UILabel _timerTitleLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (_letterTitleLabel != null) {
				_letterTitleLabel.Dispose ();
				_letterTitleLabel = null;
			}

			if (_letterLabel != null) {
				_letterLabel.Dispose ();
				_letterLabel = null;
			}

			if (_timerTitleLabel != null) {
				_timerTitleLabel.Dispose ();
				_timerTitleLabel = null;
			}
		}
	}
}
