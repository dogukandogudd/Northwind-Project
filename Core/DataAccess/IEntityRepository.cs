using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

    //***Core katmanı diğer katmnları referans almaz
namespace Core.DataAccess
{
    //Generic Constraint
    //class : refereans tip olabilir
    //IEntity : IEntity olabilir veya

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter=null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
