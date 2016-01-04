// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapWithNotesInRadiusViewModel.cs" company="ArcTouch, Inc.">
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
//   Defines the MapWithNotesInRadiusViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
//
//
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms.Maps;
using Leaf.Interfaces;
using Xamarin.Forms;
using Leaf.Event;

namespace Leaf.ViewModels.CustomViews
{

    public class MapWithNotesInRadiusViewModel
    {
        public ObservableCollection<Pin> NotesLocations { get; set; }
        public Position CurrentLocation { get; set; }

        private ILocationService locationService;

        public MapWithNotesInRadiusViewModel()
        {
            locationService = DependencyService.Get<ILocationService>();
            locationService.LocationUpdated += LocationUpdated;
            locationService.StartUpdatingLocation();
        }

        private void LocationUpdated (object sender, LocationUpdatedEventArgs e)
        {
            CurrentLocation = e.Position;
        }
    }
}