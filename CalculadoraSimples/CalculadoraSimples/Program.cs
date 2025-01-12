using System;
using System.Globalization;
class CalculadoraSimples {
    static void Main() {

        Console.Write("Digite um número inteiro: ");
        int n1 = int.Parse(Console.ReadLine());
        
        Console.Write("Digite a operação desejada (+, -, *, /): ");
        string operador = Console.ReadLine();
        
        Console.Write("Digite outro número inteiro: ");
        int n2 = int.Parse(Console.ReadLine());

        double resultado = 0;
        bool operacaoValida = true;

        switch (operador) {
            case "+":
                resultado = n1 + n2;
                break;
            case "-":
                resultado = n1 - n2;
                break;
            case "*":
                resultado = n1 * n2;
                break;
            case "/":
                if (n2 != 0) {
                    resultado = (double) n1 / n2;
                }
                else {
                    Console.WriteLine("Erro: Divisão por zero não é permitida. ");
                    operacaoValida = false;
                }
                break;
            default:
                Console.WriteLine("Erro: Operação inválida.");
                operacaoValida = false;
                break;
        } 
        if (operacaoValida) {
            Console.WriteLine($"Resultado: {resultado}");
        }

        Console.WriteLine("Fim do programa.");
    }
}