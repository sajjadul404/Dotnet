using System;
using System.Diagnostics;
using System.Security.Cryptography;
class Test
{
    public static void Main(string[] args)
    {
        for(int  i=1; i<=100; i++)
        {
            if (i == 50)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}