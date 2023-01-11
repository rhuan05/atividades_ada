namespace av1mod3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pessoa que cumprimenta e diz a idade.
            Console.WriteLine("Pessoa:");
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Cumprimentar();
            pessoa1.DizerIdade(18);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            // Aluno que vai à escola, cumprimenta e diz a idade.
            Console.WriteLine("Aluno:");
            Aluno aluno1 = new Aluno();
            aluno1.IrParaEscola();
            aluno1.Cumprimentar();
            aluno1.DizerIdade(21);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            // Professor que cumprimenta, diz a idade e explica sobre um determinado assunto.
            Console.WriteLine("Professor:");
            Professor professor1 = new Professor();
            professor1.Cumprimentar();
            professor1.DizerIdade(30);
            professor1.Explicar("Clique no link do meet e entre na reunião. Assim você conseguirá entrar na aula.");
            Console.WriteLine();
        }
    }
}