//Faça um programa que leia o valor atual do salário de uma pessoa e o valor com acréscimo. E informe a porcentagem de acréscimo que foi dada; atenção: salário somente aumenta; 

//Início
Console.WriteLine("--- Acréscimo no Salário ---\n");

//Declaração de Variáveis
float salario, salario_aux, salario_final, acrescimo;

//Entrada de Dados e Operações
Console.Write("Digite o valor do Salário: ");
salario = float.Parse(Console.ReadLine());
salario_aux = salario;

//Final do Programa
Console.WriteLine("\nAperte ENTER para encerrar...");
Console.ReadKey();