using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//fitre gönderir fakat filtre olmasa da olur
        T Get(Expression<Func<T,bool>> filter);  // linq ile bir filtre gönderir (p=> p.ProduncId==5) gibi
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
