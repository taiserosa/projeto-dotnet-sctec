namespace autocheck_dotnet.AutoCheck.ConsoleApp.Models
{
    public class Caminhao : Veiculo
    {
        public Caminhao()
        {
            
        }
        public Caminhao(string marca, string modelo, int ano, double quilometragem, int quantidadeEixos, double capacidadeCargaToneladas) : base(marca, modelo, ano, quilometragem)
        {
            this.QuantidadeEixos = quantidadeEixos;
            this.CapacidadeCargaToneladas = capacidadeCargaToneladas;
        }
        public int QuantidadeEixos { get; set; }
        public double CapacidadeCargaToneladas { get; set; }

        public override List<string> ObterChecklistObrigatorio()
        {
            List<string> itensPai = base.ObterChecklistObrigatorio();
            List<string> itens = new List<string>{"Estado da Suspensão", "Tacógrafo", "Sistema de Freio Pneumático"};
            itensPai.AddRange(itens);
            return itensPai;
        }

        public override void Preencher()
        {
            ObterEntrada obterEntrada = new ObterEntrada();

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=- VISTORIA DE CAMINHÃO -=-=-=-=-=-=-=-=-=-");
            base.Preencher();
            QuantidadeEixos = obterEntrada.ObterInt("Informe a quantidade de eixos: ");
            CapacidadeCargaToneladas = obterEntrada.ObterDouble("Informe a capacidade de carga (em toneladas): ");
        }

        public override void Imprimir()
        {
            Console.WriteLine($"-=-=-=-=-=-=-=-=-=-=- DADOS DO CAMINHÃO -=--=-=-=-=-=-=-=-=-");
            base.Imprimir();
            Console.WriteLine("> ATRIBUTOS(S) ESPECÍFICO(S)");
            Console.WriteLine($"- Quantidade de eixos: {QuantidadeEixos}");
            Console.WriteLine($"- Capacidade de carga (toneladas): {CapacidadeCargaToneladas}");
        }
    }
}