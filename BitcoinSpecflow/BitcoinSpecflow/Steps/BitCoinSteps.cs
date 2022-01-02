using BitcoinSpecflow.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BitcoinSpecflow.Steps
{
    [Binding]
    public sealed class BitCoinSteps
    {
        Bitcoin bitcoin = null;
       
        [Given(@"Launch the Chrome Application")]
        public void GivenLaunchTheChromeApplication()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            bitcoin = new Bitcoin(webDriver);

        }

        [Given(@"User open the url ""(.*)""")]
        public void GivenUserOpenTheUrl(string url)
        {
            bitcoin.Geturl(url);
        }

        [When(@"User enter date as ""(.*)"" and check rates")]
        public void WhenUserEnterDateAsAndCheckRates(string p0)
        {
            bitcoin.Getgrapg(p0);
            
            
        }

    }
}
