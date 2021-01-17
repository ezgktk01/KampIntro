using System;

namespace Months
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "Semptember", "October", "November", "December" };

            foreach (string month in Months)
            {
                Console.WriteLine(month);
            }

            for (int i = 0; i < Months.Length; i++)
            {
                Console.WriteLine(Months[i]);
            }
            Console.ReadLine();

        }
    }
}
