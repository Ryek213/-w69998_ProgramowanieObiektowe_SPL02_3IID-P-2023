using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.Models;

namespace Lab5.Interfaces
{
    internal interface IPersonRepository : IBaseRepository<Person, long>
    {
        List<Book> GetBorrowedBooks();
        void BorrowBooks(long id, Book book);
    }
}
