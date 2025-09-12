using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _03_Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conta conta = new Conta();
            //Conta conta = new Conta();
            Conta conta = new Conta("999-88");

            Conta nome = new Conta ("Luis Gustavo");
           
            Conta.Nome = "Luis Gustavo de Sousa Soeiro";
            //Não é possivel atribuir o valor em um atributo privado
           // conta.numero = "999-88";


            // conta.saldo = -1000.00
            conta.Depositar(-1000.000m);

            //Ultilizando o méôtodo acessador
            conta.setSaldo(1000.00m);

            
            


            while (true)
            {
                Console.WriteLine("Informe  a Operação: [D]-Depositar, [S]-Sacar ou [E]-Sair");
                string operacao = Console.ReadLine();

                if (operacao.ToUpper() == "D")
                {
                    Console.WriteLine("informe o valor para deposito");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "S")
                {
                    Console.WriteLine("informe o  valor para saque: ");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorDeposito);
                    conta.ImprimirSaldo();
                }
                else if(operacao.ToUpper()=="E")
                {
                    Console.WriteLine($"Conta: {conta.getNumero()} Nome: {conta.Nome} Saldo: {conta.getSaldo()} ");
                    break;
                }
                else
                {
                    Console.WriteLine("Informe apenas as Letras[D] para Depositar, [S]  para sacar ou [E] para Sair");
                }

            }
        }
    }

    public class Conta
    {
        private string numero;
        

        public Conta(string numero)
        {
            this.numero = numero;
        }
        public string getNumero()
        {
            return numero;
        }

        private string nome;

         public string getNome()
        {
            return nome;
        }
        public string setNome(string nome)
        {
            this setNome(nome);
        }

       


        //transforma a conta saldo em acesso privado
        // public decimal Saldo;
        private decimal saldo;

        //Métôdos acessadores
        public decimal getSaldo()
        {
            return saldo;
        }

        public void setSaldo(decimal saldo)
        {
            this.Depositar(saldo);
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
                saldo += valor;
            else
                Console.WriteLine("Valor do deposito incorreto, deve ser maior que zero!");
        }

        public void Sacar(decimal valor)
        {
            saldo -= valor;
        }

        public void ImprimirSaldo()
        {
            //Console.WriteLine($"Saldo Atual: {getsaldo:c2}");
            Console.WriteLine($"Saldo Atual: {saldo:c2}");
        }

    }
}
