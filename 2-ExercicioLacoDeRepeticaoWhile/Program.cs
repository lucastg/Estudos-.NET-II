using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ExercicioLacoDeRepeticaoWhile
{
    class Program
    {
        public static void Main(String[] args)
        {
            for (int linha = 1; linha <= 5; linha++)
            {
                for (int coluna = 1; coluna <= 5; coluna++)
                {
                    if (coluna > linha)
                    {
                        break;
                    }
                    Console.Write( coluna );
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}