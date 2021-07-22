using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Isabela";
            conta.agencia = 847;
            conta.numero = 123712;

            Console.WriteLine(conta);

            Console.ReadLine();
        }
    }
}
