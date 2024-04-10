// 1 - Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior

// using System;

// namespace Exercicio1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Encontre o maior dentre 3 números:");
//             Console.Write("Primeiro Número: ");
//             int num1 = int.Parse(Console.ReadLine()!);
//             Console.Write("Segundo Número: ");
//             int num2 = int.Parse(Console.ReadLine()!);
//             Console.Write("Terceiro Número: ");
//             int num3 = int.Parse(Console.ReadLine()!);

//             if (num1 > num2 && num1 > num3)
//             {
//                 Console.WriteLine($"O primeiro número: {num1} é o maior");
//             }
//             else if (num2 > num1 && num2 > num3)
//             {
//                 Console.WriteLine($"O segundo número: {num2} é o maior");
//             }
//             else
//             {
//                 Console.WriteLine($"O terceiro número: {num3} é o maior");
//             }
//         }
//     }
// }

// 2- Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop  while, do-while e for.

// using System;

// namespace Exercicio2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int i = 1;
//             int soma = 0;

//             Console.WriteLine("Usando While");
//             while (i <= 10)
//             {
//                 Console.Write(i + " ");
//                 soma += i;
//                 i++;
//             }
//             Console.WriteLine("\nA soma dos números é: " + soma);

//             i = 1;
//             soma = 0;

//             Console.WriteLine("\nUsando Do-While");
//             do
//             {
//                 Console.Write(i + " ");
//                 soma += i;
//                 i++;
//             } while (i <= 10);
//             Console.WriteLine("\nA soma dos números é: " + soma);

//             soma = 0;

//             Console.WriteLine("\nUsando For");
//             for (i = 1; i <= 10; i++)
//             {
//                 Console.Write(i + " ");
//                 soma += i;
//             }
//             Console.WriteLine("\nA soma dos números é: " + soma);
//         }
//     }
// }

// 3- Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero 

// using System;

// namespace Exercicio3
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             while (true)
//             {
//                 Console.Write("Digite um número maior que zero: ");
//                 int num = Convert.ToInt32(Console.ReadLine()!);

//                 if (num <= 0)
//                 {
//                     Console.WriteLine("Número inválido, digite um número maior que zero");
//                     continue;
//                 }

//                 for (int i = 1; i <= 10; i++)
//                 {
//                     Console.WriteLine($"{num} x {i} = {num * i}");
//                 }

//                 Console.Write("Deseja continuar? (s/n): ");
//                 string continuar = Console.ReadLine()!.ToLower();

//                 if (continuar == "n")
//                 {
//                     break;
//                 }
//             }
//         }
//     }
// }


// 4- Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 
// maneiras diferentes:

// using System;

// namespace Exercicio4
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Incrementando 2 em cada passo");
//             for (int i = 10; i <= 20; i += 2)
//             {
//                 if (i == 16)
//                 {
//                     continue;
//                 }
//                 Console.Write(i + " ");
//             }

//             Console.WriteLine("\nIncrementando 1 em cada passo");
//             for (int i = 10; i <= 20; i++)
//             {
//                 if (i == 16)
//                 {
//                     continue;
//                 }
//                 if (i % 2 == 0)
//                 {
//                     Console.Write(i + " ");
//                 }
//             }

//             Console.WriteLine("\nCom loop infinito");
//             int j = 10;
//             while (true)
//             {
//                 if (j == 16)
//                 {
//                     j++;
//                     continue;
//                 }
//                 if (j > 20)
//                 {
//                     break;
//                 }
//                 if (j % 2 == 0)
//                 {
//                     Console.Write(j + " ");
//                 }
//                 j++;
//             }
//         }
//     }
// }

// 5 - Escreva um programa para calcular o fatorial de um número inteiro. 
// O fatorial de um número é representado por : n! => n * (n – 1) * (n – 2) ....2*1 
// Exemplo : fatorial de 6 é representado por 6! = 6*5*4*3*2*1

 
// using System;

// namespace Exercicio5
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             while (true)
//             {
//                 Console.Write("Digite um número inteiro: ");
//                 int num = Convert.ToInt32(Console.ReadLine()!);

//                 if (num < 0)
//                 {
//                     Console.WriteLine("Número inválido, digite um número inteiro positivo");
//                     continue;
//                 }

//                 int fatorial = 1;
//                 for (int i = 1; i <= num; i++)
//                 {
//                     fatorial *= i;
//                 }

//                 Console.WriteLine($"O fatorial de {num} é {fatorial}");

//                 Console.Write("Deseja continuar? (s/n): ");
//                 string continuar = Console.ReadLine()!.ToLower();

//                 if (continuar == "n")
//                 {
//                     break;
//                 }
//             }
//         }
//     }
// }

// 6 - Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado.

// using System;

// namespace Exercicio6
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int i = 2;
//             do
//             {
//                 int j = 1;
//                 do
//                 {
//                     Console.WriteLine($"{i} x {j} = {i * j}");
//                     j++;
//                 } while (j <= 10);
//                 i++;
//             } while (i <= 6);
//         }
//     }
// }

// 7 - Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de 
// um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a 
// instrução switch, break e default em um loop infinito e defina uma condição de saida.)

// using System;

// namespace Exercicio7
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             while (true)
//             {
//                 Console.Write("Digite a nota do aluno (0 a 10): ");
//                 int nota;

//                 if (!int.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
//                 {
//                     Console.WriteLine("Nota inválida");
//                     continue;
//                 }

//                 string classificacao;

//                 switch (nota)
//                 {
//                     case int n when (n >= 0 && n <= 3):
//                         classificacao = "Fraco";
//                         break;
//                     case int n when (n >= 4 && n <= 6):
//                         classificacao = "Regular";
//                         break;
//                     case int n when (n >= 7 && n <= 8):
//                         classificacao = "Bom";
//                         break;
//                     case int n when (n >= 9 && n <= 10):
//                         classificacao = "Excelente";
//                         break;
//                     default:
//                         classificacao = "Nota inválida";
//                         break;
//                 }

//                 Console.WriteLine(classificacao);

//                 Console.Write("Deseja continuar? (s/n): ");
//                 string continuar = Console.ReadLine()?.ToLower()!;

//                 if (continuar != "s")
//                 {
//                     break;
//                 }
//             }
//         }
//     }
// }


// 8 - Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números 
// inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e 
// quando isso ocorrer exibir uma mensagem de alerta

using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite o primeiro número inteiro: ");
                int num1;

                if (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Número inválido");
                    continue;
                }

                Console.Write("Digite o segundo número inteiro: ");
                int num2;

                if (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Número inválido");
                    continue;
                }

                Console.WriteLine($"Adição: {num1} + {num2} = {num1 + num2}");
                Console.WriteLine($"Subtração: {num1} - {num2} = {num1 - num2}");
                Console.WriteLine($"Multiplicação: {num1} x {num2} = {num1 * num2}");

                if (num2 == 0)
                {
                    Console.WriteLine("Divisão por zero");
                }
                else
                {
                    Console.WriteLine($"Divisão: {num1} / {num2} = {num1 / (double)num2}");
                }

                Console.Write("Deseja continuar? (s/n): ");
                string continuar = Console.ReadLine()?.ToLower()!;

                if (continuar != "s")
                {
                    break;
                }
            }
        }
    }
}
