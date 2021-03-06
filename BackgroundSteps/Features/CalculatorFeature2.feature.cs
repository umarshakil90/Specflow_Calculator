﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BackgroundSteps.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Calculator remembering the last value")]
    public partial class CalculatorRememberingTheLastValueFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CalculatorFeature2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Calculator remembering the last value", "       In order to prevent mistakes re-entering the last value\r\n       As a frequ" +
                    "ent calculator user\r\n       I want to be remember the sum of the last value ente" +
                    "red", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
#line 6
       testRunner.Given("I have entered 10 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
       testRunner.And("I have also entered 20 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
       testRunner.And("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Remembered value goes into to add")]
        [NUnit.Framework.TestCaseAttribute("3", "35", null)]
        [NUnit.Framework.TestCaseAttribute("0", "30", null)]
        [NUnit.Framework.TestCaseAttribute("-10", "20", null)]
        [NUnit.Framework.TestCaseAttribute("-50", "-20", null)]
        public virtual void RememberedValueGoesIntoToAdd(string number, string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Remembered value goes into to add", null, exampleTags);
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 11
       testRunner.Given(string.Format("I have entered {0} into the calculator", number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
       testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
       testRunner.Then(string.Format("the result should be {0} on the screen", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Remembered value goes into to multiply")]
        public virtual void RememberedValueGoesIntoToMultiply()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Remembered value goes into to multiply", null, ((string[])(null)));
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 23
       testRunner.Given("I have entered 3 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
       testRunner.When("I press multiply", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
       testRunner.Then("the result should be 90 on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Remembered value goes into to divide")]
        public virtual void RememberedValueGoesIntoToDivide()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Remembered value goes into to divide", null, ((string[])(null)));
#line 27
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 28
       testRunner.Given("I have entered 5 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
       testRunner.When("I press divide", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
       testRunner.Then("the result should be 6 on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
