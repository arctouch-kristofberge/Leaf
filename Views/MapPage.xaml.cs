// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapPage.xaml.cs" company="ArcTouch, Inc.">
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
//   Defines the MapPage.xaml type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
//
//
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Leaf.Views
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();

            var map = new Map( MapSpan.FromCenterAndRadius(
                new Position(52.509678, 13.375827),
                Distance.FromKilometers(3)));

            map.IsShowingUser = false;
            map.VerticalOptions = LayoutOptions.FillAndExpand;
            map.HorizontalOptions = LayoutOptions.FillAndExpand;

            var stack = new StackLayout(){Spacing = 0};
            stack.Children.Add(map);
            Content = stack;
        }
    }
}

