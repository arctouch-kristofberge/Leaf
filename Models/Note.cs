// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Note.cs" company="ArcTouch, Inc.">
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
//   Defines the Note type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
//
//
using System;

namespace Leaf.Models
{
    public class Note
    {
        public Location Location { get; set; }
        public string Content { get; set; }
        public User Sender { get; set; }
    }
}

