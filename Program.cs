using System;
using Financeiro;
using RH;

namespace Fundamentos
{
    class Aluno 
    {
        public string Nome;
        public int Idade;
    }

    class ContaCorrente
    {
        public string Numero;
        public decimal Saldo;

        public void ImprimirInformacoes()
        {
            Console.WriteLine($"Número: { Numero } | Saldo: { Saldo }");
        }

        public string ListarInformacoes()
        {
            return $"NÚMERO: { Numero } | SALDO: { Saldo }";
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* Hello World!
            Console.WriteLine("Hello World!");
            */
            
            /* Entrada e saída de dados no terminal
            Console.WriteLine("Digite seu nome:");
            var nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome);
            */

            /* Declaração de variáveis
            int idade;
            decimal altura;
            string nome;

            nome = "Janio Alexandre";
            string email = "janioalexandre@gmail.com";

            Console.WriteLine(email);
            */
            
            /* Conversões de tipos 
            decimal taxa = 12.98m;
            DateTime data = DateTime.Now;
            string taxa2 = taxa.ToString();
            string data2 = data.ToString();

            string resposta = "12";
            int idade = int.Parse(resposta);
            Console.WriteLine(idade);
            */ 

            /* O tipo String 
            var nome = "Janio";
            var sobrenome = "Alexandre";
            var nomeCompleto = nome + " " + sobrenome;
            var nomeCompleto2 = $"{ nome } { sobrenome }.";

            Console.WriteLine(nomeCompleto2.ToUpper());
            Console.WriteLine(nomeCompleto2.ToLower());   
            Console.WriteLine(nomeCompleto2.Substring(4));
            Console.WriteLine(nomeCompleto2.Substring(4, 5));
            Console.WriteLine(nomeCompleto2.Contains("a"));   
            Console.WriteLine(nomeCompleto2.StartsWith("J"));   
            Console.WriteLine(nomeCompleto2.EndsWith("e"));   
            Console.WriteLine(nomeCompleto2.IndexOf("a"));   
            Console.WriteLine(nomeCompleto2.LastIndexOf("e"));
            */

            /* O tipo DateTime 
            var hoje = DateTime.Today;
            var agora = DateTime.Now;
            var data1 = new DateTime(2024, 01, 05);
            var data2 = new DateTime(2024, 01, 05, 22, 57, 30);
            
            Console.WriteLine(data2.Day);
            Console.WriteLine(data2.Month);
            Console.WriteLine(data2.Year);
            Console.WriteLine(data2.Hour);
            Console.WriteLine(data2.Minute);
            Console.WriteLine(data2.Second);
            Console.WriteLine(data2.AddDays(5));
            Console.WriteLine(data2.AddMonths(-1));
            Console.WriteLine(data2.ToLongDateString());
            Console.WriteLine(data2.ToLongTimeString());
            Console.WriteLine(data2.ToShortDateString());
            Console.WriteLine(data2.ToShortTimeString());
            */

            /* Trabalhando com arrays 
            int[] numeros = new int[3];
            numeros[0] = 10;
            numeros[1] = 12;
            numeros[2] = 13;

            int[] pares = new int[3] { 2, 4, 6 };

            int[] impares = new int[] { 1, 3, 5};

            string[] nomes = new [] { "Janio", "Alexandre", "Ribeiro" };

            string[] paises = {"Brasil", "EUA", "França"}; 

            var cidades = new [] {"Baía Formosa", "Natal" };

            Console.WriteLine(cidades[0]);*/

            /* Operadores aritiméticos 
            var a = 7;
            var b = 3.0m;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            var c = 10 - b;
            Console.WriteLine(c);
            */

            /* Operadores aritiméticos - atribuição 

            var a = 5;
            var b = 5;
            var c = 5;
            var d = 5;
            var e = 5;

            a += 2; // a = a + 2;
            b -= 2; // b = b - 2;
            c *= 2; // c = c * 2;
            d /= 2; // d = d / 2;
            e %= 2; // e = e % 2;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            */

            /* Operadores aritiméticos - unários de incremento e decremento 

            var a = 5;
            var b = 5;

            a++;
            b--;

            Console.WriteLine(a);
            */

            /* Operadores aritiméticos - Operadores de comparação 
            var a = 2;
            var b = 3;
            var iguais = a == b;
            var diferentes = a != b;
            var maior = a > b;
            var maioOuIgual = a >= b; 
            var menorOuIgual = a <= b;
            
            Console.WriteLine(a == b);
            */
            
            /* Estruturas condicionais - IF 
            var a = 3;
            var b = 2;
            var ativo = true;
            if(a > b && ativo == true)
            {
                Console.WriteLine("Condição verdadeira");
                Console.WriteLine("É maior");
            }
            Console.WriteLine("Final");
            */

            /* Estrutura condicionais - IF-ELSE 
            var idade = 16;

            if (idade >= 18)
            {
                Console.WriteLine("Maior de idade");
                Console.WriteLine("Cadastro autorizado");            
            }
            else if (idade >= 16 && idade < 18)
            {
                Console.WriteLine("Menos de idade (>16 anos)");
                Console.WriteLine("Cadastro autorizado com responsáveis");            
            }
            else
            {
                Console.WriteLine("Menor de idade");
                Console.WriteLine("Cadastro não autorizado");
            }
            */

            /* Estrutura condicionais - Switch 
            Console.WriteLine("Selecione a opção:");
            var opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                Console.WriteLine("Seu saldo é R$ 100,00");
                break;
                case "2":
                Console.WriteLine("Informe o valor do depósito");
                break;
                case "3":
                Console.WriteLine("Informe o valor do saque");
                break;
                default:
                Console.WriteLine("Opção inválida");
                break;
            }
            */

            /* Estrutura de repetição - While 
            var indice = 0;
            var versoes = new[]{ "1.0", "1.1", "2.0", "3.0" };

            while(indice < versoes.Length)
            {
                Console.WriteLine(versoes[indice]);
                indice++;
            }
            */

            /* Estrutura de repetição - FOR 
            var numeros = new [] { 1, 10, 100, 1000 };
            
            for (var indice = 0; indice < numeros.Length; indice++)
            {
                Console.WriteLine(numeros[indice]);
            }
            */
            
            /* Estrutura de repetição - Foreach 
            var nomes = new[]{ "Joel", "Fagner", "Felipe" };

            foreach(var nome in nomes)
            {
                Console.WriteLine(nome);
            }
            */

            /* Estrutura de repetição - Trabalhando com classes 
            var aluno1 = new Aluno();
            aluno1.Nome = "Janio Alexandre";
            aluno1.Idade = 37;

            Console.WriteLine(aluno1.Nome);
            Console.WriteLine(aluno1.Idade);
            

            var conta1 = new ContaCorrente();
            conta1.Numero = "001-002";
            conta1.Saldo = 0;
            
            //conta1.ImprimirInformacoes();
            conta1.Depositar(100);
            Console.WriteLine(conta1.ListarInformacoes());  
            */

            /* 9 - Namespaces 
            
            var contaPagar = new ContaPagar();
            var contaReceber = new ContaReceber();
            var funcionario = new Funcionario();
            var folhaPagamento = new FolhaPagamento(); 
            */ 

            /* 10 - Tratamento de exceções 
            try
            {
                var nomes = new [] { "Janio", "Alexandre", "Ribeiro" };
                for (var indice = 0; indice <= nomes.Length; indice++)
                {
                    Console.WriteLine(nomes[indice]);
                }

            }
            catch(Exception excecao)
            {
                Console.WriteLine("Ocorreu um erro: " + excecao.Message);   
                Console.WriteLine("Ocorreu um erro: " + excecao.StackTrace);     
            }
            finally
            {
                Console.WriteLine("Programa encerrado.");
            }

            Console.WriteLine("Hello World");
            */
        }
    }
}