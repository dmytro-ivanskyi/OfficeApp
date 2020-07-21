using System;
using System.Collections.Generic;
using System.Linq;
using OfficeApp.Data;
using OfficeApp.Domain;

namespace OfficeApp
{
    class Program
    {
        private static OfficeContext context = new OfficeContext();
        private static void Main()
        {
            context.Database.EnsureCreated();
            //GetUsers();
            var user = new User
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 21,
                Office = new Office { Name = "Kharkiv" },
                Tasks = new List<Task>() { new Task { Description = "Create database" } }
            };
            AddUser(user);
            GetUsers();
            Console.Write("Press any key...");
            Console.ReadKey();
        }

        private static void AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        private static void GetUsers()
        {
            var users = context.Users.ToList();
            Console.WriteLine($"{users.Count} users");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName} is {user.Age}");
            }
        }
    }
}
