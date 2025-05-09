# ConsoleAppQuestoes

Aplicação de console em C# (.NET 8.0) que implementa cinco exercícios (questões) de lógica:

* **Questão 1**: Soma de 1 até 13
* **Questão 2**: Verificação de pertinência na sequência de Fibonacci
* **Questão 3**: Cálculo de faturamento mensal (menor, maior e dias acima da média) a partir de `dados.json`
* **Questão 4**: Percentual de representação do faturamento por estado
* **Questão 5**: Inversão de caracteres em uma string

---

## Pré-requisitos

* [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* Ferramenta de linha de comando `dotnet`
* (Opcional) IDE como Visual Studio ou VS Code

---

## Estrutura do Projeto

```text
ConsoleAppQuestoes/
├── Program.cs          # Ponto de entrada e menu de seleção
├── Questao1.cs         # Implementação da Questão 1
├── Questao2.cs         # Implementação da Questão 2
├── Questao3.cs         # Implementação da Questão 3
├── Questao4.cs         # Implementação da Questão 4
├── Questao5.cs         # Implementação da Questão 5
├── Faturamento.cs      # Modelo de dados para Questão 3
├── dados.json          # Dados de faturamento para Questão 3
└── ConsoleAppQuestoes.csproj
```

> **Importante:** O arquivo `dados.json` deve estar presente na pasta de saída (bin) para que a Questão 3 consiga encontrá-lo. Veja a seção **Copiar dados.json para saída**.

---

## Copiar dados.json para saída

Garanta que, após o build, o `dados.json` seja copiado para `bin/Debug/net8.0/`:

1. No **.csproj**:

   ```xml
   <ItemGroup>
     <Content Include="dados.json">
       <CopyToOutputDirectory>Always</CopyToOutputDirectory>
     </Content>
   </ItemGroup>
   ```

2. Ou, se usar Visual Studio, selecione o arquivo em **Solution Explorer** e ajuste em **Properties**:

   * **Build Action**: `Content`
   * **Copy to Output Directory**: `Copy if newer`

---

## Uso

1. Abra um terminal na pasta do projeto:

   ```bash
   cd /caminho/para/ConsoleAppQuestoes
   ```

2. Compile:

   ```bash
   dotnet build
   ```

3. Execute:

   ```bash
   dotnet run --project ConsoleAppQuestoes.csproj
   ```

4. No menu interativo, digite o número da questão (1 a 5) e pressione **Enter**.

   * Digite **0** para sair.

Exemplo:

```
Selecione a questão (1-5) ou 0 para sair:
1: Questão 1: Soma de 1 até 13
2: Questão 2: Pertinência na sequência de Fibonacci
3: Questão 3: Faturamento mensal
4: Questão 4: Percentual de faturamento por estado
5: Questão 5: Inversão de string
Opção: 3
```

