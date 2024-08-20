using System;
using System.Collections.Generic;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store questions and answers
            var questions = new List<Question>
            {
                new Question("What is the capital of France?", "Paris"),
                new Question("What is 2 + 2?", "4"),
                new Question("What is the largest planet in our solar system?", "Jupiter")
            };

            // Variable to keep track of the score
            int score = 0;

            // Welcome message
            Console.WriteLine("Welcome to the Quiz!");
            Console.WriteLine("---------------------");

            // Loop through each question
            foreach (var question in questions)
            {
                // Display the question
                Console.WriteLine(question.Text);

                // Get the user's answer
                string userAnswer = Console.ReadLine().Trim();

                // Check if the user's answer is correct
                if (userAnswer.Equals(question.Answer, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer is: {question.Answer}");
                }

                Console.WriteLine();
            }

            // Display the final score
            Console.WriteLine($"Quiz finished! Your final score is: {score}/{questions.Count}");
        }
    }

    // Class to represent a question
    class Question
    {
        public string Text { get; }
        public string Answer { get; }

        public Question(string text, string answer)
        {
            Text = text;
            Answer = answer;
        }
    }
}
