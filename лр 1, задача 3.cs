using System;
public class Program1
{
      public static void Main()
      {
            int l = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int perimetr = 2*(l + m);
            int rasstoyanie = perimetr*n + 2*p*n + l*(n-1)*n;
            Console.WriteLine(rasstoyanie);
      }
}
