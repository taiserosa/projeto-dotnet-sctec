namespace autocheck_dotnet.AutoCheck.ConsoleApp.Models
{
    public abstract class Veiculo
    {
        public Veiculo()
        {
            
        }
        public Veiculo(string marca, string modelo, int ano, double quilometragem)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Quilometragem = quilometragem;
        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Quilometragem { get; set; }
        public List<ItemVistoria> VistoriaRealizada = new List<ItemVistoria>(); 

        public void AdicionarItemVistoriado(string nome, string status)
        {
            ItemVistoria item = new ItemVistoria(nome, status);
            VistoriaRealizada.Add(item);
        }

        public virtual List<string> ObterChecklistObrigatorio()
        {
            List<string> itensChecklist= new List<string>{"Nível de Óleo do Motor", "Estado da bateria", "Estado dos pneus", "Estado dos freios", "Documentação Regularizada", "Funcionamento das luzes"};
            return itensChecklist;
        }

        public virtual void Preencher()
        {
            ObterEntrada obterEntrada = new ObterEntrada();

            Marca = obterEntrada.ObterString("- Informe a marca: ");

            Modelo = obterEntrada.ObterString("- Informe o modelo: ");

            Ano = obterEntrada.ObterInt("- Informe o ano: ");

            Quilometragem = obterEntrada.ObterDouble("- Informe a quilometragem: ");
        }

        public virtual void Imprimir()
        {
            Console.WriteLine($"- Marca: {Marca}");
            Console.WriteLine();
            Console.WriteLine($"- Modelo: {Modelo}");
            Console.WriteLine();
            Console.WriteLine($"- Ano: {Ano}");
            Console.WriteLine();
            Console.WriteLine($"- Quilometragem: {Quilometragem}");            
        }
    }
}