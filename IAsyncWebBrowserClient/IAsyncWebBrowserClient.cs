// Copyright (c) Oleg Zudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Zu.WebBrowser.AsyncInteractions;
using Zu.WebBrowser.BrowserOptions;

namespace Zu.WebBrowser
{

    public interface IAsyncWebBrowserClient
    {
        INavigation Navigation { get; }
        IMouse Mouse { get; }
        IKeyboard Keyboard { get; }
        IJavaScriptExecutor JavaScriptExecutor { get; }
        IOptions Options { get; }
        ITargetLocator TargetLocator { get; }
        IElements Elements { get; }

        IAlert Alert { get; }
        ICoordinates Coordinates { get; }
        ITakesScreenshot Screenshot { get; }
        ITouchScreen TouchScreen { get; }

        Task<string> Connect(CancellationToken cancellationToken = default(CancellationToken));
        Task CheckConnected(CancellationToken cancellationToken = default(CancellationToken));
        Task Disconnect(CancellationToken cancellationToken = default(CancellationToken));
        Task<string> Close(CancellationToken cancellationToken = default(CancellationToken));
        void CloseSync();

        Task<string> GetPageSource(CancellationToken cancellationToken = default(CancellationToken));

        Task<string> GetTitle(CancellationToken cancellationToken = default(CancellationToken));
    }
}