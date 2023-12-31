﻿using Strategy_Pattern.Business.Models;
using Strategy_Pattern.Business.Strategies;
using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order("Sweden", "Sweden");
            
            

            order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m, ItemType.Literature), 1);
            order.LineItems.Add(new Item("CONSULTING", "Building a website", 100m, ItemType.Service), 1);

            Console.WriteLine(order.GetTax());
        }
    }
}
