using CSharp_DIO_POO.Model;

// Pessoa p1 = new Pessoa();
// p1.Nome = "João";
// p1.Idade = 30;
// p1.Apresentar();

//-----------------------------------------------------------------------------------------------
// ContaCorrente cc1 = new ContaCorrente(123, 1000);
// // cc1.saldo = 1000;  // erro pois saldo é privado

// cc1.ExibirSaldo();
// cc1.Sacar(5000);
// cc1.Sacar(100);
// cc1.ExibirSaldo();

//-----------------------------------------------------------------------------------------------
// Aluno a1 = new Aluno();
// a1.Nome = "Maria";
// a1.Idade = 20;
// a1.Email = "teste@g.com";
// a1.Nota = 8.5;
// a1.Apresentar();
// Console.WriteLine("--------------------");
// Professor prof1 = new Professor();
// prof1.Nome = "José";
// prof1.Idade = 40;
// prof1.Email = "prof@g.com";
// prof1.Salario = 5000;
// prof1.Apresentar();
//-----------------------------------------------------------------------------------------------
Corrente cc = new Corrente();
cc.Creditar(1000);
cc.ExibirSaldo();