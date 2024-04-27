using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradings
{
    class Program
    {
        static string Name(int age)
        {
            string theName;
            if (19 <= age && age <= 30)
                theName = "Michael";
            else if (16 <= age && age <= 18)
                theName = "Mercy";
            else if (14 <= age && age < 16)
                theName = "Emmanuel";
            else if (12 <= age && age < 14)
                theName = "Victory";
            else
            {
                Console.WriteLine("I don't know your name. Can you enter it below?");
                theName = Convert.ToString(Console.ReadLine());
            }
            return theName;
        }
    
        

        static char Grade(int score)
        {
            char grade = ' ';
            if (70 <= score && score <= 100)
            {
                grade = 'A';
            }
            else if (60 <= score && score < 70)
            {
                grade = 'B';
            }
            else if (50 <= score && score < 60)
            {
                grade = 'C';
            }
            else if (45 <= score && score < 50)
            {
                grade = 'D';
            }
            else if (40 <= score && score < 44)
            {
                grade = 'E';
            }
            else if (0 <= score && score < 40)
            {
                grade = 'F';
            }
            else
            {
                Console.WriteLine("Error: Invalid score");
            }

            return grade;
        }

        static bool CheckAnswer(char trueAns, char choice)
        {
            bool final = false;
            if (trueAns == 'A')
                switch (choice)
                {
                    case 'A':
                        final = true;
                        break;
                    case 'a':
                        final = true;
                        break;
                    case 'B':
                        final = false;
                        break;
                    case 'b':
                        final = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        break;
                }
            else
                switch (choice)
                {
                    case 'A':
                        final = false;
                        break;
                    case 'a':
                        final = false;
                        break;
                    case 'B':
                        final = true;
                        break;
                    case 'b':
                        final = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        break;
                }
            return final;
        }

        static int Scorer(bool value)
        {
            int val = 0;
            switch (value)
            {
                case true:
                    val = 20;
                    break;
                case false:
                    val = 0;
                    break;
            }
            return val;
        }

        static int RunExam()
        {
            int score = 0;
            char answer, a='A', b='B';
            bool value;
            Console.WriteLine("You have five (5) questions with 20 marks for each.");
            Console.WriteLine();

            Console.WriteLine("What is the name of the current deputy governor of Lagos state?");
            Console.WriteLine("A.\tSeyi Makinde");
            Console.WriteLine("B.\tObafemi Hamzat");
            Console.Write("Your answer: ");
            answer = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            value = CheckAnswer(b,answer);
            score += Scorer(value);

            Console.WriteLine("What is the name of the current Senate President of Nigeria?");
            Console.WriteLine("A.\tGodswill Akpabio");
            Console.WriteLine("B.\tBukola Saraki");
            Console.Write("Your answer: ");
            answer = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            value = CheckAnswer(a, answer);
            score += Scorer(value);

            Console.WriteLine("What is the name of the deputy governor of Lagos state?");
            Console.WriteLine("A.\tSeyi Makinde");
            Console.WriteLine("B.\tObafemi Hamzat");
            Console.Write("Your answer: ");
            answer = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            value = CheckAnswer(b, answer);
            score += Scorer(value);

            Console.WriteLine("What is the name of the deputy governor of Lagos state?");
            Console.WriteLine("A.\tSeyi Makinde");
            Console.WriteLine("B.\tObafemi Hamzat");
            Console.Write("Your answer: ");
            answer = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            value = CheckAnswer(b, answer);
            score += Scorer(value);

            Console.WriteLine("What is the name of the deputy governor of Lagos state?");
            Console.WriteLine("A.\tSeyi Makinde");
            Console.WriteLine("B.\tObafemi Hamzat");
            Console.Write("Your answer: ");
            answer = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            value = CheckAnswer(b, answer);
            score += Scorer(value);
            return score;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the short examination program.");
            Console.WriteLine();
            Console.Write("Please Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            int score = RunExam();
            char grade = Grade(score);
            Console.WriteLine();
            Console.WriteLine("Here are your results.");
            Console.WriteLine();
            Console.WriteLine("Name:\t" + Name(age));
            Console.WriteLine($"Score:\t{score}");
            Console.WriteLine($"Grade\t{grade}");

            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
