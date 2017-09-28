using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zu.WebBrowser.BasicTypes
{
    public class WebBrowserException: Exception
    {
        public string Error { get; set; }
        public JToken Json { get; set; }
        private string stackTrace;
        public override string StackTrace => stackTrace;

        public WebBrowserException()
            : base()
        {

        }
        public WebBrowserException(string message)
            :base(message)
        {

        }

        public WebBrowserException(JToken json)
            :this(json["message"]?.ToString())
        {
            Json = json;
            Error = json["error"]?.ToString();
            stackTrace = json["stacktrace"]?.ToString();
        }

        public WebBrowserException SetStackTrace(string stackTrace)
        {
            this.stackTrace = stackTrace;
            return this;
        }
    }
}
