﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_collection_Task
{
    internal class Pineapple
    {
        public string Vitamin;
        public Pineapple(string vitamin)
        {
            Vitamin = vitamin;


        }
        public override string ToString()
        {
            return $"Vitamin:{Vitamin}";
        }
    }
}
