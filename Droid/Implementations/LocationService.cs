// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocationService.cs" company="ArcTouch, Inc.">
//   All rights reserved.
//
//   This file, its contents, concepts, methods, behavior, and operation
//   (collectively the "Software") are protected by trade secret, patent,
//   and copyright laws. The use of the Software is governed by a license
//   agreement. Disclosure of the Software to third parties, in any form,
//   in whole or in part, is expressly prohibited except as authorized by
//   the license agreement.
// </copyright>
// <summary>
//   Defines the LocationService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
//
//
using System;
using Leaf.Interfaces;
using Xamarin.Forms;
using Leaf.Droid.Implementations;
using Android.Locations;
using Android.App;
using Android.Content;
using Leaf.Event;

[assembly: Dependency(typeof(LocationService))]
namespace Leaf.Droid.Implementations
{
    public class LocationService : Activity, ILocationService, ILocationListener
    {
        public event EventHandler<LocationUpdatedEventArgs> LocationUpdated;

        private LocationManager manager;

        public void StartUpdatingLocation()
        {
            this.manager = (LocationManager)Android.App.Application.Context.GetSystemService(Context.LocationService);

            string provider = GetProvider();
            StartListening(provider);
        }

        private string GetProvider()
        {
            Criteria locationCriteria = new Criteria();
            locationCriteria.Accuracy = Accuracy.Fine;

            return this.manager.GetBestProvider(locationCriteria, true);
        }

        private void StartListening(string provider)
        {
            if(!string.IsNullOrEmpty(provider))
            {
                this.manager.RequestLocationUpdates(provider, 5, 50, this);
            }
        }

        public void OnLocationChanged(Location location)
        {
            if(LocationUpdated!=null)
            {
                LocationUpdated(this, new LocationUpdatedEventArgs(location.Latitude, location.Longitude));
            }
        }

        public void OnProviderDisabled(string provider)
        {
            
        }

        public void OnProviderEnabled(string provider)
        {
            
        }

        public void OnStatusChanged(string provider, Availability status, Android.OS.Bundle extras)
        {
            
        }
    }
}

