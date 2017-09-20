// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// This file is based on or incorporates material from the project Selenium, licensed under the Apache License, Version 2.0. More info in THIRD-PARTY-NOTICES file.

using System;
using System.Collections.Generic;

namespace Zu.WebBrowser.BasicTypes
{
    /// <summary>
    /// Represents a single interaction for a given input device.
    /// </summary>
    public abstract class Interaction
    {
        private InputDevice sourceDevice;

        /// <summary>
        /// Initializes a new instance of the <see cref="Interaction"/> class.
        /// </summary>
        /// <param name="sourceDevice">The input device which performs this action.</param>
        protected Interaction(InputDevice sourceDevice)
        {
            if (sourceDevice == null)
            {
                throw new ArgumentNullException("sourceDevice", "Source device cannot be null");
            }

            this.sourceDevice = sourceDevice;
        }

        /// <summary>
        /// Gets the device for which this action is intended.
        /// </summary>
        public InputDevice SourceDevice
        {
            get { return this.sourceDevice; }
        }

        /// <summary>
        /// Returns a value for this action that can be transmitted across the wire to a remote end.
        /// </summary>
        /// <returns>A <see cref="Dictionary{TKey, TValue}"/> representing this action.</returns>
        public abstract Dictionary<string, object> ToDictionary();

        /// <summary>
        /// Gets a value indicating whether this action is valid for the specified type of input device.
        /// </summary>
        /// <param name="sourceDeviceKind">The type of device to check.</param>
        /// <returns><see langword="true"/> if the action is valid for the specified type of input device;
        /// otherwise, <see langword="false"/>.</returns>
        public virtual bool IsValidFor(InputDeviceKind sourceDeviceKind)
        {
            return this.sourceDevice.DeviceKind == sourceDeviceKind;
        }
    }
}
