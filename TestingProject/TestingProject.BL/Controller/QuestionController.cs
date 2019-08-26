using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.BL.Model;

namespace TestingProject.BL.Controller
{
    /// <summary>
    /// Контроллер для вопроса
    /// </summary>
    public class QuestionController
    {
        

        /// <summary>
        /// Список вопросов.
        /// </summary>
        public List<Question> Questions { get; }

        public QuestionController(string questionText,
                                  List<Answer> answerOptions,
                                  List<Answer> rightAnswers)
        {
            Questions.Add(new Question(questionText, answerOptions, rightAnswers));
        }


    }
}
