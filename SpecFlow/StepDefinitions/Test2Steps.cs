using SpecFlowTest.Other;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public class Test2Steps
    {
        [When(@"I run Test two")]
        public void WhenIRunTestTwo()
        {
            FeatureContext.Current["FeatureContext"] = "FeatureContext_2";
            Console.WriteLine(Support.constant + " 2");
            System.Threading.Thread.Sleep(5000);
            Support.constant = "new2";
            Console.WriteLine(Support.constant + " 2");
            Console.WriteLine(FeatureContext.Current["FeatureContext"]);
        }
    }
}
