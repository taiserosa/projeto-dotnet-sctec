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
            List<string> itensPai = base.ObterChecklistObrigatorio();
            List<string> itens = new List<string>{"Macaco e Chave de Roda", "Funcionamento dos Airbags", "Funcionamento do Ar-condicionado"};
            itensPai.AddRange(itens);
            return itensPai;
        }

        public override void Preencher()
        {
            ObterEntrada obterEntrada = new ObterEntrada();

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=- Vistoria de Carro -=-=-=-=-=-=-=-=-=-=-");
            base.Preencher();
            QuantidadePortas = obterEntrada.ObterInt("- Informe a quantidade de portas: ");
        }

        public override void Imprimir()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=- DADOS DO CARRO -=-=-=-=-=-=-=-=-=-=-");
            base.Imprimir();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=- ATRIBUTO ESPECÍFICO -=-=-=-=-=-=-=-=-=-");
            Console.WriteLine($"- Quantidade de portas: {QuantidadePortas}");
        }
    }
}