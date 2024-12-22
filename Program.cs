namespace _08_GetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Ryan";
            Console.WriteLine(p.Nome);
            // Os metodos get e set servem para que o objeto tenha acesso a um atributo privado de forma com que o atributo nao deixe de ser privado. ele pode alterar o valor do atributo com set, pois, estara enviando uma informacao para o atributo, ja com o get, ele apenas consulta o atributo e pega esse valor.
        }
    }
}
