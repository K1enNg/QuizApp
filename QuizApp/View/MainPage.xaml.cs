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
            Console.WriteLine($"Displaying question: {question.QuestionText}");
            questionLabel.Text = question.QuestionText;

            option1RadioButton.Content = question.Options[0];
            option2RadioButton.Content = question.Options[1];
            option3RadioButton.Content = question.Options[2];
            option4RadioButton.Content = question.Options[3];

            resultLabel.Text = string.Empty;
        }

        private void OnNextClicked(object sender, EventArgs e)
        {
            var question = _questions[_currentQuestionIndex];
            int selectedAnswerIndex = -1;

            if (option1RadioButton.IsChecked) selectedAnswerIndex = 0;
            if (option2RadioButton.IsChecked) selectedAnswerIndex = 1;
            if (option3RadioButton.IsChecked) selectedAnswerIndex = 2;
            if (option4RadioButton.IsChecked) selectedAnswerIndex = 3;

            if (selectedAnswerIndex == question.CorrectAnswerIndex)
            {
                _score++;
                resultLabel.Text = "✅ Correct!";
                resultLabel.TextColor = Colors.Green;
            }
            else
            {
                resultLabel.Text = "❌ Incorrect!";
                resultLabel.TextColor = Colors.Red;

                correctedAnswerLabel.Text = $"Correct Answer: {question.CorrectAnswer}";
                correctedAnswerLabel.IsVisible = true;
            }

            _currentQuestionIndex++;

            if (_currentQuestionIndex < _questions.Count)
            {
                Task.Delay(2000).ContinueWith(t => MainThread.BeginInvokeOnMainThread(DisplayQuestion));
            }
            else
            {
                resultLabel.Text += $"\nFinal Score: {_score}/{_questions.Count}";
                _currentQuestionIndex = 0;
                _score = 0;
                Task.Delay(3000).ContinueWith(t => MainThread.BeginInvokeOnMainThread(DisplayQuestion));
            }
        }

    }

}
