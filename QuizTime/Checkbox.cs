using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class Checkbox : Question
    {
        public List<string> Choices { get; private set; } = new List<string>();
        private string userAnswer;
        public string CorrectAnswer { get; private set; }

        public Checkbox(string question, List<string> choices, string correct) : base(question)
        {
            Choices = choices;
            CorrectAnswer = correct;
        }

        public override void PrintQuestion()
        {
            Console.WriteLine(QuestionText);
            Console.WriteLine("Enter the lowercase letter of each correct answer in order with no spaces and press enter:");

            foreach (string ans in Choices)
            {
                Console.WriteLine(ans);
            }
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
