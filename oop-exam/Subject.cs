using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam
{
    public class Subject
    {
        //cons

        public Subject(int _id, string _name) 
        {
            id = _id; 
            name = _name;
        }
        //fields
        public int id {  get; set; }
        public string name { get; set; }
        public Exam exam { get; set; }

        public void CreateExam(Exam _exam)
        {
            exam=_exam;
         }
        }
        }
//    Console.WriteLine("Please Enter The Type Of Exam : ( 1 for Practical | 2 for Final)");
//    int.TryParse(Console.ReadLine(), out int examType);

//    Console.WriteLine("Please Enter The Time For Exam (30 min to 180 min");
//    int.TryParse(Console.ReadLine(), out int time);

//    Console.WriteLine("Please Enter The Number Of Questions");
//    int.TryParse(Console.ReadLine(), out int numberOfQues);
//    //ques
//Console.WriteLine("Please Enter The header");
//string header = (Console.ReadLine());

//Console.WriteLine("Please Enter The body");
//string body = (Console.ReadLine());

//Console.WriteLine("Please Enter The mark");
//int.TryParse(Console.ReadLine(), out int mark);





// if (examType == 1)
// {
//   exam =new PracticalExam(time, numberOfQues);

//   Console.WriteLine(exam.Time);
//} 
// else if(examType == 2)
// {
//     exam = new FinalExam(time, numberOfQues);

//     //MCQ mcq = new MCQ(header,body,mark);

//     Answers answer1 = new Answers(1, "True");
//     Answers answer2 = new Answers(2, "False");

//     Question q1 = new MCQ("q1", "whatt is th ?", 3)
//     {
//         AnswerList = new[] { answer1, answer2 },
//         RightAnswer = answer1
//     };
//     exam.questions = new[] { q1 };

//     q1.DisplayQuestion();

//mcq.AnswerList[0].AnswerId = 1;
//mcq.AnswerList[0].AnswerText = "aa";
//mcq.AnswerList[1].AnswerId = 2;
//mcq.AnswerList[1].AnswerText = "vvv";
//mcq.AnswerList[2].AnswerId = 3;
//mcq.AnswerList[2].AnswerText = "rrr";
//Answers ans1 = new Answers(1, "aaa");
//Answers ans2 = new Answers(2, "vvvv");
//Answers ans3 = new Answers(3, "yyyy");

//for(int i = 0;i<exam.NumOfQuestions;i++)
//{
//    string h = Console.ReadLine();
//    string b = Console.ReadLine() ;
//    int.TryParse(Console.ReadLine(), out int m);
//    exam.questions[i] = new MCQ(h, b, m);


//    for (int j = 0; j < 3; j++)
//    {
//        string ans1 = Console.ReadLine();
//        Answers a1 = new Answers(j + 1, ans1);
//        exam.questions[i].AnswerList = new[] { a1};
//    }

