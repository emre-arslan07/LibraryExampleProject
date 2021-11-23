using FluentValidation;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.ValidationRules.FluentValidation
{
   public class BookValidation:AbstractValidator<Book>
    {
        public BookValidation()
        {
            RuleFor(b => b.BookName).NotEmpty().WithMessage("Kitap adı boş geçilemez");
            RuleFor(b => b.BookName).Length(3,50).WithMessage("Kitap adı uzunluğu en fazla 50 karakter olabilir");            
            RuleFor(b => b.ShelfNumber).NotEmpty().WithMessage("Raf numarası boş geçilemez");
            RuleFor(b => b.ShelfNumber).Length(2,5).WithMessage("Raf numarası en fazla 5 karakter olabilir");
        }
    }
}
