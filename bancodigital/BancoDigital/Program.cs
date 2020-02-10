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
            contaDoJoao.saldo += 200;
         

            Console.WriteLine("Titular: " + contaDoJoao.titular);
            Console.WriteLine("Agência: " + contaDoJoao.agencia);
            Console.WriteLine("conta: " + contaDoJoao.conta);
            Console.WriteLine("saldo: " + contaDoJoao.saldo);
            
            Console.ReadLine();
        }
    }
}
