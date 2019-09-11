using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Teste"); // Mostra um texto na tela igual o printf

            Cliente objCliente = new Aula_02_OO.Cliente(); // Depois do = Significa Instanciar objetos

            objCliente.Codigo = 1;  // Inserindo Dados - Quando colocar o nome da classe e digar . "Ex. objCliente." automaticamente aparece todos atributos criados
            objCliente.Nome = "Leandro"; // Sempre que for escrever usar aspas dupla
            objCliente.Sexo = "Masculino";
            objCliente.CPF = "666.666.666-65";
            objCliente.Endereco = "T Avino n 96";

            Cliente objCliente2 = new Aula_02_OO.Cliente();
            objCliente2.Codigo = 2;
            objCliente2.Nome = "Jussara";
            objCliente2.Sexo = "Feminino";
            objCliente2.CPF = "123.456.789-35";
            objCliente2.Endereco = "Rua X, n 25";

            Cliente objCliente3 = new Cliente();
            objCliente3.Codigo = 3;
            objCliente3.Nome = "Rafael";
            objCliente3.Sexo = "Masculino";
            objCliente3.CPF = "345.478.648-14";
            objCliente3.Endereco = "Rua do zeh, n 6000";

            // Console.WriteLine(objCliente2.Nome); - Vai escrever na tela os atributos dessa classe
            // Console.WriteLine(objCliente.CPF);
            // objCliente.InformarCliente(); - Vai informar todos os atributos da classe Cliente

            Conta objConta = new Conta();
            
            objConta.Tipo = "Corrente";
            objConta.Numero = 01004320; // Quando o numero for muito grande usar o "double
            objConta.Data = new DateTime(2017/02/13); // Sempre usar o new DateTime pois se trata de um comando secundario e pode envolver mais dados
            objConta.Limite = 4000.00m; // quando for decimal e tiver . colocar o m depois do número para saber que é um valor decimal
            objConta.Agencia = 0146;
            objConta.Cliente = "Josias";

            int opcao = 0;
            do
            {
                objConta.MostrarSaldo();
                Console.WriteLine("Escolha uma das opções: ");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Mostrar Saldo");
                Console.WriteLine("0 - Sair");

                opcao = Convert.ToInt32(Console.ReadLine()); // Necessário converter o string para numero para funcionar ( O int32 é o tamanho que é de 32Bits = Int

                switch (opcao)  // Switch Case 
                {
                    case 1:
                        Console.WriteLine("Digite um valor a depositar: ");
                        decimal vlDeposito = Convert.ToDecimal (Console.ReadLine());
                        objConta.Depositar(vlDeposito);
                        break;

                    case 2:
                        Console.WriteLine("Digite um valor a sacar: ");
                        decimal vlSacar = Convert.ToDecimal(Console.ReadLine());
                        objConta.Sacar(vlSacar);
                        break;

                    case 3:
                        objConta.MostrarSaldo();
                        break;

                    case 0:
                        Console.WriteLine("Até logo");
                        break;

                    default:
                        Console.WriteLine("Comando Inválido");
                        break;

                }
                Console.ReadKey();
                Console.Clear();

            } while (opcao != 0);

            // objConta.Depositar(12000);  Se nao tiver casa decimal nao precisa por o m
            

            Cartao_de_Credito objCartao = new Cartao_de_Credito();
            objCartao.NumeroCartao = 1002450678940216;
            objCartao.Senha = 1234;
            objCartao.Limite = "R$ 4000";
            objCartao.Bandeira = "Visa";
            objCartao.DataVencimento = new DateTime(2020 / 10 / 15);
            objCartao.DigitoVerificador = 348;
            objCartao.Cliente = "Pablo";

            Funcionario objFuncionario = new Funcionario();
            objFuncionario.Nome = "Torres";





        // Console.ReadKey(); Essa linha trava a tela ate uma tecla ser digitada = Return 0; do C++
        }
    }
}
