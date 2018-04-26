using SpecFlowTest.Other;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public class Test1Steps
    {
        [When(@"I run Test one")]
        public void WhenIRunTestOne()
        {
            Console.WriteLine(Support.constant + " 1");
            System.Threading.Thread.Sleep(7000);
            Console.WriteLine(Support.constant + " 1");
        }
    }
}
