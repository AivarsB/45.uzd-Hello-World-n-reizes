using System;

namespace _45.uzd_Hello_World_n_reizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of times to repeat 'Hello World': ");
            int number;
            bool result = int.TryParse(Console.ReadLine(), out number);

            if (result)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine("Hello World");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}
// Izveidot console aplikāciju, kura lietotājam paprasīs, cik reizes ir jāatkārto for cikls.