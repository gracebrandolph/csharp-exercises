using System;
using System.Collections.Generic;

namespace QuizTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz q = new Quiz();
            q.RunQuiz();
            q.GradeQuiz();
    }
}
