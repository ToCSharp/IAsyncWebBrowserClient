// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// This file is based on or incorporates material from the project Selenium, licensed under the Apache License, Version 2.0. More info in THIRD-PARTY-NOTICES file.

namespace Zu.WebBrowser.BrowserOptions
{
    /// <summary>
    ///     Interface allowing the user to determine if the driver instance supports web storage.
    /// </summary>
    public interface IHasWebStorage
    {
        /// <summary>
        ///     Gets a value indicating whether web storage is supported for this driver.
        /// </summary>
        bool HasWebStorage { get; }

        /// <summary>
        ///     Gets an <see cref="IWebStorage" /> object for managing web storage.
        /// </summary>
        IWebStorage WebStorage { get; }
    }
}