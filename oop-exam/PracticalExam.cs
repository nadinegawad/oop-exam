using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam
{
    public class PracticalExam :Exam
    {
        public PracticalExam() { }
        public PracticalExam(int _time, int _number, Subject _subject) : base(_time, _number, _subject)
        {

        }


        public override void ShowExam()
        {
            foreach (Question question in questions)
            {
                question.ShowQuestion();
               
            }
        }
        public override void ShowResults() { }
    }
}
