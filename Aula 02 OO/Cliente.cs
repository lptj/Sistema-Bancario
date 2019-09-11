using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02_OO
{
    public class Cliente
    {
        public int Codigo { get; set; } // digitar "prop" e apertar tab 2x ja gera automático o código. Ñ precisa de ponto e virgula por causa da chave
        public string Nome { get; set; } // propriedade publica (public) é algo que se pode acessar de outras classes
        public string Sexo { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }

        // TERÁ UMA AULA DE VOID - void nao retorna nenhum resultado pra quem chama, não é necessário possui atributos entao ele mostra todos os campos

        public void InformarCliente()
        { // Essas chaves = Escopo de Código
            Console.WriteLine(); // Para pular a linha
            Console.WriteLine("Informacões do Cliente " + Codigo);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Sexo: " + Sexo);
            Console.WriteLine("CPF: " + CPF);
            Console.WriteLine("Endereco: " + Endereco);
        }

    }
}
