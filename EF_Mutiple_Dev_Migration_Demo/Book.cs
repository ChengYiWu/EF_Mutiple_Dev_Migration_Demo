using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Mutiple_Dev_Migration_Demo
{
    [Table("Book")]
    public partial class Book
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Field2 { get; set; }
    }
}
