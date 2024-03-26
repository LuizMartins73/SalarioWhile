using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sl1 = 0;
            double sl2 = 0;
            double ir = 0;
            Console.WriteLine("Insira o tipo de contração: A = Assalariado , B = Comissionado , C = Horista");
            string tipo = Console.ReadLine();
            int continuar = 1;
            double qtdfp = 0;
            int funcionarios = 0;


            while (continuar == 1) { 

            switch (tipo)
            {

                case "A":
                    Console.WriteLine("Insira o salário: ");
                    double sl = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o desconto: ");
                    double dsc = double.Parse(Console.ReadLine());
                    sl1 = sl - dsc;
                    break;
                case "B":
                    Console.WriteLine("Insira a quantidade de peças produzidas: ");
                    int qtdPcs = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o valor de cada peça: ");
                    double vlp = double.Parse(Console.ReadLine());
                    sl1 = qtdPcs * vlp;
                    break;
                case "C":
                    Console.WriteLine("Insira a quantidade de horas trabalhadas: ");
                    double qtdh = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o valor da hora: ");
                    double vlh = double.Parse(Console.ReadLine());
                    sl1 = vlh * qtdh;
                    break;
                default:
                    Console.WriteLine("OPÇÃO INVÁLIDA. Por favor, certifique-se de digitar A, B ou C conforme cada tipo de contratação: ");
                    break;

            }
            if (sl1 < 2000.01)
            {
                sl2 = sl1 - (sl1 * 0.075);
            }
            else if (sl1 < 4000.01)
            {
                sl2 = sl1 - (sl1 * 0.12);
            }
            else
            {
                sl2 = sl1 - (sl1 * 0.15);
            }

            Console.WriteLine("O seu salário liquído é: R$" + sl2);
                funcionarios = funcionarios + 1;
                qtdfp = qtdfp + sl2;

                Console.WriteLine("O total da folha de pagamento é de R$" + qtdfp + " e o total de funcionários cadastrados é de: "+ funcionarios);


                Console.WriteLine("Você deseja repetir novamente? 1 = sim, 0 = não");
                continuar = int.Parse(Console.ReadLine());

                
            }
            Console.ReadKey();
        }
    }
}