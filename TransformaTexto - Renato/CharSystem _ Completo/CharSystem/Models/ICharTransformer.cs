using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharSystem.Models
{
    public interface ICharTransformer
    {
        String Transform(String text);
    }
}