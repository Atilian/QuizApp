using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Question
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public List<string> Answers { get; set; }

        public Question (int Id, String Label, List<string> Answers)
        {
            this.Id = Id;
            this.Label = Label;
            this.Answers = Answers;
        }

        public List<string> Questions ()
        {
            

            List<string> Questions = new List<string>();

            BDDQuestion getQuestions = new BDDQuestion();

            getQuestions.getBDD(Id);

            return Questions;
        }
    }
}
