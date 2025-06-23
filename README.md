# 💡 Trabalho Final - Controle de Consumo de Energia

## 📘 Introdução

Este projeto tem como objetivo o desenvolvimento de um sistema para controle de consumo de energia elétrica, atendendo tanto consumidores residenciais quanto comerciais. A solução permite o cadastro de consumidores, a associação de múltiplas contas de energia, o cálculo automático dos valores devidos (incluindo impostos e contribuições), bem como a consulta de dados de consumo.

---

## 🎯 Objetivos

- Cadastro de consumidores (pessoas físicas e jurídicas)
- Registro de contas com leitura anterior e atual
- Cálculo do consumo mensal (kWh)
- Cálculo do valor da conta com e sem impostos
- Armazenamento dos dados em arquivo JSON
- Interface gráfica com Windows Forms

---

## 🛠️ Tecnologias Utilizadas

| Tecnologia         | Descrição                          |
|--------------------|--------------------------------------|
| C#                 | Linguagem principal                  |
| .NET 6.0           | Plataforma de execução               |
| Windows Forms      | Interface gráfica (GUI)             |
| System.Text.Json   | Leitura e gravação de arquivos JSON |
| Visual Studio 2022 | IDE utilizada                        |

---

## 🧱 Arquitetura do Sistema

### 📦 Classe `Consumidor`
```csharp
public class Consumidor
{
    public string Nome { get; set; }
    public string Documento { get; set; } // CPF ou CNPJ
    public bool IsPessoaJuridica => Documento.Length > 11;
    public List<ContaEnergia> Contas { get; set; } = new();
}
```

### 📦 Classe `ContaEnergia`
```csharp
public class ContaEnergia
{
    public string Tipo { get; set; } // "Residencial" ou "Comercial"
    public double LeituraAnterior { get; set; }
    public double LeituraAtual { get; set; }

    public double Consumo => LeituraAtual - LeituraAnterior;

    public double ValorConsumo()
    {
        double tarifa = Tipo == "Residencial" ? 0.40 : 0.35;
        return Consumo * tarifa;
    }

    public double ValorComContribuicao() => ValorConsumo() + 9.25;

    public double ValorTotal()
    {
        double imposto = Tipo == "Residencial" ? 0.30 : 0.18;
        return ValorComContribuicao() * (1 + imposto);
    }
}
```

---

## 📊 Diagrama de Classes (simplificado)
```
+----------------+          +------------------+
|   Consumidor   |<>--------|   ContaEnergia   |
+----------------+          +------------------+
| - Nome         |          | - Tipo           |
| - Documento    |          | - LeituraAnterior|
| - Contas       |          | - LeituraAtual   |
+----------------+          +------------------+
                            | +Consumo         |
                            | +ValorTotal()    |
                            +------------------+
```

---

## 🔁 Fluxo de Funcionamento

1. Usuário cadastra nome e CPF/CNPJ.
2. Informa os dados da conta (tipo, leituras) e associa ao consumidor.
3. O sistema calcula o consumo e o valor da conta.
4. Os dados são armazenados automaticamente no arquivo `dados.json`.
5. O botão “Consultar” exibe as informações da última conta registrada.

---

## 💾 Persistência

- Os dados são salvos automaticamente em `dados.json`.
- O sistema carrega os dados salvos sempre que a aplicação é aberta.
- Não é necessário banco de dados externo.

---

## ✅ Testes Realizados

- Cadastro de diferentes consumidores (CPF/CNPJ)
- Múltiplas contas por consumidor
- Cálculo correto de consumo e valores
- Leitura e escrita no JSON
- Consulta funcional da última conta

---

## 🧩 Melhorias Futuras (Sugestões)

- Exportação de relatório em PDF
- Integração com banco de dados
- Tela de listagem de contas por usuário
- Validação de CPF/CNPJ
- Responsividade e design aprimorado

---

## 👥 Autores

- Arthur Braga Ribeiro
- Guilherme Souto Borges da Costa
- Raul Eleutério Aleixo

---

## 🗂️ Estrutura do Projeto

```
📁 WinFormsApp1/
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
├── Consumidor.cs
├── ContaEnergia.cs
├── dados.json
```

---

## 📝 Licença

Este projeto é acadêmico e foi desenvolvido como parte do trabalho final da disciplina de Programação Orientada por Objetos.

---

## 🎥 Demonstração

[Assista à demonstração no YouTube](https://youtu.be/XXzHjpF9p2k)

Ou clique na imagem abaixo:

[![Clique para assistir](https://img.youtube.com/vi/XXzHjpF9p2k/0.jpg)](https://youtu.be/XXzHjpF9p2k)

---
