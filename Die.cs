﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
    class Die
    {
        private int numberOfSides;
        /*zadatak 3.*/
        private RandomGenerator randomGenerator;
        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = RandomGenerator.GetInstance();
        }
        public int Roll()
        {
            return this.randomGenerator.NextInt(1, numberOfSides + 1);

        }
        public int NumberOfSides
        {
            get { return this.numberOfSides; }
        }

    }
}
