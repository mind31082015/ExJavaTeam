using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharSystem.Models
{
    public class CharTransformerReverse:ICharTransformer
    {
        public String Transform(String text)
        {
            return new string(text.Reverse().ToArray());
        }
    }
}