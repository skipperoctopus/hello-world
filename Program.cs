using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5

{ //проверка на число Армстронга
    class Program

    {
        static bool isNumberArmstrong(int numb){
            int sum = 0;
            int rem;
            for (int i = numb; i > 0; i = i / 10)
            {
                rem = i % 10;
                sum += rem * rem * rem;
            }

            if (sum == numb)
                return true;
            else
                return false;

        }

        static void Main(string[] args)
        {
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                for (int i = a; i < b; i++)
                {
                    if (isNumberArmstrong(i))

                        Console.WriteLine(i + " ");

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error");


            }


            string hey = Console.ReadLine();


        }
    }
}
