using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onditional__practice
{
    class Program
    {
        static void Main(string[] args)

        {
            int userAge;

            Console.WriteLine("What Is your age");

            userAge = int.Parse(Console.ReadLine());


            if(userAge >= 17)
            {
                Console.WriteLine(userAge + "  can go see movie ");

            }
            else
            {
                Console.WriteLine(userAge + " you cannot see movie ");
            }




            
            

        }
    }
}