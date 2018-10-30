using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UseAjaxWithASPNETCoreMVC.Models;

namespace UseAjaxWithASPNETCoreMVC.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("demo1")]
        public IActionResult Demo1()
        {
            return new JsonResult("Demo 1");
        }

        [Route("demo2/{fullName}")]
        public IActionResult Demo2(string fullName)
        {
            return new JsonResult("Hello " + fullName);
        }

        [Route("demo3")]
        public IActionResult Demo3()
        {
            var product = new Product() { Id = "p01", Name = "name 1", Price = 4 };
            return new JsonResult(product);
        }

        [Route("demo4")]
        public IActionResult Demo4()
        {
            var products = new List<Product>() {
                new Product() { Id = "p01", Name = "name 1", Price = 4 },
                new Product() { Id = "p02", Name = "name 2", Price = 2 },
                new Product() { Id = "p03", Name = "name 3", Price = 6 }
            };
            return new JsonResult(products);
        }

    }
}