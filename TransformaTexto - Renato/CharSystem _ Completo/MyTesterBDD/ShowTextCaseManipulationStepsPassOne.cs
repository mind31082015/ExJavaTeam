using System;
using TechTalk.SpecFlow;
using MyTesterBDD;
using CharSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTesterBDD
{
    [Binding]
    public class ShowTextCaseManipulationStepsPassOne
    {
        private object assert;

        [Given(@"I have get a text")]
        public void GivenIHaveGetAText()
        {
            String Text = "Renato De Moura Santos";
            TestHelper.Bag.Text = Text;
            
        }
        
        [Given(@"I should pass the text to transformation upper case")]
        public void GivenIShouldPassTheTextToTransformation()
        {
            String newText;
            String oldText = TestHelper.Bag.Text;
            CharTransformerUpper ct = new CharTransformerUpper();
            newText = ct.Transform(oldText);
            TestHelper.Bag.Result = newText;
        }
        
        [Then(@"the result should show the text in upper case")]
        public void ThenTheResultShouldShowTheTextInUpperCase()
        {
            Assert.Equals(TestHelper.Bag.Result, TestHelper.Bag.Text);
        }

        [Given(@"I should pass the text to transformation lower case")]
        public void GivenIShouldPassTheTextToTransformationLowerCase()
        {
            String newText;
            String oldText = TestHelper.Bag.Text;
            CharTransformerLowerCase ct = new CharTransformerLowerCase();
            newText = ct.Transform(oldText);
            TestHelper.Bag.Result = newText;
        }

        [Then(@"the result should show the text in lower case")]
        public void ThenTheResultShouldShowTheTextInLowerCase()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I should pass the text to reverse char")]
        public void GivenIShouldPassTheTextToReverseChar()
        {
            String newText;
            String oldText = TestHelper.Bag.Text;
            CharTransformerReverse ct = new CharTransformerReverse();
            newText = ct.Transform(oldText);
            TestHelper.Bag.Result = newText;
        }

        [Then(@"the result should show the text to reverse char")]
        public void ThenTheResultShouldShowTheTextToReverseChar()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
