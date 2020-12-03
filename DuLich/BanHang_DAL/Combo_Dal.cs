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
    class Combo_Dal
    {
        static BanHangContext context = BanHangContext.GetInstance();

        private static Combo_Dal instance;
        public static Combo_Dal getInstance()
        {
            if (instance == null)
                instance = new Combo_Dal();
            return instance;

        }
        public static List<Combo> GetAll()
        {
            return context.Comboes.ToList();
        }

        public Task AddOrUpdate(Combo combo)
        {
            context.Comboes.AddOrUpdate(combo);
            return context.SaveChangesAsync();
        }
    }
}
