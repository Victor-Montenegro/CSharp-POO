using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contagabriela = new ContaCorrente();

            contagabriela.titular = "gabriela";
            contagabriela.numero = 1243124;
            contagabriela.agencia = 432;

            ContaCorrente contaGabrielaCosta = new ContaCorrente();
            contaGabrielaCosta.titular = "gabriela";
            contaGabrielaCosta.numero = 1243124;
            contaGabrielaCosta.agencia = 432;

            Console.WriteLine("Igualdade por tipo de referencia" + (contagabriela == contaGabrielaCosta));

            int idade = 22;
            int idade2 = 22;

            Console.WriteLine("Igualdade por tipo de valor" + (idade == idade2));

            contagabriela = contaGabrielaCosta;

            Console.WriteLine((contaGabrielaCosta == contagabriela));

            contagabriela.saldo = 300;

            Console.WriteLine(contagabriela.saldo);
            Console.WriteLine(contaGabrielaCosta.saldo);

            Console.ReadLine();

        }
    }
}
