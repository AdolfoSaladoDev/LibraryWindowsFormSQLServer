using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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

            return context.Books.ToList();
        }

        public static bool AddBook(Books book)
        {
            var context = new LibraryEntities();

            context.Books.Add(book);

            context.Books.Add(book);


            
            context.SaveChanges();

            return true;
        }

        public static bool DeleteBook(Books book)
        {

            
            var context = new LibraryEntities();

            var entry = context.Entry(book);

            if (entry.State == EntityState.Detached)
            {
                context.Books.Attach(book);

            }

            context.Books.Remove(book);

            context.SaveChanges();
         
            return true;

        }

        public static bool ModifyBook(Books book)
        {
            var context = new LibraryEntities();
            context.Books.AddOrUpdate(book);

            context.SaveChanges();
            return true;
        }
    }
}
