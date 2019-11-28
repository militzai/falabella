using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class ADDProductTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void aDDProduct() {
    driver.Navigate().GoToUrl("https://www.falabella.com/falabella-cl/");
    driver.Manage().Window.Size = new System.Drawing.Size(1366, 768);
    driver.FindElement(By.CssSelector(".HamburgerIcon_hamburgerContain__1BOAJ")).Click();
    driver.FindElement(By.CssSelector("#item-1 > .FirstLevelItems_menuText__UYB9A")).Click();
    driver.FindElement(By.LinkText("Consolas")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".jsx-2736828475:nth-child(3) .multiselect"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).ClickAndHold().Perform();
    }
    {
      var element = driver.FindElement(By.CssSelector(".jsx-2736828475:nth-child(3) .multiselect"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.CssSelector(".jsx-2736828475:nth-child(3) .multiselect"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Release().Perform();
    }
    driver.FindElement(By.CssSelector("#testId-Accordion-Marca .jsx-4008065441")).Click();
    driver.FindElement(By.CssSelector("#testId-Pod-action-7314614")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".fb-quantity-input__plus"));
      Actions builder = new Actions(driver);
      builder.DoubleClick(element).Perform();
    }
    {
      string value = driver.FindElement(By.Name("quantity1")).GetAttribute("value");
      Assert.That(value, Is.EqualTo("3"));
    }
    driver.Close();
  }
}
