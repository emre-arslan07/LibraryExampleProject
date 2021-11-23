using Library.BLL.Abstract;
using Library.BLL.Concrete;
using Library.DAL.Abstract;
using Library.DAL.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.DependencyResolver.Ninject
{
   public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IAuthorService>().To<AuthorService>().InSingletonScope();
            Bind<IAuthorDal>().To<EFAuthorDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryService>().InSingletonScope();
            Bind<ICategoryDal>().To<EFCategoryDal>().InSingletonScope();

            Bind<IBookService>().To<BookService>().InSingletonScope();
            Bind<IBookDal>().To<EFBookDal>().InSingletonScope();
        }
    }
}
