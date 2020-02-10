using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDigital
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variável do tipo ContaCorrente com a instância da classe
            ContaCorrente contaDoJoao = new ContaCorrente();
            contaDoJoao.titular = "João";
            contaDoJoao.agencia = 2424;
            contaDoJoao.conta = 001222;
            contaDoJoao.saldo += 100;
         

            Console.WriteLine("Titular: " + contaDoJoao.titular);
            Console.WriteLine("Agência: " + contaDoJoao.agencia);
            Console.WriteLine("conta: " + contaDoJoao.conta); // numero;
            Console.WriteLine("saldo: " + contaDoJoao.saldo);
            
            //função Sacar
            contaDoJoao.Sacar(40);
            Console.WriteLine("Saldo após o saque é de R$ " + contaDoJoao.saldo);

            //Função depositar
            contaDoJoao.Depositar(500);
            Console.WriteLine("Saldo após o depósito é de R$ " + contaDoJoao.saldo);

            
            //programa  uma conta nova para transferência
            ContaCorrente contaDaMaria = new ContaCorrente();
            contaDaMaria.titular = "Maria";
            Console.WriteLine("O saldo da conta da Maria é R$ " + contaDaMaria.saldo);


            //o código para transferir dinheiro a conta nova:
            contaDoJoao.Transferir(540, contaDaMaria);
            Console.WriteLine("O saldo da conta do João agora é R$ " + contaDoJoao.saldo);
            Console.WriteLine("O saldo da conta da Maria agora é R$ " + contaDaMaria.saldo);


            //Apenas para teste, guarde o resultado da transferência em uma variável booleana e depois verifique se o resultado foi True ou False:
            bool resultadoTransferencia = contaDoJoao.Transferir(540, contaDaMaria);
            Console.WriteLine("Resultado da transferência é " + resultadoTransferencia);


    

            Console.ReadLine();
        }
    }
}
