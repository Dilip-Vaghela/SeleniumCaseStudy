using System.Globalization;
using Selenium.Helper;
using Selenium.Tests.PageObjects.Desktop;

namespace Selenium.Tests.PageSteps.Desktop
{
    public class ProductPageSteps: ProductPageObjects
    {
        private readonly SeleniumHelper _brower;
        public ProductPageSteps(IWebDriver webDriver) { _brower = new SeleniumHelper(webDriver); }

        
        public void CheckProductTitleIsCorrect(string productId,string expected)
        {
            By msgProductTitle = By.XPath(string.Format(MsgProductTitleById, productId));
            string actual = _brower.GetAttribute(msgProductTitle, "innerHTML");
            Assert.That(actual, Is.EqualTo(expected),
                $"The acutal value {actual} does not the match the expected {expected}");
        }

        public void CheckProductPriceIsCorrect(string productId, string expected)
        {
            By msgProductPrice = By.XPath(string.Format(MsgProductPriceById, productId));
            string actual = _brower.GetAttribute(msgProductPrice, "innerHTML");
            string expectedFormatted = string.Format("£" + expected);
            Assert.That(actual, Is.EqualTo(expectedFormatted),
                $"The acutal value {actual} does not the match the expected {expectedFormatted}");
        }

        public void CheckProductInterestRateIsCorrect(string productId, string expected)
        {
            By msgProductInterestRate = By.XPath(string.Format(MsgProductInterestRateById, productId));
            string actual = _brower.GetAttribute(msgProductInterestRate, "innerHTML");
            double expectedNum = Convert.ToDouble(expected) * 100;
            string expectedFormatted = string.Format(expectedNum.ToString() + "%");
            Assert.That(actual, Is.EqualTo(expectedFormatted),
                $"The acutal value {actual} does not the match the expected {expectedFormatted}");
        }

        public void CheckProductDescriptionIsCorrect(string productId, string expected)
        {
            By msgProductDescription = By.XPath(string.Format(MsgProductDescriptionById, productId));
            string actual = _brower.GetAttribute(msgProductDescription, "innerHTML");
            Assert.That(actual, Is.EqualTo(expected));
        }

        public void ClickProductContinueBtn(string productId)
        {
            By btnProductContine = By.XPath(string.Format(BtnProductContineById, productId));

            _brower.ClickElement(btnProductContine);
        }

    }
}

