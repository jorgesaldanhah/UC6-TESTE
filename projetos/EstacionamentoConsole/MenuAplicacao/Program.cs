bool sair = false;

while (!sair)
{
    Console.Clear();
    Console.WriteLine("===== Sistema de Estacionamento =====");
    Console.WriteLine("1. Listar Clientes");
    Console.WriteLine("2. Adicionar Cliente");
    Console.WriteLine("3. (A FAZER) Gerenciar Veículos");
    Console.WriteLine("4. (A FAZER) Gerenciar Vagas");
    Console.WriteLine("5. Ver detalhes do Cliente");
    Console.WriteLine("0. Sair");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            MenuClientes();
            break;
        case "2":
            MenuVagas();
            break;
        case "3":
            Console.WriteLine("Menu Veículos");
            break;
        case "4":
            Console.WriteLine("Menu Registros");
            break;
        case "0":
            sair = true;
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            Console.ReadKey();
            break;
    }
}

Console.WriteLine("Encerrando o sistema. Até logo!");

static void MenuClientes()
    
{

    Console.Clear();
    Console.WriteLine("Chamou o menu de clientes");
    Console.WriteLine("Pressione a tecla retornar");
    Console.ReadKey();

    
}

static void MenuVagas()

{

    Console.Clear();
    Console.WriteLine("Chamou o menu de Vagas");
    Console.WriteLine("Pressione a tecla retornar");
    Console.ReadKey();


}
Console.WriteLine("Encerrando o sistema ate logo! ");