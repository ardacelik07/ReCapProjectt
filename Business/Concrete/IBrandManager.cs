using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class IBrandManager : IBrandService
    {
       IBrandDal _IBrandDal;
        public IBrandManager(IBrandDal IBrandDal)
        {
            _IBrandDal = IBrandDal;
        }


        public List<Brand> GetAll()
        {
            return _IBrandDal.GetAll();

        }
    }
}
