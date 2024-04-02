﻿using OpenQA.Selenium;

namespace CustomerManagement.Tests.PageObjects;

public class BasePageComponents
{
    protected IWebDriver _driver;

    public BasePageComponents(IWebDriver driver)
    {
        _driver = driver;
    }
}