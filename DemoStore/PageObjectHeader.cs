using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStore
{
    class PageObjectHeader
    {
        private IWebDriver driver;
        public PageObjectHeader(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "search_input")]
        public IWebElement textSearchInput { get; set; }

        [FindsBy(How = How.ClassName, Using = "ty-search-magnifier")]
        public IWebElement btnSearch { get; set; }

        [FindsBy(How = How.Id, Using = "sw_dropdown_8")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.ClassName, Using = "ty-float-right")]
        public IWebElement btnCheckout { get; set; }

        public PageObjectSearchResults Search(String Produto)
        {
            textSearchInput.SendKeys(Produto);

            btnSearch.Submit();
            return new PageObjectSearchResults(driver);
        }

        public void ClicksOnCart()
        {
            btnCart.Click();
        }

        public void ClicksOnCheckout()
        {
            btnCheckout.Click();
        }
    }
}
