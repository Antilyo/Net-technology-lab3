using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_technology_lab3
{
    internal class Calculator
    {
        public int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Помилка! Ділення на 0 неможливе!");
                return 0;
            }
            finally
            {
                Console.WriteLine("Операція ділення завершена");
            }
        }
    }
}
