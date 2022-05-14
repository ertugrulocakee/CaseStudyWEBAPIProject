using DataAccessLayer.Abstract;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        public List<T> GetList()
        {
            using var c = new NorthwindContext();
            return c.Set<T>().ToList();
        }
    }
}
