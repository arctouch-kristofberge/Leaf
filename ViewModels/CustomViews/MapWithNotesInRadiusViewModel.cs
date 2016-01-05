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
using PropertyChanged;

namespace Leaf.ViewModels.CustomViews
{
    [ImplementPropertyChanged]
    public class MapWithNotesInRadiusViewModel
    {
        public Position CurrentLocation { get; set; }

        private Map map;
        private ILocationService locationService;
        private INotesRadar notesRadar;

        public MapWithNotesInRadiusViewModel(Map map)
        {
            this.map = map;

            locationService = DependencyService.Get<ILocationService>();
            locationService.LocationUpdated += LocationUpdated;
            locationService.StartUpdatingLocation();

            notesRadar = DependencyService.Get<INotesRadar>();

            this.map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(52.509678, 13.375827), Distance.FromKilometers(1)));
        }

        private void LocationUpdated (object sender, LocationUpdatedEventArgs e)
        {
            CurrentLocation = e.Position;
            map.MoveToRegion(MapSpan.FromCenterAndRadius(e.Position, Distance.FromKilometers(1)));

            UpdateNotesPins();
        }

        private void UpdateNotesPins()
        {
            map.Pins.Clear();

            foreach(Pin pin in notesRadar.GetNotesWithinRadius(CurrentLocation))
            {
                map.Pins.Add(pin);
            }
        }
    }
}