using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.BL.Model;

namespace TestingProject.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Answer> answersAll = new List<Answer>
            {
                new Answer("Ответ_1"),
                new Answer("Ответ_2"),
                new Answer("Ответ_3"),
                new Answer("Ответ_4"),
                new Answer("Ответ_5"),
                new Answer("Ответ_6"),
                new Answer("Ответ_7"),
            };
            List<Answer> answersTrue = new List<Answer>
            {
                new Answer("Ответ_1"),
                new Answer("Ответ_5")
            };
            Question question = new Question("Ответ 1,5!", answersAll, answersTrue);

            int[] numAns = { 0 };
            int numLine;
            do
            {
                Console.WriteLine(question.QuestionText);
                numLine = 1;
                foreach (var answer in question.AnswerOptions)
                {
                    if (numAns.Contains(numLine))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.WriteLine("\t" + numLine++ + "-" + answer.QuestionText);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine("Введите номер правильного ответа или ответов через запятую!(1,4)\nЛибо напишите y для подтверждения ответов!\nИ нажмите Enter!");
                string ans = Console.ReadLine();
                
                if (ans=="y")
                {
                    break;
                }
                numAns = ans.Split(',').Select<string, int>(x => Convert.ToInt32(x)).ToArray();
                Console.Clear();
                Console.WriteLine("Желтым то что выбрали!");
            } while (true);


            Console.WriteLine(question.QuestionText);
            numLine = 1;
            foreach (var answer in question.AnswerOptions)
            {
                if (numAns.Contains(numLine))
                {
                    if (answersTrue.Contains(answer))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                }
                else
                {
                    if (answersTrue.Contains(answer))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine("\t" + numLine++ + "-" + answer.QuestionText);
                
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }
}
