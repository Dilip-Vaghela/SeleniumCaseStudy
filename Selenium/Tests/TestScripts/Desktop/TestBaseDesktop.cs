
using Selenium.Helper;
[assembly: LevelOfParallelism(5)]
namespace Selenium.Tests.TestScripts.Desktop;

//Local drivers
[TestFixture("Local", "Desktop - Chrome")]
//[TestFixture("Local", "Desktop - Firefox")]
//[TestFixture("Local", "Desktop - Edge")]
//[TestFixture("Local", "Desktop - IE")]

//Browserstack
//[TestFixture("Browserstack", "Safari-Latest")]
//[TestFixture("Browserstack", "Safari-13")]
//[TestFixture("Browserstack", "Safari-12")]
//[TestFixture("Browserstack", "Safari-11")]
//[TestFixture("Browserstack", "Chrome-Latest")]
//[TestFixture("Browserstack", "Chrome-Beta")]
//[TestFixture("Browserstack", "Edge-Latest")]
//[TestFixture("Browserstack", "Edge-Beta")]
//[TestFixture("Browserstack", "FireFox-Latest")]
//[TestFixture("Browserstack", "FireFox-Beta")]
//[TestFixture("Browserstack", "IE11-Latest")]

//Nunit attributes
[Parallelizable(ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class TestBaseDesktop
{ 
    private string profile = string.Empty;
    private string browser = string.Empty;
    public IWebDriver? webDriver;


    public TestBaseDesktop(string profile, string browser)
    {
        this.profile = profile;
        this.browser = browser;
    }

    [SetUp]
    public void Setup()
    { 
            webDriver = new DriverHelpers().CreateDriver(profile, browser);
            webDriver.Manage().Window.Maximize();
    }

    [TearDown]
    public void TearDown()
    {
            new SeleniumHelper(webDriver).Quit();   
    } 
}
