using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    class Question
    {
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public int correctAnswerIndex { get; set; }
    }
}
