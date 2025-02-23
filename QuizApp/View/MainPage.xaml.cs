using QuizApp.Models;
using QuizApp.Services;

namespace QuizApp
{
    public partial class MainPage : ContentPage
    {
        private readonly QuizService _quizService;
        private List<Question> _questions;
        private int _currentQuestionIndex;
        private int _score;

        public MainPage()
        {
            InitializeComponent();
            _quizService = new QuizService();
            _questions = _quizService.GetQuestions();
            _currentQuestionIndex = 0;
            _score = 0;

            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            var question = _questions[_currentQuestionIndex];
            Console.WriteLine($"Displaying question: {question.Text}");
            questionLabel.Text = question.Text;

            option1RadioButton.Content = question.Options[0];
            option2RadioButton.Content = question.Options[1];
            option3RadioButton.Content = question.Options[2];
            option4RadioButton.Content = question.Options[3];

            resultLabel.Text = string.Empty;
        }

        private void OnNextClicked(object sender, EventArgs e)
        {
            var question = _questions[_currentQuestionIndex];
            var selectedAnswerIndex = -1;

            if (option1RadioButton.IsChecked)
                selectedAnswerIndex = 0;
            else if (option2RadioButton.IsChecked)
                selectedAnswerIndex = 1;
            else if (option3RadioButton.IsChecked)
                selectedAnswerIndex = 2;
            else if (option4RadioButton.IsChecked)
                selectedAnswerIndex = 3;

            if (selectedAnswerIndex == question.correctAnswerIndex)
            {
                _score++;
                resultLabel.Text = "Correct!";
            }
            else
            {
                resultLabel.Text = "Incorrect!";
            }

            _currentQuestionIndex++;

            if (_currentQuestionIndex < _questions.Count)
            {
                DisplayQuestion();
            }
            else
            {
                resultLabel.Text += $" Final Score: {_score}/{_questions.Count}";
                _currentQuestionIndex = 0;
                _score = 0;
            }
        }
    }

}
