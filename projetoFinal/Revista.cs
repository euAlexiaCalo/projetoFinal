using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFinal
{
    // Classe Revista herda de MaterialBiblioteca
    public class Revista : MaterialBiblioteca
    {
        public int Edicao { get; set; } // Propriedade específica de revistas

        // Sobrescreve o método abstrato para exibir as informações da revista
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"\nRevista ID: {Id}" +
                              $"\nTítulo: {Titulo}" +
                              $"\nAutor: {Autor}" +
                              $"\nAno: {AnoPublicacao} | Edição: {Edicao}" +
                              $"\nDisponível: {(Disponivel ? "Sim" : "Não")}");
        }
    }
}
