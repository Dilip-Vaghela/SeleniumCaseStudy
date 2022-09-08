namespace Selenium.Helper
{
    public class BrowserStack
    {
        private IWebDriver webDriver;
        private static string Browseruser = "dilipvaghela2";
        private static string Browserpassword = "yAPT5zsoeVtzNLJCKmjy";
        private static string buildDate = DateTime.Now.ToString("ddMMyyyyHHmmss");
        private static string projectName = buildDate;
        private static string buildName = " " + Browseruser;
        public BrowserStack() { }
        public IWebDriver BrowserStackInit(String RemoteBrowser)
        {
            switch (RemoteBrowser)
            {

                case "Safari-Latest":
                    SafariOptions capabilitySafari = new SafariOptions();
                    capabilitySafari.AddAdditionalOption("os", "OS X");
                    capabilitySafari.AddAdditionalOption("os_version", "Big Sur");
                    capabilitySafari.AddAdditionalOption("browser", "Safari");
                    capabilitySafari.AddAdditionalOption("browser_version", "14.0");
                    capabilitySafari.AddAdditionalOption("resolution", "1280x1024");
                    capabilitySafari.AddAdditionalOption("browserstack.local", "false");
                    capabilitySafari.AddAdditionalOption("browserstack.selenium_version", "3.141.0");
                    capabilitySafari.AddAdditionalOption("browserstack.debug", "true");
                    capabilitySafari.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilitySafari.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilitySafari.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilitySafari.AddAdditionalOption("project", projectName);
                    capabilitySafari.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafari);

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
                    capabilitySafari13.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilitySafari13.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilitySafari13.AddAdditionalOption("project", projectName);
                    capabilitySafari13.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafari13);

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
                    capabilitySafari12.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilitySafari12.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilitySafari12.AddAdditionalOption("project", projectName);
                    capabilitySafari12.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafari12);

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
                    capabilitySafari11.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilitySafari11.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilitySafari11.AddAdditionalOption("project", projectName);
                    capabilitySafari11.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafari11);

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
                    browserstackOptions.Add("userName", Browseruser);
                    browserstackOptions.Add("accessKey", Browserpassword);
                    browserstackOptions.Add("projectName", projectName);
                    browserstackOptions.Add("buildName", RemoteBrowser + buildName);
                    browserstackOptions.Add("sessionName", RemoteBrowser + buildName);
                    capabilityChrome.AddAdditionalOption("bstack:options", browserstackOptions);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChrome);

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
                    capabilityEdge.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilityEdge.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilityEdge.AddAdditionalOption("project", projectName);
                    capabilityEdge.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityEdge);

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
                    capabilityFireFox.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilityFireFox.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilityFireFox.AddAdditionalOption("project", projectName);
                    capabilityFireFox.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityFireFox);

                case "IE11-Latest":
                    EdgeOptions capabilityIE11 = new EdgeOptions();
                    capabilityIE11.AddAdditionalOption("os", "Windows");
                    capabilityIE11.AddAdditionalOption("os_version", "10");
                    capabilityIE11.AddAdditionalOption("browser", "IE");
                    capabilityIE11.AddAdditionalOption("browser_version", "11.0");
                    capabilityIE11.AddAdditionalOption("resolution", "1280x1024");
                    capabilityIE11.AddAdditionalOption("browserstack.local", "false");
                    capabilityIE11.AddAdditionalOption("browserstack.selenium_version", "3.141.0");
                    capabilityIE11.AddAdditionalOption("browserstack.debug", "true");
                    capabilityIE11.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilityIE11.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilityIE11.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilityIE11.AddAdditionalOption("project", projectName);
                    capabilityIE11.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityIE11);

                ////////////////////////////// BETA /////////////////////////////////

                case "Chrome-Beta":
                    ChromeOptions capabilityChromeBETA = new ChromeOptions();
                    capabilityChromeBETA.AddAdditionalOption("os", "OS X");
                    capabilityChromeBETA.AddAdditionalOption("os_version", "Big Sur");
                    capabilityChromeBETA.AddAdditionalOption("browser", "Chrome");
                    capabilityChromeBETA.AddAdditionalOption("browser_version", "latest-beta");
                    capabilityChromeBETA.AddAdditionalOption("resolution", "1280x1024");
                    capabilityChromeBETA.AddAdditionalOption("browserstack.local", "false");
                    capabilityChromeBETA.AddAdditionalOption("browserstack.selenium_version", "3.141.0");
                    capabilityChromeBETA.AddAdditionalOption("browserstack.debug", "true");
                    capabilityChromeBETA.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilityChromeBETA.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilityChromeBETA.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilityChromeBETA.AddAdditionalOption("project", projectName);
                    capabilityChromeBETA.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChromeBETA);

                case "Edge-Beta":
                    EdgeOptions capabilityEdgeBETA = new EdgeOptions();
                    capabilityEdgeBETA.AddAdditionalOption("os", "Windows");
                    capabilityEdgeBETA.AddAdditionalOption("os_version", "10");
                    capabilityEdgeBETA.AddAdditionalOption("browser", "Edge");
                    capabilityEdgeBETA.AddAdditionalOption("browser_version", "latest-beta");
                    capabilityEdgeBETA.AddAdditionalOption("resolution", "1280x1024");
                    capabilityEdgeBETA.AddAdditionalOption("browserstack.local", "false");
                    capabilityEdgeBETA.AddAdditionalOption("browserstack.selenium_version", "3.141.0");
                    capabilityEdgeBETA.AddAdditionalOption("browserstack.debug", "true");
                    capabilityEdgeBETA.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilityEdgeBETA.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilityEdgeBETA.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilityEdgeBETA.AddAdditionalOption("project", projectName);
                    capabilityEdgeBETA.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityEdgeBETA);

                case "FireFox-beta":
                    FirefoxOptions capabilityFireFoxBETA = new FirefoxOptions();
                    capabilityFireFoxBETA.AddAdditionalOption("os", "Windows");
                    capabilityFireFoxBETA.AddAdditionalOption("os_version", "10");
                    capabilityFireFoxBETA.AddAdditionalOption("browser", "Firefox");
                    capabilityFireFoxBETA.AddAdditionalOption("browser_version", "latest-beta");
                    capabilityFireFoxBETA.AddAdditionalOption("resolution", "1280x1024");
                    capabilityFireFoxBETA.AddAdditionalOption("browserstack.local", "false");
                    capabilityFireFoxBETA.AddAdditionalOption("browserstack.selenium_version", "3.10.0");
                    capabilityFireFoxBETA.AddAdditionalOption("browserstack.debug", "true");
                    capabilityFireFoxBETA.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilityFireFoxBETA.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilityFireFoxBETA.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilityFireFoxBETA.AddAdditionalOption("project", projectName);
                    capabilityFireFoxBETA.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityFireFoxBETA);

                ////////////////////////////// MOBILE /////////////////////////////////

                case "Safari-Mobile-14-iPhone12ProMax":
                    SafariOptions capabilitySafariMobile14 = new SafariOptions();
                    capabilitySafariMobile14.AddAdditionalOption("os_version", "14");
                    capabilitySafariMobile14.AddAdditionalOption("device", "iPhone 12 Pro Max");
                    capabilitySafariMobile14.AddAdditionalOption("real_mobile", "true");
                    capabilitySafariMobile14.AddAdditionalOption("browserstack.local", "false");
                    capabilitySafariMobile14.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilitySafariMobile14.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilitySafariMobile14.AddAdditionalOption("project", projectName);
                    capabilitySafariMobile14.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafariMobile14);

                case "Safari-Mobile-13-iPhone11":
                    SafariOptions capabilitySafariMobile13 = new SafariOptions();
                    capabilitySafariMobile13.AddAdditionalOption("os_version", "13");
                    capabilitySafariMobile13.AddAdditionalOption("device", "iPhone 11");
                    capabilitySafariMobile13.AddAdditionalOption("real_mobile", "true");
                    capabilitySafariMobile13.AddAdditionalOption("browserstack.local", "false");
                    capabilitySafariMobile13.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilitySafariMobile13.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilitySafariMobile13.AddAdditionalOption("project", projectName);
                    capabilitySafariMobile13.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafariMobile13);

                case "Safari-Mobile-12-iPhoneXS":
                    SafariOptions capabilitySafariMobile12 = new SafariOptions();
                    capabilitySafariMobile12.AddAdditionalOption("os_version", "12");
                    capabilitySafariMobile12.AddAdditionalOption("device", "iPhone XS");
                    capabilitySafariMobile12.AddAdditionalOption("real_mobile", "true");
                    capabilitySafariMobile12.AddAdditionalOption("browserstack.local", "false");
                    capabilitySafariMobile12.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilitySafariMobile12.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilitySafariMobile12.AddAdditionalOption("project", projectName);
                    capabilitySafariMobile12.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafariMobile12);

                case "Safari-Mobile-11-iPhoneX":
                    SafariOptions capabilitySafariMobile11 = new SafariOptions();
                    capabilitySafariMobile11.AddAdditionalOption("os_version", "11");
                    capabilitySafariMobile11.AddAdditionalOption("device", "iPhone X");
                    capabilitySafariMobile11.AddAdditionalOption("real_mobile", "true");
                    capabilitySafariMobile11.AddAdditionalOption("browserstack.local", "false");
                    capabilitySafariMobile11.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilitySafariMobile11.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilitySafariMobile11.AddAdditionalOption("project", projectName);
                    capabilitySafariMobile11.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafariMobile11);

                case "Safari-Mobile-10-iPhone7Plus":
                    SafariOptions capabilitySafariMobile10 = new SafariOptions();
                    capabilitySafariMobile10.AddAdditionalOption("os_version", "10");
                    capabilitySafariMobile10.AddAdditionalOption("device", "iPhone 7 Plus");
                    capabilitySafariMobile10.AddAdditionalOption("real_mobile", "true");
                    capabilitySafariMobile10.AddAdditionalOption("browserstack.local", "false");
                    capabilitySafariMobile10.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilitySafariMobile10.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilitySafariMobile10.AddAdditionalOption("project", projectName);
                    capabilitySafariMobile10.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilitySafariMobile10);

                case "Chrome-Mobile-11-Samsung Galaxy S21":
                    ChromeOptions capabilityChromeMobile11 = new ChromeOptions();
                    capabilityChromeMobile11.AddAdditionalOption("os_version", "11.0");
                    capabilityChromeMobile11.AddAdditionalOption("device", "Samsung Galaxy S21");
                    capabilityChromeMobile11.AddAdditionalOption("real_mobile", "true");
                    capabilityChromeMobile11.AddAdditionalOption("browserstack.local", "false");
                    capabilityChromeMobile11.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilityChromeMobile11.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilityChromeMobile11.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilityChromeMobile11.AddAdditionalOption("project", projectName);
                    capabilityChromeMobile11.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChromeMobile11);

                case "Chrome-Mobile-10-Samsung Galaxy S20":
                    ChromeOptions capabilityChromeMobile10 = new ChromeOptions();
                    capabilityChromeMobile10.AddAdditionalOption("os_version", "10.0");
                    capabilityChromeMobile10.AddAdditionalOption("device", "Samsung Galaxy S20");
                    capabilityChromeMobile10.AddAdditionalOption("real_mobile", "true");
                    capabilityChromeMobile10.AddAdditionalOption("browserstack.local", "false");
                    capabilityChromeMobile10.AddAdditionalOption("browserstack.timezone", "London");
                    capabilityChromeMobile10.AddAdditionalOption("browserstack.networkLogs", "true");
                    capabilityChromeMobile10.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilityChromeMobile10.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilityChromeMobile10.AddAdditionalOption("project", projectName);
                    capabilityChromeMobile10.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChromeMobile10);

                case "Chrome-Mobile-9-Motorola Moto G7 Play":
                    ChromeOptions capabilityChromeMobile9 = new ChromeOptions();
                    capabilityChromeMobile9.AddAdditionalOption("os_version", "9.0");
                    capabilityChromeMobile9.AddAdditionalOption("device", "Motorola Moto G7 Play");
                    capabilityChromeMobile9.AddAdditionalOption("real_mobile", "true");
                    capabilityChromeMobile9.AddAdditionalOption("browserstack.local", "false");
                    capabilityChromeMobile9.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilityChromeMobile9.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilityChromeMobile9.AddAdditionalOption("project", projectName);
                    capabilityChromeMobile9.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChromeMobile9);

                case "Chrome-Mobile-8-Google Pixel 2":
                    ChromeOptions capabilityChromeMobile8 = new ChromeOptions();
                    capabilityChromeMobile8.AddAdditionalOption("os_version", "8.0");
                    capabilityChromeMobile8.AddAdditionalOption("device", "Google Pixel 5");
                    capabilityChromeMobile8.AddAdditionalOption("real_mobile", "true");
                    capabilityChromeMobile8.AddAdditionalOption("browserstack.local", "false");
                    capabilityChromeMobile8.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilityChromeMobile8.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilityChromeMobile8.AddAdditionalOption("project", projectName);
                    capabilityChromeMobile8.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChromeMobile8);

                case "Chrome-Mobile-7.1-Samsung Galaxy Note 8":
                    ChromeOptions capabilityChromeMobile7 = new ChromeOptions();
                    capabilityChromeMobile7.AddAdditionalOption("os_version", "7.1");
                    capabilityChromeMobile7.AddAdditionalOption("device", "Samsung Galaxy Note 8");
                    capabilityChromeMobile7.AddAdditionalOption("real_mobile", "true");
                    capabilityChromeMobile7.AddAdditionalOption("browserstack.local", "false");
                    capabilityChromeMobile7.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilityChromeMobile7.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilityChromeMobile7.AddAdditionalOption("project", projectName);
                    capabilityChromeMobile7.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChromeMobile7);

                case "Chrome-Mobile-6-Google Nexus 6":
                    ChromeOptions capabilityChromeMobile6 = new ChromeOptions();
                    capabilityChromeMobile6.AddAdditionalOption("os_version", "6.0");
                    capabilityChromeMobile6.AddAdditionalOption("device", "Google Nexus 6");
                    capabilityChromeMobile6.AddAdditionalOption("real_mobile", "true");
                    capabilityChromeMobile6.AddAdditionalOption("browserstack.local", "false");
                    capabilityChromeMobile6.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilityChromeMobile6.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilityChromeMobile6.AddAdditionalOption("project", projectName);
                    capabilityChromeMobile6.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChromeMobile6);

                case "Chrome-Mobile-5-Samsung Galaxy S6":
                    ChromeOptions capabilityChromeMobile5 = new ChromeOptions();
                    capabilityChromeMobile5.AddAdditionalOption("os_version", "5.0");
                    capabilityChromeMobile5.AddAdditionalOption("device", "Google Pixel 5");
                    capabilityChromeMobile5.AddAdditionalOption("real_mobile", "true");
                    capabilityChromeMobile5.AddAdditionalOption("browserstack.local", "false");
                    capabilityChromeMobile5.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilityChromeMobile5.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilityChromeMobile5.AddAdditionalOption("project", projectName);
                    capabilityChromeMobile5.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityChromeMobile5);

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
                    capabilityDefult.AddAdditionalOption("browserstack.user", Browseruser);
                    capabilityDefult.AddAdditionalOption("browserstack.key", Browserpassword);
                    capabilityDefult.AddAdditionalOption("project", projectName);
                    capabilityDefult.AddAdditionalOption("build", RemoteBrowser + buildName);
                    return webDriver = new DriverHelpers().CreateBrowserStackDriver(capabilityDefult);
            }

        }
    }
}

