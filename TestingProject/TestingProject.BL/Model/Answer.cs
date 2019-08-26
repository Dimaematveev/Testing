using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.BL.Model
{
    /// <summary>
    /// Ответ.
    /// </summary>
    public class Answer
    {
        

        /// <summary>
        /// Текст ответа.
        /// </summary>
        public string QuestionText { get; set; }

        public Answer(string questionText)
        {
            QuestionText = questionText;
        }
    }
}
