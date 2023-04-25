using ConsoleApp1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BookContext : DbContext
    {
        DbSet<Bookparams> Bookparams(get;set;)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Booksale;Trusted_Connection=True");
        }
    }
    
    public class Bookparams
    {
        public string BookName { get; set; }
        public string Auothors { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public int Pages { get; set; }
        public string Nesriyyat { get; set; }
        public string Genres { get; set; }


    }
}

   


    

