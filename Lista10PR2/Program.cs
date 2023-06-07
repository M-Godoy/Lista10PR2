using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lista10PR2
{
    internal class Program
    {
        public static void Exercício1()
        {
            Console.WriteLine("Aqui será codificado o exercício 1");

            float menor, maior, media, soma=0;
            int n, i=0;

            menor = float.MaxValue;
            maior = float.MinValue;

            Console.WriteLine("Digite o tamanho do vetor: ");
            n = int.Parse(Console.ReadLine());

            float[] vetor = new float[n];

            for (; i < n; i++)
            {
                Console.WriteLine("Digite um valor para o vetor []");
                vetor[i] = float.Parse(Console.ReadLine());

                soma += vetor[i];

                if(vetor[i] < menor)
                {
                    menor = vetor[i];
                }
                if(vetor[i] > maior)
                {
                    maior = vetor[i];
                }
            }
            media = soma / n;

            Console.WriteLine("O Menor número apresentado dentro do vetor é: " + menor);
            Console.WriteLine("O Maior número apresentado dentro do vetor é: " + maior);
            Console.WriteLine("A média dos números apresentados dentro do vetor é: " + media);

            Console.ReadKey();
        }
        public static void Exercício2()
        {
            Console.WriteLine("Aqui será codificado o exercício 2");

         
            float  media, soma = 0;
            int n, i = 0;
            Console.WriteLine("Digite o tamanho do vetor: ");
            n = int.Parse(Console.ReadLine());

            float[] vetor = new float[n];
            if (n < 0)
            {
                Console.WriteLine("Tente novamente, com um número maoir que zero");
            }


            for (; i < n; i++)
            {
                Console.WriteLine("Digite um valor para o vetor []");
                vetor[i] = float.Parse(Console.ReadLine());

                soma += vetor[i];

            }
            media = soma / n;

            for (; i < n; i++)
            {
                if(vetor[i] >= media)
                Console.WriteLine("posição []" + vetor[i]);
              
            }
            Console.WriteLine("A média dos números apresentados dentro do vetor é: " + media);
            Console.ReadKey();
        }
        public static void Exercício3()
        {
            Console.WriteLine("Aqui será codificado o exercício 3");
            float media, soma = 0;
            int n, i = 0;
            Console.WriteLine("Digite o tamanho do vetor: ");
            n = int.Parse(Console.ReadLine());

            float[] vetor = new float[n];
            if (n < 0)
            {
                Console.WriteLine("Tente novamente, com um número maoir que zero");
            }

            Random rand = new Random(); //criação de números aleatórios
            for (; i < n; i++)
            {
                vetor[i] = rand.Next(10, 100);// rand.Next() cria números aleatório
                soma += vetor[i];
            }
            
            media = soma / n;

            for (; i < n; i++)
            {
                if (vetor[i] >= media)
                    Console.WriteLine("posição []" + vetor[i]);

            }
            Console.WriteLine("A média dos números apresentados dentro do vetor é: " + media);
            Console.ReadKey();
        }
        public static void Exercício4()
        {
            Console.WriteLine("Aqui será codificado o exercício 4");
            int n, i=0;

            Console.WriteLine("Digite o valor para o vetor");
            n=int.Parse(Console.ReadLine());

            string[] vetor = new string[n];
            for (; i < n; i++)
            {
                Console.WriteLine("Digite o nome na lista de presença");
                vetor[i] = Console.ReadLine();
            }
            for (; i < n; i++)
            {
                Console.WriteLine("posição []" + vetor[i]);
            }
            Console.ReadKey();

        }
        public static void Exercício5()
        {
            Console.WriteLine("Aqui será codificado o exercício 5");

            int n, i = 0, pares=0, impares=0;

            Console.WriteLine("Digite o tamanho do vetor: ");
            n = int.Parse(Console.ReadLine());

            int[] vetor = new int[n];
            if (n < 0)
            {
                Console.WriteLine("Tente novamente, com um número maoir que zero");
            }

            Random rand = new Random(); //criação de números aleatórios
            for (; i < n; i++)
            {
                vetor[i] = rand.Next(10, 100);// rand.Next() cria números aleatório

                if(vetor[i] % 2== 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine("De todos os números aleatórios presentes no vetor são pares: " + pares);
            Console.WriteLine("De todos os números aleatórios presentes no vetor são ímpares: " + impares);

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int opcao;
            do
            {

                Console.WriteLine("****MENU****");
                Console.WriteLine("Digite 0 - Sair");
                Console.WriteLine("Digite 1 - Exercício 1 ");
                Console.WriteLine("Digite 2 - Exercício 2 ");
                Console.WriteLine("Digite 3 - Exercício 3 ");
                Console.WriteLine("Digite 4 - Exercício 4 ");
                Console.WriteLine("Digite 5 - Exercício 5 ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {

                    case 0:
                        Console.WriteLine("Agradeço a preferência");
                        break;
                    case 1:
                        Exercício1();
                        break;
                    case 2:
                        Exercício2();
                        break;
                    case 3:
                        Exercício3();
                        break;
                    case 4:
                        Exercício4();
                        break;
                    case 5:
                        Exercício5();
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            } while (opcao != 0);
        }   
    }
}
