Browser Drivers<br><sub>Implement IAsyncWebBrowserClient interfaces</sub> | IAsyncWebBrowserClient<br><sub>contains interfaces</sub> | WebDriver and other tools<br><sub>Use browser drivers via IAsyncWebBrowserClient interfaces</sub> 
--------------- | ---------------------- | -------------------------- 
**[AsyncChromeDriver](https://github.com/ToCSharp/AsyncChromeDriver)**<br>connects to Chrome via DevTools Protocol<td rowspan=3>IAction<br>IAlert<br>ICookieJar<br>ICoordinates<br>IJavaScriptExecutor<br>IKeyboard<br>ILocatable<br>ILogs<br>IMouse<br>INavigation<br>IOptions<br>ITakesScreenshot<br>ITouchScreen<br>IWindow<br>_IJavaScriptDebugger_<br>_IDomDebugger_<br>_IEmulation_<br> | **[AsyncWebDriver](https://github.com/ToCSharp/AsyncWebDriver)**<br>SyncWebDriver<br> SeleniumAdapter 
**[AsyncOperaDriver](https://github.com/ToCSharp/AsyncOperaDriver)**<br>based on AsyncChromeDriver |  _DevTools_
**AsyncFirefoxDriver**<br>connects to Firefox via Marionette | _Debugger_ 


Browser Drivers implement IAsyncWebBrowserClient interfaces and AsyncWebDriver use browser drivers via IAsyncWebBrowserClient interfaces. 

AsyncWebDriver is async and is different from Selenium. SyncWebDriver is synchronous wrapper over AsyncWebDriver.

SeleniumAdapter is adapter of Selenium interfaces to SyncWebDriver. So we can run Selenium tests on AsyncWebDriver. Here is Unit Tests from Selenuim, which we can run to test functionality of all projects and its connections.