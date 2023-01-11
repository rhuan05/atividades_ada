namespace av1mod3
{
    internal class Pessoa
    {
        public string nome;
        public int idade;

        public void Cumprimentar()
        {
            Console.WriteLine("Olá prgrama, tudo bem por aí??");
        }

        public void DizerIdade(int idade)
        {
            Console.WriteLine($"Eu tenho {idade} anos!");
        }
    }
}
