using Library.DAL.Abstract;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Concrete.EntityFramework
{
   public class EFAuthorDal:EFEntityRepositoryBase<Author,LibraryContextDb>,IAuthorDal
    {
    }
}
