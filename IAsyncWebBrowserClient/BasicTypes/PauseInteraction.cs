﻿// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// This file is based on or incorporates material from the project Selenium, licensed under the Apache License, Version 2.0. More info in THIRD-PARTY-NOTICES file.

using System;
using System.Collections.Generic;

namespace Zu.WebBrowser.BasicTypes
{
    /// <summary>
    /// Represents a pause action.
    /// </summary>
    public class PauseInteraction : Interaction
    {
        private TimeSpan duration = TimeSpan.Zero;

        /// <summary>
        /// Initializes a new instance of the <see cref="PauseInteraction"/> class.
        /// </summary>
        /// <param name="sourceDevice">The input device on which to execute the pause.</param>
        public PauseInteraction(InputDevice sourceDevice)
            : this(sourceDevice, TimeSpan.Zero)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PauseInteraction"/> class.
        /// </summary>
        /// <param name="sourceDevice">The input device on which to execute the pause.</param>
        /// <param name="duration">The length of time to pause for.</param>
        public PauseInteraction(InputDevice sourceDevice, TimeSpan duration)
            : base(sourceDevice)
        {
            if (duration < TimeSpan.Zero)
            {
                throw new ArgumentException("Duration must be greater than or equal to zero", "duration");
            }

            this.duration = duration;
        }

        /// <summary>
        /// Returns a value for this action that can be transmitted across the wire to a remote end.
        /// </summary>
        /// <returns>A <see cref="Dictionary{TKey, TValue}"/> representing this action.</returns>
        public override Dictionary<string, object> ToDictionary()
        {
            Dictionary<string, object> toReturn = new Dictionary<string, object>();

            toReturn["type"] = "pause";
            toReturn["duration"] = Convert.ToInt64(this.duration.TotalMilliseconds);

            return toReturn;
        }

        /// <summary>
        /// Gets a value indicating whether this action is valid for the specified type of input device.
        /// </summary>
        /// <param name="sourceDeviceKind">The type of device to check.</param>
        /// <returns><see langword="true"/> if the action is valid for the specified type of input device;
        /// otherwise, <see langword="false"/>.</returns>
        public override bool IsValidFor(InputDeviceKind sourceDeviceKind)
        {
            return true;
        }
    }
}
