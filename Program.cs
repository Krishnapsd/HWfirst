using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int firstNo;
                int secondno;
                int sumVal;
                int subVal;
                int multVal;
                double divVal;
                int remVal;

                Console.WriteLine("Enter Your Number: ");
                firstNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Your Second Number: ");
                secondno = Convert.ToInt32(Console.ReadLine());
                sumVal = firstNo + secondno;
                Console.WriteLine("Addition is: " + sumVal);
                subVal = firstNo - secondno;
                Console.WriteLine("Substraction is: " + subVal);
                multVal = firstNo * secondno;
                Console.WriteLine("Multiply is: " + multVal);
                divVal = (double)firstNo / secondno;
                Console.WriteLine("Division is: " + divVal);
                remVal = firstNo % secondno;
                Console.WriteLine("Remainder is: " + remVal);
                Console.ReadLine();

            

        }
    }
}

