// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// This file is based on or incorporates material from the project Selenium, licensed under the Apache License, Version 2.0. More info in THIRD-PARTY-NOTICES file.

using Newtonsoft.Json.Linq;
using System;
using System.Threading;
using System.Threading.Tasks;
using Zu.WebBrowser.BasicTypes;
//using Zu.AsyncWebDriver.Interactions.Internal;

namespace Zu.WebBrowser.AsyncInteractions
{
    /// <summary>
    ///     Provides methods representing basic mouse actions.
    /// </summary>
    public interface IElements
    {
        /// <summary>
        ///     Clicks at a set of coordinates using the primary mouse button.
        /// </summary>
        /// <param name="elementId">An elementId describing where to click.</param>
        Task Click(string elementId, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElement(string strategy, string expr, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElement(string strategy, string expr, TimeSpan timeout, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElement(string strategy, string expr, int timeoutMs, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElement(string strategy, string expr, string startNode, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElement(string strategy, string expr, string startNode, TimeSpan timeout, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElement(string strategy, string expr, string startNode, int timeoutMs, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElement(string strategy, string expr, string startNode, string notElementId, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElement(string strategy, string expr, string startNode, string notElementId, TimeSpan timeout, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElement(string strategy, string expr, string startNode, string notElementId, int timeoutMs, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElements(string strategy, string expr, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElements(string strategy, string expr, TimeSpan timeout, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElements(string strategy, string expr, int timeoutMs, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElements(string strategy, string expr, string startNode, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElements(string strategy, string expr, string startNode, TimeSpan timeout, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElements(string strategy, string expr, string startNode, int timeoutMs, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElements(string strategy, string expr, string startNode, string notElementId, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElements(string strategy, string expr, string startNode, string notElementId, TimeSpan timeout, CancellationToken cancellationToken = default(CancellationToken));

        Task<JToken> FindElements(string strategy, string expr, string startNode, string notElementId, int timeoutMs, CancellationToken cancellationToken = default(CancellationToken));

        Task<string> GetActiveElement(CancellationToken cancellationToken = default(CancellationToken));

        Task<string> GetElementAttribute(string elementId, string attrName, CancellationToken cancellationToken = default(CancellationToken));

        Task<string> GetElementProperty(string elementId, string propertyName, CancellationToken cancellationToken = default(CancellationToken));

        Task<string> GetElementValueOfCssProperty(string elementId, string propertyName, CancellationToken cancellationToken = default(CancellationToken));

        Task<string> GetElementTagName(string elementId, CancellationToken cancellationToken = default(CancellationToken));

        Task<string> GetElementText(string elementId, CancellationToken cancellationToken = default(CancellationToken));

        Task<WebRect> GetElementRect(string elementId, CancellationToken cancellationToken = default(CancellationToken));

        Task<bool> IsElementDisplayed(string elementId, CancellationToken cancellationToken = default(CancellationToken));

        Task<bool> IsElementEnabled(string elementId, CancellationToken cancellationToken = default(CancellationToken));

        Task<bool> IsElementSelected(string elementId, CancellationToken cancellationToken = default(CancellationToken));

        Task<string> SendKeysToElement(string elementId, string value, CancellationToken cancellationToken = default(CancellationToken));

        Task<WebPoint> GetElementLocation(string elementId, CancellationToken cancellationToken = default(CancellationToken));

        Task<WebSize> GetElementSize(string elementId, CancellationToken cancellationToken = default(CancellationToken));

        Task<string> SubmitElement(string elementId, CancellationToken cancellationToken = default(CancellationToken));

        Task<string> ClearElement(string elementId, CancellationToken cancellationToken = default(CancellationToken));
    }
}