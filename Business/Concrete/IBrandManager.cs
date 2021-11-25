using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class IBrandManager : IBrandService
    {
        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetCarsByBrandId()
        {
            throw new NotImplementedException();
        }

        List<Brand> IBrandService.GetCarsByBrandId()
        {
            throw new NotImplementedException();
        }
    }
}
