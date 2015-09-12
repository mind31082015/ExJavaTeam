﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformaTexto.Services
{
    public class LowerCaseTransformer : ITransformer
    {
        public string Transform(string text)
        {
            return text.ToLower();
        }
    }
}
