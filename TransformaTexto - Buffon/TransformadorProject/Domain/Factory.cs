using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Factory
    {
        private Factory() { }

        public static Function<string, string> getCaixaAltaTransformer()
        {
            return new CaixaAltaAble();
        }
    }
}
