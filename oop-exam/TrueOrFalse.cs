using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam
{
    public class TrueOrFalse : Question
    {
        int userGrade = 0;
        string userAnsewer = "";
        public TrueOrFalse(string _header, string _body, int _mark) : base(_header, _body, _mark)
        {
        }
        public override void ShowQuestion()
        {
            Console.WriteLine($"Title: {Header}:   Mark:{Mark}\n{Body}\n(True|False)");
            userAnsewer = Console.ReadLine();
            
           
        }
        public override bool CheckAnswer(Answers answer)
        {
            return answer.AnswerId == RightAnswer.AnswerId;
        }
    }
}
