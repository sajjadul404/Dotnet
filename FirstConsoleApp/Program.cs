using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;
class Test
{
    public static void Main(string[] args)
    {
       double salary = 4999.50;
       Console.WriteLine("Salary: $" + salary);

       int salary2 = (int)salary;
         Console.WriteLine("Salary2: $" + salary2);
    }
}