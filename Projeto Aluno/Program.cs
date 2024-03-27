using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Aluno
{
    class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;

        public Aluno()
        {
            Console.WriteLine("Criei o Objeto Aluno");
        }

        public Aluno(string nome) 
        {
            this.nome = nome;
        }

        //static: metodo estruturado estatico esta fora da classe. ele é colocado na memória na execução do código. Todo método tem que ser estatico
        //public: 
        public void Gravar()
        {
            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("Digite Nota 1: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite Nota 2: ");
            nota2 = double.Parse(Console.ReadLine());


        }

        public void Mostrar()
        {
            Console.WriteLine("Aluno: " + nome +
                "\n Nota 1: " + nota1.ToString("0.00") +
                "\n Nota 2: " + nota2.ToString("0.00") +
                "\n Média: " + Media().ToString("0.00"));

        }

        public double Media()
        {
            return (nota1 + nota2) / 2;
        }
    }
    internal class Program
    {

        //método consultor, tem que ter o mesmo nome da classe
        //Consultor não tem tipo nem void
        static void Main(string[] args)
        {
            Aluno A1 = new Aluno();
            A1.Gravar();
            A1.Mostrar();
            Console.ReadKey();

            Console.WriteLine("\nPressione qualquer tecla para registrar o segundo aluno...");
            Console.ReadKey(true);

            Aluno aluno2;
            Console.Clear();
            Console.WriteLine("Digite o nome do segundo aluno:");
            string nome = Console.ReadLine();
            aluno2 = new Aluno();
            aluno2.Gravar();
            aluno2.Mostrar();
            Console.Clear();
            Console.WriteLine("Nome do segundo aluno:");
            Console.Clear();
        }
    }
}
