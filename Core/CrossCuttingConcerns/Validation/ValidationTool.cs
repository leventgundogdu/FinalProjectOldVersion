using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public class ValidationTool 
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context); //validator'u kullanarak ilgili sonuca ulas.
            if (!result.IsValid) //Eger sonuc gecerli degilse hata firlat.
            {
                throw new ValidationException(result.Errors);
            }

        }

    }
}
