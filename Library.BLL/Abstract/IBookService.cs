using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Abstract
{
   public interface IBookService
    {
        List<Book> GetBookByCategoryID(int categoryId);
        List<Book> GetBookByBookName(string bookname);
        List<Book> GetBookByAuthorId(int authorId);
        List<Book> GetAll();
        void Add(Book book);
        void Delete(Book book);
        void Update(Book book);
    }
}
