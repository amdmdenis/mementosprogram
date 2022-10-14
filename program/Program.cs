using System;
using System.IO;




Console.WriteLine("menu");
Console.WriteLine("1. mementos");
Console.WriteLine("2. save & exit");
int menuSelection = Convert.ToInt32(Console.ReadLine());
switch (menuSelection)
{
    case 1:
        Console.WriteLine("1. view mementos");
        Console.WriteLine("2. add memento");
        Console.WriteLine("3. view mememento");
        Console.WriteLine("4. mark memento as done");
        Console.WriteLine("5. save");
        Console.WriteLine("6. go back");
        int mementosMenuSelection = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        switch (mementosMenuSelection)
        {
            case 1:
                string file = @"A:\codingspace\c#projects\database.txt";
                string[] lines = File.ReadAllLines(file);
                foreach (string ln in lines)
                {
                    Console.WriteLine(ln);
                    i++;
                }
                break;
            case 2:
                string fileSecond = @"A:\codingspace\c#projects\database.txt";
                string[] linesSecond = File.ReadAllLines(fileSecond);
                foreach (string ln in linesSecond)
                {
                    i++;
                }
                Console.WriteLine(i);
                string stringToRead = Console.ReadLine();
                linesSecond[i] = stringToRead;
                File.AppendAllText(fileSecond, linesSecond[i]);

                break;
                
            default: break;
        }
        break;
    default: break;

}
