using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic constraint
    //class: refereans tip
    //IEntity: IEntity olabilir ya da IEntity implemente eden bir nesne olabilir.
    //new(): new'lenebilir olmali
    public interface IEntityRepository<T> where T: class,IEntity,new()    //?
    {
        
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);  // Tipe ozel sorgu olusturmak icin yaptik bunu.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}
