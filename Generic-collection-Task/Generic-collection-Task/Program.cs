using System;

namespace Generic_collection_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lemon lemon = new Lemon("Vitamin-A");
            Pineapple lemonApple = new Pineapple("Vitamin-E");
            Apple apple = new Apple("Vitamin-D");

            
            BasketList<Lemon> basketList = new BasketList<Lemon>();
            basketList.AddItem(lemon);
            foreach (var item in basketList.GetArray())
            {
                Console.WriteLine("LemanList:" + item.Vitamin);
            }

            BasketList<Pineapple> basketList2 = new BasketList<Pineapple>();
            basketList2.AddItem(lemonApple);
            foreach (var item in basketList2.GetArray())
            {
                Console.WriteLine("PineappleList:"+item.Vitamin);
            }     
            
            BasketList<Apple> basketList3 = new BasketList<Apple>();
            basketList3.AddItem(apple);
            foreach (var item in basketList3.GetArray())
            {
                Console.WriteLine("AppleList:"+item.Vitamin);
            }
        }
    }
}
