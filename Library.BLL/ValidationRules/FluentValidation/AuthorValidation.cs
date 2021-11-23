using FluentValidation;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.ValidationRules.FluentValidation
{
   public class AuthorValidation:AbstractValidator<Author>
    {
        public AuthorValidation()
        {
            RuleFor(a => a.AuthorName).NotEmpty().WithMessage("Yazar adı boş geçilemez");
            RuleFor(a => a.AuthorLastName).NotEmpty().WithMessage("Yazar soyadı boş geçilemez");
            RuleFor(a => a.BirthDate).NotEmpty();
            //RuleFor(a => a.Email).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(a => a.Email).EmailAddress().WithMessage("Uygun bir mail adresi giriniz");
        }
    }
}
