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
            Question question = new Question("Ответ 1,5", answersAll, answersTrue);

            Console.ReadLine();
        }
    }
}
