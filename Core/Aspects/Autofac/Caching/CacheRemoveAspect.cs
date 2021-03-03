using Castle.DynamicProxy;
using Core.Caching;
using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;
using static Core.Utilities.Interceptors.Class1;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheRemoveAspect : MethodInterception //pattern'a gore silme islemi yapar.
    {
        private string _pattern;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}
