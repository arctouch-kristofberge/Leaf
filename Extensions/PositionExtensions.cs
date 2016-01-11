// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PoistionExtensions.cs" company="ArcTouch, Inc.">
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
//   Defines the PoistionExtensions type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
//
//
using System;
using Xamarin.Forms.Maps;

namespace Leaf.Extensions
{
    public static class PositionExtensions
    {
        public static double DistanceTo(this Position fromPos, Position toPos)
        {
            return Math.Sqrt(
                Math.Pow(fromPos.Latitude - toPos.Latitude, 2) + 
                Math.Pow(fromPos.Longitude - toPos.Longitude, 2));
        }
    }
}

