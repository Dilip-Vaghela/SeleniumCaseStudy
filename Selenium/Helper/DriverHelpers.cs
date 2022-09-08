namespace Selenium.Helper
{
    public class DriverHelpers
    {
        public DriverHelpers() { }
        public static bool AreYouBrowserstackdriver = false;
        private IWebDriver? webDriver;
        public IWebDriver? CreateDriver(string profile, string browser)
        {
            if (profile.Equals("Browserstack"))
            {
                return webDriver = new BrowserStack().BrowserStackInit(browser);
            }
            else if (profile.Equals("Local"))
            {
                AreYouBrowserstackdriver = false;
                switch (browser)
                {
                    case "Desktop - Chrome":
                        return webDriver = new ChromeDriver();
                    case "Desktop - IE":
                        InternetExplorerOptions optionsIE = new InternetExplorerOptions();

                        optionsIE.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                        optionsIE.IgnoreZoomLevel = true;
                        optionsIE.UnhandledPromptBehavior = UnhandledPromptBehavior.Accept;
                        optionsIE.EnablePersistentHover = true;
                        optionsIE.EnableNativeEvents = false;
                        optionsIE.EnsureCleanSession = true;
                        optionsIE.RequireWindowFocus = true;
                        return webDriver = new InternetExplorerDriver(optionsIE);
                    case "Desktop - Firefox":
                        return webDriver = new FirefoxDriver();
                    case "Mobile - Chrome - iPhone X":
                        ChromeOptions optionsiPhone = new ChromeOptions();
                        optionsiPhone.EnableMobileEmulation("iPhone X");
                        optionsiPhone.AddArgument("disable-infobars");
                        return webDriver = new ChromeDriver(optionsiPhone);
                    case "Mobile - Chrome - Pixel 2 XL":
                        ChromeOptions optionsPixel = new ChromeOptions();
                        optionsPixel.EnableMobileEmulation("Pixel 2 XL");
                        optionsPixel.AddArgument("disable-infobars");
                        return webDriver = new ChromeDriver(optionsPixel);
                    default:
                        return webDriver = new ChromeDriver();
                }
            }
            else { return null; }

        }
        public IWebDriver CreateBrowserStackDriver(DriverOptions capability)
        {
            AreYouBrowserstackdriver = true;
            return webDriver = new RemoteWebDriver(
            new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capability);
        }
    }
}

