using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PracticeIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte firstNumber = -100;
            byte secondNumber = 128;
            short thirdNumber = -3540;
            ushort fourthNumber = 64876;
            uint fifthNumber = 2147483648;
            int sixthNumber = -1141583228;
            ulong seventhNumber = 12233372036854775808;
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
            Console.WriteLine(fourthNumber);
            Console.WriteLine(fifthNumber);
            Console.WriteLine(sixthNumber);
            Console.WriteLine("-" + seventhNumber);
        }
    }
}
