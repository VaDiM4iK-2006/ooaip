﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Modern
{
    public class ModernChair : IChair
    {
        public IChair Clone()
        {
            return new ModernChair();
        }
    }
}
