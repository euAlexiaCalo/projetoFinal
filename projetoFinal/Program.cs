using System.Security.Cryptography.X509Certificates;

namespace projetoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca(); // Cria objeto da biblioteca
            int opcao, tipo, ano;
            string autor, titulo;

            void dadosMaterial ()
            {
                Console.Write("Título: ");
                titulo = Console.ReadLine();

                Console.Write("Autor: ");
                autor = Console.ReadLine();

                Console.Write("Ano de Publicação: ");
                ano = int.Parse(Console.ReadLine());
            }

            // Loop do menu
            do
            {
                Console.WriteLine("\n==================== MENU BIBLIOTECA ====================");
                Console.WriteLine("(0) Sair");
                Console.WriteLine("(1) Adicionar material");
                Console.WriteLine("(2) Listar materiais");
                Console.WriteLine("(3) Buscar material por título");
                Console.WriteLine("(4) Emprestar material");
                Console.WriteLine("(5) Devolver material");
                Console.Write("\nOpção escolhida: ");

                try //código que pode dar erro
                {
                    opcao = int.Parse(Console.ReadLine()); // Lê a opção do usuário
                }
                catch //O que fazer se deu erro
                {
                    Console.WriteLine("Opção inválida, tente novamente!");
                    opcao = -1; // Valor inválido, força repetir
                }

                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        // Adicionar material
                        Console.WriteLine("Adicionar (1) Livro ou (2) Revista?");
                        tipo = int.Parse(Console.ReadLine());

                        if (tipo == 1) // Se for livro
                        {
                            dadosMaterial();
                            Console.Write("Gênero: ");
                            string genero = Console.ReadLine();

                            biblioteca.AdicionarMaterial(new Livro
                            {
                                Titulo = titulo,
                                Autor = autor,
                                AnoPublicacao = ano,
                                Genero = genero
                            });
                        }
                        else if (tipo == 2) // Se for revista
                        {
                            dadosMaterial();
                            Console.Write("Edição: ");
                            int edicao = int.Parse(Console.ReadLine());

                            biblioteca.AdicionarMaterial(new Revista
                            {
                                Titulo = titulo,
                                Autor = autor,
                                AnoPublicacao = ano,
                                Edicao = edicao
                            });
                        }
                        else
                        {
                            Console.WriteLine("Tipo inválido!");
                        }
                        break;

                    case 2:
                        // Lista todos os materiais
                        biblioteca.ListarMateriais();
                        break;

                    case 3:
                        // Busca material por título
                        Console.Write("Digite o título do material: ");
                        string busca = Console.ReadLine();
                        var material = biblioteca.BuscarPorTitulo(busca);
                        if (material != null)
                            material.ExibirInformacoes();
                        else
                            Console.WriteLine("Material não encontrado!");
                        break;

                    case 4:
                        // Emprestar material
                        Console.Write("Digite o título do material para emprestar: ");
                        string emprestimo = Console.ReadLine();
                        biblioteca.EmprestarMaterial(emprestimo);
                        break;

                    case 5:
                        // Devolver material
                        Console.Write("Digite o título do material para devolver: ");
                        string devolucao = Console.ReadLine();
                        biblioteca.DevolverMaterial(devolucao);
                        break;

                    case 0:
                        // Finaliza o programa
                        Console.WriteLine("Finalizando programa...");
                        break;

                    default:
                        // Caso o usuário digite número inválido
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0); // Continua até escolher a opção "0 - Sair"
        }
    }
}
