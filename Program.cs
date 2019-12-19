using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citys
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Kharkv=1431000,350;Kiev=2804000,839;Las Vegas=603400,352";

            string[] split = str.Split(';', ',', '=');

            int count = 1;

            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == ';')
                {
                    count++;
                }

            }

            string[] split6 = new string[count];
            int p = 0;
            for (int j = 0; j < count; j++)

            {
                split6[j] = split[p];
                p = p + 3;
            }

            string[] split2 = new string[count];
            int k = 0;
            for (int j = 0; j < count; j++)

            {
                split2[j] = split[k];
                k = k + 3;
            }

            string tmp;
            for (int i = 0; i < count - 1; i++)

            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (split2[j + 1].Length > split2[j].Length)

                    {
                        tmp = split2[j + 1];
                        split2[j + 1] = split2[j];
                        split2[j] = tmp;
                    }

                }


            }
          
            int[] split3 = new int[count];
            int l = 1;
            for (int j = 0; j < count; j++)

            {
                split3[j] = Convert.ToInt32(split[l]);
                l = l + 3;
            }

            int tmp1;
            for (int i = 0; i < count - 1; i++)

            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (split3[j + 1] > split3[j])

                    {
                        tmp1 = split3[j + 1];
                        split3[j + 1] = split3[j];
                        split3[j] = tmp1;
                    }

                }

            }

            string outcity = Convert.ToString(split3[0]);
            for (int i = 0; i < split.Length; i++)
            {
                if (string.Equals(outcity, split[i]))
                {
                    Console.WriteLine("Most populated:" + split[i - 1] + '(' + outcity + " people)");
                    break;
                }
            }

            Console.WriteLine("Longest name:" + split2[0] + '(' + split2[0].Length + " letters )");

            int[] split5 = new int[count];
            int m = 1;
            for (int j = 0; j < count; j++)

            {
                split5[j] = Convert.ToInt32(split[m]);
                m = m + 3;
            }

            int[] split4 = new int[count];
            int n = 2;
            for (int j = 0; j < count; j++)

            {
                split4[j] = Convert.ToInt32(split[n]);
                n = n + 3;
            }

            double[] dencity = new double[count];
            for (int denc = 0; denc < count; denc++)

            {
                dencity[denc] = Convert.ToDouble(split5[denc]) / Convert.ToDouble(split4[denc]);
            }
            Console.WriteLine("Dencity :");


            for (int i = 0; i < count; i++)

            {
                Console.WriteLine(split6[i] + '-' + string.Format("{0:N2}", dencity[i]));
                Console.WriteLine();
            }

            int tmp2;
            for (int i = 0; i < count - 1; i++)

            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (split4[j + 1] > split4[j])

                    {
                        tmp2 = split4[j + 1];
                        split4[j + 1] = split4[j];
                        split4[j] = tmp2;
                    }

                }

            }
            
            Console.ReadKey();
        }
    }
}
