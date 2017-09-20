// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// This file is based on or incorporates material from the project Selenium, licensed under the Apache License, Version 2.0. More info in THIRD-PARTY-NOTICES file.

namespace Zu.WebBrowser.BasicTypes
{
    /// <summary>
    /// Enumerated values for the kinds of devices available.
    /// </summary>
    public enum InputDeviceKind
    {
        /// <summary>
        /// Represents the null device.
        /// </summary>
        None,

        /// <summary>
        /// Represents a key-based device, primarily for entering text.
        /// </summary>
        Key,

        /// <summary>
        /// Represents a pointer-based device, such as a mouse, pen, or stylus.
        /// </summary>
        Pointer
    }
}
