using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        
        double a = Convert.ToDouble(input[0]);
        double b = Convert.ToDouble(input[1]);
        double c = Convert.ToDouble(input[2]);
        double d = Convert.ToDouble(input[3]);

        if (a > 0 && b > 0 && c > 0 && d > 0)
        {
            if (
                ((a == b) && (c == d)) || 
                ((a == c) && (b == d)) || 
                ((a == d) && (b == c))
                )
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        else
        {
            Console.WriteLine("NO");
        }

    }
}