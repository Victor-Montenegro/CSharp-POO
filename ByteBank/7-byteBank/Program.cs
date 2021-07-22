using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_byteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(831, 123122);
            ContaCorrente conta2 = new ContaCorrente(123, 11232);
            ContaCorrente conta3 = new ContaCorrente(123, 11232);
            ContaCorrente conta4 = new ContaCorrente(123, 11232);
            ContaCorrente conta5 = new ContaCorrente(123, 11232);
            ContaCorrente conta22 = new ContaCorrente(123, 11232);

            Console.WriteLine(ContaCorrente.TotalDeContas);

            Console.ReadLine();

        }
    }
}
