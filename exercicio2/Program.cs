using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cidade, dia, ano, mes;
            string cc, mestxt;


            Console.WriteLine("1- Atibaia 2- Bragança Paulista 3- Mairiporã 4- Nazaré 5- Terra Preta 6- Extrema 7- vargem ");
            Console.WriteLine("digite o Codigo da Cidade");
            cidade = double.Parse(Console.ReadLine());

            switch (cidade)
            {
                case 1:
                    cc = "Atibaia";
                    break;
                case 2:
                    cc = "Bragança Paulista";
                    break;
                case 3:
                    cc = "Mairiporã";
                    break;
                case 4:
                    cc = "Nazaré";
                    break;
                case 5:
                    cc = "Terra Preta";
                    break;
                case 6:
                    cc = "Extrema";
                    break;
                case 7:
                    cc = "Vargem";
                    break;

                default:
                    cc = " Codigo da Cidade invalido";
                    break;
            }
            Console.WriteLine("digite o Dia");
            dia = double.Parse(Console.ReadLine());


            Console.WriteLine("digite o Mes");
            mes = double.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    mestxt = "Janeiro";
                    break;
                case 2:
                    mestxt = "Fevereiro";
                    break;
                case 3:
                    mestxt = "Março";
                    break;
                case 4:
                    mestxt = "Abril";
                    break;
                case 5:
                    mestxt = "Maio";
                    break;
                case 6:
                    mestxt = "Junho";
                    break;
                case 7:
                    mestxt = "Julho";
                    break;
                case 8:
                    mestxt = "Agosto";
                    break;
                case 9:
                    mestxt = "Setembro";
                    break;
                case 10:
                    mestxt = "Outubro";
                    break;
                case 11:
                    mestxt = "Novembro";
                    break;
                case 12:
                    mestxt = "Dezembro";
                    break;
                default:
                    mestxt = "Mes invalido";
                    break;
            }

            Console.WriteLine("digite o Ano");
            ano = double.Parse(Console.ReadLine());

            Console.WriteLine(cc + ", " + dia + " de " + mestxt + " de " + ano);


            Console.ReadKey();
        }
    }
}
