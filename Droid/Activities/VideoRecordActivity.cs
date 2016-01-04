// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VideoRecordActivity.cs" company="ArcTouch, Inc.">
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
//   Defines the VideoRecordActivity type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
//
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Media;
using Xamarin.Forms.Platform.Android;
using Android.Content.PM;

namespace Leaf.Droid.Activities
{
    [Activity(Label = "VideoRecordActivity", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class VideoRecordActivity : Activity
    {
        private MediaRecorder recorder;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.VideoRecordActivity);

            var record = FindViewById<Button> (Resource.Id.Record);
            var stop = FindViewById<Button> (Resource.Id.Stop);
            var play = FindViewById<Button> (Resource.Id.Play);
            var video = FindViewById<VideoView> (Resource.Id.SampleVideoView);

            string path = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath + "path.mp4";

            record.Click += delegate {
                video.StopPlayback ();

                recorder = new MediaRecorder ();
                recorder.SetVideoSource (VideoSource.Default);
                recorder.SetAudioSource (AudioSource.Mic);
                recorder.SetOutputFormat (OutputFormat.Default);
                recorder.SetVideoEncoder (VideoEncoder.Default);
                recorder.SetAudioEncoder (AudioEncoder.Default);
                recorder.SetOutputFile (path);
                recorder.SetPreviewDisplay (video.Holder.Surface);
                recorder.Prepare();
                recorder.Start();
            };

            stop.Click += delegate {
                if (recorder != null) {
                    recorder.Stop ();
                    recorder.Release ();
                }
            };

            play.Click += delegate {
                var uri = Android.Net.Uri.Parse (path);
                video.SetVideoURI (uri);
                video.Start ();
            };
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();

            if (recorder != null) 
            {
                recorder.Release ();
                recorder.Dispose ();
                recorder = null;
            }
        }
    }
}