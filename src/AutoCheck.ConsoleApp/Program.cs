
using autocheck_dotnet.AutoCheck.ConsoleApp.Models;

ObterNumero obterNumero = new ObterNumero();

Console.WriteLine("-=-=-=-= Bem-vindo ao AutoCheck! =-=-=-=-");

Console.WriteLine("Informe a opção que deseja: ");
Console.WriteLine("0 - Sair");
Console.WriteLine("1 - Realizar Nova Vistoria");
Console.WriteLine("2 - Exibir Relatório de Vendas");

int opcao = obterNumero.ObterInt(Console.ReadLine());

List<Veiculo> veiculosVistoriados = new List<Veiculo>();

do
{
    if (opcao == 1)
    {
        Console.WriteLine("Informe o tipo de veículo: ");
        Console.WriteLine("1 - carro | 2 - moto | 3 - caminhão): ");

        int tipoVeiculo = obterNumero.ObterInt(Console.ReadLine());

        if (tipoVeiculo == 1)
        {
            Carro novoCarro = new Carro();
            novoCarro.Preencher();
            veiculosVistoriados.Add(novoCarro);

        } else if (tipoVeiculo == 2) {
            Moto novaMoto = new Moto();
            novaMoto.Preencher();
            veiculosVistoriados.Add(novaMoto);

        } else if (tipoVeiculo == 3)
        {
            Caminhao novoCaminhao = new Caminhao();
            novoCaminhao.Preencher();
            veiculosVistoriados.Add(novoCaminhao);

        } else
        {
            Console.WriteLine("Opção inválida! Digite Novamente!");
        }
    } else if (opcao == 2)
    {
        
    } else if (opcao < 0 || opcao > 2)
    {
        Console.WriteLine("Opção inválida!");
    }
} while (opcao != 0);

Console.WriteLine("Até a próxima!");
