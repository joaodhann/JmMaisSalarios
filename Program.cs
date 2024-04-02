using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JmMaisSalarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            int cont = 0;
            string rsp;
            Console.WriteLine("Deseja começar? (S/N)");
            rsp = Console.ReadLine().ToUpper();
            while (rsp == "S")
            {
                Console.WriteLine("Qual a forma de contratação do funcionário [A-Assalariado,H-Horista,C-Comissado]");
                string rsp2 = Console.ReadLine().ToUpper();
                switch (rsp2)
                {
                    case "A":
                        Console.WriteLine("Informe o valor do salário: ");
                        double sal = double.Parse(Console.ReadLine());

                        Console.WriteLine("Qual o valor do desconto: ");
                        double de = double.Parse(Console.ReadLine());
                        double sbrt = sal - de;
                        Console.WriteLine("O salário bruto do funcionário é de: " + sbrt.ToString("C"));
                        cont++;
                        total += sbrt;
                        break;

                    case "H":
                        Console.WriteLine("Digite o valor por hora: ");
                        double vh = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
                        int qh = int.Parse(Console.ReadLine());

                        sbrt = qh * vh;
                        Console.WriteLine("Salário bruto do funcionário é de: " + sbrt.ToString("C"));
                        cont++;
                        total += sbrt;
                        break;
                    case "C":
                        Console.WriteLine("Digite o valor que o funcionário ganha por peça: ");
                        double vpp = double.Parse(Console.ReadLine());
                        Console.WriteLine("Quantidade de peças que o funcionário vendeu: ");
                        int qpp = int.Parse(Console.ReadLine());

                        sbrt = qpp * vpp;
                        Console.WriteLine("O salário bruto do funcionário é de: " + sbrt.ToString("C"));
                        cont++;
                        total += sbrt;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("Deseja continuar: ");
                rsp = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("A quantidade de funcionários cadastrados é: " + cont);
            Console.WriteLine("O total da folha de pagamento é: " + total.ToString("C"));
            Console.WriteLine("A média salarial é de: " + (total / cont).ToString("C"));
            Console.ReadKey();
        }
    }
}
