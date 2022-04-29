﻿namespace Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void Add(int id, string firstName, string lastName)
        {

            Console.WriteLine("Added.");
        }

        public virtual void Update(int id, string firstName, string lastName)
        {
            Console.WriteLine("Updated.");
        }
    }
}