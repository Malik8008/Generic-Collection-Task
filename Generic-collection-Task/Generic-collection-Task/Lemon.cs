﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_collection_Task
{
    internal class Lemon
    {
        public string Vitamin;
        public Lemon(string vitamin)
        {
            Vitamin = vitamin;


        }
        public override string ToString()
        {
            return $"Vitamin:{Vitamin}";
        }
    }
}
