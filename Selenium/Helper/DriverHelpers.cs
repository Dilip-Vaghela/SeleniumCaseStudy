namespace Selenium.Helper
{
    public class DriverHelpers
    {
        public DriverHelpers() { }
        public static bool AreYouBrowserstackdriver = false;
        private IWebDriver? _webDriver;
        public IWebDriver? CreateDriver(string profile, string browser)
        {
            if (profile.Equals("Browserstack"))
            {
                return _webDriver = new BrowserStack().BrowserStackInit(browser);
            }
            else if (profile.Equals("Local"))
            {
                AreYouBrowserstackdriver = false;
                switch (browser)
                {
                    case "Desktop - Chrome":
                        return _webDriver = new ChromeDriver();
                    case "Desktop - IE":
                        InternetExplorerOptions optionsIe = new InternetExplorerOptions();

                        optionsIe.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                        optionsIe.IgnoreZoomLevel = true;
                        optionsIe.UnhandledPromptBehavior = UnhandledPromptBehavior.Accept;
                        optionsIe.EnablePersistentHover = true;
                        optionsIe.EnableNativeEvents = false;
                        optionsIe.EnsureCleanSession = true;
                        optionsIe.RequireWindowFocus = true;
                        return _webDriver = new InternetExplorerDriver(optionsIe);
                    case "Desktop - Firefox":
                        return _webDriver = new FirefoxDriver();
                    case "Mobile - Chrome - iPhone X":
                        ChromeOptions optionsiPhone = new ChromeOptions();
                        optionsiPhone.EnableMobileEmulation("iPhone X");
                        optionsiPhone.AddArgument("disable-infobars");
                        return _webDriver = new ChromeDriver(optionsiPhone);
                    case "Mobile - Chrome - Pixel 2 XL":
                        ChromeOptions optionsPixel = new ChromeOptions();
                        optionsPixel.EnableMobileEmulation("Pixel 2 XL");
                        optionsPixel.AddArgument("disable-infobars");
                        return _webDriver = new ChromeDriver(optionsPixel);
                    default:
                        return _webDriver = new ChromeDriver();
                }
            }
            else { return null; }

        }
        public IWebDriver CreateBrowserStackDriver(DriverOptions capability)
        {
            AreYouBrowserstackdriver = true;
            return _webDriver = new RemoteWebDriver(
            new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capability);
        }
    }
}

