// See https://aka.ms/new-console-template for more information
using ProductReviewManagement;

Console.WriteLine("Welcome to Product Review Management!");
List<ProductReview> productReviewList = new List<ProductReview>()
{

    new ProductReview(){ProductID=1,  UserID=1,  Rating=1, Review="Bad",      Islike=false},
    new ProductReview(){ProductID=2,  UserID=1,  Rating=2, Review="Nice",     Islike=false},
    new ProductReview(){ProductID=3,  UserID=1,  Rating=3, Review="Average",  Islike=false},
    new ProductReview(){ProductID=4,  UserID=1,  Rating=4, Review="Good",     Islike=true},
    new ProductReview(){ProductID=5,  UserID=1,  Rating=5, Review="Excellent",Islike=true},
    new ProductReview(){ProductID=6,  UserID=2,  Rating=1, Review="Bad",      Islike=false},
    new ProductReview(){ProductID=7,  UserID=2,  Rating=2, Review="Nice",     Islike=false},
    new ProductReview(){ProductID=8,  UserID=2,  Rating=3, Review="Average",  Islike=false},
    new ProductReview(){ProductID=9,  UserID=2,  Rating=4, Review="Good",     Islike=true},
    new ProductReview(){ProductID=10, UserID=2,  Rating=5, Review="Excellent",Islike=true},
    new ProductReview(){ProductID=11, UserID=3,  Rating=1, Review="Bad",      Islike=false},
    new ProductReview(){ProductID=12, UserID=3,  Rating=2, Review="Nice",     Islike=false},
    new ProductReview(){ProductID=13, UserID=3,  Rating=3, Review="Average",  Islike=false},
    new ProductReview(){ProductID=14, UserID=3,  Rating=4, Review="Good",     Islike=true},
    new ProductReview(){ProductID=15, UserID=3,  Rating=5, Review="Excellent",Islike=true},
    new ProductReview(){ProductID=16, UserID=4,  Rating=1, Review="Bad",      Islike=false},
    new ProductReview(){ProductID=17, UserID=4,  Rating=2, Review="Nice",     Islike=false},
    new ProductReview(){ProductID=18, UserID=4,  Rating=3, Review="Average",  Islike=false},
    new ProductReview(){ProductID=19, UserID=4,  Rating=4, Review="Good",     Islike=true},
    new ProductReview(){ProductID=20, UserID=4,  Rating=5, Review="Excellent",Islike=true},
    new ProductReview(){ProductID=21, UserID=10, Rating=1, Review="Bad",      Islike=false},
    new ProductReview(){ProductID=22, UserID=10, Rating=2, Review="Nice",     Islike=false},
    new ProductReview(){ProductID=23, UserID=10, Rating=3, Review="Average",  Islike=false},
    new ProductReview(){ProductID=24, UserID=10, Rating=4, Review="Good",     Islike=true},
    new ProductReview(){ProductID=25, UserID=10, Rating=5, Review="Excellent",Islike=true},
};



Product review = new Product();
while (true)
{
    Console.WriteLine("Choose the correct option : \n1)Adding Values to List\n2)Retrieve Top 3 Records\n3)Greater than 3 from ProductId's 1/4/9\n4)Retrieve Count of Review\n5)Retieve ProductID and Review\n6)Skip Top Five Records\n7)Retrieve ProductID and Review Using Select\n8)Create a DataTable\n9)Retrieve Records Where Islike Is True\n10)Average of Ratings");
    int option = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("---------------------------------------------------------------------------------------------");
    switch (option)
    {
        case 1:
            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID :" + list.ProductID + "  " + "UserID :" + list.UserID + "  " + "Rating :" + list.Rating + "  " + "Review :" + list.Review + "  " + "isLike :" + list.Islike);
            }
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************************************");
            break;
        case 2:
            review.TopThreeRecords(productReviewList);
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************************************");
            break;
        case 3:
            review.GraterThanThreeRecords(productReviewList);
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************************************");
            break;
        case 4:
            review.CountReview(productReviewList);
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************************************");
            break;
        case 5:
            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID :" + list.ProductID + " Review :" + list.Review);
            }
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************************************");
            break;
        case 6:
            review.SkipTop5Records(productReviewList);
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************************************");
            break;
        case 7:
            review.RetrieveUsingSelect(productReviewList);
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************************************");
            break;
        case 8:
            review.CreateDatatables();
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************************************");
            break;
        case 9:
            review.RetrieveRecordsFromDataTable(productReviewList);
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************************************");
            break;
        case 10:
            review.AverageRating(productReviewList);
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************************************");
            break;
        default:
            Console.WriteLine("Please choose the correct option!");
            break;
    }
}