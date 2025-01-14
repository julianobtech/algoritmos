using System;
class ContagemVogais {
    static void Main(string[] args) {

        Console.Write("Digite uma letra ou frase: ");
        string entrada = Console.ReadLine();

        int contagem = 0;
        string vogais = "aeiouAEIOU";
        
        // Para cada caractere da entrada vai verificar se é vogal.
        foreach (char caractere in entrada) { 
            if (vogais.Contains(caractere)) {
                contagem++;
                Console.Write($"{caractere}, ");    
            }
        }

        Console.WriteLine();
        Console.WriteLine($"A entrada contém {contagem} vogais");
    }
}