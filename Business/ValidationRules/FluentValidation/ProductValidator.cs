using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        //FluentValidation nasil yapilir:
        public ProductValidator() //constructor'a yazilir.
        {
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p =>p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Urunler A harfi ile baslamalidir.");
            //Cross Cutting Concerns : Kodu ikiye kesenler deniyor. Log, Cache, Transaction, Authorization,...

        }

        private bool StartWithA(string arg) //arg senin parametrendir.
        {
            return arg.StartsWith("A"); //A ile basliyorsa true doner eger baslamiyorsa patlar :)
        }
    }
}
