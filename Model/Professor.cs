using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_DIO_POO.Model
{
    // public sealed class Professor: Pessoa
    public class Professor: Pessoa
    {
        public Professor(string nome) : base(nome)
        {
        }

        public decimal Salario { get; set; }
        //  public sealed override void Apresentar()
         public override void Apresentar()
    {
        Console.WriteLine($"Olá! Me chamo {Nome} e tenho {Idade} anos. Meu e-mail é {Email}. Meu salário é {Salario:C}");
    }
    }
   
}