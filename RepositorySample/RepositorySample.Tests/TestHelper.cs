using System.Dynamic;

namespace RepositorySample.Tests
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
