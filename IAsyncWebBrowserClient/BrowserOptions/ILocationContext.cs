// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// This file is based on or incorporates material from the project Selenium, licensed under the Apache License, Version 2.0. More info in THIRD-PARTY-NOTICES file.

using System.Threading;
using System.Threading.Tasks;

namespace Zu.WebBrowser.BrowserOptions
{
    /// <summary>
    ///     Interface for location context
    /// </summary>
    public interface ILocationContext
    {
        /// <summary>
        ///     Gets or sets a value indicating the physical location of the browser.
        /// </summary>
        Task<Location> GetPhysicalLocation(CancellationToken cancellationToken = default(CancellationToken));
   
        /// <summary>
        ///     Sets a value indicating the physical location of the browser.
        /// </summary>
        Task SetPhysicalLocation(Location location, CancellationToken cancellationToken = default(CancellationToken));
    }
}