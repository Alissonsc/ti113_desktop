namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double valorHora;
            short quantHora;

            Console.Write("Digite o Seu Nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o número de horas trabalhadas: ");
            quantHora = Convert.ToInt16(Console.ReadLine());
            
            Console.Write("Digite o valor por hora: ");
            valorHora = Convert.ToDouble(Console.ReadLine());

            double total = valorHora * quantHora;

            Console.WriteLine($@"
            O valor total de {nome} é R$ {total:f2}
            ");
         }
    }
}
