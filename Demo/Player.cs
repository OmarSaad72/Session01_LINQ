using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //Subscriber ==> Like Child
    internal class Player
    {
        public Player(string? name, string? team)
        {
            Name = name;
            Team = team;
        }

        public string? Name { get; set; }
        public string? Team { get; set; }

        public override string ToString()
        {
            return $"PlayerName: {Name} & Team: {Team}";
        }

        public void Run(object? sender, LocatinEventArgs location)
        {
            Ball? ball= sender as Ball;
            Console.WriteLine($"{this} Run >>> {location.Location} & {ball}"); //this refer to object(ToString)
        }
    }

}
