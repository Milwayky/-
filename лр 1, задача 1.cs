using System;
public class Program1
{
      public static void Main()
      {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            (a, b) = (b, a);
            Console.WriteLine(a);
            Console.WriteLine(b);
      }
}
