﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.HighTech
{
    public class HighTechSofa : ISofa
    {
        public string Result()
        {
            return "high-tech sofa";
        }
    }
}
