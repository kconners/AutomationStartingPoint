using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace StartingPoint
{
    [TestFixture]
    public class SimpleFirst
    {
        //For this solution to work, you will need to get some nuget packages if starting from scratch, these items have already been ran if you are using this exact solution.
        //Run the following using the nuget console. See Tool > Nuget Package Manager > Package Manager Console in the menu bar
        //Install-Package Selenium.WebDriver
        //Install-Package NUnit
        //Install-Package Selenium.WebDriver.ChromeDriver
        //Install-Package NUnit3TestAdapter
        //Install-Package MSTest.TestAdapter
        //Install-Package MSTest.TestFramework

        public IWebDriver Driver { get; set; } //This is the driver that will be used, it represents the browser you want to do your actions in
        [SetUp]
        public void ThisRunsBeforeEachTest()
        { }
        [TearDown]
        public void ThisRunsAfterEachTest()
        {
            if (Driver != null) //Check to see if the driver is null, if it is, take no action
            {
                Driver.Quit(); //Quit the driver, comment this out if you want to leave the browser open for debugging purposes
            }
        }

        [Test]
        public void FirstTest()
        {
            Driver = new OpenQA.Selenium.Chrome.ChromeDriver(); //If you have ChromeDriver in the bin folder that you are executing your test from, you will not need to supply a path to the driver
            Driver.Navigate().GoToUrl("https://www.google.com/"); //This will navigate to the url supplied.
            System.Threading.Thread.Sleep(10000); //This is used to pause the processing. It should be used sparringly
        }

    }
}
