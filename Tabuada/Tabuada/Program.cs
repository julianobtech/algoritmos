using System;
class Tabuada {
    static void Main() {

        Console.Write("Digite um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero <= 0) {
            Console.WriteLine("Erro: O número deve ser positivo.");
        }
        else {
            for (int i = 0; i <= 10; i++) {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
            Console.WriteLine("Fim do programa.");
        }
    }
}