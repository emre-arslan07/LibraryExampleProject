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
    public class AuthorService : IAuthorService
    {
        IAuthorDal _authorDal;
        public AuthorService(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }
        public void Add(Author author)
        {
            ValidationTool.Validate(new AuthorValidation(), author);
            _authorDal.Add(author);
        }

        public void Delete(Author author)
        {
            try
            {
                _authorDal.Delete(author);
            }
            catch
            {

                throw new Exception("Silme İşlemi Başarısız");
            }
        }

        public List<Author> GetAll()
        {
            return _authorDal.GetAll();
        }

        public List<Author> GetBookByAuthorName(string authorname)
        {
            return _authorDal.GetAll(a => a.AuthorName.ToLower().Contains(authorname.ToLower())).ToList();
        }

        public void Update(Author author)
        {
            ValidationTool.Validate(new AuthorValidation(), author);
            _authorDal.Update(author);
        }
    }
}
