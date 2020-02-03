using System;


public class Program
{
    delegate double Calc(double x, double y);
    public static void Main()
    {
        double num;
        double status = 0;
        string action;
        Calc addition = (x, y) => { var res = x + y; return res; };
        Calc dif = (x, y) => { var res = x - y; return res; };
        Calc mult = (x, y) => { var res = x * y; return res; };
        Calc division = (x, y) => {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                var res = x / y;
                return res;
            }
        };
        Console.WriteLine(status);
        Console.Write("Enter the number: ");
        status += Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Press the Escape (Esc) key to quit: \n");
        do
        {
            Console.Write("Select an action (+, -, *, /): ");
            action = Console.ReadLine();
            Console.Write("Enter the next number: ");
            num = Convert.ToDouble(Console.ReadLine());
            switch (action)
            {
                case "+":
                    status = addition(status, num);
                    Console.WriteLine(status);
                    break;
                case "-":
                    status = dif(status, num);
                    Console.WriteLine(status);
                    break;
                case "*":
                    status = mult(status, num);
                    Console.WriteLine(status);
                    break;
                case "/":
                    try
                    {
                        status = division(status, num);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Divizion by zero");
                    }
                    finally
                    {
                        Console.WriteLine(status);
                    }
                    break;
                default:
                    Console.WriteLine("Incorrect action");
                    break;
            }
            Console.Write("Press <Escape> to exit or <Enter> to contunue... ");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

    }
}
