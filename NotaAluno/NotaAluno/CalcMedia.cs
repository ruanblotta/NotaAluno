using System;
using System.Collections.Generic;
using System.Text;

namespace NotaAluno
{
    public class CalcMedia
    {
        public string NomeAluno;
        public double Nota1;
        public double Nota2;
        public double Nota3;


        public void Notas(double nota1, double nota2, double nota3)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }
        
        public void CalcNotaFinal()
        {
            int Peso1 = 30;
            int Peso2 = 35;
            int Peso3 = 35;

            double notaFinal = (Nota1 * Peso1 + Nota2 * Peso2 + Nota3 * Peso3) / (Peso1 + Peso2 + Peso3);
            double notaPesoFinal = notaFinal * 100;

           Console.WriteLine("A nota final é: " + notaFinal);
            VerifAprovacao(notaPesoFinal);
        }

        public void VerifAprovacao(double notaPesoFinal)
        {

            if (notaPesoFinal >= 600)
            {
                Console.WriteLine("Aprovado.");
            }
            else
            {
                double notaRecuperacao = ((600 - notaPesoFinal) * 10) / 1000;
                Console.WriteLine($"Reprovado. \nFaltam {notaRecuperacao.ToString("F2")} pontos para ser aprovado.");
            }
        }
    }
}
