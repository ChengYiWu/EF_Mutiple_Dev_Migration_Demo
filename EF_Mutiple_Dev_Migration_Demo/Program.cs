using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Mutiple_Dev_Migration_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MigrationDBContext db = new MigrationDBContext())
            {
                db.Book.AddRange(new List<Book>()
                {
                   new Book()
                   {
                       Name = "Book1_By_Dev1",
                   },
                   new Book()
                   {
                       Name = "Book2_By_Dev1",
                   }
                });

                db.SaveChanges();
            }
        }
    }
}
