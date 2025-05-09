using ConsoleAppQuestoes.Interfaces;

namespace ConsoleAppQuestoes.Questoes;

public class Questao2 : IQuestao
{
    public string Nome => "Questão 2: Pertinência na sequência de Fibonacci";
    public void Executar()
    {
        Console.Write("Informe um número para verificar na sequência de Fibonacci: ");
        if (!int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }
        bool pertence = VerificarFibonacci(numero);
        Console.WriteLine(pertence
            ? $"O número {numero} pertence à sequência de Fibonacci."
            : $"O número {numero} não pertence à sequência de Fibonacci.");
    }

    private bool VerificarFibonacci(int n)
    {
        if (n < 0) return false;
        int a = 0, b = 1;
        if (n == a || n == b) return true;
        while (b < n)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b == n;
    }
}