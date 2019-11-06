using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class ProductDbInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            context.Products.Add(new Product { Name = "Масло сливочное", Price = 240 });
            context.Products.Add(new Product { Name = "Молоко \"Домик в деревне\"", Description = " 1 литр", Price = 70 });
            context.Products.Add(new Product { Name = "Чипсы \"Lays\"", Description = "Сметана и зелень, 150 гр", Price = 120 });
            base.Seed(context);
        }

    }
}