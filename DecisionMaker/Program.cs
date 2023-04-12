// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

public class Program1
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your name!");
        string name=Console.ReadLine();
       
        bool onGo = true;

        do
        {
            Console.WriteLine($"{name} please enter an integer between 1 and 100: ");
            int num=int.Parse( Console.ReadLine() );
            if (num >= 0 && num<=100)
            {
                MyMethod(num);
                onGo =Continue();
            }
            else
            {
                Console.WriteLine("Enter wrong,let's try again.");
                continue;
            }
        }while(onGo==true);

    }

    static bool Continue()
    {
        Console.WriteLine("would you like to enter again?yes/no");
        string result=Console.ReadLine().ToLower();
        if (result == "yes")
        {
            return true;
        }
        else if (result == "no")
        {
            Console.WriteLine($"Bye!");
            return false;
        }
        else
        {
            Console.WriteLine("Enter wrong,let's try again.");
            return Continue();
        }

    }
    static void MyMethod(int i)
    {

        if (i % 2 == 1 && i < 60)
        {
            Console.WriteLine($"Output: {i} Odd and less than 60.");
        }
        else if (i % 2 == 0 && i <= 24 && i >= 2)
        {
            Console.WriteLine($"Output: {i} Even and less than 25.");
        }
        else if (i % 2 == 0 && i >= 26 && i <= 60)
        {
            Console.WriteLine($"Output: {i} Even and between 26 and 60 inclusive.");
        }
        else if (i % 2 == 0 && i > 60)
        {
            Console.WriteLine($"Output:{i} Even and greater than 60.");
        }
        else if (i % 2 == 1 && i > 60)
        {
            Console.WriteLine($"Output:{i} Odd and greater than 60.");
        }
    }
}