﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Modern
{
    public class ModernTable : ITable
    {
        public ITable Clone()
        {
            return new ModernTable();
        }
    }
}
