using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_DIO_POO.Model
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá! Me chamo {Nome} e tenho {Idade} anos. Meu e-mail é {Email}");
        }
    }
}