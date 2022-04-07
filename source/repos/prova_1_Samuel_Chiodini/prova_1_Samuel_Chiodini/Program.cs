using System;

namespace prova_1_Samuel_Chiodini
{
    class Program
    {
        static void Main(string[] args)
        {
            static void DiaSemana()
            {
                char sDiaSemana;
                int iConta = 0;
                int iValorDia = 6;

                while (iConta <= iValorDia)
                {
                    switch(iConta)
                    {
                        case 0:
                            Console.WriteLine("Hoje é Segunda-feira");
                            break;
                        case 1:
                            Console.WriteLine("Hoje é Terça-feira");
                            break;
                        case 2:
                            Console.WriteLine("Hoje é Quarta-feira");
                            break;
                        case 3:
                            Console.WriteLine("Hoje é Quinta-feira");
                            break;
                        case 4:
                            Console.WriteLine("Hoje é Sexta-feira");
                            break;
                        case 5:
                            Console.WriteLine("Hoje é Sabado");
                            break;
                        case 6:
                            Console.WriteLine("Hoje é Domingo");
                            break;
                        default:
                            Console.WriteLine("Dia invalido");
                            break;
                    }
                    iConta = iConta +1;
                    Console.ReadKey();
                }
                
            }
            //QUESTAO 6
            static void calcula()
            {
                string sTexto;
                for (int i = 0; i <= 200; i++)
                {
                    int resto = i % 6;
                    sTexto = resto == 0 ? "O valor " + i + " divisível por 6" : " O valor " + i + " não édivisível por 6";
                    Console.WriteLine(sTexto);
                }
            }

            //QUESTAO 7
            static void maiorResto(int n1, double n2)
            {
                int n3;
                n3 = n1 % (int)n2;
                if (n3 > n1)
                {
                    Console.WriteLine("O resto de n3: " + n3 + " é maior que n1: " + n1);
                }
                else if (n3 < n1)
                {
                    Console.WriteLine("O resto de n3: " + n3 + " é menor que n1: " + n1);
                }
                else
                {
                    Console.WriteLine("O resto de n3: " + n3 + " é igual a n1: " + n1);
                }
            }
            //QUESTAO 5
            //DiaSemana();

            //QUESTAO 6
            //calcula();

            //QUESTAO 7
            //maiorResto(10, 5);
        }
    }
}

namespace Aula
{
    public class Produto
    {
        public int id;
        public string descricao;
        public double valor;
    }
}