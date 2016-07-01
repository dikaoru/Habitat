﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.Accounts.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "UI")]
    public partial class SaveUserDetailsInXDBFeature : Xunit.IClassFixture<SaveUserDetailsInXDBFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Save user details in xDB.feature"
#line hidden
        
        public SaveUserDetailsInXDBFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Save user details in xDB", null, ProgrammingLanguage.CSharp, new string[] {
                        "UI"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(SaveUserDetailsInXDBFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Account_Save user details in xDB_UC1_Save full info")]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC1_Save full info")]
        [Xunit.TraitAttribute("Category", "NeedUpdateStepWithRemovingDataFromAnalytic")]
        public virtual void Account_SaveUserDetailsInXDB_UC1_SaveFullInfo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC1_Save full info", new string[] {
                        "NeedUpdateStepWithRemovingDataFromAnalytic"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table1.AddRow(new string[] {
                        "kovuc1@sitecore.net",
                        "k",
                        "k"});
#line 7
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table2.AddRow(new string[] {
                        "kovuc1@sitecore.net",
                        "k"});
#line 10
 testRunner.And("User was Login to Habitat", ((string)(null)), table2, "And ");
#line 13
 testRunner.And("Edit profile page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "LastName",
                        "FirstName",
                        "PhoneNumber"});
            table3.AddRow(new string[] {
                        "Maximov",
                        "Stas",
                        "+38(067)3333333"});
#line 14
 testRunner.When("User inputs data in to the fields", ((string)(null)), table3, "When ");
#line 17
 testRunner.And("User selects Skiing from Interests drop-down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("User clicks Update button on Edit User Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.Then("Contact kovuc1@sitecore.net has FirstName equals Stas and Surname equals Maximov", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.And("Contact kovuc1@sitecore.net has PhoneNumber equals +38(067)3333333", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("Contact kovuc1@sitecore.net has SMTP emails equals kovuc1@sitecore.net", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "\"0\""});
            table4.AddRow(new string[] {
                        "Skiing"});
#line 23
 testRunner.And("Contact collection Tags.Interests.Values section for kovuc1@sitecore.net consist " +
                    "of", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Account_Save user details in xDB_UC2_Update full user info")]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC2_Update full user info")]
        [Xunit.TraitAttribute("Category", "NeedUpdateStepWithRemovingDataFromAnalytic")]
        public virtual void Account_SaveUserDetailsInXDB_UC2_UpdateFullUserInfo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC2_Update full user info", new string[] {
                        "NeedUpdateStepWithRemovingDataFromAnalytic"});
#line 34
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table5.AddRow(new string[] {
                        "kovuc2@sitecore.net",
                        "k",
                        "k"});
#line 35
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table5, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table6.AddRow(new string[] {
                        "kovuc2@sitecore.net",
                        "k"});
#line 38
 testRunner.And("User was Login to Habitat", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "LastName",
                        "FirstName",
                        "PhoneNumber",
                        "Interests"});
            table7.AddRow(new string[] {
                        "Teltov",
                        "Konstantin",
                        "+38(067)3333333",
                        "Swiming"});
#line 41
 testRunner.And("User inputs data on User Profile page and clicks Update button", ((string)(null)), table7, "And ");
#line 44
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("Edit profile page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "LastName",
                        "FirstName",
                        "PhoneNumber"});
            table8.AddRow(new string[] {
                        "Maximov",
                        "Stas",
                        "+38(067)8888888"});
#line 46
 testRunner.When("User inputs data in to the fields", ((string)(null)), table8, "When ");
#line 49
 testRunner.And("User selects Skiing from Interests drop-down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("User clicks Update button on Edit User Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.Then("Contact kovuc2@sitecore.net has FirstName equals Stas and Surname equals Maximov", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
 testRunner.And("Contact kovuc2@sitecore.net has PhoneNumber equals +38(067)8888888", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("Contact kovuc2@sitecore.net has SMTP emails equals kovuc2@sitecore.net", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "\"0\"",
                        "\"1\""});
            table9.AddRow(new string[] {
                        "Swiming",
                        "Skiing"});
#line 55
 testRunner.And("Contact collection Tags.Interests.Values section for kovuc2@sitecore.net consist " +
                    "of", ((string)(null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Account_Save user details in xDB_UC3_Save only one of the name fields")]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC3_Save only one of the name fields")]
        [Xunit.TraitAttribute("Category", "NeedUpdateStepWithRemovingDataFromAnalytic")]
        public virtual void Account_SaveUserDetailsInXDB_UC3_SaveOnlyOneOfTheNameFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC3_Save only one of the name fields", new string[] {
                        "NeedUpdateStepWithRemovingDataFromAnalytic"});
#line 64
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table10.AddRow(new string[] {
                        "kovuc3@sitecore.net",
                        "k",
                        "k"});
#line 65
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table10, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table11.AddRow(new string[] {
                        "kovuc3@sitecore.net",
                        "k"});
#line 68
 testRunner.And("User was Login to Habitat", ((string)(null)), table11, "And ");
#line 71
 testRunner.And("Edit profile page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "LastName"});
            table12.AddRow(new string[] {
                        "Maximov"});
#line 72
 testRunner.When("User inputs data in to the fields", ((string)(null)), table12, "When ");
#line 75
 testRunner.And("User clicks Update button on Edit User Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.Then("Contact kovuc3@sitecore.net has FirstName equals @empty and Surname equals Maximo" +
                    "v", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
 testRunner.And("Contact kovuc3@sitecore.net has PhoneNumber equals @empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("Contact kovuc3@sitecore.net has SMTP emails equals kovuc3@sitecore.net", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "\"0\""});
            table13.AddRow(new string[] {
                        "@empty"});
#line 80
 testRunner.And("Contact collection Tags.Interests.Values section for kovuc3@sitecore.net consist " +
                    "of", ((string)(null)), table13, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Account_Save user details in xDB_UC4_Save only phone number")]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC4_Save only phone number")]
        [Xunit.TraitAttribute("Category", "NeedUpdateStepWithRemovingDataFromAnalytic")]
        public virtual void Account_SaveUserDetailsInXDB_UC4_SaveOnlyPhoneNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC4_Save only phone number", new string[] {
                        "NeedUpdateStepWithRemovingDataFromAnalytic"});
#line 86
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table14.AddRow(new string[] {
                        "kovuc4@sitecore.net",
                        "k",
                        "k"});
#line 87
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table14, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table15.AddRow(new string[] {
                        "kovuc4@sitecore.net",
                        "k"});
#line 90
 testRunner.And("User was Login to Habitat", ((string)(null)), table15, "And ");
#line 93
 testRunner.And("Edit profile page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "PhoneNumber"});
            table16.AddRow(new string[] {
                        "+38(067)8888888"});
#line 94
 testRunner.When("User inputs data in to the fields", ((string)(null)), table16, "When ");
#line 97
 testRunner.And("User clicks Update button on Edit User Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.Then("Contact kovuc4@sitecore.net has FirstName equals @empty and Surname equals @empty" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.And("Contact kovuc4@sitecore.net has PhoneNumber equals +38(067)8888888", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.And("Contact kovuc4@sitecore.net has SMTP emails equals kovuc4@sitecore.net", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "\"0\""});
            table17.AddRow(new string[] {
                        "@empty"});
#line 102
 testRunner.And("Contact collection Tags.Interests.Values section for kovuc4@sitecore.net consist " +
                    "of", ((string)(null)), table17, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Account_Save user details in xDB_UC5_Save only Interests")]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC5_Save only Interests")]
        [Xunit.TraitAttribute("Category", "NeedUpdateStepWithRemovingDataFromAnalytic")]
        public virtual void Account_SaveUserDetailsInXDB_UC5_SaveOnlyInterests()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC5_Save only Interests", new string[] {
                        "NeedUpdateStepWithRemovingDataFromAnalytic"});
#line 109
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table18.AddRow(new string[] {
                        "kovuc5@sitecore.net",
                        "k",
                        "k"});
#line 110
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table18, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table19.AddRow(new string[] {
                        "kovuc5@sitecore.net",
                        "k"});
#line 113
 testRunner.And("User was Login to Habitat", ((string)(null)), table19, "And ");
#line 116
 testRunner.And("Edit profile page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.When("User selects Skiing from Interests drop-down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 118
 testRunner.And("User clicks Update button on Edit User Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.Then("Contact kovuc5@sitecore.net has FirstName equals @empty and Surname equals @empty" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 121
 testRunner.And("Contact kovuc5@sitecore.net has PhoneNumber equals @empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.And("Contact kovuc5@sitecore.net has SMTP emails equals kovuc5@sitecore.net", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "\"0\""});
            table20.AddRow(new string[] {
                        "@empty"});
#line 123
 testRunner.And("Contact collection Tags.Interests.Values section for kovuc5@sitecore.net consist " +
                    "of", ((string)(null)), table20, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Account_Save user details in xDB_UC6_Update only one of the name fields")]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC6_Update only one of the name fields")]
        [Xunit.TraitAttribute("Category", "NeedUpdateStepWithRemovingDataFromAnalytic")]
        public virtual void Account_SaveUserDetailsInXDB_UC6_UpdateOnlyOneOfTheNameFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC6_Update only one of the name fields", new string[] {
                        "NeedUpdateStepWithRemovingDataFromAnalytic"});
#line 129
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table21.AddRow(new string[] {
                        "kovuc6@sitecore.net",
                        "k",
                        "k"});
#line 130
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table21, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table22.AddRow(new string[] {
                        "kovuc6@sitecore.net",
                        "k"});
#line 133
 testRunner.And("User was Login to Habitat", ((string)(null)), table22, "And ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "LastName",
                        "FirstName",
                        "PhoneNumber",
                        "Interests"});
            table23.AddRow(new string[] {
                        "Teltov",
                        "Konstantin",
                        "+38(067)3333333",
                        "Swiming"});
#line 136
 testRunner.And("User inputs data on User Profile page and clicks Update button", ((string)(null)), table23, "And ");
#line 139
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
 testRunner.And("Edit profile page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "LastName"});
            table24.AddRow(new string[] {
                        "Maximov"});
#line 141
 testRunner.When("User inputs data in to the fields", ((string)(null)), table24, "When ");
#line 144
 testRunner.And("User clicks Update button on Edit User Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
 testRunner.Then("Contact kovuc6@sitecore.net has FirstName equals Konstantin and Surname equals Ma" +
                    "ximov", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 147
 testRunner.And("Contact kovuc6@sitecore.net has PhoneNumber equals +38(067)3333333", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
 testRunner.And("Contact kovuc6@sitecore.net has SMTP emails equals kovuc6@sitecore.net", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "\"0\""});
            table25.AddRow(new string[] {
                        "Swiming"});
#line 149
 testRunner.And("Contact collection Tags.Interests.Values section for kovuc6@sitecore.net consist " +
                    "of", ((string)(null)), table25, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Account_Save user details in xDB_UC7_Update only phone number")]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC7_Update only phone number")]
        [Xunit.TraitAttribute("Category", "NeedUpdateStepWithRemovingDataFromAnalytic")]
        public virtual void Account_SaveUserDetailsInXDB_UC7_UpdateOnlyPhoneNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC7_Update only phone number", new string[] {
                        "NeedUpdateStepWithRemovingDataFromAnalytic"});
#line 155
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table26.AddRow(new string[] {
                        "kovuc7@sitecore.net",
                        "k",
                        "k"});
#line 156
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table26, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table27.AddRow(new string[] {
                        "kovuc7@sitecore.net",
                        "k"});
#line 159
 testRunner.And("User was Login to Habitat", ((string)(null)), table27, "And ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "LastName",
                        "FirstName",
                        "PhoneNumber",
                        "Interests"});
            table28.AddRow(new string[] {
                        "Teltov",
                        "Konstantin",
                        "+38(067)3333333",
                        "Swiming"});
#line 162
 testRunner.And("User inputs data on User Profile page and clicks Update button", ((string)(null)), table28, "And ");
#line 165
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 166
 testRunner.And("Edit profile page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                        "Phone number"});
            table29.AddRow(new string[] {
                        "+38(067)8888888"});
#line 167
 testRunner.When("User inputs data in to the fields", ((string)(null)), table29, "When ");
#line 170
 testRunner.And("User clicks Update button on Edit User Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 171
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 172
 testRunner.Then("Contact kovuc7@sitecore.net has FirstName equals Konstantin and Surname equals Ma" +
                    "ximov", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 173
 testRunner.And("Contact kovuc7@sitecore.net has PhoneNumber equals +38(067)8888888", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 174
 testRunner.And("Contact kovuc7@sitecore.net has SMTP emails equals kovuc7@sitecore.net", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                        "\"0\""});
            table30.AddRow(new string[] {
                        "Swiming"});
#line 175
 testRunner.And("Contact collection Tags.Interests.Values section for kovuc7@sitecore.net consist " +
                    "of", ((string)(null)), table30, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Account_Save user details in xDB_UC8_Update only only Interests")]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC8_Update only only Interests")]
        [Xunit.TraitAttribute("Category", "NeedUpdateStepWithRemovingDataFromAnalytic")]
        public virtual void Account_SaveUserDetailsInXDB_UC8_UpdateOnlyOnlyInterests()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC8_Update only only Interests", new string[] {
                        "NeedUpdateStepWithRemovingDataFromAnalytic"});
#line 180
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table31.AddRow(new string[] {
                        "kovuc8@sitecore.net",
                        "k",
                        "k"});
#line 181
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table31, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table32.AddRow(new string[] {
                        "kovuc8@sitecore.net",
                        "k"});
#line 184
 testRunner.And("User was Login to Habitat", ((string)(null)), table32, "And ");
#line hidden
            TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                        "LastName",
                        "FirstName",
                        "PhoneNumber",
                        "Interests"});
            table33.AddRow(new string[] {
                        "Teltov",
                        "Konstantin",
                        "+38(067)3333333",
                        "Swiming"});
#line 187
 testRunner.And("User inputs data on User Profile page and clicks Update button", ((string)(null)), table33, "And ");
#line 190
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 191
 testRunner.And("Edit profile page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 192
 testRunner.When("User selects Skiing from Interests drop-down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 193
 testRunner.And("User clicks Update button on Edit User Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 194
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 195
 testRunner.Then("Contact kovuc8@sitecore.net has FirstName equals Konstantin and Surname equals Te" +
                    "ltov", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 196
 testRunner.And("Contact kovuc8@sitecore.net has PhoneNumber equals +38(067)3333333", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 197
 testRunner.And("Contact kovuc8@sitecore.net has SMTP emails equals kovuc8@sitecore.net", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                        "\"0\"",
                        "\"1\""});
            table34.AddRow(new string[] {
                        "Swiming",
                        "Skiing"});
#line 198
 testRunner.And("Contact collection Tags.Interests.Values section for kovuc8@sitecore.net consist " +
                    "of", ((string)(null)), table34, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Account_Save user details in xDB_UC9_Update system section in xDB")]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC9_Update system section in xDB")]
        [Xunit.TraitAttribute("Category", "NeedUpdateStepWithRemovingDataFromAnalytic")]
        public virtual void Account_SaveUserDetailsInXDB_UC9_UpdateSystemSectionInXDB()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC9_Update system section in xDB", new string[] {
                        "NeedUpdateStepWithRemovingDataFromAnalytic"});
#line 204
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table35.AddRow(new string[] {
                        "kovuc9@sitecore.net",
                        "k",
                        "k"});
#line 205
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table35, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table36.AddRow(new string[] {
                        "kovuc9@sitecore.net",
                        "k"});
#line 208
 testRunner.And("User was Login to Habitat", ((string)(null)), table36, "And ");
#line 211
 testRunner.When("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 212
 testRunner.Then("Contact kovuc9@sitecore.net has visit count 2 and value 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Account_Save user details in xDB_UC10_Empty Interests value")]
        [Xunit.TraitAttribute("FeatureTitle", "Save user details in xDB")]
        [Xunit.TraitAttribute("Description", "Account_Save user details in xDB_UC10_Empty Interests value")]
        [Xunit.TraitAttribute("Category", "NeedUpdateStepWithRemovingDataFromAnalytic")]
        public virtual void Account_SaveUserDetailsInXDB_UC10_EmptyInterestsValue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Save user details in xDB_UC10_Empty Interests value", new string[] {
                        "NeedUpdateStepWithRemovingDataFromAnalytic"});
#line 218
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table37.AddRow(new string[] {
                        "kovuc10@sitecore.net",
                        "k",
                        "k"});
#line 219
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table37, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table38.AddRow(new string[] {
                        "kovuc10@sitecore.net",
                        "k"});
#line 222
 testRunner.And("User was Login to Habitat", ((string)(null)), table38, "And ");
#line 225
 testRunner.And("Edit profile page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 226
 testRunner.When("User selects Skiing from Interests drop-down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 227
 testRunner.And("User clicks Update button on Edit User Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 228
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 229
 testRunner.And("Edit profile page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 230
 testRunner.And("User selects empty from Interests drop-down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 231
 testRunner.And("User clicks Update button on Edit User Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 232
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table39 = new TechTalk.SpecFlow.Table(new string[] {
                        "\"0\"",
                        "\"1\""});
            table39.AddRow(new string[] {
                        "Swiming",
                        "@empty"});
#line 233
 testRunner.Then("Contact collection Tags.Interests.Values section for kovuc10@sitecore.net consist" +
                    " of", ((string)(null)), table39, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SaveUserDetailsInXDBFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SaveUserDetailsInXDBFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
