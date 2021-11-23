using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Abstract
{
   public interface IAuthorService
    {
        List<Author> GetBookByAuthorName(string authorname);
        List<Author> GetAll();
        void Add(Author author);
        void Update(Author author);
        void Delete(Author author);
    }
}
