using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //проверка строки на количество одинаковых букв
            /*string str =  "аргентина манит негра";
            char a = 'а';
            char e = 'е';
            int suma = 0;
            int sume = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == a)
                {
                    suma = suma + 1;
                }

                if (str[i] == e)
                {
                    sume = sume + 1;
                }
            }
            if (suma > sume)
            {
                Console.WriteLine($"Букв а в данной строке больше. Количество букв равно {suma}");
            }
            if (sume > suma)
            {
                Console.WriteLine($"Букв е в данной строке больше. Количество букв равно {sume}");
            }
            Console.ReadLine();*/

            //проверка строки на уникальные символы
            /*Console.Write("Введите слово: ");
            string text = Console.ReadLine();

            Dictionary<char, int> dictionarys = text.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            foreach (KeyValuePair<char, int> keyValuePair in dictionarys)
            {
                Console.WriteLine("{0}: {1}", keyValuePair.Key, keyValuePair.Value); 
            }
            Console.ReadLine();*/
            
             //проверка строки на палиндромность
             /*string str = "Аргентина манит негра";
             str = str.ToLower().Replace(" ", string.Empty);
             char[] str1 = str.ToCharArray();
             Array.Reverse(str1);
             string str2 = new string(str1);

             if(str2 == str)
             {
                 Console.WriteLine("Строка является палиндромом.");
             }
             else
             {
                 Console.WriteLine("Строка не является палиндромом.");
             }
             Console.ReadLine();*/

            //посчитать кол-во цифр
            /*string str = "2'5fZeA3y9oW";
            Console.WriteLine(str.Count(x => char.IsDigit(x)));
            Console.ReadLine();*/
        }
    }
}