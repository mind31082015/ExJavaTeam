using System.Dynamic;

namespace TransformaTexto.Testes
{
    public static class TestHelper
    {
        public static dynamic Bag { get; private set; }

        static TestHelper()
        {
            Bag = new ExpandoObject();
        }
    }
}
