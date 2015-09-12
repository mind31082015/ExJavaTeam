using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TransformaTexto.Services;
using static TransformaTexto.Testes.TestHelper;

namespace TransformaTexto.Testes
{
    [Binding]
    public class TransformerSteps
    {
        [Given(@"A UppercaseTransformer")]
        public void GivenAUppercaseTransformer()
        {
            var transformer = new UpperCaseTransformer();
            Bag.Transformer = transformer;
        }
        
        [Given(@"I write the text Marcos Paulo")]
        public void GivenIWriteTheTextMarcosPaulo()
        {
            var text = "Marcos Paulo";
            Bag.Text = text;
        }
        
        [When(@"I call Transform")]
        public void WhenICallTransform()
        {
            var transformer = Bag.Transformer as ITransformer;
            var text = Bag.Text;
            var result = transformer.Transform(text);
            Bag.Result = result;
        }
        
        [Then(@"The result is the text MARCOS PAULO")]
        public void ThenTheResultIsTheTextMARCOSPAULO()
        {
            var result = Bag.Result as string;
            Assert.AreEqual(result, "MARCOS PAULO");
        }

        [Given(@"A LowercaseTransformer")]
        public void GivenALowercaseTransformer()
        {
            var transformer = new LowerCaseTransformer();
            Bag.Transformer = transformer;
        }

        [Then(@"The result is the text marcos paulo")]
        public void ThenTheResultIsTheTextMarcosPaulo()
        {
            var result = Bag.Result as string;
            Assert.AreEqual(result, "marcos paulo");
        }

        [Given(@"A ReverseTransformer")]
        public void GivenAReverseTransformer()
        {
            var transformer = new ReverseTransformer();
            Bag.Transformer = transformer;
        }

        [Then(@"The result is the text oluap socraM")]
        public void ThenTheResultIsTheTextOluapSocraM()
        {
            var result = Bag.Result as string;
            Assert.AreEqual(result, "oluaP socraM");
        }

    }
}
