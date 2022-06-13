
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator_Testing.Support
{
    public class LoadDriver
    {
        private const string winAppDriverPath = @"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe";
        private const string appPath = @"C:\Users\DarkJoker\Desktop\Calculator.exe";
        private const string localhost = @"http://127.0.0.1:4723";

        public AppiumOptions appiumOptions;
        public WindowsDriver<WindowsElement> driver;

        public void InitializeDriver()
        {
            System.Diagnostics.Process.Start(winAppDriverPath);
            appiumOptions = new AppiumOptions();

            appiumOptions.AddAdditionalCapability("app", appPath);
            appiumOptions.AddAdditionalCapability("deviceName", "WindowPC");

            driver = new WindowsDriver<WindowsElement>(new Uri(localhost), appiumOptions);
        }
    }
}
