using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Person : IEntity<int>, IDateOfCreation
    {
        static int idCounter = 1;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Person()
        {
            Id = idCounter++;
        }
    }
}
