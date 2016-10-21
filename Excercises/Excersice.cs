using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises
{
    public class Excersice
    {
        private string _answer;
        private string _question;
        public bool IsCorrect;
        public bool IsFinish;
        private int PositionQuestion;
        public int QuestionsCount=6;

        string question { get { return _question; }
            set
            {
                _question = value;
            }
        }
        string answer { set
            {
                _answer = value;
            }
        }

        string[] questions = new string[6];
        string[] answers   = new string[6];

        public Excersice()
        {
            Load();
        }

        void Load()
        {
            questions[0] = Jacob_1;
            answers[0] = George_1;
            questions[1] = Jacob_2;
            answers[1] = George_2;
            questions[2] = Jacob_3;
            answers[2] = George_3;
            questions[3] = Jacob_4;
            answers[3] = George_4;
            questions[4] = Jacob_5;
            answers[4] = George_5;
            questions[5] = Jacob_6;
            answers[5] = George_6;
            PositionQuestion = 0;
        }

        #region
        string Jacob_1  = "Hello, how are you?";
        string George_1 = "Hello, I am good, and you?";
        string Jacob_2  = "I am good, too. what is your name?";
        string George_2 = "My name is George. What is your name?";
        string Jacob_3  = "My name is Jacob. Where are you from?";
        string George_3 = "I am from Mexico. What about you? Where are you from?";
        string Jacob_4  = "I am from the United States. I am American.";
        string George_4 = "Do you live here in Los Angeles?";
        string Jacob_5  = "Yes, I do. I must say, you speak english very well.";
        string George_5 = "Thank you, but I don't think that I speak that well yet. I am still learning it.";
        string Jacob_6  = "Well, I Think you do !! Anyway, I should go back to work. Have a nice day !!";
        string George_6 = "Nice Chatting with you. Have a nice day as well !! GoodBay !!";
        #endregion


        public string GetNextQuestion(int position)
        {
            PositionQuestion = position;
            if (position >= 5) { IsFinish = true; };
            return questions[position];
        }

        public void SetAnswer(string snwer)
        {
            if (snwer == answers[PositionQuestion]){IsCorrect = true;}
            else { IsCorrect = false; }
        }


    }

    public class Excersice2
    {
        private string _answer;
        private string _question;
        public bool IsCorrect;
        public bool IsFinish;
        private int PositionQuestion;
        public int QuestionsCount = 6;

        string question
        {
            get { return _question; }
            set
            {
                _question = value;
            }
        }
        string answer
        {
            set
            {
                _answer = value;
            }
        }

        string[] questions = new string[6];
        string[] answers = new string[6];

        public Excersice2()
        {
            Load();
        }

        void Load()
        {
            questions[0] = Jacob_1;
            answers[0] = George_1;
            questions[1] = Jacob_2;
            answers[1] = George_2;
            questions[2] = Jacob_3;
            answers[2] = George_3;
            questions[3] = Jacob_4;
            answers[3] = George_4;
            questions[4] = Jacob_5;
            answers[4] = George_5;
            questions[5] = Jacob_6;
            answers[5] = George_6;
            PositionQuestion = 0;
        }

        #region
        string Jacob_1 = "Hello, how are you?";
        string George_1 = "Hello, I am good, and you?";
        string Jacob_2 = "I am good, too. what is your name?";
        string George_2 = "My name is George. What is your name?";
        string Jacob_3 = "My name is Jacob. Where are you from?";
        string George_3 = "I am from Mexico. What about you? Where are you from?";
        string Jacob_4 = "I am from the United States. I am American.";
        string George_4 = "Do you live here in Los Angeles?";
        string Jacob_5 = "Yes, I do. I must say, you speak english very well.";
        string George_5 = "Thank you, but I don't think that I speak that well yet. I am still learning it.";
        string Jacob_6 = "Well, I Think you do !! Anyway, I should go back to work. Have a nice day !!";
        string George_6 = "Nice Chatting with you. Have a nice day as well !! GoodBay !!";
        #endregion


        public string GetNextQuestion(int position)
        {
            PositionQuestion = position;
            if (position >= 5) { IsFinish = true; };
            return questions[position];
        }

        public void SetAnswer(string snwer)
        {
            if (snwer == answers[PositionQuestion]) { IsCorrect = true; }
            else { IsCorrect = false; }
        }


    }





}
