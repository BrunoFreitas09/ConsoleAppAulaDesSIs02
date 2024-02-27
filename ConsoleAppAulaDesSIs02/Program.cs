using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

            //é possivel fazer declarando primeiro as variaveis primeiros,vc usa o double e escreve as
            //variaveis separando -as com virgulas

            Console.WriteLine("Escreva quanto está o Litro do combustível: ");
            double gasolina = double.Parse( Console.ReadLine() );

            Console.WriteLine("Escreva quantos Km o carro faz por Litro: ");
            double km = double.Parse( Console.ReadLine() );

            Console.WriteLine("Qual a distância percorrida: ");
            double dist = double.Parse( Console.ReadLine() );

            double ValorViagem = (dist / km) * gasolina ;

            Console.WriteLine("O valor da viagem é de: " +  ValorViagem);

            // término do terceiro e exercício e unicio do quarto

            Console.WriteLine("Escreva sua idade em anos: ");
             int anos = int.Parse( Console.ReadLine() );

            Console.WriteLine("Escreva quantos meses passou desde de seu ultimo aniversário: ");
            int meses = int.Parse( Console.ReadLine() );

            Console.WriteLine("Escreva quantos dias se passaram do mes: ");
            int dias = int.Parse( Console.ReadLine() );

            int r3 = (anos * 365) + (meses * 30) + dias;
            Console.WriteLine("seus dias vividos são de: "+ r3);

            //fim do quarto exercicio e inicio do quinto
            //esse ex. é pedido que criemos duas variáveis e troquemos o valor de uma pela outra mas sem mudar as variáveis

            Console.WriteLine("digite um valor para A: ");
            double A = double.Parse( Console.ReadLine() );

            Console.WriteLine("Digite um valor para B: ");
            double b = double.Parse( Console.ReadLine() );
            double c;
            c = A;
             A = b;
            b = c;


            Console.WriteLine("O valor de A é de : "+ A);
            Console.WriteLine("O valor de B é de : " + b);












            Console.ReadKey();








            


        }
    }
}
