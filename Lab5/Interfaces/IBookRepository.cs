using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.Models;

namespace Lab5.Interfaces
{
    internal interface IBookRepository : IBaseRepository<Book, int>
    {
        List<Book> GetBooksByAuthor(string author);
        List<Book> GetBooksByYearOfPublication(int year);
    }
}
