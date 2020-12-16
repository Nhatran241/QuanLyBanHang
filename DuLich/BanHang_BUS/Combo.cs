using DuLich.BanHang_Dal;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DuLich.BanHang_Entity
{
    public partial class combo
    {
        public Task AddOrUpdate()
        {
            return Combo_Dal.getInstance().AddOrUpdate(this);
        }

        public long TotalPriceOfProductsCombo()
        {
            long tong = 0;
            if (comboproducts == null)
                return tong;
            foreach(comboproducts comboProduct in comboproducts)
            {
                tong += comboProduct.product.price * comboProduct.product_amount;
            }
            return tong;
        }

        public long TotalPriceOfCombo()
        {
            long totalPrice = TotalPriceOfProductsCombo();
            return (totalPrice - (totalPrice * discountpercent)/100);
        }
        public List<comboproducts> GetListComboProduct()
        {
            List<comboproducts> comboProducts = new List<comboproducts>();
            if (comboproducts == null)
                return comboProducts;
            foreach(comboproducts comboProduct in comboproducts)
            {
                comboproducts newCombo = new comboproducts();
                newCombo.Map(comboProduct);
                comboProducts.Add(newCombo);
            }
            return comboProducts;

        }
    }
}
