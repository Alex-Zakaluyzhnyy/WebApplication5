﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Product
    {
        public int Id { get; set; } //Идентификатор продукта

        public string Name { get; set; } //Название продукта

        public string Description { get; set; } //Описание продукта

        public double Price { get; set; } //Цена продукта
    }
}