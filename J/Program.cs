using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string[] mas = s.Split();
        int[] res = new int[mas.Length];
        int k = 0;

        for (int i = 0; i < mas.Length; i++)
        {
            for (int j = i + 1; j < mas.Length; j++)
            {
                k++;
                if (int.Parse(mas[i]) < int.Parse(mas[j]))
                {
                    res[i] = k;
                    k = 0;
                    break;
                }
            }
        }

        foreach (var el in res)
        {
            Console.Write($"{el} ");
        }
    }
}