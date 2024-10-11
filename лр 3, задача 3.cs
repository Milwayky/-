using System;
class HelloWorld
{
  static void Main()
  {
    int n = Convert.ToInt32(Console.ReadLine());
    int MmaxSum = 0;
    int Sum = 0;

    
    for (int i = 0; i < n; i++)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0)
        {
            Sum += a;
        }
        else
        {
            MmaxSum = Math.Max(Sum, MmaxSum)
        }
    }
    MmaxSum = Math.Max(Sum, MmaxSum)
    Console.WriteLine(MmaxSum)
  }
}