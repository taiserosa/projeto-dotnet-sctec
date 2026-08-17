namespace autocheck_dotnet.AutoCheck.ConsoleApp.Models
{
    public class Carro : Veiculo
    {
        public Carro(string marca, string modelo, int ano, double quilometragem, int quantidadePortas) : base( marca, modelo, ano, quilometragem)
        {
            this.QuantidadePortas = quantidadePortas;
        }
        public int QuantidadePortas { get; set; }

        public override List<string> ObterChecklistObrigatorio() {
        
        }

        public override void Preencher()
        {
            ObterNumero obterNumero = new ObterNumero();
            Console.WriteLine("=-=-=-=-= Vistoria de Carro =-=-=-=-=");
            base.Preencher();
            QuantidadePortas = obterNumero.ObterInt("Informe a quantidade de portas: ");
        }
    }
}