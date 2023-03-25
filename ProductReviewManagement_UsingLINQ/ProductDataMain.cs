﻿using System;
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
        /// <summary>
        ///  Uc 2 Retrieve top 3 records from the list who’s rating is high using LINQ
        /// </summary>
        public void RetriveTopRecord()
        {
            var result = this.products.Where(x => x.Rating ==5).Take(3);
            Console.WriteLine(" **RetriveTop3Record*****");
            Display(result.ToList());

        }
        /// <summary>
        /// Uc3 Management - Retrieve all record from the listwho’s rating are greater then 3 and productID is 1 or 4 or 9 using
        /// </summary>
        /// <param name="list"></param>
        public void RetriveAllRecord()
        {
            var result = this.products.Where(x => x.Rating > 3 && (x.ProductId==1||x.ProductId==4||x.ProductId==9));
            Console.WriteLine(" **RetriveAllRecord*****");
            Display(result.ToList());
        }
        /// <summary>
        /// Display Method
        /// </summary>
        /// <param name="products"></param>
        public void Display(List<ProductData> products)
        {
            foreach (var data in products)
            {
                Console.WriteLine("ProductId "+data.ProductId+" UserId "+data.UserId +"Rating"+data.Rating+"Review"+data.Review);
            }
        }
    }
}
