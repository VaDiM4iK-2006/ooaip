﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.HighTech
{
    public class HighTechChair : IChair
    {
        public string Result()
        {
            return "high-tech chair";
        }
    }
}
