using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace Restaurant_Rvw.Models
{
  public class Question
  {
    public int QuestionId { get; set; }
    public bool Active { get; set; }
    public int QuestionNum { get; set; }
    public int QuestionType { get; set; }
    public string QuestionText { get; set; }
    public List<AnswerOpt> answerOpts;

    public Question()
    {
      QuestionId =   0;
      Active =       false;
      QuestionNum =  0;
      QuestionType = 0;
      QuestionText = "";
      answerOpts =   new List<AnswerOpt>();
    }

    public Question(int questionId, bool active, int questionNum, int questionType, string questionText)
    {
      QuestionId =   questionId;
      Active =       active;
      QuestionNum =  questionNum;
      QuestionType = questionType;
      QuestionText = questionText;
      answerOpts =   new List<AnswerOpt>();
    }
  }
}