using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_DIO_POO.Model
{
    public class Professor: Pessoa
    {
        public decimal Salario { get; set; }
         public override void Apresentar()
    {
        Console.WriteLine($"Olá! Me chamo {Nome} e tenho {Idade} anos. Meu e-mail é {Email}. Meu salário é {Salario:C}");
    }
    }
   
}