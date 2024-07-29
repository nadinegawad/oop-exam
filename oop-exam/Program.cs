namespace oop_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject(1, "Math");

            Console.WriteLine("Please Enter The Type Of Exam (1 For Final| 2 For Practical):");
            int.TryParse(Console.ReadLine(), out int examType);

            Console.WriteLine("Please Enter Time For Exam From (30 min to 180 min):");
            int.TryParse(Console.ReadLine(), out int timeOfExam);

            Console.WriteLine("Enter Number of Questions:");
            int.TryParse(Console.ReadLine(), out int numberOfQuestions);
            Exam exam = null;

            if (examType == 1)
            {
                exam = new FinalExam(timeOfExam, numberOfQuestions, subject);
            }
            else if (examType == 2)
            {
                exam = new PracticalExam(timeOfExam, numberOfQuestions, subject);
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            // Create and add questions to the exam
            exam.questions = new Question[numberOfQuestions];
            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine($"Enter Question {i + 1} Header:");
                string header = Console.ReadLine();

                Console.WriteLine($"Enter Question {i + 1} Body:");
                string body = Console.ReadLine();

                Console.WriteLine($"Enter Question {i + 1} Mark:");
                int.TryParse(Console.ReadLine(),out int mark);

                Question question = null;

                if (examType == 1)
                {
                    Console.WriteLine("Enter Question Type ( 1 for True Or False/ 2 for MCQ):");
                    int.TryParse( Console.ReadLine(), out int questionType);

                    if (questionType == 1)
                    {
                        question = new TrueOrFalse(header, body, mark);
                        Console.WriteLine("Enter the ID of the Correct Answer:(1 for True| 0 for False)");
                        int.TryParse(Console.ReadLine(), out int correctAnswerId);
                    }
                    else if (questionType == 2)
                    {
                        question = new MCQ(header, body, mark);
                       
                        question.AnswerList = new Answers[3];

                        for (int j = 0; j < 3; j++)
                        {
                            int answerId = j + 1;
                            Console.WriteLine($"Enter Answer {answerId} Text:");
                            string answerText = Console.ReadLine();

                            question.AnswerList[j] = new Answers(answerId, answerText);
                        }

                        Console.WriteLine("Enter the ID of the Correct Answer:");
                        int.TryParse(Console.ReadLine(),out int correctAnswerId);
                        foreach (Answers answer in question.AnswerList)
                        {
                            if (answer.AnswerId == correctAnswerId)
                            {
                                question.RightAnswer = answer;
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid question type.");
                        continue;
                    }
                }
                else if (examType == 2)
                {
                    question = new MCQ(header, body, mark);
                    Console.WriteLine("Enter Number of Answers:");
                    int numAnswers = int.Parse(Console.ReadLine());
                    question.AnswerList = new Answers[numAnswers];

                    for (int j = 0; j < numAnswers; j++)
                    {
                        Console.WriteLine($"Enter Answer {j + 1} ID:");
                        int answerId = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Enter Answer {j + 1} Text:");
                        string answerText = Console.ReadLine();

                        question.AnswerList[j] = new Answers(answerId, answerText);
                    }

                    Console.WriteLine("Enter the ID of the Correct Answer:");
                    int correctAnswerId = int.Parse(Console.ReadLine());
                    foreach (Answers answer in question.AnswerList)
                    {
                        if (answer.AnswerId == correctAnswerId)
                        {
                            question.RightAnswer = answer;
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid question type.");
                    continue;
                
            }
                exam.questions[i] = question;
            }
            // create the exam
            subject.CreateExam(exam);
            Console.Clear();
            // Show the exam
            subject.exam.ShowExam();
            //show the results
             subject.exam.ShowResults();

            //Subject subject = new Subject(10, "math");
            //subject.CreateExam();
            //Console.WriteLine("=====================");
            //subject.exam.ShowExam();
            //Answers answers = new Answers(1,"qqqq");
            // Answers answers2 = new Answers(2, "aaa");
            // Answers answers3 = new Answers(3, "ddds");
            // MCQ mcq = new MCQ("ff","fffg",3);
            // mcq.addAnswers(0,answers);
            // mcq.addAnswers(1, answers2);
            // mcq.addAnswers(2, answers3);
            // mcq.DisplayQuestion();
        }
    }
}
