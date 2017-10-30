using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant_Rvw.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public bool Pending { get; set; }

    public Restaurant()
    {
      RestaurantId = 0;
      Name =         "";
      Address =      "";
      City =         "";
      State =        "";
      Pending =      true;
    }

    public Restaurant(int restaurantId, string name, string address, string city, string state, bool pending)
    {
      RestaurantId = restaurantId;
      Name =         name;
      Address =      address;
      City =         city;
      State =        state;
      Pending =      pending;
    }
  }
}