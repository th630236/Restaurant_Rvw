using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant_Rvw.Models
{
  public class AnswerOpt
  {
    public int AnswerOptId { get; set; }
    public int QuestionId { get; set; }
    public int Seq { get; set; }
    public int Value { get; set; }
    public string OptText { get; set; }

    public AnswerOpt()
    {
      AnswerOptId = 0;
      QuestionId =  0;
      Seq =         0;
      Value =       0;
      OptText =     "";
    }

    public AnswerOpt(int answerOptId, int questionId, int seq, int value, string optText)
    {
      AnswerOptId = answerOptId;
      QuestionId =  questionId;
      Seq =         seq;
      Value =       value;
      OptText =     optText;
    }
  }
}