using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace ConsoleApp1
{
    internal class Program:Bookparams
    {
        static void Main(string[] args)
        {
        
        }
        public void Remove()
        {
            using (BookContext db = new BookContext())
            {
                db.Database.BookName = Console.WriteLine;
                db.Stock.Where(d => d.Name == "Accounts").First();
                db.Stock.Remove(db.Stock.Where(d => d.Name == "Accounts").First(););
                db.SaveChanges();

                Console.WriteLine("Book {0} ({1}) is Deleted " );
                Console.ReadKey();
            }
        }
    }
}