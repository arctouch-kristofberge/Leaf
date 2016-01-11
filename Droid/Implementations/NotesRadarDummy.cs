// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotesRadar.cs" company="ArcTouch, Inc.">
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
//   Defines the NotesRadar type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
//
//
using System;
using Xamarin.Forms;
using Leaf.Droid.Implementations;
using Leaf.Interfaces;
using System.Collections.Generic;
using Xamarin.Forms.Maps;
using System.Linq;
using Leaf.Extensions;

[assembly: Dependency(typeof(NotesRadarDummy))]
namespace Leaf.Droid.Implementations
{
    public class NotesRadarDummy : INotesRadar
    {
        private IList<Pin> Notes;

        public IList<Pin> GetNotesWithinRadius(Position currentLocation)
        {
            Notes = Notes ?? FillNotesList(currentLocation);

            var notes = Notes.Where(x => x.Position.DistanceTo(currentLocation) <= 1000).ToList();
            return notes;
        }
       
        private IList<Pin> FillNotesList(Position currentLocation)
        {
            // Pins inside radius
            IList<Pin> notes = new List<Pin> { 
                new Pin { Position = new Position(currentLocation.Latitude + 0.05, currentLocation.Longitude + 0.05), Label = "Note" },
                new Pin { Position = new Position(currentLocation.Latitude + 0.05, currentLocation.Longitude - 0.05), Label = "Note" },
                new Pin { Position = new Position(currentLocation.Latitude - 0.05, currentLocation.Longitude + 0.05), Label = "Note" },
                new Pin { Position = new Position(currentLocation.Latitude - 0.05, currentLocation.Longitude - 0.05), Label = "Note" },
            };
            return notes;

        }
    }
}