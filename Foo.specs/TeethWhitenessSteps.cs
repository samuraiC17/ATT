using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Foo.specs
{
    [Binding]
    public class TeethWhitenessSteps
    {
        [Given(@"I'm using ""(.*)"" brand toothpaste")]
        public void GivenIMUsingBrandToothpaste(string brand)
        {
            ScenarioContext.Current.Add("brand name", brand);
            Assert.IsNotEmpty(brand);
        }

        [When(@"I brush for (.*) minutes")]
        public void WhenIBrushForMinutes(int mins)
        {
            var brandName = ScenarioContext.Current["brand name"];
            Assert.AreNotEqual(mins,0);
        }

        [Then(@"the teeth look (.*) white")]
        public void ThenTheTeethLookWhite(int percent)
        {
            //ScenarioContext.Current.Pending();
            Assert.AreNotEqual(percent, 0);
        }
    }
}
