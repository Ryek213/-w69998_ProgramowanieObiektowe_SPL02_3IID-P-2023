using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.Interfaces;

namespace Lab5.Models
{
    internal class Book(string title, string author, DateTime dateOfPublication) : IEntity<int>, IDateOfCreation
    {
        static int idCounter = 1;
        public int Id { get; set; } = idCounter++;
        public string Title { get; set; } = title;
        public string Author { get; set; } = author;
        public DateTime DateOfPublication { get; set; } = dateOfPublication;
        public DateTime DateOfCreation { get; set; } = DateTime.Now;
    }
}
