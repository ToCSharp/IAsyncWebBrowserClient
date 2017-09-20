// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// This file is based on or incorporates material from the project Selenium, licensed under the Apache License, Version 2.0. More info in THIRD-PARTY-NOTICES file.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Zu.WebBrowser.AsyncInteractions
{
    /// <summary>
    ///     Defines the interface through which the user can locate a given frame or window.
    /// </summary>
    public interface ITargetLocator
    {
        /// <summary>
        ///     Select a frame by its (zero-based) index.
        /// </summary>
        /// <param name="frameIndex">The zero-based index of the frame to select.</param>
        /// <exception cref="NoSuchFrameException">If the frame cannot be found.</exception>
        Task SwitchToFrame(int frameIndex, CancellationToken cancellationToken = new CancellationToken());

        /// <summary>
        ///     Select a frame by its name or ID.
        /// </summary>
        /// <param name="frameName">The name of the frame to select.</param>
        /// <exception cref="NoSuchFrameException">If the frame cannot be found.</exception>
        Task SwitchToFrame(string frameName, CancellationToken cancellationToken = new CancellationToken());

        /// <summary>
        ///     Select a frame using its previously located <see cref="IWebElement" />
        /// </summary>
        /// <param name="frameElement">The frame element to switch to.</param>
        /// <exception cref="NoSuchFrameException">If the element is neither a FRAME nor an IFRAME element.</exception>
        /// <exception cref="StaleElementReferenceException">If the element is no longer valid.</exception>
        Task SwitchToFrameByElement(string element, CancellationToken cancellationToken = new CancellationToken());

        /// <summary>
        ///     Select the parent frame of the currently selected frame.
        /// </summary>
        Task SwitchToParentFrame(CancellationToken cancellationToken = new CancellationToken());

        /// <summary>
        ///     Switches the focus of future commands for this driver to the window with the given name.
        /// </summary>
        /// <param name="windowName">The name of the window to select.</param>
        /// <exception cref="NoSuchWindowException">If the window cannot be found.</exception>
        Task SwitchToWindow(string windowName, CancellationToken cancellationToken = new CancellationToken());

        /// <summary>
        ///     Selects either the first frame on the page or the main document when a page contains iFrames.
        /// </summary>
        Task SwitchToDefaultContent(CancellationToken cancellationToken = new CancellationToken());

        /// <summary>
        ///     Switches to the element that currently has the focus, or the body element
        ///     if no element with focus can be detected.
        /// </summary>
        /// <returns>
        ///     An <see cref="string" /> instance representing the element id
        ///     with the focus, or the body element if no element with focus can be detected.
        /// </returns>
        Task<string> SwitchToActiveElement(CancellationToken cancellationToken = new CancellationToken());

        /// <summary>
        ///     Switches to the currently active modal dialog for this particular driver instance.
        /// </summary>
        /// <returns>A handle to the dialog.</returns>
        Task<IAlert> SwitchToAlert(CancellationToken cancellationToken = new CancellationToken());

        Task<string> GetWindowHandle(CancellationToken cancellationToken = new CancellationToken());

        Task<List<string>> GetWindowHandles(CancellationToken cancellationToken = new CancellationToken());
    }
}