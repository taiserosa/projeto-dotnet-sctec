using autocheck_dotnet.AutoCheck.ConsoleApp.Models;
using autocheck_dotnet.Services;

ObterEntrada obterEntrada = new ObterEntrada();
MotorVistoria motorVistoria = new MotorVistoria();

Console.WriteLine("-=-=-=-= Bem-vindo ao AutoCheck! =-=-=-=-");

int opcao;

List<Veiculo> veiculosVistoriados = new List<Veiculo>();

do
{
    Console.WriteLine("0 - Sair");
    Console.WriteLine("1 - Realizar Nova Vistoria");
    Console.WriteLine("2 - Exibir Relatório das Vistorias");

    opcao = obterEntrada.ObterInt("Informe a opção que deseja: ");
    
    if (opcao == 1)
    {
        Console.WriteLine("1 - Carro | 2 - Moto | 3 - Caminhão): ");
        int tipoVeiculo = obterEntrada.ObterInt("Informe o tipo de veículo: ");

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
            obterEntrada.ObterInt("Opção inválida! Digite Novamente!");
        }
    } else if (opcao == 2)
    {
        Console.WriteLine("=-=-=-= RELATÓRIO DAS VISTORIAS =-=-=-=");
        if (veiculosVistoriados.Count == 0)
        {
            Console.WriteLine("Nenhuma vistoria realizada até o momento!");
        } else
        {
            foreach (var item in veiculosVistoriados)
            {
                motorVistoria.ExibeRelatorioFinal(item);
            }    
        }
        
    } else if (opcao < 0 || opcao > 2)
    {
        Console.WriteLine("Opção inválida!");
    }
} while (opcao != 0);

Console.WriteLine("Até a próxima!");
