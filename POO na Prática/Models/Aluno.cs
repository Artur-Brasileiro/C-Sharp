using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_na_Prática.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}!");
        }
    }
}