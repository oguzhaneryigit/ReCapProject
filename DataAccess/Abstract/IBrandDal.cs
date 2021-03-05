using Core.Data_Access;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBrandDal : IEntityRepository<Brand>
    {
        // IEntityRepository kullandıktan sonra burdaki metotları kaldırdık çünkü interface interface i inherit etti --implemente etmedi
        //
    }
}
