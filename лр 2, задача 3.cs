using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int mmax1 = 2;
        int mmax2 = 1;
        for (int i = 0; i < n; i++)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > mmax1)
            {
                mmax2 = mmax1;
                mmax1 = a;
            }
            else if(a > mmax2)
            {
                mmax2 = a;
            }
            else
            {
                continue;
            }

        }
        Console.WriteLine($"Второй максимальный элемент: {mmax2}");
    }
}
