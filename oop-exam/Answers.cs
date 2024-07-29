using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam
{
    public class Answers
    {

        //fields
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        //constructors
        public Answers(int _id, string _text)
        {
            AnswerId = _id;
            AnswerText = _text;
        }

        //methods
        public override string ToString()
        {
            return $"AnswerId: {AnswerId}, AnswerText: {AnswerText}";
        }
    }
}
