using Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concrete
{
   public class Book:IEntity
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string ShelfNumber { get; set; }
        public int CategoryID { get; set; }
        public int AuthorID { get; set; }
    }
}
