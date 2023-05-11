using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Simples.Equacoes
{
    class Menus
    {
        #region Menu
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual operação você deseja efetuar?");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Resto");
            Console.WriteLine("6 - sair");

            Console.WriteLine();

            Console.Write("Nº: ");
            int valor = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Clear();

            switch (valor)
            {
                case 1:
                    Soma soma = new Soma();
                    Console.WriteLine("Após escolher qual operação calcular" +
                        "\nVocê deverá colocar o simbolo da operação" +
                        "\nque escolheu para calcular\n" +
                        "Ex: \u002210+10\u0022");
                    Console.WriteLine();
                    Console.Write("_Nº: ");
                    string[] valores = Console.ReadLine().Split('+');//Recorte de cada valor nas suas posição
                    double[] x = Array.ConvertAll(valores, double.Parse);//Convete os valores da variavel "valores" para double
                    soma._soma(x);
                    Console.WriteLine(soma);
                    Console.ReadLine();
                    Menu();
                    break;
                case 2:
                    Subtracao subtrair = new Subtracao();
                    Console.WriteLine("Após escolher qual operação calcular" +
                        "\nVocê deverá colocar o simbolo da operação" +
                        "\nque escolheu para calcular\n" +
                        "Ex: \u002210-10\u0022");
                    Console.Write("_Nº: ");
                    valores = Console.ReadLine().Split('-');//Recorte de cada valor nas suas posição
                    x = Array.ConvertAll(valores, double.Parse);//Convete os valores da variavel "valores" para double
                    subtrair._subtracao(x);
                    Console.WriteLine(subtrair);
                    Console.ReadLine();
                    Menu();
                    break;
                case 3:
                    Divisao divisao = new Divisao();
                    Console.WriteLine("Após escolher qual operação calcular" +
                        "\nVocê deverá colocar o simbolo da operação" +
                        "\nque escolheu para calcular\n" +
                        "Ex: \u002210/10\u0022");
                    Console.Write("_Nº: ");
                    valores = Console.ReadLine().Split('/');//Recorte de cada valor nas suas posição
                    x = Array.ConvertAll(valores, double.Parse);//Convete os valores da variavel "valores" para double
                    divisao._divisao(x);
                    Console.WriteLine(divisao);
                    Console.ReadLine();
                    Menu();
                    break;
                case 4:
                    Multiplicacao multiplicar = new Multiplicacao();
                    Console.WriteLine("Após escolher qual operação calcular" +
                        "\nVocê deverá colocar o simbolo da operação" +
                        "\nque escolheu para calcular\n" +
                        "Ex: \u002210*10\u0022");
                    Console.Write("_Nº: ");
                    valores = Console.ReadLine().Split('*');//Recorte de cada valor nas suas posição
                    x = Array.ConvertAll(valores, double.Parse);//Convete os valores da variavel "valores" para double
                    multiplicar._multiplicar(x);
                    Console.WriteLine(multiplicar);
                    Console.ReadLine();
                    Menu();
                    break;
                case 5:
                    Resto resto = new Resto();
                    Console.WriteLine("Após escolher qual operação calcular" +
                        "\nVocê deverá colocar o simbolo da operação" +
                        "\nque escolheu para calcular\n" +
                        "Ex: \u002210%10\u0022");
                    Console.Write("_Nº: ");
                    valores = Console.ReadLine().Split('%');//Recorte de cada valor nas suas posição
                    x = Array.ConvertAll(valores, double.Parse);//Convete os valores da variavel "valores" para double
                    resto._resto(x);
                    Console.WriteLine(resto);
                    Console.ReadLine();
                    Menu();
                    break;
                case 6:
                    System.Environment.Exit(0); // Fecha a Aplicação
                    break;
                default:
                    Menu();
                    break;
            }

        }
        #endregion
    }
}
