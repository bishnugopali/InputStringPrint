using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputStringPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1="";
            Console.WriteLine("Please Enter Something");
            str1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("You Entered following:");
            Console.Write("{0}",str1);

            Console.ReadLine();



        }
    }
}
