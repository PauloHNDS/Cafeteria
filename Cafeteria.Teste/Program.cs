using Cafeteria.Business;
using Cafeteria.Repository.Context;
using Cafeteria.Repository.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace Cafeteria.Teste
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;
            
            do
            {
                Console.Clear();
                
                Console.WriteLine("Escolha uma das opções \n" +
                    "1 - categoria : \n" +
                    "2 - alimento : \n" +
                    "3 - comida : \n" +
                    "4 - estruturas : \n" +
                    "5 - usuarios : \n" +
                    "6 - Variações : \n" +
                    "7 - sair :");

                var opcao = Console.ReadLine() ?? "7";

            if (opcao.Equals("1"))
            {
                    MenuCategoria();
            }
            else if (opcao.Equals("2"))
            {

            }
            else if (opcao.Equals("3"))
            {

            }
            else if (opcao.Equals("4"))
            {

            }
            else if (opcao.Equals("5"))
            {

            }
            else if (opcao.Equals("6"))
            {

            }
            else if (opcao.Equals("7"))
            {
                    continua = false;
            }
            else
            {
                Console.WriteLine("opção não encontrada !!!");
                Console.ReadKey();
            }

            } while (continua);

        }

        static async void MenuCategoria()
        {

            DbContextOptionsBuilder<Contexto> opcaoContexto = new DbContextOptionsBuilder<Contexto>();

            opcaoContexto.UseSqlite("Data Source=cafeteria.db;");

            Contexto contexto = new Contexto(opcaoContexto.Options);

            await contexto.Database.EnsureCreatedAsync();

            CategoriaRepository repository = new CategoriaRepository(contexto);


            var continua = true;

            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das opções para Categoria : \n" +
                    "1 - cadastrar nova categoria. \n" +
                    "2 - buscar categoria pelo id. \n" +
                    "3 - atualizar uma categoria. \n" +
                    "4 - apagar uma categoria. \n" +
                    "5 - listar todas categorias. \n" +
                    "6 - volta ao menu.");

                var opcao = Console.ReadLine() ?? "5";
                
                if (opcao.Equals("1"))
                {
                    Categoria categoria = new();

                    Console.WriteLine("informa o nome da categoria :");
                    categoria.Nome = Console.ReadLine() ?? "";

                    Console.WriteLine("informe o local da imagem da categoria : ");
                    categoria.Imagem = Console.ReadLine() ?? "";

                    await repository.Insert(categoria);

                    await repository.Persistir();

                }
                else if (opcao.Equals("2"))
                {
                    Console.WriteLine("digite o ID :");
                    var id = Convert.ToInt32(Console.ReadLine());
                    var result = await repository.Get(id);
                    if (result is null)
                    {
                        Console.WriteLine("não encontrado !!!!");
                        Console.ReadKey();
                        continue;
                    }
                    Console.WriteLine($"id : {result.Nome}");
                    Console.WriteLine($"Nome : {result.Nome}");
                    Console.WriteLine($"Imagem:  {result.Imagem}");
                }
                else if (opcao.Equals("3"))
                {

                }
                else if (opcao.Equals("4"))
                {

                }
                else if (opcao.Equals("5"))
                {
                    var result = await repository.Get();

                    Console.Write("|");
                    Console.Write(("id").PadRight(3, ' '));
                    Console.Write("|");
                    Console.Write(("nome").PadRight(20, ' '));
                    Console.Write("|");
                    Console.Write(("imagem").PadRight(20, ' '));
                    Console.Write("|");
                    Console.WriteLine();
                    Console.WriteLine(("-").PadRight(47, '-'));
                    foreach (var item in result)
                    {
                        Console.Write("|");
                        Console.Write((item.Id.ToString()).PadRight(3, ' '));
                        Console.Write("|");
                        Console.Write((item.Nome).PadRight(20, ' '));
                        Console.Write("|");
                        Console.Write((item.Imagem).PadRight(20, ' '));
                        Console.Write("|");
                        Console.WriteLine();
                        Console.WriteLine(("-").PadRight(47,'-'));

                    }
                    Console.ReadKey();
                }
                else if (opcao.Equals("6"))
                {
                    continua = false;
                }
                else
                {
                    Console.WriteLine("opção não encontrada !!!");
                    Console.ReadKey();
                }
            } while (continua);
        }
    }
}