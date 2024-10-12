using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class Test
    {
        private string _subject;
        private string _description;
        private Question[] _questions;

        public string GetSubject { get; }
        public string[] GetDescription { get; }
        public Question[] GetQuestions { get; }

        public Test(string subject, string description, Question[] questions)
        {
            _subject = subject;
            _description = description;
            _questions = questions;
        }
    }
}
