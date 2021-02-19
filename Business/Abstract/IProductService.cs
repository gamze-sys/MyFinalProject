using System;
using System.Collections.Generic;
using System.Text;

using Entities.Concrete;

namespace Business.Abstract
{
    //is katmaninda kullanacagimiz servis operasyonu
   public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetByUnitPrice(decimal min,decimal max);

    }
}
