using System;
                    
public class Program
{
    delegate int DelegateElem(Random rnd);    
    delegate void AverageDelegate(DelegateElem[] arrayX);
    
    public static void Main()
    {
        Random rnd = new Random();
        Console.WriteLine("Enter the amount of numbers: ");
        int num = Convert.ToInt32(Console.ReadLine());
        DelegateElem[] delegateArr = new DelegateElem[num];
        
        int x = 0;
        for(int i = 0; i < delegateArr.Length; i++)
        {
            delegateArr[i] = RandomValue;
        }
        Console.WriteLine();

        AverageDelegate averageDel = delegate(DelegateElem[] arrayX)
        {    
            int sum = 0;            
            
            foreach(DelegateElem elem in arrayX)
            {
                x = elem.Invoke(rnd);
                Console.Write(" " + x + " ");
                sum += x;
            }
            Console.WriteLine();
            Console.WriteLine("Average: {0}", sum/(arrayX.Length*1.0));            
        };
        
        averageDel(delegateArr);
        Console.ReadLine();
    }
    
    private static int RandomValue(Random rnd)
    {
        int result = rnd.Next(-1024, 1024);
        return result;
    }
    
}
