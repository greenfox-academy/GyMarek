﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Garden
{
    public class Tree : Plant
    {
        public Tree(string color)
        {
            this.wateringTreshold = 10;
            this.waterPull = 0.4;
            this.currentWaterAmount = 0;
            this.type = "Tree";
            this.color = color;
        }
        public override void Water(double waterAmount)
        {
            currentWaterAmount += waterAmount * waterPull;
        }
    }
}
