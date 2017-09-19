// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// This file is based on or incorporates material from the project Selenium, licensed under the Apache License, Version 2.0. More info in THIRD-PARTY-NOTICES file.

using System.Threading.Tasks;

namespace Zu.WebBrowser.BrowserOptions
{
    /// <summary>
    ///     Represents both local and session storage for the site currently opened in the browser.
    /// </summary>
    public interface IWebStorage
    {
        /// <summary>
        ///     Gets the local storage for the site currently opened in the browser.
        /// </summary>
        ILocalStorage LocalStorage { get; }

        /// <summary>
        ///     Gets the session storage for the site currently opened in the browser.
        /// </summary>
        ISessionStorage SessionStorage { get; }
    }
}