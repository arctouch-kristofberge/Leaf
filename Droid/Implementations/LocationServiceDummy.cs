// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocationServiceDummy.cs" company="ArcTouch, Inc.">
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
//   Defines the LocationServiceDummy type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
//
//
using System;
using Xamarin.Forms;
using Leaf.Droid.Implementations;
using Leaf.Interfaces;
using Xamarin.Forms.Maps;
using Leaf.Event;
using System.Timers;

//[assembly: Dependency(typeof(LocationServiceDummy))]
namespace Leaf.Droid.Implementations
{
    public class LocationServiceDummy : ILocationService
    {
        double lat;
        double lng;

        #region ILocationService implementation
        public event EventHandler<LocationUpdatedEventArgs> LocationUpdated;
        public void StartUpdatingLocation()
        {
            lat = -27.59681225;
            lng = -48.52060127;
            var timer = new Timer(2000);
            timer.Elapsed += LaunchEvent;
        }

        private void LaunchEvent (object sender, ElapsedEventArgs e)
        {
            if(LocationUpdated != null)
            {
                LocationUpdated(this, new LocationUpdatedEventArgs(lat, lng));
                lat += 0.5d;
                lng += 0.5d;
            }
        }
        #endregion
    }
}

