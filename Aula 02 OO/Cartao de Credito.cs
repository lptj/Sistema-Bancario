using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02_OO
{
    public class Cartao_de_Credito
    {
        public double NumeroCartao { get; set; }
        public int Senha { get; set; }
        public string Limite { get; set; }
        public string Bandeira { get; set; }
        public DateTime DataVencimento { get; set; }
        public int DigitoVerificador { get; set; }
        public string Cliente { get; set; }

    }
}
