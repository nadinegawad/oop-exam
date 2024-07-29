using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam
{
    public class MCQ :Question
    {
        public MCQ(string _header, string _body, int _mark):base(_header, _body, _mark)
        {
            
        }
        int userGrade = 0;
        
        
        public override void ShowQuestion()
        {
         
        Console.WriteLine($"Title:{Header}   Mark:{Mark}\n{Body}");

            for(int i = 0;i< AnswerList.Length;i++)
            {
                Console.WriteLine($" {AnswerList[i].AnswerId}: {AnswerList[i].AnswerText}");
            }

            int.TryParse( Console.ReadLine(), out int userAnswerId);
         /// how to store it ?!
  
        }
           public override bool CheckAnswer(Answers answer)
        {
            return answer.AnswerId == RightAnswer.AnswerId;
        }
       
    }
}
