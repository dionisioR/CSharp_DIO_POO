using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_DIO_POO.Model
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá! Me chamo {Nome} e tenho {Idade} anos. Meu e-mail é {Email}. Minha nota é {Nota}");
        }
    }
}
