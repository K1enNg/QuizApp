using QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Services
{
    class QuizService
    {
        public List<Question> GetQuestions()
        {
            return new List<Question>
            {
                new Question
                {
                    Text = "What is the capital of France?",
                    Options = new List<string> {"Berlin", "Madrid", "Paris", "Rome"},
                    correctAnswerIndex = 2
                },
                new Question
                {
                    Text = "Which planet is known as the Red Planet?",
                    Options = new List<string> {"Earth", "Mars", "Venus", "Jupiter"},
                    correctAnswerIndex = 1
                }
            };
        }
    }
}
