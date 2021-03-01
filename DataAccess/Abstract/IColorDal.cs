using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IColorDal:IEntityRepository<Color>
    {
        // IEntityRepository kullandıktan sonra burdaki metotları kaldırdık çünkü interface interface i inherit etti --implemente etmedi
        //
    }
}
