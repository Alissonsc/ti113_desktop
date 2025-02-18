namespace StatusAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o Nome do Aluno: ");
            string nome = Console.ReadLine()!;
            Console.Write("\n");
            Console.Write("Informe a Nota 1: ");
            //float nota1 = Convert.ToSingle(Console.ReadLine()!);
            float nota1 = float.Parse(Console.ReadLine()!);
            Console.Write("Informe a Nota 2: ");
            float nota2 = float.Parse(Console.ReadLine()!);

            float soma = nota1 + nota2;
            float media = soma / 2;
            float status = media

            Console.WriteLine($"A média de {nome} é {media}");

            if (media >= 6.0)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

        }
    }
}
