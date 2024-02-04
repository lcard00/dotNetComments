using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetComments.Models
{
    /// <summary>
    /// Define a classe Pessoa.
    /// </summary>
    public class Pessoa
    {
        public string? Nome { get; set; }

        /// <summary>
        /// Método para apresentar uma Pessoa.
        /// </summary>
        public void ApresentarPessoa()
        {
            Console.WriteLine(Nome);
        }

        /// <summary>
        /// Apresenta uma Pessoa utilizando o nome.
        /// </summary>
        /// <param name="nome">nome: Informe o nome para apresentar.</param>
        public void Apresentar(string nome, string sobrenome)
        {
            Console.WriteLine($"{nome} + {sobrenome}");
        }
    }


}