using POO_na_Prática.Models;

// Exemplo Abstração
// Pessoa p1 = new Pessoa();
// p1.Nome = "Artur";
// p1.Idade = 20;
// p1.Apresentar();

// Exemplo Encapsulamento
// ContaCorrente c1 = new ContaCorrente(123, 1000);
// c1.ExibirSaldo();
// c1.Sacar(500);
// c1.ExibirSaldo();

// Exemplo Herança e Polimorfismo
Aluno a1 = new Aluno();
a1.Nome = "Artur";
a1.Idade = 20;
a1.Nota = 10;
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Leonardo";
p1.Idade = 24;
p1.Salario = 1000;
p1.Apresentar();