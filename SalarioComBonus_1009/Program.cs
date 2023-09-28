using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        string nome;
        double salario, comissao;

        Console.WriteLine("Escreva o nome do funcionário: ");
        nome = Console.ReadLine();

        Console.WriteLine("Qual o valor do salário do funcionário?: ");
        salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual o valor das vendas do funcionário?:  ");
        comissao = double.Parse(Console.ReadLine());

        comissao = (comissao / 100) * 15;
        double total = comissao + salario;

        Console.WriteLine("Total a receber = R$ " + total.ToString("f2", CultureInfo.InvariantCulture));

    }

}