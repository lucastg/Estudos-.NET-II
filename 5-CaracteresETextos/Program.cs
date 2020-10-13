using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando proj 5");

            //charcter
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos" + 2020;
            string cursos = 
@".NET
- Java
- JavaScript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursos);



            Console.ReadLine();
        }
    }
}
