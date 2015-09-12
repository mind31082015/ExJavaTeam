using Domain;
using System;
using System.Dynamic;
using TechTalk.SpecFlow;

namespace TransformadorProject
{
    [Binding]
    public class MyTestSteps
    {
        private static dynamic Bag = new ExpandoObject();

        public MyTestSteps()
        {
        }
        [Given(@"A String transformer")]
        public void GivenAStringTransformer()
        {
            Bag.Transformer = Factory.getCaixaAltaTransformer();
        }

        [Given(@"A string (\w+)")]
        public void GivenAString(string str)
        {
            Bag.Trasformeer = str;
        }

        [When(@"I press toCapsLock")]
        public void WhenIPressToCapsLock()
        {
            Function<string, string> transformer = Bag.Transformer;
            String transformeer = Bag.Transformeer;
            Bag.Transformed = transformer.apply(transformeer);
        }

        [Then(@"A caps lock string should be returned")]
        public string ThenACapsLockStringShouldBeReturned()
        {
            return Bag.Transformed;
        }
    }
}
