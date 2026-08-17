using autocheck_dotnet.AutoCheck.ConsoleApp.Models;

ObterEntrada obterEntrada = new ObterEntrada();

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
        Console.WriteLine("1 - carro | 2 - moto | 3 - caminhão): ");
        int tipoVeiculo = obterEntrada.ObterInt("Informe o tipo de veículo: ");

        if (tipoVeiculo == 1)
        {
            Carro novoCarro = new Carro();
            novoCarro.Preencher();
            foreach(var item in novoCarro.ObterChecklistObrigatorio())
            {
                Console.WriteLine("Informe BOM, REGULAR ou RUIM");
                string status = obterEntrada.ObterString($"Informe o status do {item}: ");
                novoCarro.AdicionarItemVistoriado(item, status);
            }
            veiculosVistoriados.Add(novoCarro);

        } else if (tipoVeiculo == 2) {
            Moto novaMoto = new Moto();
            novaMoto.Preencher();
            foreach(var item in novaMoto.ObterChecklistObrigatorio())
            {
                Console.WriteLine("Informe BOM, REGULAR ou RUIM");
                string status = obterEntrada.ObterString($"Informe o status do {item}: ");
                novaMoto.AdicionarItemVistoriado(item, status);
            }
            veiculosVistoriados.Add(novaMoto);

        } else if (tipoVeiculo == 3)
        {
            Caminhao novoCaminhao = new Caminhao();
            novoCaminhao.Preencher();
            foreach(var item in novoCaminhao.ObterChecklistObrigatorio())
            {
                Console.WriteLine("Informe BOM, REGULAR ou RUIM");
                string status = obterEntrada.ObterString($"Informe o status do {item}: ");
                novoCaminhao.AdicionarItemVistoriado(item, status);
            }
            veiculosVistoriados.Add(novoCaminhao);

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
                item.ExibeRelatorioFinal();
            }    
        }
        
    } else if (opcao < 0 || opcao > 2)
    {
        Console.WriteLine("Opção inválida!");
    }
} while (opcao != 0);

Console.WriteLine("Até a próxima!");
