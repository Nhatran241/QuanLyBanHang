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
    class Storage_Dal
    {
        static BanHangContext context = BanHangContext.GetInstance();
        private static Storage_Dal instance;
        public static Storage_Dal getInstance()
        {
            if (instance == null)
                instance = new Storage_Dal();
            return instance;

        }

        public Task AddOrUpdate(storage storage)
        {
            context.Storages.AddOrUpdate(storage);
            return context.SaveChangesAsync();
        }

        public Task Delete(storage storage)
        {
            context.Storages.Remove(storage);
            return context.SaveChangesAsync();
        }

        public List<storage> GetAll()
        {
            return context.Storages.ToList();
        }
       
    }
}
