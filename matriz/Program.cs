using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int m = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);

            int[,] mat = new int[m, n];


            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }


            int x = int.Parse(Console.ReadLine());

            for (int z = 0; z < m; z++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (mat[z, y] == x)
                    {
                       
                        Console.WriteLine("Position: " + z + ", " + y);
                        if ((y - 1) >= 0)
                        {
                            Console.WriteLine("Left: " + mat[z, (y-1)]);
                        }
                        if (((y + 1) <= (n - 1)))
                        {
                            Console.WriteLine("Right: " + mat[z, (y + 1)]);
                        }
                        if ((z - 1) >= 0)
                        {
                            Console.WriteLine("Up: " + mat[(z - 1), y]);
                        }
                        if ((z + 1) <= (m -1))
                        {
                            Console.WriteLine("Down: " + mat[(z + 1), y]);
                        }

                    }
                }
            }






        }
    }
}
