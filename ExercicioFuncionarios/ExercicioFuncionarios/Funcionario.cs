using System;
using System.Collections.Generic;

namespace ExercicioFuncionarios
{
    public class Funcionario
    {
        public Funcionario()
        {
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public double Salario { get; set; }

        public void Salvar()
        {
            Funcionario.BancoDeDadosEmMemoriaFuncionarios.Add(this);
        }

        public static double FolhaPagamento()
        {
            double valor = 0;
            foreach(var func in Funcionario.BancoDeDadosEmMemoriaFuncionarios)
            {
                valor += func.Salario;
            }
            return valor;
        }

        public static List<Funcionario> BancoDeDadosEmMemoriaFuncionarios = new List<Funcionario>();
    }
}
