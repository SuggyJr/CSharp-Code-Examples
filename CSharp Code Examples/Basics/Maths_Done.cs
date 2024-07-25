using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    class Maths_Done
    {
        //Authors: Alfie Sugden (26584784)
        //simple calculator
        public static void run()
        {
            Console.WriteLine("Piack a number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Piack one of the following operators, + , - , * , / :");
            char op = Console.ReadLine()[0];

            Console.WriteLine("Piack another number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            string n1 = number1.ToString();
            string n2 = number2.ToString();

            switch (op)
            {
                case '+':
                result = number1 + number2;
                break;
                case '-':
                result = number1 - number2;
                break;
                case '*':
                result = number1 * number2;
                break;
                case '/':
                if(number2 !=0)
                result = number1 / number2;
                else
                Console.WriteLine("Cannot divide by zero!");
                break;
                default:
                break;
            }
            
            Console.WriteLine(n1, op, n2, " = ", result);
        }
    }
}