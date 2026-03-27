using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_technology_lab3
{
    internal class ArrayProcessor
    {
        public double Process(int[] numbers)
        {
            try
            {
                if (numbers == null)
                {
                    throw new ArgumentNullException("Помилка! Масив не може бути null.");
                }

                if (numbers.Length == 0)
                {
                    throw new ArgumentException("Помилка! Масив порожній.");
                }

                return numbers.Average();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            finally
            {
                Console.WriteLine("Обробка масиву завершена.");
            }
        }
    }
}
