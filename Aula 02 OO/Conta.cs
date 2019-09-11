using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02_OO
{
    public class Conta // Não esquecer de tornar publico para poder chamar de qualquer classe
    {
        public int Agencia { get; set; }
        public double Numero { get; set; }
        private decimal Saldo { get; set; }
        public string Tipo { get; set; }
        public DateTime Data { get; set; }
        public decimal Limite { get; set; } // Cabe muito mais numeros (128 Bits)
        public string Cliente { get; set; }


        public void MostrarSaldo()
        
        {
            Console.WriteLine("Saldo: {0:c}", Saldo); // Com o {0} = o printf com float 2.f por ex. onde após a virgula ele entra com o valor do {0}
            Console.WriteLine();                      // com o {0:c} (Currency) ele ja puxa em formato monetário colocando R$ automático.
        }
        public void Depositar(decimal vlDeposito)
        {
            Saldo += vlDeposito; // += significa incrementar igual no C++ onde é igual a i++; = Saldo = Saldo + vlDeposito;
            Console.WriteLine("Foi depositado {0:C} na sua conta" , vlDeposito);
            MostrarSaldo();
        }
        public void Sacar (decimal vlSacar)
        {
            Saldo -= vlSacar;
            Console.WriteLine("Foi sacado {0:C} na sua conta", vlSacar);
            MostrarSaldo();
        }
    }
}
