using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula06CondicoesParte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mes;
            int dia;
            int periodoAuxiliar;
            string periodo;

            Console.WriteLine("Bem-vindo ao AeroEdu, seu programa de venda de passagens aéreas!\n");
            Console.WriteLine("8 - Agosto");
            Console.WriteLine("9 - Setembro");
            Console.WriteLine("10 - Outubro");
            Console.Write("Selecione um dos meses para realizar sua viagem: ");
            mes = int.Parse(Console.ReadLine());

            if ((mes > 10) || (mes < 8))
            {
                Console.Clear();
                Console.WriteLine("Mês inválido!");
                Console.WriteLine("Reiniciando o  programa...\n");
                Main(null);
                return;
            }

            Console.WriteLine("Agora vamos escolher o dia da sua viagem...");
            Console.WriteLine("Temos dias disponíveis entre 6 e 21");
            Console.Write("Insira o dia que você deseja realizar a viagem: ");
            dia = int.Parse(Console.ReadLine());

            if ((dia > 21) || (dia < 6))
            {
                Console.Clear();
                Console.WriteLine("Dia inválido!");
                Console.WriteLine("Reiniciando o  programa...\n");
                Main(null);
                return;
            }

            Console.WriteLine("Estamos quase acabando, agora so falta saber o período que ocorrerá sua viagem");
            Console.WriteLine("1 - Tarde");
            Console.WriteLine("2 - Manhã");
            Console.WriteLine("3 - Noite");
            Console.Write("Insira o período que você deseja realizar a viagem: ");
            periodoAuxiliar = int.Parse(Console.ReadLine());

            if ((periodoAuxiliar > 3) || (periodoAuxiliar < 1))
            {
                Console.Clear();
                Console.WriteLine("Periodo inválido!");
                Console.WriteLine("Reiniciando o  programa...\n");
                Main(null);
                return;
            }

            if (periodoAuxiliar == 1 )
            {
                periodo = "Tarde";
            }
            else if (periodoAuxiliar == 2)
            {
                periodo = "Manhã";
            }
            else
            {
                periodo = "Noite";
            }

            Console.WriteLine("\nSua passagem foi comprada com sucesso!");
            Console.WriteLine("Aqui está seu recibo\n");

            Console.WriteLine("_____RECIBO_____");
            Console.WriteLine("Empresa: AeroEdu");
            Console.WriteLine($"Dia: {dia}");
            Console.WriteLine($"Mês: {mes}");
            Console.WriteLine($"Período: {periodo}");
            Console.WriteLine("________________");

            Console.WriteLine("\nFIM");

            Console.ReadKey();

        }
    }
}
