// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace IndoorNavigation.iOS
{
    [Register ("MainViewController")]
    partial class MainViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView AutosuggestionsTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CurrentLocationButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView FloorsTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton HomeButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton InvisibleButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISearchBar LocationSearchBar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Esri.ArcGISRuntime.UI.Controls.MapView MapView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Settings { get; set; }

        [Action ("Home_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Home_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AutosuggestionsTableView != null) {
                AutosuggestionsTableView.Dispose ();
                AutosuggestionsTableView = null;
            }

            if (CurrentLocationButton != null) {
                CurrentLocationButton.Dispose ();
                CurrentLocationButton = null;
            }

            if (FloorsTableView != null) {
                FloorsTableView.Dispose ();
                FloorsTableView = null;
            }

            if (HomeButton != null) {
                HomeButton.Dispose ();
                HomeButton = null;
            }

            if (InvisibleButton != null) {
                InvisibleButton.Dispose ();
                InvisibleButton = null;
            }

            if (LocationSearchBar != null) {
                LocationSearchBar.Dispose ();
                LocationSearchBar = null;
            }

            if (MapView != null) {
                MapView.Dispose ();
                MapView = null;
            }

            if (Settings != null) {
                Settings.Dispose ();
                Settings = null;
            }
        }
    }
}