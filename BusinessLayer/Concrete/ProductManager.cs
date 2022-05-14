using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {

        IProductDAL productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            this.productDAL = productDAL;
        }

        public List<Product> TGetList()
        {
            return productDAL.GetList();    
        }

        public List<Product> TProductListExtras()
        {
            return productDAL.ProductsWithExtras();
        }
    }
}
