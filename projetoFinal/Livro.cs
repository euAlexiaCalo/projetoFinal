using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFinal
{
    // Classe Livro herda de MaterialBiblioteca
    public class Livro : MaterialBiblioteca
    {
        public string Genero { get; set; } // Propriedade específica de livros

        // Sobrescreve o método abstrato para exibir as informações do livro
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"\nLivro ID: {Id} " +
                              $"\nTítulo: {Titulo}" +
                              $"\nAutor: {Autor}" +
                              $"\nAno: {AnoPublicacao} | Gênero: {Genero}" +
                              $"\nDisponível: {(Disponivel ? "Sim" : "Não")}");
        }
    }
}
