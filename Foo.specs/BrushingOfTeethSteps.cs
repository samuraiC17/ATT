using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Foo.specs
{
    [Binding]
    public class BrushingOfTeethSteps
    {
        [Given]
        public void Given_there_is_GRAMS_gram_of_BRAND_X_toothpaste_on_the_brush(int grams, string brand)
        {
            Assert.Pass();
            ScenarioContext.Current.Pending();
        }

        [Given]
        public void Given_there_is_GRAMS_gram_of_toothpaste_on_the_brush(int grams)
        {
            Assert.Pass();
            ScenarioContext.Current.Pending();
        }
        [Given]
        public void Given_I_have_the_following_tools(Table table)
        {
            var firstToolName = table.Rows[0][0];
            var firstToolQuality = table.Rows[0][1];

            var secondToolName = table.Rows[1]["ToolName"];
            var secondToolQuality = table.Rows[1]["ToolQuality"];

            var isToolColorColumnSpecified = table.ContainsColumn("Color");

            Assert.Pass();
            ScenarioContext.Current.Pending();
        }

        [Given]
        public void Given_the_mouth_is_open()
        {
            Assert.Pass();
            ScenarioContext.Current.Pending();
        }

        [When]
        public void When_the_back_teeth_are_brushed()
        {
            Assert.Pass();
            ScenarioContext.Current.Pending();
        }

        [When]
        public void When_the_front_teeth_are_brushed()
        {
            Assert.Pass();
            ScenarioContext.Current.Pending();
        }

        [Then]
        public void Then_the_teeth_look_clean()
        {
            Assert.Pass();
            ScenarioContext.Current.Pending();
        }

        [Then]
        public void Then_the_mouth_feels_fresh()
        {
            Assert.Pass();
            ScenarioContext.Current.Pending();
        }

        [Then]
        public void Then_the_braces_aren_t_damaged()
        {
            Assert.Pass();
            ScenarioContext.Current.Pending();
        }
    }
}
