using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zu.WebBrowser.Firefox
{
    public interface IAsyncWebBrowserClientFirefox : IAsyncWebBrowserClient
    {
        Task<Contexts> GetContext(CancellationToken cancellationToken = default(CancellationToken));
        Task<JToken> SetContextChrome(CancellationToken cancellationToken = default(CancellationToken));
        Task<JToken> SetContextContent(CancellationToken cancellationToken = default(CancellationToken));
    }
}
