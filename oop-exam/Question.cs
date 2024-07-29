using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam
{
    public abstract  class Question
    {
        //fields
        public string Header {  get; set; }
        public string Body { get; set; }
        public int Mark {  get; set; }
        public  Answers[] AnswerList {  get; set; }
        public Answers[] userAnswers { get; set; }
        public Answers RightAnswer { get; set; }
        
        //constructors

        public Question() { }
        public Question(string _header, string _body, int _mark)
        {
            Header = _header;
            Body = _body;
            Mark = _mark;
            AnswerList = new Answers[3];
        }
        public abstract void ShowQuestion();
        public abstract bool CheckAnswer(Answers answer);

        
       

        //public abstract bool CheckAnswer(Answers answer);

        //public void addAnswers(int index ,Answers answer) 
        //{
        //    AnswerList[index] = answer;
        //}

        //public void AddRightAnswer(Answers answer)
        //{
        //    RightAnswer = answer;
        //}
        // methods


    }
}
