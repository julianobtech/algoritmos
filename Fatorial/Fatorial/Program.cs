using System;
class Fatorial {
    static void Main() {

        Console.Write("Digite um número de 1 a 10 para calcular o fatorial: ");
        int numero = int.Parse(Console.ReadLine());

        int fatorial = 1;
        // Cria uma string para armazenar os termos da multiplicação
        string multiplicacao = "";

        // Calcula o fatorial de números maiores que 1
        for (int i = numero; i >= 1; i--) {
            // Concatena o número atual à string de multiplicação
            if (i != numero) {
                multiplicacao += " × ";
            }
            multiplicacao += i;
            // Atualiza o valor de fatorial
            fatorial *= i; 
        }

        Console.WriteLine($"{numero}! = {multiplicacao} = {fatorial}");
    
    }
}