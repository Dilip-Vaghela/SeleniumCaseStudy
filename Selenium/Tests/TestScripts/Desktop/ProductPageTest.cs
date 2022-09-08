
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
            string ID, string Title, string Price, string InterestRate, string Description )
        {
            SeleniumHelper Browser = new SeleniumHelper(webDriver);
            ProductPageSteps ProductPageSteps = new ProductPageSteps(webDriver);

            Browser.Goto("https://podium-test-65804.firebaseapp.com/");
            // check product title is correct
            ProductPageSteps.CheckProductTitleIsCorrect(ID, Title);
            // check product price is correct
            ProductPageSteps.CheckProductPriceIsCorrect(ID, Price);
            // check product interest rate is correct
            ProductPageSteps.CheckProductInterestRateIsCorrect(ID, InterestRate);
            // check product description is correct
            ProductPageSteps.CheckProductDescriptionIsCorrect(ID, Description);
            // click on continue button
            ProductPageSteps.ClickProductContinueBtn(ID);
        }
    }
}

