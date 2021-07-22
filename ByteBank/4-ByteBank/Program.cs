using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            Console.WriteLine(contaDoBruno.saldo);
            bool resultadoDoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoDoSaque);

            contaDoBruno.Depositar(1000);
            resultadoDoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine(resultadoDoSaque);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            ContaCorrente contaGabriela = new ContaCorrente();

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(contaGabriela.saldo);

            contaDoBruno.Transferir(100, contaGabriela);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(contaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
