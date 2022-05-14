using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EF
{
    public class EFProductDAL : GenericRepository<Product>, IProductDAL
    {
         public  List<Product> ProductsWithExtras()
         {
          

                using (var c = new NorthwindContext())
                {


                    var values =   c.Products.Include(x => x.Supplier)
                                             .Include(x => x.Category)
                                             .Include(x => x.OrderDetails)
                                             .ToList();

                      return values;
                }
            
         }                                                   
    }
}
