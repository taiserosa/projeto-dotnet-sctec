namespace autocheck_dotnet.AutoCheck.ConsoleApp.Models
{
    public class Carro : Veiculo
    {
        public Carro()
        {
            
        }
        public Carro(string marca, string modelo, int ano, double quilometragem, int quantidadePortas) : base( marca, modelo, ano, quilometragem)
        {
            this.QuantidadePortas = quantidadePortas;
        }
        public int QuantidadePortas { get; set; }

        public override List<string> ObterChecklistObrigatorio() 
        {
            List<string> itensChecklist= new List<string>{"Macaco e Chave de Roda", "Funcionamento dos Airbags", "Funcionamento do Ar-condicionado"};
            return itensChecklist;
        }

        public override void Preencher()
        {
            ObterEntrada obterNumero = new ObterEntrada();
            Console.WriteLine("=-=-=-=-= Vistoria de Carro =-=-=-=-=");
            base.Preencher();
            QuantidadePortas = obterNumero.ObterInt("Informe a quantidade de portas: ");
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("> ATRIBUTOS(S) ESPECÍFICO(S)");
            Console.WriteLine($"- Quantidade de portas: {QuantidadePortas}");
        }
    }
}