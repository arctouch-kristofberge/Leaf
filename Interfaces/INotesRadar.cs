﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INotesLocationService.cs" company="ArcTouch, Inc.">
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
//   Defines the INotesLocationService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
//
//
using System;
using System.Collections.Generic;
using Xamarin.Forms.Maps;

namespace Leaf.Interfaces
{
    public interface INotesRadar
    {
        IList<Pin> GetNotesWithinRadius(Position currentLocation);
    }
}
