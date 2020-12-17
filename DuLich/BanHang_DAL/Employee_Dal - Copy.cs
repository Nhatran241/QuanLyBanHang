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
    class Customer_Dal
    {
        static BanHangContext context = BanHangContext.GetInstance();

        private static Customer_Dal instance;
        public static Customer_Dal getInstance()
        {
            if (instance == null)
                instance = new Customer_Dal();
            return instance;

        }
        public List<customer> GetAll()
        {
            return context.Customers.ToList();
        }
       
    }
}
