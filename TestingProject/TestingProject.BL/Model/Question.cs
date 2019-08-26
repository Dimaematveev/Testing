using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.BL.Model
{
    /// <summary>
    /// Вопрос.
    /// </summary>
    public class Question
    {
        /// <summary>
        /// Текст вопроса.
        /// </summary>
        public string QuestionText { get; set; }
        /// <summary>
        /// Варианты ответов(Все).
        /// </summary>
        public List<Answer> AnswerOptions { get; set; }

        /// <summary>
        /// Правильные ответы.
        /// </summary>
        public List<Answer> RightAnswers { get; set; }


        public Question(string questionText,
                        List<Answer> answerOptions,
                        List<Answer> rightAnswers)
        {
            QuestionText = questionText;
            AnswerOptions = answerOptions;
            if (CheckRightAnswer(rightAnswers))
            {
                RightAnswers = rightAnswers;
            }
            else
            {
                throw new ArgumentException("Правильные ответы должны содержаться во всех ответах!");
            }
            
        }

        private bool CheckRightAnswer(List<Answer> rightAnswers)
        {
            foreach (var right in rightAnswers)
            {
                if(!AnswerOptions.Contains(right))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
