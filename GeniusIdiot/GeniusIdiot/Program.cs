using System;

public class MainClass
{
    public static void Main()
    {
        List<string> questions = new List<string>() { "Сколько будет 2 + 2, умноженное на 2", "Бревнонужно распилить на 10 частей. Сколько нужно сделать распилов?", "На двух руках 10 пальцев. Сколько на 5 руках", "Укол делают каждые 30 минут. Сколько нужно минут для трех уколов?", "5 свечей горело, 2 потухли. Сколько свечей осталось?" };
        List<int> rightAnswers = new List<int>() { 6, 9, 25, 60, 2 };
        int RightAnswerscount = 0;
        int answerCount = questions.Count;
        Console.WriteLine("Введи свое имя");
        string userName = Console.ReadLine();
        for (int i = 0; i < questions.Count; i++)
        {
            Random randomQuestion = new Random();
            int randomId = randomQuestion.Next(questions.Count);
            Console.WriteLine(questions[i]);
            int userAnswer = int.Parse(Console.ReadLine());
            if (userAnswer == rightAnswers[i])
            {
                RightAnswerscount++;
            }
            questions.RemoveAt(randomId);
            rightAnswers.RemoveAt(randomId);
        }
        Console.Write(userName + ", поздравляю тебя, твой диагноз - ");
        switch (RightAnswerscount)
        {
            case 0: Console.WriteLine("Идиот!"); break;
            case 1: Console.WriteLine("Кретин!"); break;
            case 2: Console.WriteLine("Дурак!"); break;
            case 3: Console.WriteLine("Нормальный!"); break;
            case 4: Console.WriteLine("Талант!"); break;
            case 5: Console.WriteLine("Гений!"); break;

        }
        Console.WriteLine();
    }
}