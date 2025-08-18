using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFinal
{
    // Classe abstrata base (não pode ser instanciada diretamente)
    public abstract class MaterialBiblioteca
    {
        //Propriedades:
        public int Id { get; set; } // Identificador único
        public string Titulo { get; set; } // Nome do material (livro/revista)
        public string Autor { get; set; } // Autor do material
        public int AnoPublicacao { get; set; } // Ano em que foi publicado
        public bool Disponivel { get; set; } = true; // Começa disponível por padrão

        //Métodos:
        // Método para emprestar um material
        public void Emprestar()
        {
            if (Disponivel) // Se está disponível
            {
                Disponivel = false; // Marca como emprestado
                Console.WriteLine($"{Titulo} foi emprestado com sucesso!");
            }
            else
            {
                Console.WriteLine($"{Titulo} já está emprestado!");
            }
        }
        // Método para devolver um material
        public void Devolver()
        {
            if (!Disponivel) //Se está emprestado
            {
                Disponivel = true; // Marca como disponível
                Console.WriteLine($"{Titulo} foi devolvido com sucesso!");
            }
            else
            {
                Console.WriteLine($"{Titulo} já está disponível!");
            }
        }
        // Método abstrato (obrigatório de implementar nas subclasses)
        public abstract void ExibirInformacoes();
    }
}
