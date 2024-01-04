namespace Fundamentos
{
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
            
            /* Conversões de tipos */ 
            decimal taxa = 12.98m;
            DateTime data = DateTime.Now;
            string taxa2 = taxa.ToString();
            string data2 = data.ToString();

            string resposta = "12";
            int idade = int.Parse(resposta);
            
            Console.WriteLine(idade);
        }
    }
}