using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogsAndLamps
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lamps = new int[100];

            for (int i = 0; i < lamps.Length; i++)
            {
                lamps[i] = i + 1;
            }

            Press(30);
            Console.ReadLine();
            

            void Press(int frogNumber)
            {
                if (frogNumber > 0 && frogNumber <= 100)
                {
                    for (int i = frogNumber; i <= lamps.Length; i += frogNumber)
                    {
                        Console.WriteLine("Frog №{0} pressed lamp №{1}", frogNumber, i);
                    }
                }
                else
                {
                    Console.WriteLine("Frog with such a number is absent");
                }
            }
        }

        
    }
}
