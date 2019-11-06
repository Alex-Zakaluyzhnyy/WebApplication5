using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Models
{
    public class ProductListModel
    {
        public IEnumerable<Product> Products{ get; set; }
        public SelectList Name { get; set; }
        public SelectList Price { get; set; }
    }
}