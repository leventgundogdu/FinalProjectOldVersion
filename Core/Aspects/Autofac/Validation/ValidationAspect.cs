using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using FluentValidation;
using System;
using System.Linq;
using static Core.Utilities.Interceptors.Class1;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            //Defensive Coding
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir dogrulama sinifi degil!");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType); //invocation = metod !!!
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }

    }
}
