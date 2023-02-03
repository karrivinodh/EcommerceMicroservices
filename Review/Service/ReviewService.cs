using Review.Model;
using ReviewMicroService.Model;

namespace ReviewMicroService.Service
{
    public class ReviewService
    {

        public static List<Reviews> ReviewDataList { get; }
        static int reviewId = 1;

        public static Reviews Post(Reviews review)
        {
            var reviews = new Reviews();
            reviews.Id = reviewId++;
            ReviewDataList.Add(review);
            return review;
        }
        public static List<Reviews> Get()
        {
            return ReviewDataList;
        }
        public static Reviews GetByID(int id)
        {
            return ReviewDataList.FirstOrDefault(Review => Review.Id == id);
        }

    }
    }
