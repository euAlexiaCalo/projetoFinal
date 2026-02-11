# Sistema de Biblioteca — C# Console

![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)
![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)

---

## Descrição
Aplicação **console** em C# para gerenciar uma biblioteca, permitindo **adicionar, listar, buscar, emprestar e devolver materiais** (livros e revistas).  

O projeto demonstra o uso de:
- Classes e objetos  
- Métodos e encapsulamento  
- Estruturas de decisão (`switch`)  
- Laços de repetição (`do-while`)  
- Tratamento de exceções (`try-catch`)  

---

## Funcionalidades
- Adicionar materiais (Livro ou Revista)  
- Listar todos os materiais cadastrados  
- Buscar material por título  
- Emprestar material disponível  
- Devolver material emprestado  

---

## Pré-requisitos
- **Windows, Linux ou macOS**  
- **.NET SDK** instalado (versão 6.0 ou superior)  
- IDE ou editor de código de sua preferência (Visual Studio, VS Code, Rider, etc.)

---

## Como obter o projeto

### Opção 1 — Git (recomendado)
```bash
- git clone https://github.com/seu-usuario/seu-repo.git
- cd seu-repo
```

### Opção 2 — Download
- Baixe o **.zip** do repositório  
- Extraia em uma pasta local  
- Abra a solução ou projeto na sua IDE preferida  

---

## Executando o app
1. Abra a solução ou projeto no Visual Studio ou outro editor que suporte C#  
2. Compile o projeto (`Ctrl + Shift + B` no Visual Studio)  
3. Execute o programa (`F5` no Visual Studio ou `dotnet run` no terminal)  
4. O menu da biblioteca aparecerá no console

---

## Como usar
1. Ao iniciar, você verá o menu com opções:  
  0 - Sair
  1 - Adicionar material
  2 - Listar materiais
  3 - Buscar material por título
  4 - Emprestar material
  5 - Devolver material
2. Digite o número da opção desejada.  
3. Para **adicionar materiais**: escolha **Livro** ou **Revista** e insira os dados solicitados (título, autor, ano, gênero ou edição).  
4. Para **buscar, emprestar ou devolver**, digite o **título do material** quando solicitado.  
5. Para **sair**, selecione **0 - Sair**.

---

## Estrutura do projeto
- **Program.cs** → Contém o menu, lógica principal e métodos de interação com o usuário  
- **Biblioteca.cs** → Gerencia a lista de materiais e operações de empréstimo/devolução  
- **MaterialBiblioteca.cs** → Classe base que define propriedades comuns a livros e revistas  
- **Livro.cs** → Representa livros na biblioteca  
- **Revista.cs** → Representa revistas na biblioteca  
- **projetoFinal.csproj** → Arquivo de configuração do projeto .NET 

---

## Solução de problemas
- **Entrada inválida** → Digite números válidos para o menu ou campos solicitados  
- **Exceções de conversão** (ex.: ano ou edição) → Digite números inteiros  
- **Material não encontrado** → Verifique o título informado  

---

## Roadmap
- Persistência de dados em arquivo ou banco de dados  
- Validação avançada de entrada  
- Sistema de reservas de materiais  
- Relatórios de empréstimos  

---

## Contribuindo
- Fork o repositório  
- Crie uma branch (`feat/sua-melhoria`)  
- Commit suas alterações  
- Abra um Pull Request  

---

📜 **Licença**
- Este projeto está sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.  

---

**Autoria**
- Projeto desenvolvido como exemplo de gerenciamento de biblioteca em C#.
