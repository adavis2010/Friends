using System;
using System.Collections.Generic;

namespace Friends {
    class Program {
        static void Main(string[] args) {



            var friends = new List<Friends>();

            var Jess = new Friends { Name = "Jess", Email = "mynameisJess@yahoo.com", BFF = true };
            friends.Add(Jess);

            var Patty = new Friends { Name = "Patty", Email = "Patty@yahoo.com", BFF = true };
            friends.Add(Patty);


            foreach (var friend in friends) {
                Console.WriteLine($"{friend.Name}");


            }
        }
    }
}
