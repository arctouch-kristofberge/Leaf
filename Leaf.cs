// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Leaf.cs" company="ArcTouch, Inc.">
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
//   Defines the Leaf type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
//
//
using System;

using Xamarin.Forms;
using Leaf.Views;
using Leaf.Views.Pages;

namespace Leaf
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage( new MapPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

