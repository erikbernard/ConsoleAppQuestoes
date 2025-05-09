using ConsoleAppQuestoes.Interfaces;

namespace ConsoleAppQuestoes.Questoes;

public class Questao4 : IQuestao
{
    public string Nome => "Questão 4: Percentual de faturamento por estado";
    public void Executar()
    {
        var dados = new Dictionary<string, double>
        {
            ["SP"] = 67836.43,
            ["RJ"] = 36678.66,
            ["MG"] = 29229.88,
            ["ES"] = 27165.48,
            ["Outros"] = 19849.53
        };
        double total = dados.Values.Sum();
        Console.WriteLine($"Faturamento total: {total}");
        foreach (var kvp in dados)
        {
            double perc = kvp.Value / total * 100;
            Console.WriteLine($"{kvp.Key}: {perc:F2}%");
        }
    }
}