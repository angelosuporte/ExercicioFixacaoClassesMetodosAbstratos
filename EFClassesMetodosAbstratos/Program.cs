using System;
using System.Globalization;
using EFClassesMetodosAbstratos.Entities;
using System.Collections.Generic;


namespace EFClassesMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> lista = new List<Contribuinte>();

            Console.Write("Informe o número de contribuintes: ");
            int contribuinte = int.Parse(Console.ReadLine());
            for (int i = 1; i <= contribuinte; i++)
            {
                Console.WriteLine($"Informe os dados do contribuinte #{i}: ");
                Console.Write("Pessoa Física ou Jurídica (f/j)? ");
                char pessoa = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());
                if (pessoa == 'f')
                {
                    Console.Write("Informe os gastos com saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new PessoaFisica(nome, rendaAnual, gastosSaude)); 
                }
                else if (pessoa == 'j')
                {
                    Console.Write("Informe o número de funcionários: ");
                    int numeroDeFuncionarios = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaJuridica(nome, rendaAnual, numeroDeFuncionarios));
                }
            }
            Console.WriteLine();
            double soma = 0.0;
            Console.WriteLine("Imposto pago: ");
            foreach (Contribuinte tp in lista)
            {
                double imposto = tp.imposto();
                Console.WriteLine(tp.Nome + ": $" + imposto.ToString("F2", CultureInfo.InvariantCulture));
                soma += imposto;
            }
            Console.WriteLine();
            Console.WriteLine("IMPOSTO TOTAL: %" + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
