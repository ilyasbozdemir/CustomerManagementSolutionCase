﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CustomerManagement.TestWithOutAutomation.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CustomerManagement_IntegrationTestScenariosFeature : object, Xunit.IClassFixture<CustomerManagement_IntegrationTestScenariosFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Manual_End_to_End_Test_Scenarios.feature"
#line hidden
        
        public CustomerManagement_IntegrationTestScenariosFeature(CustomerManagement_IntegrationTestScenariosFeature.FixtureData fixtureData, CustomerManagement_TestWithOutAutomation_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Customer Management - Integration Test Scenarios", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Creating a New Customer")]
        [Xunit.TraitAttribute("FeatureTitle", "Customer Management - Integration Test Scenarios")]
        [Xunit.TraitAttribute("Description", "Creating a New Customer")]
        [Xunit.TraitAttribute("Category", "CreateCustomer")]
        public void CreatingANewCustomer()
        {
            string[] tagsOfScenario = new string[] {
                    "CreateCustomer"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating a New Customer", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
    testRunner.Given("the user wants to create a new customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
    testRunner.When("the user accesses the customer creation functionality", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 7
    testRunner.And("the user provides necessary customer information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
    testRunner.And("the user initiates the customer creation process", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
    testRunner.Then("the user should receive confirmation that the new customer has been successfully " +
                        "created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Updating Customer Information")]
        [Xunit.TraitAttribute("FeatureTitle", "Customer Management - Integration Test Scenarios")]
        [Xunit.TraitAttribute("Description", "Updating Customer Information")]
        [Xunit.TraitAttribute("Category", "UpdatingCustomerInformation")]
        public void UpdatingCustomerInformation()
        {
            string[] tagsOfScenario = new string[] {
                    "UpdatingCustomerInformation"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Updating Customer Information", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 12
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 13
    testRunner.Given("the user wants to update customer information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 14
    testRunner.When("the user accesses the customer editing functionality", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
    testRunner.And("the user modifies the customer\'s information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
    testRunner.And("the user saves the changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
    testRunner.Then("the user should see the updated customer information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Viewing Customer Details")]
        [Xunit.TraitAttribute("FeatureTitle", "Customer Management - Integration Test Scenarios")]
        [Xunit.TraitAttribute("Description", "Viewing Customer Details")]
        [Xunit.TraitAttribute("Category", "ViewingCustomerDetails")]
        public void ViewingCustomerDetails()
        {
            string[] tagsOfScenario = new string[] {
                    "ViewingCustomerDetails"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Viewing Customer Details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 20
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 21
    testRunner.Given("the user wants to view customer details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 22
    testRunner.When("the user accesses the customer details functionality", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
    testRunner.Then("the user should see the details of the selected customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Customer Listing")]
        [Xunit.TraitAttribute("FeatureTitle", "Customer Management - Integration Test Scenarios")]
        [Xunit.TraitAttribute("Description", "Customer Listing")]
        [Xunit.TraitAttribute("Category", "ListingCustomer")]
        public void CustomerListing()
        {
            string[] tagsOfScenario = new string[] {
                    "ListingCustomer"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Customer Listing", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 26
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 27
    testRunner.Given("the user wants to view the list of customers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 28
    testRunner.When("the user accesses the customer listing functionality", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
    testRunner.Then("the user should see the current list of customers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Customer Deletion")]
        [Xunit.TraitAttribute("FeatureTitle", "Customer Management - Integration Test Scenarios")]
        [Xunit.TraitAttribute("Description", "Customer Deletion")]
        [Xunit.TraitAttribute("Category", "CustomerDeletion")]
        public void CustomerDeletion()
        {
            string[] tagsOfScenario = new string[] {
                    "CustomerDeletion"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Customer Deletion", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 32
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 33
    testRunner.Given("the user wants to delete a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 34
    testRunner.When("the user accesses the customer deletion functionality", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
    testRunner.And("the user confirms the deletion", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
    testRunner.Then("the user should receive confirmation that the customer has been successfully dele" +
                        "ted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CustomerManagement_IntegrationTestScenariosFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CustomerManagement_IntegrationTestScenariosFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
