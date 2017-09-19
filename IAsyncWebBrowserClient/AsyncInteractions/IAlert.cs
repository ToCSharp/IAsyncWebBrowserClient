// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// This file is based on or incorporates material from the project Selenium, licensed under the Apache License, Version 2.0. More info in THIRD-PARTY-NOTICES file.

using System.Threading;
using System.Threading.Tasks;

namespace Zu.WebBrowser.AsyncInteractions
{
    /// <summary>
    ///     Defines the interface through which the user can manipulate JavaScript alerts.
    /// </summary>
    public interface IAlert
    {
        /// <summary>
        ///     Gets the text of the alert.
        /// </summary>
        Task<string> Text(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///     Dismisses the alert.
        /// </summary>
        Task Dismiss(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///     Accepts the alert.
        /// </summary>
        Task Accept(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///     Sends keys to the alert.
        /// </summary>
        /// <param name="keysToSend">The keystrokes to send.</param>
        Task SendKeys(string keysToSend, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///     Sets the user name and password in an alert prompting for credentials.
        /// </summary>
        /// <param name="userName">The user name to set.</param>
        /// <param name="password">The password to set.</param>
        Task SetAuthenticationCredentials(string userName, string password,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}