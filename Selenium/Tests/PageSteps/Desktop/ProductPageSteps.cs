using System.Globalization;
using Selenium.Helper;
using Selenium.Tests.PageObjects.Desktop;

namespace Selenium.Tests.PageSteps.Desktop
{
    public class ProductPageSteps: ProductPageObjects
    {
        private SeleniumHelper Brower;
        public ProductPageSteps(IWebDriver webDriver) { Brower = new SeleniumHelper(webDriver); }

        
        public void CheckProductTitleIsCorrect(string productID,string expected)
        {
            By msgProductTitle = By.XPath(string.Format(msgProductTitleByID, productID));
            string actual = Brower.GetAttribute(msgProductTitle, "innerHTML");
            Assert.That(actual, Is.EqualTo(expected),string.Format("The acutal value {0} does not the match the expected {1}",actual,expected));
        }

        public void CheckProductPriceIsCorrect(string productID, string expected)
        {
            By msgProductPrice = By.XPath(string.Format(msgProductPriceByID, productID));
            string actual = Brower.GetAttribute(msgProductPrice, "innerHTML");
            string expectedFormatted = string.Format("£" + expected);
            Assert.That(actual, Is.EqualTo(expectedFormatted), string.Format("The acutal value {0} does not the match the expected {1}", actual, expectedFormatted));
        }

        public void CheckProductInterestRateIsCorrect(string productID, string expected)
        {
            By msgProductInterestRate = By.XPath(string.Format(msgProductInterestRateByID, productID));
            string actual = Brower.GetAttribute(msgProductInterestRate, "innerHTML");
            double ExpectedNum = Convert.ToDouble(expected) * 100;
            string expectedFormatted = string.Format(ExpectedNum.ToString() + "%");
            Assert.That(actual, Is.EqualTo(expectedFormatted), string.Format("The acutal value {0} does not the match the expected {1}", actual, expectedFormatted));
        }

        public void CheckProductDescriptionIsCorrect(string productID, string expected)
        {
            By msgProductDescription = By.XPath(string.Format(msgProductDescriptionByID, productID));
            string actual = Brower.GetAttribute(msgProductDescription, "innerHTML");
            Assert.That(actual, Is.EqualTo(expected));
        }

        public void ClickProductContinueBtn(string productID)
        {
            By btnProductContine = By.XPath(string.Format(btnProductContineByID, productID));

            Brower.ClickElement(btnProductContine);
        }

    }
}

