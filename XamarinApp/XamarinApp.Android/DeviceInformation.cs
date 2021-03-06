﻿using System;
using Android.App;
using Android.Provider;
using Android.Telephony;

[assembly:Xamarin.Forms.Dependency(typeof(XamarinApp.Droid.DeviceInformation))]
namespace XamarinApp.Droid
{
    public class DeviceInformation : IDeviceInformation
    {
        /// <summary>
        /// Gets the ID of the device.
        /// </summary>
        public string GetDeviceID()
        {
            return Settings.Secure.GetString(Application.Context.ContentResolver, Settings.Secure.AndroidId);
        }
    }
}