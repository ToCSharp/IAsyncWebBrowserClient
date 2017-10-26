### IAsyncWebBrowserClient

Interfaces for .Net Browser Drivers and WebDriver 

[![Join the chat at https://gitter.im/AsyncWebDriver/Lobby](https://badges.gitter.im/AsyncWebDriver/Lobby.svg)](https://gitter.im/AsyncWebDriver/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)


Browser Drivers<br><sub>Implement IAsyncWebBrowserClient interfaces</sub> | [IAsyncWebBrowserClient](https://github.com/ToCSharp/IAsyncWebBrowserClient/blob/master/IAsyncWebBrowserClient/IAsyncWebBrowserClient.cs)<br><sub>contains interfaces</sub> | WebDriver and other tools<br><sub>Use browser drivers via IAsyncWebBrowserClient interfaces</sub> 
--------------- | ---------------------- | -------------------------- 
**[AsyncChromeDriver](https://github.com/ToCSharp/AsyncChromeDriver)**<br>connects to Chrome via DevTools Protocol<td rowspan=3>[INavigation](https://github.com/ToCSharp/IAsyncWebBrowserClient/blob/master/IAsyncWebBrowserClient/AsyncInteractions/INavigation.cs)<br>[IElements](https://github.com/ToCSharp/IAsyncWebBrowserClient/blob/master/IAsyncWebBrowserClient/AsyncInteractions/IElements.cs)<br>[IAlert](https://github.com/ToCSharp/IAsyncWebBrowserClient/blob/master/IAsyncWebBrowserClient/AsyncInteractions/IAlert.cs)<br>[ICookieJar](https://github.com/ToCSharp/IAsyncWebBrowserClient/blob/master/IAsyncWebBrowserClient/BrowserOptions/ICookieJar.cs)<br>[ICoordinates](https://github.com/ToCSharp/IAsyncWebBrowserClient/blob/master/IAsyncWebBrowserClient/AsyncInteractions/ICoordinates.cs)<br>[IJavaScriptExecutor](https://github.com/ToCSharp/IAsyncWebBrowserClient/blob/master/IAsyncWebBrowserClient/AsyncInteractions/IJavascriptExecutor.cs)<br>[IKeyboard](https://github.com/ToCSharp/IAsyncWebBrowserClient/blob/master/IAsyncWebBrowserClient/AsyncInteractions/IKeyboard.cs)<br>[IMouse](https://github.com/ToCSharp/IAsyncWebBrowserClient/blob/master/IAsyncWebBrowserClient/AsyncInteractions/IMouse.cs)<br>[IOptions](https://github.com/ToCSharp/IAsyncWebBrowserClient/blob/master/IAsyncWebBrowserClient/BrowserOptions/IOptions.cs)<br>[ITakesScreenshot](https://github.com/ToCSharp/IAsyncWebBrowserClient/blob/master/IAsyncWebBrowserClient/AsyncInteractions/ITakesScreenshot.cs)<br>[ITouchScreen](https://github.com/ToCSharp/IAsyncWebBrowserClient/blob/master/IAsyncWebBrowserClient/AsyncInteractions/ITouchScreen.cs)<br>[IWindow](https://github.com/ToCSharp/IAsyncWebBrowserClient/blob/master/IAsyncWebBrowserClient/BrowserOptions/IWindow.cs)<br>_IJavaScriptDebugger_<br>_IDomDebugger_<br>_IEmulation_<br> | **[AsyncWebDriver](https://github.com/ToCSharp/AsyncWebDriver)**<br>[SyncWebDriver](https://github.com/ToCSharp/AsyncWebDriver/tree/master/AsyncWebDriver/SyncWrapper)<br> [SeleniumAdapter](https://github.com/ToCSharp/AsyncChromeDriverExamplesAndTests/tree/master/AsyncWebDriver.SeleniumAdapter) 
**[AsyncOperaDriver](https://github.com/ToCSharp/AsyncOperaDriver)**<br>based on AsyncChromeDriver |  _DevTools.Net_
**[AsyncFirefoxDriver](https://github.com/ToCSharp/AsyncWebDriver/tree/master/AsyncFirefoxDriver)**<br>connects to Firefox via Marionette | _Debugger_ 


Browser Drivers implement IAsyncWebBrowserClient interfaces and AsyncWebDriver use browser drivers via IAsyncWebBrowserClient interfaces. 

**[AsyncWebDriver](https://github.com/ToCSharp/AsyncWebDriver)** is async and is different from Selenium. SyncWebDriver is synchronous wrapper over AsyncWebDriver.

[SeleniumAdapter](https://github.com/ToCSharp/AsyncChromeDriverExamplesAndTests/tree/master/AsyncWebDriver.SeleniumAdapter) is adapter of [Selenium interfaces](https://github.com/ToCSharp/AsyncChromeDriverExamplesAndTests/tree/master/AsyncWebDriver.SeleniumAdapter/Selenium) to [SyncWebDriver](https://github.com/ToCSharp/AsyncWebDriver/tree/master/AsyncWebDriver/SyncWrapper). So we can run Selenium tests on [AsyncWebDriver](https://github.com/ToCSharp/AsyncWebDriver). [Here is Unit Tests from Selenuim](https://github.com/ToCSharp/AsyncChromeDriverExamplesAndTests/tree/master/AsyncWebDriver.SeleniumAdapter.Common.Tests), which we can run to test functionality of all projects and its connections.

**[AsyncChromeDriver](https://github.com/ToCSharp/AsyncChromeDriver)** is Chrome WebDriver and Chrome DevTools in one library.  
It connects directly to [Chrome DevTools](https://chromedevtools.github.io/devtools-protocol/) and is async from this connection. No need in chromedriver.exe. [NuGet](https://www.nuget.org/packages/AsyncChromeDriver/)

**[AsyncFirefoxDriver](https://github.com/ToCSharp/AsyncWebDriver/tree/master/AsyncFirefoxDriver)** connects directly to Marionette and is async from this connection. No need in geckodriver.exe. [NuGet](https://www.nuget.org/packages/AsyncFirefoxDriver/)  

Look video of example of using Browser's Developer tools while using drivers: https://youtu.be/dNMuoeDmEME  