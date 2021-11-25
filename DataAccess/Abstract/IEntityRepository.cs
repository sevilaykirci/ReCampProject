using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    // referans tip olabilir
    //IENtitiy : ientity olabilir eya ientity implemente edebilen bir nesne olabilir.
    //new : newlenebilir olmali.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {

        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        void Update(T entity);
        void Add(T entity);
        void Delete(T entity);

    }
}
