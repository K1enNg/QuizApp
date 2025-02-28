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
                new Question("What is a program in computer science?", new List<string>
                {
                    "a planned series of events, a schedule",
                    "a translated language that is easy for the computer to understand",
                    "a sequence of instructions that specifies how to perform a computation",
                    "a general process for solving a category of problems"
                },2),
                new Question("What is the function of the compiler?", new List<string>
                {
                    "It loads the program from its saved location and makes the computer execute it.",
                        "It reads a high-level program and translates everything at once, before executing any of the commands.",
                        "It translates the program from the low-level language you coded in to a high-level language that the computer can understand.",
                        "It translates the program line-by-line, alternately reading lines and carrying out commands."
                },1),
                new Question("What is the difference between source code and object code?", new List<string>
                {
                   "Source code can contain simple things like variables and values. Object code can contain more complex objects like data structures.",
                        "Object code can contain simple things like variables and values. Source code can contain more complex objects like data structures.",
                        "Object code is the code that your program is written in. Source code is the translated version of this code that the computer can understand.",
                        "Source code is the code that your program is written in. Object code is the translated version of this code that the computer can understand."
                },2),
                new Question("C++ is a(n) ________.", new List<string>
                {
                    "natural language",
                        "foreign language",
                        "high-level language.",
                        "low-level language."
                },2),
                new Question("Which of the following sorting algorithms has the best average-case time complexity?", new List<string>
                {
                        "Bubble Sort",
                        "Merge Sort",
                        "Selection Sort",
                        "Question Sort"
                },1),
            };
        }
    }
}
