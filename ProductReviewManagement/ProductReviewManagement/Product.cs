﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Product
    {
        public void TopThreeRecords(List<ProductReview> productReviewList)
        {
            var productData = (from ProductReview in productReviewList orderby ProductReview.Rating descending select ProductReview).Take(3);

            foreach (var list in productData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                     + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "IsLike:- " + list.Islike);
            }
        }
        public void GraterThanThreeRecords(List<ProductReview> productreviewlist)
        {
            var productData = (from productReviews in productreviewlist
                               where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                               && productReviews.Rating > 3
                               select productReviews);

            foreach (var list in productData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                     + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "IsLike:- " + list.Islike);
            }
        }
        public void CountReview(List<ProductReview> productreviewlist)
        {
            foreach (var line in productreviewlist.GroupBy(info => info.ProductID)
                           .Select(group => new {
                               products = group.Key,
                               Count = group.Count()
                           })
                           .OrderBy(x => x.products))
            {
                Console.WriteLine("Product Id:{0} => Count :{1}", line.products, line.Count);
            }
        }
        public void SkipTop5Records(List<ProductReview> productreviewlist)
        {
            foreach (var productData in (from productReviews in productreviewlist
                                         select productReviews).Skip(5))
            {
                Console.WriteLine("ProductID:- " + productData.ProductID + " " + "UserID:- " + productData.UserID
                                     + " " + "Rating:- " + productData.Rating + " " + "Review:- " + productData.Review + " " + "IsLike:- " + productData.Islike);
            }
        }
        public void RetrieveUsingSelect(List<ProductReview> productreviewlist)
        {
           
            var recordData = productreviewlist.Select(x => new { ProductId = x.ProductID, Review = x.Review });
            Console.WriteLine("\nProductID  Review");
            foreach (var list in recordData)
            {
                Console.WriteLine(list.ProductId + "\t    " + list.Review);
            }
        }
    }
}
