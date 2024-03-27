using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_2
{
    class IMC
    {
        double altura;
        double peso;
        

        public double Calcular()
        {
            return (peso * altura) * altura;
        }

        public void Gravar()
        {
            Console.WriteLine("Insira o peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a altura: ");
            altura = double.Parse(Console.ReadLine());

        }

        public void Mostrar()
        {
            Console.WriteLine("\nPeso: " + peso.ToString("0kg") + "\nAltura: " + altura.ToString("0.00") + "\n IMC: " + Calcular().ToString());

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IMC imc1 = new IMC();
            imc1.Equals(imc1);
            imc1.Gravar();
            imc1.Mostrar();
            Console.ReadKey();
        }
    }
}
