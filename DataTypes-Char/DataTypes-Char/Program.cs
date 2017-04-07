using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = char.MinValue;
                int charMax = char.MaxValue;
            char myVar = 'G';
            int myVarValue = 'G';
            char myvarvalue2 = Convert.ToChar(myVarValue);
            Console.WriteLine("Min Char = {0} Max Cahr = {1} My Character = {2} my variable Number = {3} my conversion = {4} ", charMin, charMax, myVar, myVarValue , myvarvalue2);


            string mystring = "this is my variable";
            Console.WriteLine("\nmy string is  {0}", mystring);

            bool myBool = true;
            Console.WriteLine("\n my boolean value is {0}", myBool);

            Console.ReadKey();
        }
    }
}
