using ConsoleAppQuestoes.Interfaces;

namespace ConsoleAppQuestoes.Questoes;

public class Questao5 : IQuestao
{
    public string Nome => "Questão 5: Inversão de string";
    public void Executar()
    {
        Console.Write("Informe uma string para inverter: ");
        string entrada = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrEmpty(entrada))
        {
            Console.WriteLine("Entrada vazia.");
            return;
        }
        char[] inverso = new char[entrada.Length];
        for (int i = 0; i < entrada.Length; i++)
        {
            inverso[i] = entrada[entrada.Length - 1 - i];
        }
        string resultado = new string(inverso);
        Console.WriteLine($"String invertida: {resultado}");
    }
}