using Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concrete
{
   public class Author:IEntity
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorLastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }

       public string FullName
        {
            get
            {
                return AuthorName + " " + AuthorLastName;
            }
        }
       
    }
}
