using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //倒星形三角形
            for(int i = 0; i <= 5; i++)
            {
                int A = 5 - i ;
                string row = new string('*', A);
                Console.WriteLine(row);
            }


        }
    }
}
