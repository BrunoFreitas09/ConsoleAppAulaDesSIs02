using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAulaDesSIs02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome ;
            Console.WriteLine("Digite o seu nome ");
            nome = Console.ReadLine();
            Console.WriteLine("o nome digitado foi: " + nome );
            //termina o primeiro exemplo e começa o segundo 

            Console.WriteLine("Digite o primeiro numero: ");
            int n1 = int.Parse( Console.ReadLine() );

            Console.WriteLine("Digite o segundo número: ");
            int n2 = int.Parse( Console.ReadLine() );

            //criação da variável e processamento 
            int resultado = n1 + n2;

            //saida de dados 
            Console.WriteLine("O resultdo da soma é: " +  resultado);

            // fim do segundo ex e inicio do terceiro

            Console.WriteLine("Escreva quanto está o Litro do combustível: ");
            double gasolina = double.Parse( Console.ReadLine() );

            Console.WriteLine("Escreva quantos Km o carro faz por Litro: ");
            double km = double.Parse( Console.ReadLine() );

            Console.WriteLine("Qual a distância percorrida: ");
            double dist = double.Parse( Console.ReadLine() );

            double ValorViagem = (dist / km) * gasolina ;

            Console.WriteLine("O valor da viagem é de: " +  ValorViagem);
            //










            Console.ReadKey();








            


        }
    }
}
