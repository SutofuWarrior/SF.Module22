using System;
using System.Collections.Generic;
using System.Linq;

namespace SF.Module22
{
    class Program
    {
        static void Main()
        {
            var phoneBook = new List<Contact>
            {
                new Contact("Игорь", 79990000001, "igor@example.com", 25),
                new Contact("Сергей", 79990000010, "serge@example.com", 32),
                new Contact("Анатолий", 79990000011, "anatoly@example.com", 27),
                new Contact("Валерий", 79990000012, "valera@example.com", 23),
                new Contact("Сергей", 799900000013, "serg@example.com", 30),
                new Contact("Иннокентий", 799900000013, "innokentii@example.com", 21) 
            };

            foreach (var entry in phoneBook.OrderBy(p => p.Name).ThenBy(p => p.Age))
                Console.WriteLine($"{entry.Name}, {entry.Age}: {entry.PhoneNumber}");

            Console.ReadKey();
        }

        public class Contact
        {
            public Contact(string name, long phoneNumber, String email, sbyte age)
            {
                Name = name;
                PhoneNumber = phoneNumber;
                Email = email;
                Age = age;
            }

            public String Name { get; }
            public long PhoneNumber { get; }
            public String Email { get; }
            public sbyte Age { get; }
        }
    }
}
