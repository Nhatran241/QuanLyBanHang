using DuLich.BanHang_Dal;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DuLich.BanHang_Entity
{
    public partial class Combo
    {
        public Task AddOrUpdate()
        {
            return Combo_Dal.getInstance().AddOrUpdate(this);
        }

        public long TotalPriceOfProductsCombo()
        {
            long tong = 0;
            if (ComboProducts == null)
                return tong;
            foreach(ComboProduct comboProduct in ComboProducts)
            {
                tong += comboProduct.Product.Price * comboProduct.Product_Amount;
            }
            return tong;
        }

        public long TotalPriceOfCombo()
        {
            long totalPrice = TotalPriceOfProductsCombo();
            return totalPrice - (totalPrice * discountPercent);
        }
        public List<ComboProduct> GetListComboProduct()
        {
            List<ComboProduct> comboProducts = new List<ComboProduct>();
            if (ComboProducts == null)
                return comboProducts;
            foreach(ComboProduct comboProduct in ComboProducts)
            {
                ComboProduct newCombo = new ComboProduct();
                newCombo.Map(comboProduct);
                comboProducts.Add(newCombo);
            }
            return comboProducts;

        }
    }
}
