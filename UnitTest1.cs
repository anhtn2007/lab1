using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstTests;

public class Tests
{
    private IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
    }

    [Test]
    public void TestGoogleTitle()
    {
        driver.Navigate().GoToUrl("https://www.google.com");
        string title = driver.Title;
        
        // Khẳng định tiêu đề trang chứa từ "Google"
        Assert.That(title, Does.Contain("Google"), "Tiêu đề trang không khớp!");
    }

    [TearDown]
    public void TearDown()
    {
        // Đóng trình duyệt và giải phóng tài nguyên triệt để
        driver?.Quit();
        driver?.Dispose();
    }
}