using FluentValidation;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.ValidationRules.FluentValidation
{
   public class CategoryValidation:AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage("Kategori adı boş geçilemez");
            RuleFor(c => c.CategoryName).Length(3,20).WithMessage("Kategori isim uzunluğu 3 ve 20 karakter arasında olabilir");
        }
    }
}
