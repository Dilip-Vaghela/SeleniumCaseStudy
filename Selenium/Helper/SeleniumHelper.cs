using System.Diagnostics.CodeAnalysis;

namespace Selenium.Helper
{
    public class SeleniumHelper
    {
        private readonly IWebDriver _webDriver;
        public SeleniumHelper(IWebDriver driver) { _webDriver = driver; }
        private static bool IsNotNull([NotNullWhen(true)] object? obj) => obj != null;

        public void Quit()
        {
            CheckTestCaseResult();
            CheckTestCaseResultForBrowserStack();
            _webDriver.Quit();
        }

        public void CheckTestCaseResult()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status.Equals(TestStatus.Failed)) { GetScreenShot(); }
        }

        public string GetAttribute(By element, string attributeName)
        {
            WaitForReady(element);
            return _webDriver.FindElement(element).GetAttribute(attributeName);
        }


        public void GetScreenShot()
        {
            string? fileName = TestContext.CurrentContext.Test.MethodName;
            string? presentDate = DateTime.Now.ToString("MMddyyyyHHmmss");
            string? screenshotLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (IsNotNull(screenshotLocation))
            {
                string? pngLocation = Path.Combine(screenshotLocation, "Utilities/Screenshots/" + fileName + presentDate + ".png");
                Screenshot screenshot = ((ITakesScreenshot)_webDriver).GetScreenshot();
                screenshot.SaveAsFile(pngLocation);
                TestContext.AddTestAttachment(pngLocation, "Screenshot");
            }
        }

        public void CheckTestCaseResultForBrowserStack()
        {
            
            DateTime presentDateTime = DateTime.Now;
            string strPresentDateTime = presentDateTime.ToString("dd/MM/yyyy HH':'mm':'ss");
            if (DriverHelpers.AreYouBrowserstackdriver.Equals(true))
            {
                    if (TestContext.CurrentContext.Result.Outcome.Status.Equals(TestStatus.Failed))
                    {
                        ((IJavaScriptExecutor)_webDriver).ExecuteScript("browserstack_executor: {\"action\": \"setSessionStatus\", \"arguments\": {\"status\":\"failed\", \"reason\": \"" + TestContext.CurrentContext.Result.Message.ToString() + "\"}}");
                        ((IJavaScriptExecutor)_webDriver).ExecuteScript("browserstack_executor: {\"action\": \"setSessionName\", \"arguments\": {\"name\":\"" + strPresentDateTime + " " + TestContext.CurrentContext.Test.MethodName?.ToString() + "\"}}");
                    }
                    else
                    {
                        ((IJavaScriptExecutor)_webDriver).ExecuteScript("browserstack_executor: {\"action\": \"setSessionStatus\", \"arguments\": {\"status\":\"passed\", \"reason\": \"PASSED WITHOUT ERRORS\"}}");
                        ((IJavaScriptExecutor)_webDriver).ExecuteScript("browserstack_executor: {\"action\": \"setSessionName\", \"arguments\": {\"name\":\"" + strPresentDateTime + " " + TestContext.CurrentContext.Test.MethodName?.ToString() + "\"}}");
                    }

            }
        }
        public IWebDriver? GetDriver { get { return _webDriver; } }
        public void Goto(string url)
        {
            _webDriver.Url = url;
        }
        public void SwitchToOverlay(int iFrameNumber)
        {
            _webDriver.SwitchTo().Frame(iFrameNumber);
        }

        public void SwitchToFrame(By frameElement1)
        {
            try
            {
                IWebElement frameElement = _webDriver.FindElement(frameElement1);
                _webDriver.SwitchTo().Frame(frameElement);
                Console.WriteLine("Navigated to frame with element " + frameElement);
            }
            catch (NoSuchFrameException e)
            {
                Console.WriteLine("Unable to locate frame with element " + frameElement1 + e.Message);
            }
            catch (StaleElementReferenceException e)
            {
                Console.WriteLine("Element with " + frameElement1 + "is not attached to the page document" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to navigate to frame with element " + frameElement1 + e.Message);
            }
        }

        public void SwitchToOverlay(By element)
        {
            _webDriver.SwitchTo().Frame(1);
        }
        public void SwitchToDefaultIFrame() { _webDriver.SwitchTo().DefaultContent(); }
        public void HoverOnElement(By element)
        {
            IWebElement ele = _webDriver.FindElement(element);
            try
            {
                ((IJavaScriptExecutor)_webDriver).ExecuteScript("arguments[0].scrollIntoView(false);", ele);
                Wait(2);
                ((IJavaScriptExecutor)_webDriver).ExecuteScript("window.scrollBy(0,100);");
                Wait(2);
            }
            catch (StaleElementReferenceException)
            {
                Wait(2);
                ((IJavaScriptExecutor)_webDriver).ExecuteScript("arguments[0].scrollIntoView(false);", ele);
                Wait(2);
                ((IJavaScriptExecutor)_webDriver).ExecuteScript("window.scrollBy(0,100);");
                Wait(2);
            }
            catch (Exception)
            {
                Assert.Fail($"Unable to make [{element}]");
            }
        }

        public void HoverOnElementWithoutScrollBy(By element)
        {
            IWebElement ele = _webDriver.FindElement(element);
            try
            {
                ((IJavaScriptExecutor)_webDriver).ExecuteScript("arguments[0].scrollIntoView(false);", ele);
            }
            catch (StaleElementReferenceException)
            {
                Wait(2);
                ((IJavaScriptExecutor)_webDriver).ExecuteScript("arguments[0].scrollIntoView(false);", ele);
            }
            catch (Exception)
            { 
                Assert.Fail($"Unable to make [{element}]");
            }
            
        }


        public void ClickElementWithErrors(By element)
        {
            //WaitForReady(element);
            //HoverOnElement(element);
            Wait(5);
            try
            {
                _webDriver.FindElement(element).Click();
            }
            catch (Exception)
            {
                Assert.Fail($"Unable to Click on [{element}]");
            }
        }

        public void ClickElement(By element)
        {
            WaitForReady(element);
            HoverOnElement(element);
            try
            {
                _webDriver.FindElement(element).Click();
            }
            catch (StaleElementReferenceException)
            {
                Wait(2);
                _webDriver.FindElement(element).Click();
            }
            catch (Exception)
            {
                Assert.Fail($"Unable to Click on [{element}]");
            }
        }
        public void SendKeyEnter(By element)
        {
            WaitForReady(element);
            HoverOnElement(element);
            try
            {
                _webDriver.FindElement(element).SendKeys(Keys.Return);
            }
            catch (StaleElementReferenceException)
            {
                Wait(2);
                _webDriver.FindElement(element).SendKeys(Keys.Return);
            }
            catch (Exception)
            {
                Assert.Fail($"Unable to press 'ENTER' key on [{element}]");
            }

        }
        public void SendKeyTab(By element)
        {
            WaitForReady(element);
            HoverOnElement(element);
            try
            {
                _webDriver.FindElement(element).SendKeys(Keys.Tab);
            }
            catch (StaleElementReferenceException)
            {
                Wait(2);
                _webDriver.FindElement(element).SendKeys(Keys.Tab);
            }
            catch (Exception)
            {
                Assert.Fail($"Unable to press 'TAB' key on [{element}]");
            }
        }
        public void SendKeys(By element, string keys)
        {
            WaitForReady(element);
            HoverOnElement(element);
            try
            {
                _webDriver.FindElement(element).SendKeys(keys);
            }
            catch (StaleElementReferenceException)
            {
                Wait(2);
                _webDriver.FindElement(element).SendKeys(keys);
            }
            catch (Exception)
            {
                Assert.Fail($"Unable to enter [{keys}] into [{element}]");
            }
        }
        public void ClearKeys(By element)
        {
            try
            {
                _webDriver.FindElement(element).Clear();
            }
            catch (Exception)
            {   
                Assert.Fail($"Unable to clear text within [{element}]");
            }
        }
        public void SelectOptionByText(By element, string option)
        {
            WaitForReady(element);
            HoverOnElement(element);
            SelectElement selectElement = new SelectElement(_webDriver.FindElement(element));
            try
            {
                selectElement.SelectByText(option);
            }
            catch (StaleElementReferenceException)
            {
                Wait(2);
                selectElement.SelectByText(option);
            }
            catch (Exception)
            {
                Assert.Fail($"Unable to select [{option}] within [{element}]");
            }

        }
        public void SelectOptionByValue(By element, string value)
        {
            WaitForReady(element);
            HoverOnElement(element);
            SelectElement selectElement = new SelectElement(_webDriver.FindElement(element));
            try
            {
                selectElement.SelectByValue(value);
            }
            catch (StaleElementReferenceException)
            {
                Wait(2); selectElement.SelectByValue(value);
            }
            catch (Exception)
            {
                Assert.Fail($"Unable to select [{value}] within [{element}]");
            }
        }

        public void Wait(int delay)
        {
            try
            {
                //int interval = 1;
                var now = DateTime.Now;
                WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(delay));
                //{ PollingInterval = TimeSpan.FromMilliseconds(interval) };
                bool duration = wait.Until(wd => (DateTime.Now - now) - TimeSpan.FromSeconds(delay) > TimeSpan.Zero);
            }
            catch (WebDriverTimeoutException)
            {
                Assert.Fail($"Failed to wait [{delay}] seconds");
            }
        }
        public void WaitForReady(By element)
        {
            FluentWaitForElementTobeDisplayed(element);
            FluentWaitForElementTobeEnabled(element);
            WaitUntilJsReady();
            WaitUntilJQueryReady();
            Wait(2);
        }

        public void FluentWaitForElementTobeDisplayed(By element)
        {
            int delay = 3;
            DefaultWait<IWebDriver?> fluentWait = new DefaultWait<IWebDriver?>(_webDriver);
            fluentWait.Timeout = TimeSpan.FromMinutes(delay);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            try
            {
                fluentWait.Until(driver =>
                {
                    IWebElement tempElement = _webDriver.FindElement(element);
                    return tempElement.Displayed;
                }
                );
            }
            catch (WebDriverTimeoutException)
            {
                Assert.Fail($"Failed to wait for [{element}] to be displayed for [{delay}] mintues]");
            }

        }
        public void FluentWaitForElementTobeEnabled(By element)
        {
            int delay = 3;
            DefaultWait<IWebDriver?> fluentWait = new DefaultWait<IWebDriver?>(_webDriver);
            fluentWait.Timeout = TimeSpan.FromMinutes(delay);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            try
            {
                fluentWait.Until(driver =>
                {
                    IWebElement tempElement = _webDriver.FindElement(element);
                    return tempElement.Enabled;
                }
                );
            }
            catch (WebDriverTimeoutException)
            {
                Assert.Fail($"Failed to wait for [{element}] to be enabled for [{delay}] mintues]");
            }
        }
        public void WaitUntilJsReady()
        {
            int delay = 3;
            DefaultWait<IWebDriver?> fluentWait = new DefaultWait<IWebDriver?>(_webDriver);
            fluentWait.Timeout = TimeSpan.FromMinutes(delay);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            fluentWait.Until(driver =>
            {
            try
                { 
                    bool jsReady = (bool)((IJavaScriptExecutor)_webDriver).ExecuteScript("return document.readyState").ToString().Equals("complete");
                    if (jsReady)
                    {
                        return true;
                    };
                }
                catch (WebDriverTimeoutException)
                {
                    Assert.Fail($"Failed to load JavaScript within [{delay}] mintues]");
                }
                return false;
            });
        }
        public void WaitUntilJQueryReady()
        {
            bool jqueryDefined = (bool)((IJavaScriptExecutor)_webDriver).ExecuteScript("return typeof jQuery != 'undefined'");
            if (jqueryDefined)
            {
                WaitUntilJQueryLoad();
            }

        }
        public void WaitUntilJQueryLoad()
        {
            int delay = 3;
            DefaultWait<IWebDriver?> fluentWait = new DefaultWait<IWebDriver?>(_webDriver);
            fluentWait.Timeout = TimeSpan.FromMinutes(delay);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            fluentWait.Until(driver =>
            {
                try
                {
                    bool jqueryReady = (bool)((IJavaScriptExecutor)_webDriver).ExecuteScript("return jQuery.active == 0");
                    if (jqueryReady)
                    {
                        return true;
                    }
                }
                catch (WebDriverTimeoutException)
                {
                    Assert.Fail($"Failed to load jQuery within [{delay}] mintues]");
                }
                return false;
            });
        }
    }
}


