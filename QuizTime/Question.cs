using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    public abstract class Question
    {
        public string QuestionText { get; private set; }
        public Question(string question)
        {
            QuestionText = question;
        }
        public abstract void PrintQuestion();

        public abstract void GetAnswer();

        public abstract bool IsCorrect();

    }
}
