﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Class_Schedule
{
    class NormalClass : ClassBase
    {
        public bool[,] IsClassHave = 
            new bool[5, 4] { 
                { false, false, false, false }, 
                { false, false, false, false }, 
                { false, false, false, false }, 
                { false, false, false, false }, 
                { false, false, false, false }
            };

    }
}
