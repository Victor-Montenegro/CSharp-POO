using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_byteBank
{
    class Cliente
    {
        public string Nome { get; set; }
        public string profissao { get; set; }

        private string _cpf;

        public string CPF 
        {
            get
            {
                return _cpf;
            }
            set
            { 
                if(value.Length != 11)
                {
                    return;
                }

                _cpf = value;
            } 
        }
       

    }
}
