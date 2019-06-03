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
    [Register ("Dashboard_Controller")]
    partial class Dashboard_Controller
    {
        [Outlet]
        UIKit.UILabel _letterLabel { get; set; }

        [Outlet]
        UIKit.UILabel _letterTitleLabel { get; set; }

        [Outlet]
        UIKit.UIButton _newGameButton { get; set; }

        [Outlet]
        UIKit.UIButton _stopButton { get; set; }

        [Outlet]
        UIKit.UILabel _timerLabel { get; set; }

        [Outlet]
        UIKit.UISlider _timerSlider { get; set; }

        [Outlet]
        UIKit.UILabel _timerTitleLabel { get; set; }
        
        void ReleaseDesignerOutlets ()
        {
            if (_stopButton != null) {
                _stopButton.Dispose ();
                _stopButton = null;
            }

            if (_letterLabel != null) {
                _letterLabel.Dispose ();
                _letterLabel = null;
            }

            if (_letterTitleLabel != null) {
                _letterTitleLabel.Dispose ();
                _letterTitleLabel = null;
            }

            if (_newGameButton != null) {
                _newGameButton.Dispose ();
                _newGameButton = null;
            }

            if (_timerLabel != null) {
                _timerLabel.Dispose ();
                _timerLabel = null;
            }

            if (_timerSlider != null) {
                _timerSlider.Dispose ();
                _timerSlider = null;
            }

            if (_timerTitleLabel != null) {
                _timerTitleLabel.Dispose ();
                _timerTitleLabel = null;
            }
        }
    }
}
