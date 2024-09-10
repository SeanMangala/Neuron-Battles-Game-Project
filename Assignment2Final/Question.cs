using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: Sean Mangala
//Date: 2024-04-12
//Purpose: A class defines a question
namespace Assignment2Final
{
    internal class Question
    {
        Random randomNumber = new Random();
        static private int previousQuestionIndex = 0; //Does not need a getter or setter
        private int answer;
        private char typeMath;
        private string[] longQuestion = { "In what year did the first man step on the moon?",
                                     "When did WW1 start?",
                                     "In what year was PHP created?",
                                     "In what year did programming start?",
                                     "What year was I born?",
                                     "In what year was the internet created?",
                                     "How many major island groups does Philippines have?",
                                     };
        private int[] longQuestionAnswers = {1969,
                                             1914,
                                             1995,
                                             1883,
                                             2005,
                                             1983,
                                             3};
        //Auto implemented property
        //Create a set of questions with different difficulty
        //Each difficulty of questions will determine the damage dealt to player.
        public int Damage { get; set; }

        //Non-auto implemented property
        public int Answer
        {
            get 
            { 
                return answer; 
            }
            set 
            { 
                if (answer >= 0)
                    answer = value;
            }
        }

        public char TypeMath
        {
            get 
            { 
                return typeMath; 
            }
            set 
            { 
                typeMath = value; 
            }
        }
        
        //Methods
        public string getQuestion()
        {
            //Increased to probability of getting a history question to 66%
            int randomQuestion = randomNumber.Next(3);
            string question;
            if(randomQuestion == 1)
            {
                //Math question
                //Addition question prototype
                int numberOne = randomNumber.Next(0, 10),
                    numberTwo = randomNumber.Next(0, 10);
                string mathOperator;
                determineTypeMathAndDamage();
                switch (typeMath)
                {
                    case 'A':
                        answer = numberOne + numberTwo;
                        mathOperator = " + ";
                        break;
                    case 'S':
                        answer = numberOne - numberTwo;
                        mathOperator = " - ";
                        break;
                    default:
                        answer = numberOne * numberTwo;
                        mathOperator = " * ";
                        break;
                }
                question = "What is " + numberOne + mathOperator + numberTwo +
                        ": ";
            }
            else
            {
                int randomLongQuestion;
                //Prevents the object to have the same question twice in a row
                do
                {
                    randomLongQuestion = randomNumber.Next(longQuestion.Length);
                } while (randomLongQuestion == previousQuestionIndex);
                previousQuestionIndex = randomLongQuestion;
                question = longQuestion[randomLongQuestion];
                answer = longQuestionAnswers[randomLongQuestion];
                Damage = 45;
            }
            return question;
        }

        private void determineTypeMathAndDamage()
        {
            int type = randomNumber.Next(1, 4);
            switch (type)
            {
                case 1:
                    typeMath = 'A';
                    Damage = 20;
                    break;
                case 2:
                    typeMath = 'S';
                    Damage = 35;
                    break;
                default:
                    typeMath = 'M';
                    Damage = 40;
                    break;
                    
            }
        }
    }
}
