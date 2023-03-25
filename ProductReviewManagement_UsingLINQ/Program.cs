namespace ProductReviewManagement_UsingLINQ
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<ProductData> products = new List<ProductData>()
            {
                new ProductData(){ProductId=1,UserId =1,Rating = 5,Review="BEST",IsLike=true},
                new ProductData(){ProductId=2,UserId =2,Rating = 4,Review="GOOD",IsLike=true},
                new ProductData(){ProductId=3,UserId =3,Rating = 3,Review="NICE",IsLike=true},
                new ProductData(){ProductId=4,UserId =5,Rating = 2,Review="NOTGOOD",IsLike=false},
                new ProductData(){ProductId=6,UserId =6,Rating = 2,Review="NOTGOOD",IsLike=false},
                new ProductData(){ProductId=7,UserId =7,Rating = 5,Review="BEST",IsLike=true},
                new ProductData(){ProductId=8,UserId =8,Rating = 4,Review="BEST",IsLike=true},
                new ProductData(){ProductId=9,UserId =9,Rating = 3,Review="NICE",IsLike=true},
                new ProductData(){ProductId=10,UserId =10,Rating = 2,Review="NOTGOOD",IsLike=false},
                new ProductData(){ProductId=11,UserId =11,Rating = 4,Review="GOOD",IsLike=true},
                new ProductData(){ProductId=12,UserId =12,Rating = 5,Review="BEST",IsLike=true},
                new ProductData(){ProductId=13,UserId =13,Rating = 3,Review="NICE",IsLike=true},
                new ProductData(){ProductId=14,UserId =14,Rating = 3,Review="NICE",IsLike=true},
                new ProductData(){ProductId=15,UserId =15,Rating = 5,Review="BEST",IsLike=true},
            };
            ProductDataMain productDataMain = new ProductDataMain();
            productDataMain.Addtional(products);

            try
            {
                Console.WriteLine("1.Display the ProductReview 2.Retrieve top 3 record 3.AllRecord Greater Than 3, 4.Retrive group by ProductId 5.AllRecordProductId" +
                    "\n 6.topp five record skip 7.SkipTopRecord_ByRating 8.AVG 9.review which contain NICE");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        productDataMain.Display(products);
                        break;
                    case 2:
                        productDataMain.RetriveTopRecord();
                        break;
                    case 3:
                        productDataMain.RetriveAllRecord();
                        break;
                    case 4:
                        productDataMain.RetriveGroupByProductId();
                        break;
                    case 5:
                        productDataMain.RetriveGroupByProductId();
                        break;
                    case 6:
                        productDataMain.SkipTopRecord_ByProductId();
                        break;
                    case 7:
                        productDataMain.SkipTopRecord_ByRating();
                        break;
                    case 8:
                        productDataMain.AvergaeRating();
                        break;
                    case 9:
                        productDataMain.RetriveReviews();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}