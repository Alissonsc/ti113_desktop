namespace CadastroUsuarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 7:");
            int numero = int.Parse(Console.ReadLine());

            string diaDaSemana = numero switch
            {
                1 => "Domingo",
                2 => "Segunda-feira",
                3 => "Terça-feira",
                4 => "Quarta-feira",
                5 => "Quinta-feira",
                6 => "Sexta-feira",
                7 => "Sábado",
                _ => "Número inválido. Por favor, digite um número de 1 a 7."
            };

            Console.WriteLine(diaDaSemana);
        }
    }
}