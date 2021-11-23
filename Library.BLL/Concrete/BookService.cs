using Library.BLL.Abstract;
using Library.BLL.Utilities;
using Library.BLL.ValidationRules.FluentValidation;
using Library.DAL.Abstract;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Concrete
{
    public class BookService : IBookService
    {
        private IBookDal _bookDal;
        public BookService(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        public void Add(Book book)
        {
            ValidationTool.Validate(new BookValidation(), book);
            _bookDal.Add(book);
        }

        public void Delete(Book book)
        {
            try
            {
                _bookDal.Delete(book);
            }
            catch 
            {

                throw new Exception("Silme İşlemi Başarısız!!");
            }
        }

        public List<Book> GetAll()
        {
           return _bookDal.GetAll();
        }

        public List<Book> GetBookByAuthorId(int authorId)
        {
            return _bookDal.GetAll(b => b.AuthorID == authorId).ToList();
        }

        public List<Book> GetBookByBookName(string bookname)
        {
            return _bookDal.GetAll(b => b.BookName.ToLower().Contains(bookname.ToLower())).ToList();
        }

        public List<Book> GetBookByCategoryID(int categoryId)
        {
            return _bookDal.GetAll(b => b.CategoryID == categoryId).ToList();
        }

        public void Update(Book book)
        {
            ValidationTool.Validate(new BookValidation(), book);
            _bookDal.Update(book);
        }
    }
}
