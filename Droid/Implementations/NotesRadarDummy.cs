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

[assembly: Dependency(typeof(NotesRadarDummy))]
namespace Leaf.Droid.Implementations
{
    public class NotesRadarDummy : INotesRadar
    {
        
        public IList<Pin> GetNotesWithinRadius(Position currentLocation)
        {
            return new List<Pin>() { 
                new Pin(){ Position = new Position(currentLocation.Latitude + 0.0005, currentLocation.Longitude + 0.0005), Label = "Note" },
                new Pin(){ Position = new Position(currentLocation.Latitude + 0.0005, currentLocation.Longitude - 0.0005), Label = "Note" },
                new Pin(){ Position = new Position(currentLocation.Latitude - 0.0005, currentLocation.Longitude + 0.0005), Label = "Note" },
                new Pin(){ Position = new Position(currentLocation.Latitude - 0.0005, currentLocation.Longitude - 0.0005), Label = "Note" },
            };
        }
       
    }
}

