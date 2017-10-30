using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant_Rvw.Models
{
  public class WebSiteComments
  {
    public int CommentId { get; set; }
    public int UserID { get; set; }
    public DateTime Date { get; set; }
    public string Comment { get; set; }

    public WebSiteComments()
    {
      CommentId = 0;
      UserID =    0;
      Date =      new DateTime();
      Comment =   "";
    }

    public WebSiteComments(int commentId, int userID, DateTime date, string comment)
    {
      CommentId = commentId;
      UserID =    userID;
      Date =      date;
      Comment =   comment;
    }
  }
}