using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Вариант 10
Дана строка.Словом текста считается любая последовательность цифр; между
соседними словами - не менее одного пробела, за последним словом - точка. Поменять
местами в строке первое и последнее слово.
*/
namespace _3_2_10
{
    internal class Program
    {
        static string myString;
        static string FirstSecond(string myString)
        {
            char[] sep = { ' ', '.' };
            string[] myWords = Program.myString.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            (myWords[myWords.Length - 1], myWords[0]) = (myWords[0], myWords[myWords.Length - 1]);

            Program.myString = "";
            for (int i = 0; i < myWords.Length; i++)
                Program.myString += myWords[i] + " ";

            return Program.myString;
        }

        static void Main(string[] args)
        {
            myString = "Первое было, а стало Последнее.";                        
            Console.WriteLine(FirstSecond(myString));
            Console.ReadKey();
        }
    }
}
