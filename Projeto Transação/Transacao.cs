using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Transação
{
    //Em uma classe a gente tem que encapsular (proteger) os dados. E poder acessar esses dados através de métodos, Propriedades, e atributos de visibilidade 
    //Atributos de visibilidade = - *Private* (só poderá ser usado dentro da classe) / - *Public* (Fora da classe)
    // Usar Métodos para Gravar os dados, e Métodos para Mostrar esses dados.
    internal class Transacao
    {
        private double PrecoProduto;
        private double ValorPago;

        public void GravarDados(double precoProduto, double valorPago) //Passar Parâmetros para Gravar
        {
           PrecoProduto = precoProduto;
            ValorPago = valorPago;

            //or this.PrecoProduto = PrecoProduto;
            //   this.ValorPago = ValorPago;

        }

        public double CalcularTroco()
        {
            if(ValorPago>=PrecoProduto)
            {
                return ValorPago - PrecoProduto;
            }
            else
            {
                return -1;
            }
        }

        public string MostrarDados() //Retornar como String
        {
            string aux = "";

            aux = "Valor do Produto:" + PrecoProduto.ToString("0.00");
            aux += "\nValor Pago: " + ValorPago.ToString("0.00");
            if(CalcularTroco() >= 0)
            {
                aux += "\n Troco: " + CalcularTroco().ToString("0.00");
            }
            else
            {
                aux += "\n Valor Insuficiente. ";
                
            }
            return aux;

        }
    }
}
//Introduzir o conceito de propriedades