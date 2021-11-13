using CORE.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class IEntityFrameworkColorDal : EfEntityRepositoryBase<Color, ReCapProjectcontext>, IColorDal
    {
       
    }
}
