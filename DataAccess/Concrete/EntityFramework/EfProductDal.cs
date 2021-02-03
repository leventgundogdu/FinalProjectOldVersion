using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        //ORM: veri tabani ve kodlar arasinda bir iliski kurup veri tabani ile kodlari baglama islemine denir.
        //NuGet: Nuget bir paket yonetim aracidir.

        public void Add(Product entity)
        {
            //using'de calisanlar isi bitince cope atilir.
            //IDisposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())    //Kisayol : "using" tab tab
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();


            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())    //Kisayol : "using" tab tab
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();


            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null 
                    ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())    //Kisayol : "using" tab tab
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();


            }
        }

    }
}
