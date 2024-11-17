﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Duck
{
    public class WhiteDuck : IDuck
    {
        public string Quack()
        {
            return "quack!!!";
        }
    }
}
