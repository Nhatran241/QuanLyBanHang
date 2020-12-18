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

        public Task Delete(combo combo)
        {
            List<comboproducts> oldList = context.Comboproducts.Where(c => c.combo.id == combo.id).ToList();
            context.Comboproducts.RemoveRange(oldList);
            context.Comboes.Remove(combo);
            return context.SaveChangesAsync();
        }

        private static Combo_Dal instance;
        public static Combo_Dal getInstance()
        {
            if (instance == null)
                instance = new Combo_Dal();
            return instance;

        }
        public List<combo> GetAll()
        {
            return context.Comboes.ToList();
        }

        public Task AddOrUpdate(combo combo)
        {
            List<comboproducts> oldList = context.Comboproducts.Where(c => c.combo.id == combo.id).ToList();
            context.Comboproducts.RemoveRange(oldList);
            context.Comboes.AddOrUpdate(combo);
            return context.SaveChangesAsync();
        }
    }
}
