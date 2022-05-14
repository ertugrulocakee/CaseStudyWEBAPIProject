using BusinessLayer.Concrete;
using DataAccessLayer.EF;
using EntityLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using X.PagedList;

namespace PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
      
        public async Task<IActionResult> Index(int page = 1)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44314/api/Product");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Product>>(jsonString);

            return View(values.ToPagedList(page, 12));
        }
    }
}
