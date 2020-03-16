using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class TrueFalse : Question
    {
        private string userAnswer;
        public string CorrectAnswer { get; private set; }

        public TrueFalse(string question, string correct) : base(question)
        {
            CorrectAnswer = correct;
        }

        public override void PrintQuestion()
        {
            Console.WriteLine(QuestionText);
            Console.WriteLine("Enter 'true' or 'false':");
        }

        public override void GetAnswer()
        {
            userAnswer = Console.ReadLine();
            Console.WriteLine();
        }

        public override bool IsCorrect()
        {
            bool correct = false;

            if (userAnswer.Equals(CorrectAnswer))
            {
                correct = true;
            }

            return correct;
        }
    }
}
