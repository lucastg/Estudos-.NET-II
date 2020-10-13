using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_CoversaoOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando proj 4");

            double salario = 1200.50;

            //int variavel de 32 bits
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            //long variavel de 64 bits
            long idade;
            idade = 20000000000000000;
            Console.WriteLine(idade);

            //shot variavel de 16 bits
            short quantidadeProduto;
            quantidadeProduto = 15000;
            Console.WriteLine(quantidadeProduto);

            
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();

        }
    }
}
