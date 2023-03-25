using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement_UsingLINQ
{
    public class ProductDataMain
    {
        /// <summary>
        /// Insert data in List
        /// </summary>
        List<ProductData> products;
        public void Addtional(List<ProductData> products)
        {
            this.products = products;
        }
    }
}
