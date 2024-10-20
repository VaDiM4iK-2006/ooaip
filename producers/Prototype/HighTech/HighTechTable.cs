﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.HighTech
{
    public class HighTechTable : ITable
    {
        public IPrototype Clone()
        {
            return new HighTechTable();
        }
    }
}