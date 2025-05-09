using ConsoleAppQuestoes.Interfaces;

namespace ConsoleAppQuestoes.Questoes;

public class Questao1 : IQuestao
{
    public string Nome => "Questão 1: Soma de 1 até 13";
    public void Executar()
    {
        int INDICE = 13, SOMA = 0, K = 0;
        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }
        Console.WriteLine($"Resultado da soma: {SOMA}");
    }
}