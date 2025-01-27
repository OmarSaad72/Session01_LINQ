using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Refree
    {
        //Subscriber ==> Like Child
        public Refree(string? name)
        {
            Name = name;
        }

        public string? Name { get; set; }

        public override string ToString()
        {
            return $"RefreeName: {Name}";
        }
        public void Look(object? sender, LocatinEventArgs location)
        { 
            Ball? ball= sender as Ball;
            Console.WriteLine($"{this} Look At >>> {location.Location} & {ball}"); //this refer to object(ToString)
        }
    }
}

