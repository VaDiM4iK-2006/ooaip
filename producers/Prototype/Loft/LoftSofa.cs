﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Loft
{
    public class LoftSofa : ISofa
    {
        public IPrototype Clone()
        {
            return new LoftSofa();
        }
    }
}