using System;

namespace quiz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }

        //Verilmiş sözün tərsdən oxunuşunun özü ilə eyni olub olmadığnı tapan metod
        static string GivenWord(string word)
        {
            string text = "";

            for (int i=0 ; i < word.Length-1; i++)
            {
                text+= word[i];
            }
            
            
            if (word ==text )
            {
                Console.WriteLine("Eynidir");
            }
            else
            {
                Console.WriteLine("Eyni deyil");
            }
        }

        //Verilmiş array-dən verilmiş indexli elementi silən metod.

        static string DeleteGivenOne(string[] text)
        {

        }

        //Verilmiş yazının əvvəlindəki boşluqları silən metod

        static string DeleteSpace(string text)
        {
            string text1 = "";

        }

    }
}
