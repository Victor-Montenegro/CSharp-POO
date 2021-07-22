using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_byteBank
{
    class ContaCorrente
    {
        public ContaCorrente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        
        private double _saldo;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }
        public static int TotalDeContas{ get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContas++;
        }

        public void Depositar(double valor)
        {
            if(valor < 0)
            {
                return;
            }

            _saldo += valor;

        }

        public bool Sacar(double valor)
        {
            if(valor > _saldo)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public bool Transferir(double valor,ContaCorrente contaDestino)
        {
            if(valor > _saldo)
            {
                return false;
            }

            _saldo -= valor;

            contaDestino.Depositar(valor);

            return true;

        }
    }
}
