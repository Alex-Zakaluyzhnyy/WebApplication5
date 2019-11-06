using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class ValuesController : ApiController
    {
        ProductContext db = new ProductContext();

        public IEnumerable<Product> GetAllProducts()
        {
            return db.Products;
        }


        public IHttpActionResult Get(int id)
        {
            Product product = db.Products.FirstOrDefault(elem => elem.Id == id);
            if (product == null)
            {
                return NotFound(); ;
            }
            else
            {
                return Ok(product);
            }
        }

    }
}
