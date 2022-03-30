using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_collection_Task
{
    internal class Apple
    {
        public string Vitamin;
        public Apple(string vitamin)
        {
            Vitamin = vitamin;


        }
        public override string ToString()
        {
            return $"Vitamin:{Vitamin}";
        }
    }
}
