﻿namespace ProductReviewManagement_UsingLINQ
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
                Console.WriteLine("1.Display the ProductReview 2.Retrieve top 3 record ");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        productDataMain.Display(products);
                        break;
                    case 2:
                        productDataMain.RetriveTopRecord();
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