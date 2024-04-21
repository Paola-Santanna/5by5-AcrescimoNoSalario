//Faça um programa que leia o valor atual do salário de uma pessoa e o valor com acréscimo. E informe a porcentagem de acréscimo que foi dada; atenção: salário somente aumenta; 

//Início
Console.WriteLine("--- Acréscimo no Salário ---\n");

//Declaração de Variáveis
float salario, salario_aux, salario_final, salario_acrescimo, salario_acrescimo_aux, acrescimo;

//Entrada de Dados e Operações
Console.WriteLine("Digite um valor posiivo para o salário\n");

do
{
    Console.Write("Digite o valor do Salário: R$");
    salario = float.Parse(Console.ReadLine());
    salario_aux = salario;

    if (salario_aux == 0)
        Console.WriteLine("\nNúmero inválido!");

} while (salario_aux == 0);

do
{
    Console.Write("Digite o valor do Salário com o acréscimo: R$");
    salario_acrescimo = float.Parse(Console.ReadLine());
    salario_acrescimo_aux = salario_acrescimo;

    if (salario_acrescimo_aux == 0)
        Console.WriteLine("\nNúmero Inválido!");
} while (salario_acrescimo_aux == 0);

acrescimo = ((salario_acrescimo_aux * 100)/ salario_aux) - 100;
Console.WriteLine($"\nO acréscimo foi de: {acrescimo}%");

//Final do Programa
Console.WriteLine("\nAperte ENTER para encerrar...");
Console.ReadKey();