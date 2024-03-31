using System;

namespace NotaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine("Digite a nota do primeiro trimestre: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do segundo trimestre: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do terceiro trimestre: ");
            double nota3 = double.Parse(Console.ReadLine());

            int peso1 = 30;
            int peso2 = 35;
            int peso3 = 35;

            double notaFinal = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);
            double notaPesoFinal = notaFinal * 100;

            Console.WriteLine("A nota final é: " + notaFinal);

            if (notaPesoFinal >= 600)
            {
                Console.WriteLine("Aprovado.");
            } else
            {
                double notaRecuperacao = ((600 - notaPesoFinal) * 10) / 1000;
                Console.WriteLine($"Reprovado. \nFaltam {notaRecuperacao.ToString("F2")} pontos para ser aprovado.");
            }
        }
    }
}
