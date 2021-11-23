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
    public class CategoryService : ICategoryService
    {
       private ICategoryDal _categoryDal;
        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            ValidationTool.Validate(new CategoryValidation(), category);
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            try
            {
                _categoryDal.Delete(category);
            }
            catch 
            {

                throw new Exception("Silme İşlemi Başarısız");
            }
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Update(Category category)
        {
            ValidationTool.Validate(new CategoryValidation(), category);
            _categoryDal.Update(category);
        }
    }
}
