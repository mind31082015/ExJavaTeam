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
        public void GivenIShouldPassTheTextToTransformationUpperCase()
        {
            String newText;
            String oldText = TestHelper.Bag.Text;
            CharTransformer ct = new CharTransformer();
            newText = ct.Transform(oldText);
            TestHelper.Bag.Result = newText;
        }
        
        [Then(@"the result should show the text in upper case")]
        public void ThenTheResultShouldShowTheTextInUpperCase()
        {
            Assert.Equals(TestHelper.Bag.Result, TestHelper.Bag.Text);
        }
    }
}
