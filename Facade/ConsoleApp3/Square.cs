﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    public class Square
    {
        private static readonly Random random = new Random();
        public List<int> Generate(int count)
        {
            return Enumerable.Range(0, count)
              .Select(_ => random.Next(1, 6))
              .ToList();
        }
    }
}
