// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// This file is based on or incorporates material from the project Selenium, licensed under the Apache License, Version 2.0. More info in THIRD-PARTY-NOTICES file.

namespace Zu.WebBrowser.BrowserOptions
{
    /// <summary>
    ///     Interface allowing the user to determine if the driver instance supports geolocation.
    /// </summary>
    public interface IHasLocationContext
    {
        /// <summary>
        ///     Gets a value indicating whether manipulating geolocation is supported for this driver.
        /// </summary>
        bool HasLocationContext { get; }

        /// <summary>
        ///     Gets an <see cref="ILocationContext" /> object for managing browser location.
        /// </summary>
        ILocationContext LocationContext { get; }
    }
}