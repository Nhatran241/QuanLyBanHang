﻿using DuLich.BanHang_Entity;
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
    class Employee_Dal
    {
        static BanHangContext context = BanHangContext.GetInstance();

        public static List<employee> GetAll()
        {
            return context.Employees.ToList();
        }
       
    }
}
