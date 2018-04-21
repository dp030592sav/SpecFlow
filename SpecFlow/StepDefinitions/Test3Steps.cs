using System;
using SpecFlowTest.Other;
using TechTalk.SpecFlow;

namespace SpecFlow.StepDefinitions
{
    [Binding]
    public class Test3Steps
    {
        [When(@"I run Test three")]
        public void WhenIRunTestThree()
        {
            FeatureContext.Current["FeatureContext"] = "FeatureContext_3";
            Console.WriteLine(Support.constant + " 3");
            System.Threading.Thread.Sleep(3000);
            Support.constant = "new3";
            Console.WriteLine(Support.constant + " 3");
            Console.WriteLine(FeatureContext.Current["FeatureContext"]);
        }
    }
}
