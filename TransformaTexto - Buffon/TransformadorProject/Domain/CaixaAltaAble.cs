using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class CaixaAltaAble : Function<string, string>
    {
        string Function<string, string>.apply(string value)
        {
            throw new NotImplementedException();
        }

        string apply(string value)
        {
            return value.ToUpper();
        }
    }
}
