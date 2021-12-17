using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quiz
{
    class Quiz
    {
        public List<Questions> Questions { get; set; }
        public Player Player { get; set; }
        public Quiz()
        {
            LoadQuestionFile(@"D:\Projects\UdemyCSharp\Quiz\question.txt");
        }
        private void LoadQuestionFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            var counter = 0;
            var courentQuestion = new Questions();
            Questions = new List<Questions>();
            foreach (var line in lines)
            {
                if (counter == 6)
                {
                    counter = 0;
                }
                if (counter == 0)
                {
                    courentQuestion.Title = line;
                }
                if (counter == 1)
                {
                    courentQuestion.AnswerA = line;
                }
                if (counter == 2)
                {
                    courentQuestion.AnswerB = line;
                }
                if (counter == 3)
                {
                    courentQuestion.AnswerC = line;
                }
                if (counter == 4)
                {
                    courentQuestion.AnswerD = line;
                }
                if (counter == 5)
                {
                    courentQuestion.RightAnswerLetter = line[0].ToString();
                    courentQuestion.Score = int.Parse(line[1].ToString());
                    var newQuestion = new Questions()
                    { 
                    Title = courentQuestion.Title,
                        AnswerA = courentQuestion.AnswerA,
                        AnswerB = courentQuestion.AnswerB,
                        AnswerC = courentQuestion.AnswerC,
                        AnswerD = courentQuestion.AnswerD,
                        RightAnswerLetter = courentQuestion.RightAnswerLetter,
                        Score = courentQuestion.Score
                    };
                Questions.Add(newQuestion);
                }
                counter++;
            }
        }
        public void Start()
        {
            Player = new Player();

            Console.WriteLine("Tell me your name");
            Player.Name = Console.ReadLine();
            for(var  i=0;i< Questions.Count;i++)
            {
                var score = ShowQuestion(Player.CurrentQuestion);
                Player.Score += score;
                Player.CurrentQuestion++;
            }
            Console.WriteLine("Quiz finshed.");
            Console.WriteLine(Player.Name+", your score was: "+Player.Score);

        }
        public int ShowQuestion(int questionCounter)
        {
            var cuurnetQuestionToShow = Questions[questionCounter - 1];
            Console.WriteLine("Question: "+cuurnetQuestionToShow.Title);
            Console.WriteLine("A " + cuurnetQuestionToShow.AnswerA);
            Console.WriteLine("B " + cuurnetQuestionToShow.AnswerB);
            Console.WriteLine("C " + cuurnetQuestionToShow.AnswerC);
            Console.WriteLine("D " + cuurnetQuestionToShow.AnswerD);
            var userResponse = Console.ReadLine().ToUpper();
            
            if(userResponse== cuurnetQuestionToShow.RightAnswerLetter)
            {
                return cuurnetQuestionToShow.Score;
            }
            Console.WriteLine("Your answer was wrong.");
            return 0;

        }
    }
   
}
