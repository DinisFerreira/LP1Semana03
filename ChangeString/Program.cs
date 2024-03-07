using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("por favor escreva uma string:");
            string str = Console.ReadLine();

            Console.Write("por favor escolha um caráter:");
            char letter = char.Parse(Console.ReadLine());
             
             foreach (char chare in str)
            {
                
                if (chare == letter)
                {
                    Console.Write('X');
                }
                 
                else
                {
                    Console.Write(chare);

        }
    }
}
