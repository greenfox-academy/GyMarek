﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_FoxClass
{
    public class Fox
    {
        public string name;
        public string type;
        public string color;

        public Fox(string name, string type, string color)
        {
            this.name = name;
            this.type = type;
            this.color = color;
        }

        public override string ToString()
        {
            return $"{name},{type},{color}";
        }        
    }
}
