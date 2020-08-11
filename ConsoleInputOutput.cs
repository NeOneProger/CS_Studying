using System;

class ConsoleInputOutput
{
    public static void Acquaitance()
    {
        string Name;
        string Answer;

        Console.Title = "Acquaitance";
        Console.WriteLine("What's your name?");
        Name = Console.ReadLine();
        Answer = "Very nice " + Name + ".";
        Console.WriteLine(Answer);
    }

    public static void AgeCount()
    {
        string BrthYear, Answr;
        int year, age, Brthyear;

        Console.Title = "Birth Year";
        Console.WriteLine("What year is it?");
        BrthYear = Console.ReadLine();
        year = Int32.Parse(BrthYear);
        Console.WriteLine("What's your birthyear?");
        BrthYear = Console.ReadLine();
        Brthyear = Int32.Parse(BrthYear);
        age = year - Brthyear;
        Answr = "Then you are " + age + " years old.";
        Console.WriteLine(Answr);
        Console.ReadKey();
    }
}