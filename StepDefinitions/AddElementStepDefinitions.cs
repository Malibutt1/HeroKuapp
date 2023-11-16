using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace HeroKuapp.StepDefinitions
{
    [Binding]
    public class AddElementStepDefinitions
    {
        public IWebDriver _driver;
        int count = 0;
        public AddElementStepDefinitions(IWebDriver driver)
            {
                _driver = driver;
            }

        [Given(@"Navigate to the Url")]
        public void GivenNavigateToTheUrl()
        {
            _driver.Url = "https://the-internet.herokuapp.com/";
            Thread.Sleep(3000);
        }

        [When(@"Click on the add element link")]
        public void WhenClickOnTheAddElementLink()
        {
            _driver.FindElement(By.XPath("//a[@href = '/add_remove_elements/']")).Click();
            Thread.Sleep(3000);
        }

        [When(@"Add any number of element required")]
        public void WhenAddAnyNumberOfElementRequired()
        {
           
            for(int i = 1;i<=5;i++)   //taking n = 5
            {
                _driver.FindElement(By.XPath("//div[@class = 'example']//button")).Click();
                Thread.Sleep(3000);
                count++;    
            }
        }

        [Then(@"Validate that element has been added")]
        public void ThenValidateThatElementHasBeenAdded()
        {
            IWebElement element = _driver.FindElement(By.XPath("//div[@id= 'elements']"));

            Assert.AreEqual("DeleteDeleteDeleteDeleteDelete", element.Text);
            Console.WriteLine("The number of elements added = " + count);
        }
    }
}
