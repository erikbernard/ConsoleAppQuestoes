using ConsoleAppQuestoes.Interfaces;
using ConsoleAppQuestoes.Questoes;

namespace ConsoleAppQuestoes
{
    class Program
    {
        static void Main()
        {
            var questoes = new List<IQuestao>
            {
                new Questao1(),
                new Questao2(),
                new Questao3(),
                new Questao4(),
                new Questao5()
            };
            while (true)
            {
                Console.WriteLine("Selecione a questão (1-5) ou 0 para sair:");
                for (int i = 0; i < questoes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {questoes[i].Nome}");
                }
                Console.Write("Opção: ");
                if (!int.TryParse(Console.ReadLine(), out int opcao) || opcao < 0 || opcao > questoes.Count)
                {
                    Console.WriteLine("Opção inválida.");
                    continue;
                }
                if (opcao == 0) break;
                Console.Clear();
                questoes[opcao - 1].Executar();
                Console.WriteLine("\nPressione Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
