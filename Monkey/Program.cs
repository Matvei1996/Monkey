using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество обезьян");
            int n = Int32.Parse(Console.ReadLine());

            if ((n >= 1) && (n <= 100))
            {
                int[] A = new int[n];
                int[] B = new int[n];

                Console.WriteLine("Введите координату обезьяны и координату броска");
                string str;


                for (int i = 0; i < n; i++)
                {
                    str = Console.ReadLine();
                    A[i] = Convert.ToInt32(str.Split(' ')[0]);
                    B[i] = Convert.ToInt32(str.Split(' ')[1]);

                    if ((A[i] >= -104) && (A[i] <= 104) && (A[i] >= -104) && (A[i] <= 104))
                    {
                            for (int j = 0; j < n; j++)
                            {

                                if (A[i] == A[j] + B[j] && A[j] == A[i] + B[i])
                                {
                                    Console.WriteLine("Результат: Yes");
                                    Console.ReadKey();
                                    return;
                                }

                            }
                    }
                }
                Console.WriteLine("Результат: No");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Позиция не удовлетворяет начальным условиям");
                Console.ReadKey();
                return;
            }
            
        }
    }
}