using System;

namespace Course12
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Segunda";
                    break;
                case 2:
                    day = "Terça";
                    break;

                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine(day);
        }
    }
}
