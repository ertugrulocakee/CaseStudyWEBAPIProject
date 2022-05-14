using BusinessLayer.Concrete;
using DataAccessLayer.EF;
using EntityLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        ProductManager productManager = new ProductManager(new EFProductDAL());

        [HttpGet]
        public  IActionResult GetProducts()
        {

            return Ok(productManager.TGetList());

        }

            
            
    }

}








