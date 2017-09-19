// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// This file is based on or incorporates material from the project Selenium, licensed under the Apache License, Version 2.0. More info in THIRD-PARTY-NOTICES file.

using Zu.WebBrowser.AsyncInteractions;

namespace Zu.WebBrowser.BrowserOptions
{
    /// <summary>
    ///     Defines an interface allowing the user to set options on the browser.
    /// </summary>
    public interface IOptions: IHasLocationContext, IHasApplicationCache, IWebStorage
    {
        /// <summary>
        ///     Gets an object allowing the user to manipulate cookies on the page.
        /// </summary>
        ICookieJar Cookies { get; }

        /// <summary>
        ///     Gets an object allowing the user to manipulate the currently-focused browser window.
        /// </summary>
        /// <remarks>
        ///     "Currently-focused" is defined as the browser window having the window handle
        ///     returned when IWebDriver.CurrentWindowHandle is called.
        /// </remarks>
        IWindow Window { get; }

        /// <summary>
        ///     Gets an object allowing the user to examing the logs for this driver instance.
        /// </summary>
        ILogs Logs { get; }

        /// <summary>
        ///     Provides access to the timeouts defined for this driver.
        /// </summary>
        /// <returns>An object implementing the <see cref="ITimeouts" /> interface.</returns>
        ITimeouts Timeouts { get; }

        ///// <summary>
        /////     Provides access to local and session storage of this driver.
        ///// </summary>
        ///// <returns>An object implementing the <see cref="IWebStorage" /> interface.</returns>
        //IWebStorage WebStorage { get; }

        ///// <summary>
        /////     Provides access to location context of this driver.
        ///// </summary>
        ///// <returns>An object implementing the <see cref="IHasLocationContext" /> interface.</returns>
        //IHasLocationContext HasLocationContext { get; }

        ///// <summary>
        /////     Provides access to application cache of this driver.
        ///// </summary>
        ///// <returns>An object implementing the <see cref="IHasApplicationCache" /> interface.</returns>
        //IHasApplicationCache HasApplicationCache { get; }
    }
}