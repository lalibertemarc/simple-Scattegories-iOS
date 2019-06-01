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
	[Register ("Categories_Controller")]
	partial class Categories_Controller
	{
		[Outlet]
		UIKit.UILabel _caterogiesTitleLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (_caterogiesTitleLabel != null) {
				_caterogiesTitleLabel.Dispose ();
				_caterogiesTitleLabel = null;
			}
		}
	}
}
