using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BitcoinSpecflow.Pages
{
    class Bitcoin
    {
     

        public IWebDriver WebDriver { get; }
        public Bitcoin(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

  

        public void Geturl(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
            Thread.Sleep(3000);
        }

        public void Getgrapg(string p0)
        {
            
            Actions act = new Actions(WebDriver);
            IWebElement ele= WebDriver.FindElement(By.XPath("((//*[name()='svg' and @class='highcharts-root'])[1]//*[name()='rect'])[4]"));
            int getTopLeftY = ((ele.Size.Height) / 2)-ele.Size.Height;
            int getTopLeftX = ((ele.Size.Width) / 2)-ele.Size.Width;

            

            for (int i = 0; i < ele.Size.Width; i++)
            {
                act.MoveToElement(ele, getTopLeftX + i, getTopLeftY).Perform();
                Thread.Sleep(1000);
                string text = p0;
                string date = WebDriver.FindElement(By.XPath("//div[@class='highcharts-label highcharts-tooltip chart-tooltip highcharts-color-undefined']/span/span[1]")).Text;
                if (date == text)
                {
                    Console.WriteLine(WebDriver.FindElement(By.XPath("//div[@class='highcharts-label highcharts-tooltip chart-tooltip highcharts-color-undefined']/span/span[2]")).Text);
                    break;
                }
                
            }
            

        }

    


    }
}
