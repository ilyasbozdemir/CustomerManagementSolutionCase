﻿using CustomerManagement.BDD.TestWithAutomation.PageObjects;

namespace CustomerManagement.TestWithAutomation.PageObjects.Pages;
public class CustomerEditPage : BasePage
{
    private readonly Guid _userId;
    public CustomerEditPage(Guid userId)
    {
        _userId = userId;

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
    }
    public string GetUrl() => $"{_baseUrl}/Edit/{_userId}";
   
}
