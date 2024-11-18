namespace Selenium.Helper
{
    public class BrowserStack
    {
        private IWebDriver _webDriver;
        private static string _browseruser = "dilipvaghela2";
        private static string _browserpassword = "yAPT5zsoeVtzNLJCKmjy";
        private static string _buildDate = DateTime.Now.ToString("ddMMyyyyHHmmss");
        private static string _projectName = _buildDate;
        private static string _buildName = " " + _browseruser;
        public BrowserStack() { }
        public IWebDriver BrowserStackInit(String remoteBrowser)
        {
            switch (remoteBrowser)
            {

                case "Safari-Latest":
                    var capabilitySafari = new SafariOptions();
                    capabilitySafari.AddAdditionalOption("os", "OS X");
                    capabilitySafari.AddAdditionalOption("os_version", "Big Sur");
                    capabilitySafari.AddAdditionalOption("browser", "Safari");
                    capabilitySafari.AddAdditionalOption("browser_version", "14.0");
                    capabilitySafari.AddAdditionalOption("resolution", "1280x1024");
                    capabilitySafari.AddAdditionalOption("browserstack.local", "false");
                    capabilitySafari.AddAdditionalOption("browserstack.selenium_version", "3.141.0");
                    capabilitySafari.AddAdditionalOption("browserstack.debug", "true");
                    capabilitySafari.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilitySafari.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilitySafari.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilitySafari.AddAdditionalOption("project", _projectName);
                    capabilitySafari.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafari);

                case "Safari-13":
                    SafariOptions capabilitySafari13 = new SafariOptions();
                    capabilitySafari13.AddAdditionalOption("os", "OS X");
                    capabilitySafari13.AddAdditionalOption("os_version", "Catalina");
                    capabilitySafari13.AddAdditionalOption("browser", "Safari");
                    capabilitySafari13.AddAdditionalOption("browser_version", "13.0");
                    capabilitySafari13.AddAdditionalOption("resolution", "1280x1024");
                    capabilitySafari13.AddAdditionalOption("browserstack.local", "false");
                    capabilitySafari13.AddAdditionalOption("browserstack.selenium_version", "3.141.0");
                    capabilitySafari13.AddAdditionalOption("browserstack.debug", "true");
                    capabilitySafari13.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilitySafari13.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilitySafari13.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilitySafari13.AddAdditionalOption("project", _projectName);
                    capabilitySafari13.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafari13);

                case "Safari-12":
                    SafariOptions capabilitySafari12 = new SafariOptions();
                    capabilitySafari12.AddAdditionalOption("os", "OS X");
                    capabilitySafari12.AddAdditionalOption("os_version", "Mojave");
                    capabilitySafari12.AddAdditionalOption("browser", "Safari");
                    capabilitySafari12.AddAdditionalOption("browser_version", "12.0");
                    capabilitySafari12.AddAdditionalOption("resolution", "1280x1024");
                    capabilitySafari12.AddAdditionalOption("browserstack.local", "false");
                    capabilitySafari12.AddAdditionalOption("browserstack.selenium_version", "3.141.0");
                    capabilitySafari12.AddAdditionalOption("browserstack.debug", "true");
                    capabilitySafari12.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilitySafari12.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilitySafari12.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilitySafari12.AddAdditionalOption("project", _projectName);
                    capabilitySafari12.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafari12);

                case "Safari-11":
                    SafariOptions capabilitySafari11 = new SafariOptions();
                    capabilitySafari11.AddAdditionalOption("os", "OS X");
                    capabilitySafari11.AddAdditionalOption("os_version", "High Sierra");
                    capabilitySafari11.AddAdditionalOption("browser", "Safari");
                    capabilitySafari11.AddAdditionalOption("browser_version", "11.0");
                    capabilitySafari11.AddAdditionalOption("resolution", "1280x1024");
                    capabilitySafari11.AddAdditionalOption("browserstack.local", "false");
                    capabilitySafari11.AddAdditionalOption("browserstack.selenium_version", "3.141.0");
                    capabilitySafari11.AddAdditionalOption("browserstack.debug", "true");
                    capabilitySafari11.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilitySafari11.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilitySafari11.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilitySafari11.AddAdditionalOption("project", _projectName);
                    capabilitySafari11.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafari11);

                case "Chrome-Latest":
                    ChromeOptions capabilityChrome = new ChromeOptions();
                    capabilityChrome.BrowserVersion = "latest";
                    Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
                    browserstackOptions.Add("os", "Windows");
                    browserstackOptions.Add("osVersion", "11");
                    browserstackOptions.Add("local", "false");
                    browserstackOptions.Add("debug", "true");
                    browserstackOptions.Add("networkLogs", "true");
                    browserstackOptions.Add("seleniumVersion", "3.14.0");
                    browserstackOptions.Add("userName", _browseruser);
                    browserstackOptions.Add("accessKey", _browserpassword);
                    browserstackOptions.Add("projectName", _projectName);
                    browserstackOptions.Add("buildName", remoteBrowser + _buildName);
                    browserstackOptions.Add("sessionName", remoteBrowser + _buildName);
                    capabilityChrome.AddAdditionalOption("bstack:options", browserstackOptions);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChrome);

                case "Edge-Latest":
                    EdgeOptions capabilityEdge = new EdgeOptions();
                    capabilityEdge.AddAdditionalOption("os", "Windows");
                    capabilityEdge.AddAdditionalOption("os_version", "10");
                    capabilityEdge.AddAdditionalOption("browser", "Edge");
                    capabilityEdge.AddAdditionalOption("browser_version", "latest");
                    capabilityEdge.AddAdditionalOption("resolution", "1280x1024");
                    capabilityEdge.AddAdditionalOption("browserstack.local", "false");
                    capabilityEdge.AddAdditionalOption("browserstack.selenium_version", "3.141.0");
                    capabilityEdge.AddAdditionalOption("browserstack.debug", "true");
                    capabilityEdge.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilityEdge.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilityEdge.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilityEdge.AddAdditionalOption("project", _projectName);
                    capabilityEdge.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityEdge);

                case "FireFox-Latest":
                    FirefoxOptions capabilityFireFox = new FirefoxOptions();
                    capabilityFireFox.AddAdditionalOption("os", "Windows");
                    capabilityFireFox.AddAdditionalOption("os_version", "10");
                    capabilityFireFox.AddAdditionalOption("browser", "Firefox");
                    capabilityFireFox.AddAdditionalOption("browser_version", "latest");
                    capabilityFireFox.AddAdditionalOption("resolution", "1280x1024");
                    capabilityFireFox.AddAdditionalOption("browserstack.local", "false");
                    capabilityFireFox.AddAdditionalOption("browserstack.selenium_version", "3.10.0");
                    capabilityFireFox.AddAdditionalOption("browserstack.debug", "true");
                    capabilityFireFox.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilityFireFox.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilityFireFox.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilityFireFox.AddAdditionalOption("project", _projectName);
                    capabilityFireFox.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityFireFox);

                case "IE11-Latest":
                    EdgeOptions capabilityIe11 = new EdgeOptions();
                    capabilityIe11.AddAdditionalOption("os", "Windows");
                    capabilityIe11.AddAdditionalOption("os_version", "10");
                    capabilityIe11.AddAdditionalOption("browser", "IE");
                    capabilityIe11.AddAdditionalOption("browser_version", "11.0");
                    capabilityIe11.AddAdditionalOption("resolution", "1280x1024");
                    capabilityIe11.AddAdditionalOption("browserstack.local", "false");
                    capabilityIe11.AddAdditionalOption("browserstack.selenium_version", "3.141.0");
                    capabilityIe11.AddAdditionalOption("browserstack.debug", "true");
                    capabilityIe11.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilityIe11.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilityIe11.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilityIe11.AddAdditionalOption("project", _projectName);
                    capabilityIe11.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityIe11);

                ////////////////////////////// BETA /////////////////////////////////

                case "Chrome-Beta":
                    ChromeOptions capabilityChromeBeta = new ChromeOptions();
                    capabilityChromeBeta.AddAdditionalOption("os", "OS X");
                    capabilityChromeBeta.AddAdditionalOption("os_version", "Big Sur");
                    capabilityChromeBeta.AddAdditionalOption("browser", "Chrome");
                    capabilityChromeBeta.AddAdditionalOption("browser_version", "latest-beta");
                    capabilityChromeBeta.AddAdditionalOption("resolution", "1280x1024");
                    capabilityChromeBeta.AddAdditionalOption("browserstack.local", "false");
                    capabilityChromeBeta.AddAdditionalOption("browserstack.selenium_version", "3.141.0");
                    capabilityChromeBeta.AddAdditionalOption("browserstack.debug", "true");
                    capabilityChromeBeta.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilityChromeBeta.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilityChromeBeta.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilityChromeBeta.AddAdditionalOption("project", _projectName);
                    capabilityChromeBeta.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChromeBeta);

                case "Edge-Beta":
                    EdgeOptions capabilityEdgeBeta = new EdgeOptions();
                    capabilityEdgeBeta.AddAdditionalOption("os", "Windows");
                    capabilityEdgeBeta.AddAdditionalOption("os_version", "10");
                    capabilityEdgeBeta.AddAdditionalOption("browser", "Edge");
                    capabilityEdgeBeta.AddAdditionalOption("browser_version", "latest-beta");
                    capabilityEdgeBeta.AddAdditionalOption("resolution", "1280x1024");
                    capabilityEdgeBeta.AddAdditionalOption("browserstack.local", "false");
                    capabilityEdgeBeta.AddAdditionalOption("browserstack.selenium_version", "3.141.0");
                    capabilityEdgeBeta.AddAdditionalOption("browserstack.debug", "true");
                    capabilityEdgeBeta.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilityEdgeBeta.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilityEdgeBeta.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilityEdgeBeta.AddAdditionalOption("project", _projectName);
                    capabilityEdgeBeta.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityEdgeBeta);

                case "FireFox-beta":
                    FirefoxOptions capabilityFireFoxBeta = new FirefoxOptions();
                    capabilityFireFoxBeta.AddAdditionalOption("os", "Windows");
                    capabilityFireFoxBeta.AddAdditionalOption("os_version", "10");
                    capabilityFireFoxBeta.AddAdditionalOption("browser", "Firefox");
                    capabilityFireFoxBeta.AddAdditionalOption("browser_version", "latest-beta");
                    capabilityFireFoxBeta.AddAdditionalOption("resolution", "1280x1024");
                    capabilityFireFoxBeta.AddAdditionalOption("browserstack.local", "false");
                    capabilityFireFoxBeta.AddAdditionalOption("browserstack.selenium_version", "3.10.0");
                    capabilityFireFoxBeta.AddAdditionalOption("browserstack.debug", "true");
                    capabilityFireFoxBeta.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilityFireFoxBeta.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilityFireFoxBeta.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilityFireFoxBeta.AddAdditionalOption("project", _projectName);
                    capabilityFireFoxBeta.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityFireFoxBeta);

                ////////////////////////////// MOBILE /////////////////////////////////

                case "Safari-Mobile-14-iPhone12ProMax":
                    SafariOptions capabilitySafariMobile14 = new SafariOptions();
                    capabilitySafariMobile14.AddAdditionalOption("os_version", "14");
                    capabilitySafariMobile14.AddAdditionalOption("device", "iPhone 12 Pro Max");
                    capabilitySafariMobile14.AddAdditionalOption("real_mobile", "true");
                    capabilitySafariMobile14.AddAdditionalOption("browserstack.local", "false");
                    capabilitySafariMobile14.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilitySafariMobile14.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilitySafariMobile14.AddAdditionalOption("project", _projectName);
                    capabilitySafariMobile14.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafariMobile14);

                case "Safari-Mobile-13-iPhone11":
                    SafariOptions capabilitySafariMobile13 = new SafariOptions();
                    capabilitySafariMobile13.AddAdditionalOption("os_version", "13");
                    capabilitySafariMobile13.AddAdditionalOption("device", "iPhone 11");
                    capabilitySafariMobile13.AddAdditionalOption("real_mobile", "true");
                    capabilitySafariMobile13.AddAdditionalOption("browserstack.local", "false");
                    capabilitySafariMobile13.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilitySafariMobile13.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilitySafariMobile13.AddAdditionalOption("project", _projectName);
                    capabilitySafariMobile13.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafariMobile13);

                case "Safari-Mobile-12-iPhoneXS":
                    SafariOptions capabilitySafariMobile12 = new SafariOptions();
                    capabilitySafariMobile12.AddAdditionalOption("os_version", "12");
                    capabilitySafariMobile12.AddAdditionalOption("device", "iPhone XS");
                    capabilitySafariMobile12.AddAdditionalOption("real_mobile", "true");
                    capabilitySafariMobile12.AddAdditionalOption("browserstack.local", "false");
                    capabilitySafariMobile12.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilitySafariMobile12.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilitySafariMobile12.AddAdditionalOption("project", _projectName);
                    capabilitySafariMobile12.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafariMobile12);

                case "Safari-Mobile-11-iPhoneX":
                    SafariOptions capabilitySafariMobile11 = new SafariOptions();
                    capabilitySafariMobile11.AddAdditionalOption("os_version", "11");
                    capabilitySafariMobile11.AddAdditionalOption("device", "iPhone X");
                    capabilitySafariMobile11.AddAdditionalOption("real_mobile", "true");
                    capabilitySafariMobile11.AddAdditionalOption("browserstack.local", "false");
                    capabilitySafariMobile11.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilitySafariMobile11.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilitySafariMobile11.AddAdditionalOption("project", _projectName);
                    capabilitySafariMobile11.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafariMobile11);

                case "Safari-Mobile-10-iPhone7Plus":
                    SafariOptions capabilitySafariMobile10 = new SafariOptions();
                    capabilitySafariMobile10.AddAdditionalOption("os_version", "10");
                    capabilitySafariMobile10.AddAdditionalOption("device", "iPhone 7 Plus");
                    capabilitySafariMobile10.AddAdditionalOption("real_mobile", "true");
                    capabilitySafariMobile10.AddAdditionalOption("browserstack.local", "false");
                    capabilitySafariMobile10.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilitySafariMobile10.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilitySafariMobile10.AddAdditionalOption("project", _projectName);
                    capabilitySafariMobile10.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafariMobile10);

                case "Chrome-Mobile-11-Samsung Galaxy S21":
                    ChromeOptions capabilityChromeMobile11 = new ChromeOptions();
                    capabilityChromeMobile11.AddAdditionalOption("os_version", "11.0");
                    capabilityChromeMobile11.AddAdditionalOption("device", "Samsung Galaxy S21");
                    capabilityChromeMobile11.AddAdditionalOption("real_mobile", "true");
                    capabilityChromeMobile11.AddAdditionalOption("browserstack.local", "false");
                    capabilityChromeMobile11.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilityChromeMobile11.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilityChromeMobile11.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilityChromeMobile11.AddAdditionalOption("project", _projectName);
                    capabilityChromeMobile11.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChromeMobile11);

                case "Chrome-Mobile-10-Samsung Galaxy S20":
                    ChromeOptions capabilityChromeMobile10 = new ChromeOptions();
                    capabilityChromeMobile10.AddAdditionalOption("os_version", "10.0");
                    capabilityChromeMobile10.AddAdditionalOption("device", "Samsung Galaxy S20");
                    capabilityChromeMobile10.AddAdditionalOption("real_mobile", "true");
                    capabilityChromeMobile10.AddAdditionalOption("browserstack.local", "false");
                    capabilityChromeMobile10.AddAdditionalOption("browserstack.timezone", "London");
                    capabilityChromeMobile10.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilityChromeMobile10.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilityChromeMobile10.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilityChromeMobile10.AddAdditionalOption("project", _projectName);
                    capabilityChromeMobile10.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChromeMobile10);

                case "Chrome-Mobile-9-Motorola Moto G7 Play":
                    ChromeOptions capabilityChromeMobile9 = new ChromeOptions();
                    capabilityChromeMobile9.AddAdditionalOption("os_version", "9.0");
                    capabilityChromeMobile9.AddAdditionalOption("device", "Motorola Moto G7 Play");
                    capabilityChromeMobile9.AddAdditionalOption("real_mobile", "true");
                    capabilityChromeMobile9.AddAdditionalOption("browserstack.local", "false");
                    capabilityChromeMobile9.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilityChromeMobile9.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilityChromeMobile9.AddAdditionalOption("project", _projectName);
                    capabilityChromeMobile9.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChromeMobile9);

                case "Chrome-Mobile-8-Google Pixel 2":
                    ChromeOptions capabilityChromeMobile8 = new ChromeOptions();
                    capabilityChromeMobile8.AddAdditionalOption("os_version", "8.0");
                    capabilityChromeMobile8.AddAdditionalOption("device", "Google Pixel 5");
                    capabilityChromeMobile8.AddAdditionalOption("real_mobile", "true");
                    capabilityChromeMobile8.AddAdditionalOption("browserstack.local", "false");
                    capabilityChromeMobile8.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilityChromeMobile8.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilityChromeMobile8.AddAdditionalOption("project", _projectName);
                    capabilityChromeMobile8.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChromeMobile8);

                case "Chrome-Mobile-7.1-Samsung Galaxy Note 8":
                    ChromeOptions capabilityChromeMobile7 = new ChromeOptions();
                    capabilityChromeMobile7.AddAdditionalOption("os_version", "7.1");
                    capabilityChromeMobile7.AddAdditionalOption("device", "Samsung Galaxy Note 8");
                    capabilityChromeMobile7.AddAdditionalOption("real_mobile", "true");
                    capabilityChromeMobile7.AddAdditionalOption("browserstack.local", "false");
                    capabilityChromeMobile7.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilityChromeMobile7.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilityChromeMobile7.AddAdditionalOption("project", _projectName);
                    capabilityChromeMobile7.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChromeMobile7);

                case "Chrome-Mobile-6-Google Nexus 6":
                    ChromeOptions capabilityChromeMobile6 = new ChromeOptions();
                    capabilityChromeMobile6.AddAdditionalOption("os_version", "6.0");
                    capabilityChromeMobile6.AddAdditionalOption("device", "Google Nexus 6");
                    capabilityChromeMobile6.AddAdditionalOption("real_mobile", "true");
                    capabilityChromeMobile6.AddAdditionalOption("browserstack.local", "false");
                    capabilityChromeMobile6.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilityChromeMobile6.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilityChromeMobile6.AddAdditionalOption("project", _projectName);
                    capabilityChromeMobile6.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChromeMobile6);

                case "Chrome-Mobile-5-Samsung Galaxy S6":
                    ChromeOptions capabilityChromeMobile5 = new ChromeOptions();
                    capabilityChromeMobile5.AddAdditionalOption("os_version", "5.0");
                    capabilityChromeMobile5.AddAdditionalOption("device", "Google Pixel 5");
                    capabilityChromeMobile5.AddAdditionalOption("real_mobile", "true");
                    capabilityChromeMobile5.AddAdditionalOption("browserstack.local", "false");
                    capabilityChromeMobile5.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilityChromeMobile5.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilityChromeMobile5.AddAdditionalOption("project", _projectName);
                    capabilityChromeMobile5.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChromeMobile5);

                default:
                    ChromeOptions capabilityDefult = new ChromeOptions();
                    capabilityDefult.AddAdditionalOption("os", "OS X");
                    capabilityDefult.AddAdditionalOption("os_version", "Big Sur");
                    capabilityDefult.AddAdditionalOption("browser", "Chrome");
                    capabilityDefult.AddAdditionalOption("browser_version", "latest");
                    capabilityDefult.AddAdditionalOption("resolution", "1280x1024");
                    capabilityDefult.AddAdditionalOption("browserstack.local", "false");
                    capabilityDefult.AddAdditionalOption("browserstack.selenium_version", "3.14.0");
                    capabilityDefult.AddAdditionalOption("browserstack.debug", "true");
                    capabilityDefult.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilityDefult.AddAdditionalOption("browserstack.user", _browseruser);
                    capabilityDefult.AddAdditionalOption("browserstack.key", _browserpassword);
                    capabilityDefult.AddAdditionalOption("project", _projectName);
                    capabilityDefult.AddAdditionalOption("build", remoteBrowser + _buildName);
                    return _webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityDefult);
            }

        }
    }
}

