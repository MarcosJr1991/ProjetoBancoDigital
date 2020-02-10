using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDigital
{
    public class ContaCorrente
    {
        public string titular;
        public int agencia;
        public int conta; // numero;
        public double saldo;

        //Função Sacar 
                    public bool Sacar(double valor)
            {
                if (this.saldo >= valor)
                {
                    this.saldo -= valor;
	       Console.WriteLine("Saque realizado com sucesso.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Função não permitida, saldo insuficiente");
                    return false;   
                }

    }

       //FUNÇÃO DEPOSITAR (SEM RETORNO)
       public void Depositar(double valor)
       	 {
            		Console.WriteLine("Depósito realizado COM SUCESSO.");
           		 this.saldo += valor;
        }


        //FUNÇÃO TRANSFERENCIA
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            	if (this.saldo >= valor)
           	{
            this.saldo -= valor;
        	//contaDestino.saldo += valor;
	    // Mas como fizemos o método Depositar, podemos usá-lo em vez
	    // de lidar com a lógica de acessar o campo saldo da classe.	
	        contaDestino.Depositar(valor);
    	Console.WriteLine("Transferência realizado com sucesso");
	    return true;
            }
            else
            {
                Console.WriteLine("Saldo insufiente para Transferência R$ " +saldo);
         return false;            
}
        }


    }


}
    
