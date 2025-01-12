using System;
class NumerosPares {
    static void Main(string[] args) {

        Console.WriteLine("Números pares entre 1 a 100:");

        for (int i = 1; i <= 100; i++) {
            if (i % 2 == 0) // Verifica se o número é par
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("Fim do programa!");
    }
}