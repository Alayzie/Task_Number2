using System;

namespace TAM_Task_02
{
    class Program
    {
        static void Main(string[] args)

        {
            string Word;

            Console.WriteLine("Данная программа позволяет вам вводить любые слова до тех пор, пока вы не введёт 'exit' ");

            do
            {
                Console.WriteLine("==============================================================================================================");
                Word = Convert.ToString(Console.ReadLine());
            }
            while (Word != "exit");

            Console.WriteLine("\n");
            Console.WriteLine("==============================================================================================================");
            Console.WriteLine("'Exit' введён! Окончание программы...");
            Console.WriteLine("==============================================================================================================");
        }
    }
}