namespace autocheck_dotnet.AutoCheck.ConsoleApp.Models
{
    public abstract class Veiculo
    {
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
        public List<string> ItemVistoria = new List<string>(); 

        public void AdicionarItemVistoriado(string nome, string status)
        {
            
        }

        public virtual List<string> ObterChecklistObrigatorio()
        {
            Console.WriteLine();
        }

        public virtual void Preencher()
        {
            Console.WriteLine("Informe a marca: ");
            Marca = Console.ReadLine();

            Console.WriteLine("Informe o modelo: ");
            Modelo = Console.ReadLine();

            Console.WriteLine("Informe o ano: ");
            Ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quilometragem: ");
            Quilometragem = Convert.ToDouble(Console.ReadLine());
        }

        
    }
}