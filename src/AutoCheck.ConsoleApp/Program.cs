using autocheck_dotnet.AutoCheck.ConsoleApp.Models;
using autocheck_dotnet.Services;

ObterEntrada obterEntrada = new ObterEntrada();
MotorVistoria motorVistoria = new MotorVistoria();

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("-=-=-=-=-=-=-=-=- Bem-vindo ao AutoCheck! -=-=-=-=-=-=-=-=-=-");

int opcao;

List<Veiculo> veiculosVistoriados = new List<Veiculo>();

do
{
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    Console.WriteLine(" 0 - Sair");
    Console.WriteLine(" 1 - Realizar Nova Vistoria");
    Console.WriteLine(" 2 - Exibir Relatório das Vistorias");
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

    opcao = obterEntrada.ObterInt("- Informe a opção que deseja: ");
    
    if (opcao == 1)
    {
        int tipoVeiculo;
        do
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("1 - Carro | 2 - Moto | 3 - Caminhão): ");
            tipoVeiculo = obterEntrada.ObterInt("- Informe o tipo de veículo (1, 2 ou 3): ");

            if (tipoVeiculo == 1)
            {
                Veiculo novoVeiculo = new Carro();
                novoVeiculo.Preencher();
                motorVistoria.RealizarVistoria(novoVeiculo);
                veiculosVistoriados.Add(novoVeiculo);

            } else if (tipoVeiculo == 2) {
                Veiculo novoVeiculo = new Moto();
                novoVeiculo.Preencher();
                motorVistoria.RealizarVistoria(novoVeiculo);
                veiculosVistoriados.Add(novoVeiculo);

            } else if (tipoVeiculo == 3)
            {
                Veiculo novoVeiculo = new Caminhao();
                novoVeiculo.Preencher();
                motorVistoria.RealizarVistoria(novoVeiculo);
                veiculosVistoriados.Add(novoVeiculo);

            } else
            {
                Console.WriteLine("--- Opção inválida para tipo de veículo! ---");
            }
        } while(tipoVeiculo < 1 || tipoVeiculo > 3);
        
    } else if (opcao == 2)
    {
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=- RELATÓRIO DAS VISTORIAS -=-=-=-=-=-=-=-=-");

        if (veiculosVistoriados.Count == 0)
        {
            Console.WriteLine(" Nenhuma vistoria realizada até o momento!");
        } else
        {
            foreach (var item in veiculosVistoriados)
            {
                motorVistoria.ExibeRelatorioFinal(item);
            }    
        }
        
    } else if (opcao < 0 || opcao > 2)
    {
        Console.WriteLine("--- Opção inválida! ---");
    }
} while (opcao != 0);

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("-=-=-=-=-=-=--=--=-=- ATÉ A PRÓXIMA! -=-=-=-=-=-=--=-=-=-=-=-");
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
