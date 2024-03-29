﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using Android.Views;

namespace BluetoothCarTracker.Droid
{
    [Activity(
            MainLauncher = true,
            ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize,
            WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden
        )]
    public class MainActivity : Windows.UI.Xaml.ApplicationActivity
    {
        Services.BluetoothFragment Fragment { get; set; }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var tx = FragmentManager.BeginTransaction();
            Fragment = new Services.BluetoothFragment();
            tx.Replace(Android.Resource.Id.Content, Fragment);
            tx.Commit();
        }
    }
}

