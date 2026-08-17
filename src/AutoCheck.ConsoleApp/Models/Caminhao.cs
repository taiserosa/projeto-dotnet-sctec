namespace autocheck_dotnet.AutoCheck.ConsoleApp.Models
{
    public class Caminhao : Veiculo
    {
        public Caminhao(string marca, string modelo, int ano, double quilometragem, int quantidadeEixos, double capacidadeCargaToneladas) : base(marca, modelo, ano, quilometragem)
        {
            this.QuantidadeEixos = quantidadeEixos;
            this.CapacidadeCargaToneladas = capacidadeCargaToneladas;
        }
        public int QuantidadeEixos { get; set; }
        public double CapacidadeCargaToneladas { get; set; }

        public override List<string> ObterChecklistObrigatorio()
        {
            
        }

        public override void Preencher()
        {
            ObterNumero obterNumero = new ObterNumero();
            Console.WriteLine("=-=-=-=-= Vistoria de Caminhão =-=-=-=-=");
            base.Preencher();
            QuantidadeEixos = obterNumero.ObterInt("Informe a quantidade de eixos: ");
            CapacidadeCargaToneladas = obterNumero.ObterDouble("Informe a capacidade de carga (em toneladas): ");
        }
    }
}