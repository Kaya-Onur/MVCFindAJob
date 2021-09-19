using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AdminValidatior:AbstractValidator<Admin>
    {
        public AdminValidatior()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("İsim alanını boş geçemezsiniz");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyisim alanını boş geçemezsiniz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanını boş geçemezsiniz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanını boş geçemezsiniz");
        }
    }
}
