using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScraperRefreshUsingSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new ChromeOptions();
            //options.AddArgument("headless");
            options.AddArguments("--disable-gpu");
            options.AddArguments("disable-popup-blocking");//to disable pop-up blocking

            var chromeDriver = new ChromeDriver(options);

            chromeDriver.Navigate().GoToUrl("https://login.yahoo.com/");
            Console.WriteLine("In Yahoo home page");
            chromeDriver.Manage().Window.Maximize();

            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            chromeDriver.FindElementById("login-username").SendKeys("asangeethu@yahoo.com");
            chromeDriver.FindElementById("login-signin").Click();
            
            chromeDriver.FindElementById("login-passwd").SendKeys("@nuk1978");
            chromeDriver.FindElementById("login-signin").Click();

            chromeDriver.Url = "https://finance.yahoo.com/portfolio/p_1/view/v1";
            Console.WriteLine("In yahoo finance page");

            //var closePopup = chromeDriver.FindElementByXPath("//*[@id=\"fin - tradeit\"]/div[2]/div");
            var closePopup = chromeDriver.FindElementByXPath("//dialog[@id = '__dialog']/section/button");
            closePopup.Click();
            var items = chromeDriver.FindElementsByXPath("//*[@id=\"main\"]/section/section[2]/div[2]/table/tbody/tr[*]/td[*]/span/a");

            foreach(var item in items)
            {
                Console.WriteLine("My WatchList: " + item);
            }
        }       
    }
}
