// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// This file is based on or incorporates material from the project Selenium, licensed under the Apache License, Version 2.0. More info in THIRD-PARTY-NOTICES file.

using System;
using System.Collections.Generic;
using System.Globalization;

namespace Zu.WebBrowser.BasicTypes
{
    /// <summary>
    /// Base class for all input devices for actions.
    /// </summary>
    public abstract class InputDevice
    {
        private string deviceName;

        /// <summary>
        /// Initializes a new instance of the <see cref="InputDevice"/> class.
        /// </summary>
        /// <param name="deviceName">The unique name of the input device represented by this class.</param>
        protected InputDevice(string deviceName)
        {
            if (string.IsNullOrEmpty(deviceName))
            {
                throw new ArgumentException("Device name must not be null or empty", "deviceName");
            }

            this.deviceName = deviceName;
        }

        /// <summary>
        /// Gets the unique name of this input device.
        /// </summary>
        public string DeviceName
        {
            get { return this.deviceName; }
        }

        /// <summary>
        /// Gets the kind of device for this input device.
        /// </summary>
        public abstract InputDeviceKind DeviceKind { get; }

        /// <summary>
        /// Returns a value for this input device that can be transmitted across the wire to a remote end.
        /// </summary>
        /// <returns>A <see cref="Dictionary{TKey, TValue}"/> representing this action.</returns>
        public abstract Dictionary<string, object> ToDictionary();

        /// <summary>
        /// Returns a hash code for the current <see cref="InputDevice"/>.
        /// </summary>
        /// <returns>A hash code for the current <see cref="InputDevice"/>.</returns>
        public override int GetHashCode()
        {
            return this.deviceName.GetHashCode();
        }

        /// <summary>
        /// Returns a string that represents the current <see cref="InputDevice"/>.
        /// </summary>
        /// <returns>A string that represents the current <see cref="InputDevice"/>.</returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} input device [name: {1}]", this.DeviceKind, this.deviceName);
        }
    }
}
