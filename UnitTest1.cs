using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace automationexercise
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Automation_Exercise_Log_In_Test()
        {
            var options = new ChromeOptions();
            options.BinaryLocation = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe";
            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.automationexercise.com/");
            Thread.Sleep(1000);

            IWebElement AutomationElement = driver.FindElement(By.XPath("//a[@href='/login']"));
            AutomationElement.Click();

            Thread.Sleep(1000);

            AutomationElement = driver.FindElement(By.Name("email"));
            AutomationElement.SendKeys("YOUR_EMAIL");

            AutomationElement = driver.FindElement(By.Name("password"));
            AutomationElement.SendKeys("YOUR_PASSWORD");

            AutomationElement = driver.FindElement(By.XPath("//button[@data-qa='login-button']"));
            AutomationElement.Submit();

            Thread.Sleep(2000);

            driver.Close();
        }
    }
}