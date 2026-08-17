namespace autocheck_dotnet.AutoCheck.ConsoleApp.Models
{
    public abstract class Veiculo
    {
        public Veiculo(string marca, string modelo, DateTime ano, decimal quilometragem)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Quilometragem = quilometragem;
        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }
        public decimal Quilometragem { get; set; }
        public List<string> ItemVistoria = new List<string>(); 

        public void AdicionarItemVistoriado(string nome, string status)
        {
            
        }

        public virtual List<string> ObterChecklistObrigatorio()
        {
            
        }

        public virtual void Preencher()
        {
            Console.WriteLine("Informe a marca: ");
            Marca = Console.ReadLine();

            Console.WriteLine("Informe o modelo: ");
            Modelo = Console.ReadLine();

            Console.WriteLine("Informe o ano: ");
            Ano = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe a quilometragem: ");
            Quilometragem = Convert.ToDecimal(Console.ReadLine());
        }
    }

}