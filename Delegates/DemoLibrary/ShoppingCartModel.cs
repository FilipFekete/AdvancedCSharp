using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ShoppingCartModel
    {

        public delegate void MentionDiscount(decimal subTotal);

        public List<ProductModel> Items { get; set; } = new List<ProductModel>();
        
        //generating total with discount
        public decimal GenerateTotal(MentionDiscount mentionSubtotal,
           Func<List<ProductModel>, decimal, decimal> calculateDiscountedTotal,
           Action<string> tellUserDiscount)
            
        {
            decimal subTotal = Items.Sum(x => x.Price);

            mentionSubtotal(subTotal);

            tellUserDiscount("We are applying your discount.");

            decimal total = calculateDiscountedTotal(Items, subTotal);

            return total;         
        }
    }
}
