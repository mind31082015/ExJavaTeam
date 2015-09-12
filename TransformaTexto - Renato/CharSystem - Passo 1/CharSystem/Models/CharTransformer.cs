using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharSystem.Models
{
    public class CharTransformer:ICharTransformer
    {
        public string Transform(String text)
        {
            return text.ToUpper();
        }
    }
}