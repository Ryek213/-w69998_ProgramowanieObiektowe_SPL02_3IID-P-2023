using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.Interfaces;

namespace Lab5.Models
{
    internal class Person(string firstName, string lastName, int age) : IEntity<long>, IDateOfCreation
    {
        static long idCounter = 1;
        public long Id { get; set; } = idCounter++;
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public int Age { get; set; } = age;
        public List<Book> BorrowedBooks { get; set; } = [];
        public DateTime DateOfCreation { get; set; } = DateTime.Now;
    }
}
