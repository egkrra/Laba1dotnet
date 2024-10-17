using Laba1;
using System;

public class Program
{
    public static void Main()
    {
        ResearchTeam team = new ResearchTeam();
        Console.WriteLine(team.ToShortString());

        Console.WriteLine($"Индексатор Year: {team[TimeFrame.Year]}");
        Console.WriteLine($"Индексатор TwoYears: {team[TimeFrame.TwoYears]}");
        Console.WriteLine($"Индексатор Long: {team[TimeFrame.Long]}");

        team.ResearchTopic = "Новая тема исследований";
        team.OrganizationName = "Новая организация";
        team.RegistrationNumber = 12345;
        team.ResearchDuration = TimeFrame.TwoYears;
        Console.WriteLine(team.ToString());

        Person author = new Person("Евгений", "Онегин", new DateTime(1985, 6, 1));
        Paper paper1 = new Paper("Публикация 1", author, new DateTime(2021, 5, 1));
        Paper paper2 = new Paper("Публикация 2", author, new DateTime(2022, 7, 1));
        team.AddPapers(paper1, paper2);
        Console.WriteLine(team.ToString());

        Console.WriteLine($"Самая поздняя публикация: {team.LatestPublication}");

        Console.WriteLine("Введите количество строк и столбцов через разделитель (например, 3 4):");
        string input = Console.ReadLine();
        string[] tokens = input.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

        int nrow = int.Parse(tokens[0]);
        int ncolumn = int.Parse(tokens[1]);

        int totalElements = nrow * ncolumn;

        Paper[] oneDimArray = new Paper[totalElements];
       for (int i = 0; i < totalElements; i++)
        {
            oneDimArray[i] = new Paper();
        }

        Paper[,] twoDimRectArray = new Paper[nrow, ncolumn];
        for (int i = 0; i < nrow; i++)
        {
            for (int j = 0; j < ncolumn; j++)
            {
                twoDimRectArray[i, j] = new Paper();
            }
        }

        Paper[][] jaggedArray = new Paper[nrow][];
        for (int i = 0; i < nrow; i++)
        {
            jaggedArray[i] = new Paper[ncolumn];
            for (int j = 0; j < ncolumn; j++)
            {
                jaggedArray[i][j] = new Paper();
            }
        }

        string newTitle = "Новое название";

        int startOneDim = Environment.TickCount;
        for (int i = 0; i < totalElements; i++)
        {
            oneDimArray[i].Title = newTitle;
        }
        int endOneDim = Environment.TickCount;
        int oneDimTime = endOneDim - startOneDim;

        int startTwoDimRect = Environment.TickCount;
        for (int i = 0; i < nrow; i++)
        {
            for (int j = 0; j < ncolumn; j++)
            {
                twoDimRectArray[i, j].Title = newTitle;
            }
        }
        int endTwoDimRect = Environment.TickCount;
        int twoDimRectTime = endTwoDimRect - startTwoDimRect;

        int startJagged = Environment.TickCount;
        for (int i = 0; i < nrow; i++)
        {
            for (int j = 0; j < ncolumn; j++)
            {
                jaggedArray[i][j].Title = newTitle;
            }
        }
        int endJagged = Environment.TickCount;
        int jaggedTime = endJagged - startJagged;

        Console.WriteLine($"\nВремя выполнения операций:");
        Console.WriteLine($"Одномерный массив: {oneDimTime} мс");
        Console.WriteLine($"Двумерный прямоугольный массив: {twoDimRectTime} мс");
        Console.WriteLine($"Двумерный ступенчатый массив: {jaggedTime} мс");
    }
}
