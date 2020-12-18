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
    class Invoice_Dal
    {
        static BanHangContext context = BanHangContext.GetInstance();

        public Task Delete(invoice invoice)
        {
            context.Invoices.Remove(invoice);
            return context.SaveChangesAsync();
        }

        private static Invoice_Dal instance;
        public static Invoice_Dal getInstance()
        {
            if (instance == null)
                instance = new Invoice_Dal();
            return instance;

        }
        public List<invoice> GetAll()
        {
            return context.Invoices.ToList();
        }

        public Task AddOrUpdate(invoice invoice)
        {
            List<invoicedetail> oldList = context.InvoiceDetails.Where(c => c.invoice.id == invoice.id).ToList();
            context.InvoiceDetails.RemoveRange(oldList);
            context.Invoices.AddOrUpdate(invoice);
            return context.SaveChangesAsync();
        }
    }
}
