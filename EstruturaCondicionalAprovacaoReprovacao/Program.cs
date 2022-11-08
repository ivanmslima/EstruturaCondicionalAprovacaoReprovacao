using System;
using System.Globalization;

namespace Course
{ class Program{
           static void Main(string[] args) {

            double nota1, nota2, soma;

            Console.WriteLine("Entre com a Primeira nota");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com a Segunda nota");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = (nota1 + nota2)/2;

            Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CultureInfo.InvariantCulture));


            if (soma < 60.0) {
                Console.WriteLine("Reprovado");
            }
            else if (soma > 60.0)
            {
                Console.WriteLine("Aprovado!");
            }
            else {
                Console.WriteLine("Recuperação");
            }
           
            Console.ReadLine();

        }
    }
}