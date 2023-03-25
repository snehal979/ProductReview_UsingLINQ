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
        /// Uc 4 RetriveGroupByProductId
        /// </summary>
        public void RetriveGroupByProductId()
        {
            var result = this.products.GroupBy(x => x.ProductId);
            foreach (var data in result)
            {
                foreach (var item in data)
                {
                    Console.WriteLine(item.ProductId);
                }
            }
        }
        /// <summary>
        /// Uc5  Retrieve only productId and review from the list for all
        /// </summary>
        public void RetriveALLProductId()
        {
            var result = this.products.Select(x => new { x.ProductId, x.Review });
            foreach (var data in result)
            {
                Console.WriteLine(data.ProductId);
            }
        }
        /// <summary>
        /// Uc 6 SkipRecord top five Product id
        /// </summary>
        public void SkipTopRecord_ByProductId()
        {
            var result = this.products.OrderByDescending(x => x.ProductId).Skip(5);
            foreach (var data in result)
            {
                Console.WriteLine(data.ProductId);
            }
        }
        /// <summary>
        /// Uc7 Skip top Five Record rating
        /// </summary>
        /// <param name="list"></param>
        public void SkipTopRecord_ByRating()
        {
            var result = this.products.OrderByDescending(x => x.Rating).Skip(5);
            foreach (var data in result)
            {
                Console.WriteLine(data.ProductId);
            }
        }
        /// <summary>
        /// Uc10 Avergate of rating
        /// </summary>
        /// <param name="list"></param>
        public void AvergaeRating()
        {
            var result = this.products.Average(x => x.Rating);
            Console.WriteLine(result);
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
