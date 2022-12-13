using System.Text.Json;

namespace Ex2json
{
    class Program
    {
        public static void Main(string[] args)

        {
            
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\filip\OneDrive\Área de Trabalho\.Net\Ex2json\arquivosJson\");
            foreach (FileInfo f in di.GetFiles())
            {
                if (f.Extension.ToLower() == ".json")

                {
                    using (StreamReader r = new StreamReader($"{f}"))
                    {
                        string json = r.ReadToEnd();
                        var cliente = JsonSerializer.Deserialize<Cliente>(json, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });
                        Console.WriteLine($"Nome: {cliente.Nome} - Telefone: {cliente.Telefone}");
                    }

                }

            }



        }
        

    }
    class Cliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
