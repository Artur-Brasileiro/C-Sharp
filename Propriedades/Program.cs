using Propriedades.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Artur";
// p1.Sobrenome = "Brasileiro";
// p1.Idade = 20;
// p1.Apresentar();

Pessoa p1 = new Pessoa(nome: "Artur", sobrenome: "Brasileiro");
Pessoa p2 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");
Pessoa p3 = new Pessoa("Maria", "Fernanda");
Pessoa p4 = new Pessoa("Sandra", "Ferreira");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.AdicionarAluno(p4);

cursoDeIngles.ListarAlunos();