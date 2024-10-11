using System;
class HelloWorld
{
  static void Main()
  {
    int n = Convert.ToInt32(Console.ReadLine());
    int MmaxCounter = 0;
    int Counter = 0;
    int Last = -1;
    for (int i = 0; i < n; i++)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0)
        {
            if (a == Last)
            {
                Counter++;
            }
            else
            {
                Last = a;
                Counter = 1;
            }
            MmaxCounter = Math.Max(MmaxCounter, Counter);
        }
        else
        {
            Counter = 0;
        }
    }
    Console.WriteLine(MmaxCounter);
  }
}