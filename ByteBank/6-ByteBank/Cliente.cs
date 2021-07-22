using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ByteBank
{
    public class Cliente
    {

        public string Nome { get; set; }
        public string _CPF;
        public string Profissao { get; set; }

        public string CPF
        {
            get
            {
                return _CPF;
            }
            set
            {
                _CPF = value;
            }
        }
    }
}
