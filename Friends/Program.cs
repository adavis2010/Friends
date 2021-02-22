using System;
using System.Collections.Generic;

namespace FriendDictionary {
    class Program {
        static void Main(string[] args) {


            var friend = new Dictionary<long, Friend>();
           


            var Jess = new Friend {Name = "Jess", Email = "mynameisJess@yahoo.com", BFF = true, Phone = 5134445555};
            friend.Add(Jess.Phone,Jess);
            

            var Patty = new Friend {Name = "Patty", Email = "Patty@yahoo.com", BFF = true, Phone = 5133335555 };
            friend.Add(Patty.Phone, Patty);
            

            var Robert  = new Friend {Name = "Robert", Email = "Robert@yahoo.com", BFF = true, Phone = 5137770000 };
            friend.Add(Robert.Phone,Robert);


            foreach (var phone in friend.Keys) {
                var friends = friend[phone];
                Console.WriteLine($"{friends.Phone} : {friends.Name}");


            }
        }
    }
}
