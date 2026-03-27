using System;
using System.Text;

namespace Net_technology_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.WriteLine("---------- Завдання 1. Калькулятор ----------\n");

            Calculator calc = new Calculator();

            Console.WriteLine($"8/0 = {calc.Divide(8, 0)}\n");
            Console.WriteLine($"8/4 = {calc.Divide(8, 4)}\n");

            Console.WriteLine("--------- Завдання 2. Зчитування файлів ----------\n");
            
            FileReader reader = new FileReader();

            Console.WriteLine("Зчитування файлу TextFile1.txt.");
            Console.WriteLine(reader.ReadFile("TextFile1.txt"));

            Console.WriteLine("Зчитування файлу TextFile22.txt.");
            Console.WriteLine(reader.ReadFile("TextFile22.txt"));

            Console.WriteLine("---------- Завдання 3. Пошук середнього значення ----------\n");

            ArrayProcessor processor = new ArrayProcessor();

            int[] validArray = { 1, 2, 3, 4 };
            Console.WriteLine("Середнє значення масиву {1, 2, 3, 4}: " + processor.Process(validArray) + "\n");

            int[] emptyArray = { };
            Console.WriteLine("Результат для порожнього масиву: " + processor.Process(emptyArray) + "\n");

            int[] nullArray = null;
            Console.WriteLine("Результат для null масиву: " + processor.Process(nullArray) + "\n");

            Console.ReadLine();
        }
    }
}