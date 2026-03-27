using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_technology_lab3
{
    internal class FileReader
    {
        public string ReadFile(string path)
        {
            try
            {
                string content = File.ReadAllText(path);
                return content;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Помилка зчитування! Файлу {path} не існує!");
                return string.Empty;
            }
            finally
            {
                Console.WriteLine("Операція зчитування файлу завершена.");
            }
        }
    }
}
