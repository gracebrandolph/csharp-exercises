using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class Quiz
    {
        public List<Question> questions { get; set; } = new List<Question>();
        private int score;
        public Quiz()
        {
            score = 0;
            questions.Add(new TrueFalse("Was this studio easy?", "false"));
            questions.Add(new MultipleChoice("What made this studio difficult?", new List<string>
            {"a. Having to read someone else's code", "b. Class design", "c. Understanding MVC"}, "b"));
            questions.Add(new Checkbox("What should I do next time a studio is hard?", new List<string>
            {"a. Feel overconfident and procrastinate", "b. Step back and review the prepwork", "c. Ask others for help in class"}, "bc"));
        }
        public void RunQuiz()
        {
            foreach(Question q in questions)
            {
                q.PrintQuestion();
                q.GetAnswer();
                if (q.IsCorrect())
                {
                    score++;
                }
                Console.WriteLine();
            }
        }
        public void GradeQuiz()
        {
            Console.WriteLine("You got " + score + " out of " + questions.Count + " questions correct");
        }
    }
}
