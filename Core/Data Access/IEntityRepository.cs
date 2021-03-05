using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Data_Access
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //generic constraint -> T yi kısıtlama 
        // class  : referans tipii sağlar --  int string olmasını engeller
        // IEntity: Ientity veya onu inherit eden bir nesne sadecce veritabanı nesnesi sağlar
        // new()  : newlenebilir olmalı
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//fitre gönderir fakat filtre olmasa da olur
        T Get(Expression<Func<T, bool>> filter);  // linq ile bir filtre gönderir (p=> p.ProduncId==5) gibi
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
