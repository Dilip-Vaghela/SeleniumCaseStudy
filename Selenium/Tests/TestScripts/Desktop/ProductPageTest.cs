
using Selenium.Helper;
using Selenium.Tests.PageSteps;
using Selenium.Tests.PageSteps.Desktop;
using Selenium.Config;

namespace Selenium.Tests.TestScripts.Desktop
{
    public class ProductPageTest : TestBaseDesktop
    {
        public ProductPageTest(string profile, string browser) : base(profile, browser) { }

 
        [Test,TestCaseSource(typeof(ConfigDataAccess), nameof(ConfigDataAccess.ReadDataProduct))]
        public void Check_ProductDetailsAndClickContinueButton(
            string id, string title, string price, string interestRate, string description )
        {
            SeleniumHelper browser = new SeleniumHelper(WebDriver);
            ProductPageSteps productPageSteps = new ProductPageSteps(WebDriver);

            browser.Goto("https://podium-test-65804.firebaseapp.com/");
            // check product title is correct
            productPageSteps.CheckProductTitleIsCorrect(id, title);
            // check product price is correct
            productPageSteps.CheckProductPriceIsCorrect(id, price);
            // check product interest rate is correct
            productPageSteps.CheckProductInterestRateIsCorrect(id, interestRate);
            // check product description is correct
            productPageSteps.CheckProductDescriptionIsCorrect(id, description);
            // click on continue button
            productPageSteps.ClickProductContinueBtn(id);
        }
    }
}

