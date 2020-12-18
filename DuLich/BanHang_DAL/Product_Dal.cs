using DuLich.BanHang_Entity;
using DuLich.BUS;
using DuLich.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace DuLich.BanHang_Dal
{
    class Product_Dal
    {
        static BanHangContext context = BanHangContext.GetInstance();
        private static Product_Dal instance;
        public static Product_Dal getInstance()
        {
            if (instance == null)
                instance = new Product_Dal();
            return instance;

        }

        public Task Delete(product product)
        {
            context.Products.Remove(product);
            return context.SaveChangesAsync();
        }

        public List<product> GetAll()
        {
            return context.Products.ToList();
        }
        public Task AddOrUpdate(product product)
        {
            context.Products.AddOrUpdate(product);
            return context.SaveChangesAsync();
        }

    }
}
