// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// This file is based on or incorporates material from the project Selenium, licensed under the Apache License, Version 2.0. More info in THIRD-PARTY-NOTICES file.

namespace Zu.WebBrowser.BrowserOptions
{
    /// <summary>
    ///     Represents the application cache status.
    /// </summary>
    public enum AppCacheStatus
    {
        /// <summary>
        ///     AppCache status is uncached
        /// </summary>
        Uncached = 0,

        /// <summary>
        ///     AppCache status is idle
        /// </summary>
        Idle = 1,

        /// <summary>
        ///     AppCache status is checkint
        /// </summary>
        Checking,

        /// <summary>
        ///     AppCache status is downloading
        /// </summary>
        Downloading,

        /// <summary>
        ///     AppCache status is updated-ready
        /// </summary>
        UpdateReady,

        /// <summary>
        ///     AppCache status is obsolete
        /// </summary>
        Obsolete
    }
}