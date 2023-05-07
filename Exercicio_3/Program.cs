namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.WriteLine("Indique o número de quartos a alugar: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("ID do Aluguer: " + i);
                Console.Write("Nome do aluno: ");
                string nome = Console.ReadLine();
                Console.Write("Email do aluno: ");
                string email = Console.ReadLine();
                Console.Write("Número do Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);


                }

            }
        }
    }
}