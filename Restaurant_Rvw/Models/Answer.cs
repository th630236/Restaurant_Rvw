using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant_Rvw.Models
{
  public class Answer
  {
    public int AnswerId { get; set; }
    public int ReviewId { get; set; }
    public int QuestionId { get; set; }
    public int Response { get; set; }
    public string AnswerText { get; set; }

    public Answer()
    {
      AnswerId =   0;
      ReviewId =   0;
      QuestionId = 0;
      Response =   0;
      AnswerText = "";
    }

    public Answer(int answerId, int reviewId, int questionId, int response, string answerText)
    {
      AnswerId =   answerId;
      ReviewId =   reviewId;
      QuestionId = questionId;
      Response =   response;
      AnswerText = answerText;
    }
  }
}