using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant_Rvw.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public int UserId { get; set; }
    public int RestaurantId { get; set; }
    public DateTime ReviewDate { get; set; }
    public string ReviewTitle { get; set; }
    public float OverallRating { get; set; }

    public Review()
    {
      ReviewId =      0;
      UserId =        0;
      RestaurantId =  0;
      ReviewDate =    new DateTime();
      ReviewTitle =   "";
      OverallRating = 0.0f;
    }

    public Review(int reviewId, int userId, int restaurantId, DateTime reviewDate, string reviewTitle, float overallRating)
    {
      ReviewId =      reviewId;
      UserId =        userId;
      RestaurantId =  restaurantId;
      ReviewDate =    reviewDate;
      ReviewTitle =   reviewTitle;
      OverallRating = overallRating;
    }
  }
}