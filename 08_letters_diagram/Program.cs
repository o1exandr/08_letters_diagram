/*
 Завдання 8. Дано текст. Вивести статистику  зустрічі у тексті лат букв у вигляді гістограми
(цикл по буквах алфавіту, Count(лямбда))
 */

using System;
using System.Linq;

namespace _08_letters_diagram
{
    class Program
    {
        static void Gistoram(string text)
        {
            int cnt;
            Console.WriteLine(text);
            for (int i = 97; i < 123; i++)
            {
                cnt = text.Count(x => (x == Convert.ToChar(i)) || x == Convert.ToChar(i - 32));
                if (cnt != 0)
                { 
                    Console.Write($"{Convert.ToChar(i)}: {cnt}\t");
                    for (int k = 0; k < cnt; k++)
                        Console.Write("|");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Gistoram("The quick brown fox jumps over the lazy dog");
            Gistoram("The grass is always greener on the other side of the fence");          
        }
    }
}
