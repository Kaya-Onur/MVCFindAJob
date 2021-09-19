using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserValidatior : AbstractValidator<User>
    {
        public UserValidatior()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("İsminizi boş geçemezsiniz");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyisminizi boş geçemezsiniz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanını geçemezsiniz");
        }
    }
}
