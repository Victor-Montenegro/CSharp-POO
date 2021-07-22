
namespace _6_ByteBank
{
    public class ContaCorrente
    {
        //quando não tem regra de negocio e usual ser fazer assim
        public Cliente Titular {get; set;}
        public int agencia;
        public int numero;
        // o underline e uma boa pratica para simbolizar que o atributo e private
        private double _saldo = 100;
        
        //boa pratica
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 100)
                {
                    return;
                }

                _saldo = value;
            }
        }

        /*
        public void SetSaldo(double saldo)
        {
            if(saldo < 100)
            {
                return;
            }

            this.saldo = saldo;

        }

        public double GetSaldo()
        {
            return this.saldo;
        }
        */
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo  += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo  -= valor;

            contaDestino.Depositar(valor);
            return true;
        }
    }
}