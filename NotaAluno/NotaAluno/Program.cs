using System;

namespace NotaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcMedia calcmedia = new CalcMedia();

            Console.WriteLine("Digite o nome do aluno: ");
            calcmedia.NomeAluno = Console.ReadLine();

            Console.WriteLine("Digite a nota do primeiro trimestre: ");
            calcmedia.Nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do segundo trimestre: ");
            calcmedia.Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do terceiro trimestre: ");
            calcmedia.Nota3 = double.Parse(Console.ReadLine());

            calcmedia.CalcNotaFinal();
            
        }
    }
}
