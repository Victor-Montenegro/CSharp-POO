using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Cliente gabriela = new Cliente();

            gabriela.cpf = "123.123.123-12";
            gabriela.nome = "Gabriela";
            gabriela.profissao ="Desenvolvedora C#";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;

            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(gabriela.nome);

            conta.titular.nome = "Gabriela Costa";

            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(gabriela.nome);
            */

            ContaCorrente conta = new ContaCorrente();

            conta.titular = new Cliente();

            conta.titular.nome = "Bruno";
            conta.titular.cpf = "212.123.123-22";
            conta.titular.profissao = "Desenvolvedor C#";

            Console.WriteLine(conta.titular.nome);
            Console.ReadLine();
        }
    }
}
