using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ContaCorrente conta = new ContaCorrente();

            conta.saldo = -10;

            Console.WriteLine(conta.saldo);

            */

            ContaCorrente conta = new ContaCorrente();

            conta.Titular = new Cliente();

            conta.Titular.Nome = "Gabriela";
            conta.Titular.CPF = "123.123.123-23";
            conta.Titular.Profissao = "Desenvolvedor C#";

            conta.Saldo = -19;

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.CPF);

            Console.ReadLine();
        }
    }
}
