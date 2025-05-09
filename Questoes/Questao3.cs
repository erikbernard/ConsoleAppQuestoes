using ConsoleAppQuestoes.Interfaces;
using ConsoleAppQuestoes.Model;
using System.Text.Json;

namespace ConsoleAppQuestoes.Questoes;

public class Questao3 : IQuestao
{
    public string Nome => "Questão 3: Faturamento mensal";
    public void Executar()
    {
        const string arquivoJson = "dados.json";
        if (!File.Exists(arquivoJson))
        {
            Console.WriteLine($"Arquivo {arquivoJson} não encontrado.");
            return;
        }

        var json = File.ReadAllText(arquivoJson);
        // Ajusta chaves JSON para corresponder às propriedades
        json = json.Replace("\"dia\"", "\"Dia\"").Replace("\"valor\"", "\"Valor\"");
        var dados = JsonSerializer.Deserialize<List<Faturamento>>(json);
        if (dados == null || dados.Count == 0)
        {
            Console.WriteLine("Nenhum dado de faturamento encontrado.");
            return;
        }

        // Filtra apenas valores positivos
        var valores = dados
            .Where(d => d.Valor > 0)
            .Select(d => d.Valor)
            .ToList();

        if (!valores.Any())
        {
            Console.WriteLine("Não há dias com faturamento positivo para calcular.");
            return;
        }

        double menor = valores.Min();
        double maior = valores.Max();
        double media = valores.Average();
        int diasAcimaMedia = valores.Count(v => v > media);

        Console.WriteLine($"Menor faturamento: {menor}");
        Console.WriteLine($"Maior faturamento: {maior}");
        Console.WriteLine($"Dias com faturamento acima da média ({media:F2}): {diasAcimaMedia}");
    }
}