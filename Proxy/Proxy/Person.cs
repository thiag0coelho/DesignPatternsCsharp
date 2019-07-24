using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class Person
    {
        public int Age { get; set; }

        public Person(int age)
        {
            Age = age;
        }

        public string Drink()
        {
            return "drinking";
        }

        public string Drive()
        {
            return "driving";
        }

        public string DrinkAndDrive()
        {
            return "driving while drunk";
        }
    }
}
