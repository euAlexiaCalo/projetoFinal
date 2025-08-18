using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFinal
{
    public class Biblioteca
    {
        // Lista que vai armazenar todos os livros e revistas
        private List<MaterialBiblioteca> materiais = new List<MaterialBiblioteca>();
        private int proximoId = 1; // Contador para gerar IDs automáticos

        // Adiciona material (livro ou revista) à lista
        public void AdicionarMaterial(MaterialBiblioteca material)
        {
            material.Id = proximoId++; // Gera ID automaticamente
            materiais.Add(material);
            Console.WriteLine($"\nMaterial adicionado com sucesso!");
        }

        // Lista todos os materiais cadastrados
        public void ListarMateriais()
        {
            Console.WriteLine("----------Materiais cadastrados----------");
            if (materiais.Count == 0) // Se não houver nada cadastrado
            {
                Console.WriteLine("\nNenhum material cadastrado.");
                return;
            }

            // Para cada material na lista, chama o método ExibirInformacoes()
            foreach (var m in materiais)
            {
                m.ExibirInformacoes();
            }
        }

        // Busca material pelo título (usando Find)
        public MaterialBiblioteca BuscarPorTitulo(string titulo)
        {
            //Para cada item representado em (m) na lista materiais, verifica se o título do material é igual ao título buscado, sem se importar com maiúsculas ou minúsculas ou acentuação
            return materiais.Find(m => m.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }

        // Empresta material pelo título
        public void EmprestarMaterial(string titulo)
        {
            var material = BuscarPorTitulo(titulo);
            if (material != null)
                material.Emprestar(); // Chama o método da classe
            else
                Console.WriteLine("Material não encontrado!");
        }

        // Devolve material pelo título
        public void DevolverMaterial(string titulo)
        {
            var material = BuscarPorTitulo(titulo);
            if (material != null)
                material.Devolver();
            else
                Console.WriteLine("Material não encontrado!");
        }
    }
}
