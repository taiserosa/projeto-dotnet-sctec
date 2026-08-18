using autocheck_dotnet.AutoCheck.ConsoleApp.Models;

namespace autocheck_dotnet.Services
{
    public class MotorVistoria
    {
        

        public void RealizarVistoria(Veiculo veiculo)
        {
            ObterEntrada obterEntrada = new ObterEntrada();

            foreach(var item in veiculo.ObterChecklistObrigatorio())
            {
                Console.WriteLine("=-=-=-= ITENS A SEREM INSPECIONADOS =-=-=-=");

                Console.WriteLine("Informe BOM, REGULAR ou RUIM");
                
                string status = obterEntrada.ObterString($"Informe o status do {item}: ");
                
                veiculo.AdicionarItemVistoriado(item, status);
                
                Console.WriteLine("=-=-=-= INSPEÇÃO CONCLUÍDA =-=-=-=");
                
            }
        }

        public void ExibePendencias(Veiculo veiculo)
        {
            if (veiculo.VistoriaRealizada.Count == 0)
            {
                Console.WriteLine("Nenhuma pendência registrada!");
            }
            foreach(var item in veiculo.VistoriaRealizada)
            {
                if (item.Status.ToUpper() == "RUIM")
                {
                    Console.WriteLine("=-=-=-= ITENS CRÍTICOS / REPROVADOS (AÇÃO IMEDIATA) =-=-=-=");
                    Console.WriteLine($"- {item.Nome} - Status: {item.Status} - Item Crítico!");

                } else if (item.Status.ToUpper() == "REGULAR") 
                {
                    Console.WriteLine("=-=-=-= ITENS DE ATENÇÃO (REVISÃO PREVENTIVA) =-=-=-=");
                    Console.WriteLine($"- {item.Nome} - {item.Status} - Item de Atenção!");
                }
            }
        }

        public void ExibeRelatorioFinal(Veiculo veiculo)
        {
            veiculo.Imprimir();
            Console.WriteLine($"=-=-=-= AVALIAÇÃO DOS ITENS INSPECIONADOS ({veiculo.VistoriaRealizada.Count} itens) =-=-=-=");

            Console.WriteLine("=-=-=-= RESUMO DA PONTUAÇÃO =-=-=-=");
            Console.WriteLine($"- Pontuação Atingida: {veiculo.CalculaPontuacao():F2} de {veiculo.VistoriaRealizada.Count*10} pontos possíveis");
            Console.WriteLine($"- Percentual de Aprovação: {veiculo.CalculaPercentual()}%");
            Console.WriteLine($"- Classificação Final: [{veiculo.ClassificaVeiculo()}]");
            Console.WriteLine("=-=-=-= RELATÓRIO DE MANUTENÇÃO E RECOMENDAÇÕES DA OFICINA =-=-=-=");
            ExibePendencias(veiculo);
        }
    }
}