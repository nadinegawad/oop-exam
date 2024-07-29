using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam
{
    public abstract class Exam
    {
        public int Time {  get; set; }
        public int NumOfQuestions { get; set; }
        public Subject Subject { get; set; }
        public Question[] questions { get; set; }

        public Exam() { }
        public Exam(int _time , int _num, Subject _subject)
        {
            Time = _time;
            NumOfQuestions = _num;
            Subject = _subject;
            questions = new Question[0];
        }
  
        public abstract void ShowExam();
        public abstract void ShowResults();
    }
}
