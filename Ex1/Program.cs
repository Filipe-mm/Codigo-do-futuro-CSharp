namespace Basico
{
    class Program
    {
        static void Main(string[] args)
        {
            var produtos = new List<Produto>();

            bool sair = true;

            while (sair)
            {
                Console.WriteLine("1 - Cadastrar produto:");
                Console.WriteLine("2 - Lista de produtos:");
                Console.WriteLine("3 -  Sair do sistema!");

                Console.Write("Digite uma das opções acima:");

                int op = Convert.ToInt16(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        string nome;
                        int id;
                        int quantidade;

                        Console.WriteLine("\n\n\n\n\n\n\n\n");

                        Console.Write("Digite o id do produto: ");
                        id = Convert.ToInt16(Console.ReadLine());


                        do
                        {
                            Console.Write("Digite o nome do produto: ");
                            nome = Console.ReadLine();

                        } while (nome == "");


                        Console.Write("Digite a quantidade do produto: ");
                        quantidade = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("\n\n\n\n\n\n\n\n");

                        var novoProduto = new Produto() { Id = id, Nome = nome, Quantidade = quantidade };
                        produtos.Add(novoProduto);

                        break;

                    case 2:
                        Console.WriteLine("\n\n\n\n\n\n\n\n");

                        Console.WriteLine("Lista de Produtos:");
                        foreach (var produto in produtos)
                        {
                            Console.WriteLine($"ID: {produto.Id} - NOME: {produto.Nome} - QUANTIDADE: {produto.Quantidade}");
                        }

                        Console.WriteLine("\n\n\n\n\n\n\n\n");

                        break;

                    case 3:
                        sair = false;
                        break;

                    default:
                        Console.WriteLine("\n\n\n\n\n\n\n\n");
                        Console.WriteLine("Escolha errada, escolha novamente !!!!!!!");
                        Console.WriteLine("\n\n\n\n\n\n\n\n");
                        break;
                }

            }
        }
    }

    class Produto
    {
        public int Id;
        public string Nome;
        public int Quantidade;
    }
}