using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://horse.industryconnect.io/Account/Login";
            Console.WriteLine("Title of the application opened"+driver.Title);
            driver.Close();
            driver.Quit();
            Console.ReadLine();
        }
    }
}
