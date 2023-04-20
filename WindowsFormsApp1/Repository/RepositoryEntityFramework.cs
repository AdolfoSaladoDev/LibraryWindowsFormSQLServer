using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repository
{
    internal class RepositoryEntityFramework
    {



        public static List<Books> GetBooks()
        {
            var context = new LibraryEntities();

            return context.Books.ToList<Books>();
        }

        public static bool AddBook(Books book)
        {
            var context = new LibraryEntities();

            context.Books.Add(book);

            return true;
        }
    }
}
