using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Int32.TryParse(Console.ReadLine(), out N);
            int[,] array = new int[N, N];
            Random random = new Random();
            int rand;
            int sum = 0;

            {
                {
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            rand = random.Next(1, 3);
                            array[i, j] = rand;
                            Console.Write(array[i, j]);

                        }
                        Console.WriteLine();
                    }
                    {
                        {
                            for (int i = 0; i < N; i++)
                                sum += array[i, i];

                        }
                    }
                    {
                        {
                            for (int i = 0; i < N; i++)
                            {
                                for (int j = 0; j < N; j++)
                                {

                                    if (j == N - i - 1)
                                    {
                                        sum += array[i, j];
                                    }
                                    if (N % 2 != 0 && i == N / 2 + 1 && j == N / 2 + 1)
                                    {
                                        sum -= array[N / 2 + 1, N / 2 + 1];
                                    }
                                }
                            }
                        }
                    }
                }

                Console.Write(sum);
                Console.ReadKey();

            }
        }    }
}
