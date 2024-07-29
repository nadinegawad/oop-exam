using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam
{
    public class FinalExam : Exam
    {
        public FinalExam() { }
        public FinalExam(int _time, int _number ,Subject _subject):base(_time, _number, _subject)
        {
         
        }
        
        public override void ShowExam()
        {
            foreach (Question question in questions)
            {
                question.ShowQuestion();

            }
        }
        public override void ShowResults() 
        { 
           for(int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"{questions[i].Body}  Right answer : {questions[i].RightAnswer.AnswerText}");
            }
        }

   
    }
}
