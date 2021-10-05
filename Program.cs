using System;

namespace ReduceAway
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToReduce;
            do
            {
                Console.WriteLine("Write string that has length between 1 and 100 characters");
                stringToReduce = Console.ReadLine();
                if (stringToReduce.Length < 1) Console.WriteLine("String is too short");
                if (stringToReduce.Length > 100) Console.WriteLine("String is too long");
            } while (stringToReduce.Length < 1 || stringToReduce.Length > 100);
            
            for(int i = 0; i < stringToReduce.Length - 1; i++)
            {
                if(stringToReduce[i] == stringToReduce[i + 1])
                {
                    stringToReduce = stringToReduce.Remove(i, 2);
                    i = -1;
                }
            }
            if (stringToReduce == "") stringToReduce = "Empty String";
            Console.WriteLine(stringToReduce);
        }
    }
}
