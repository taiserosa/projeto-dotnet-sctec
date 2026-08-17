namespace autocheck_dotnet.AutoCheck.ConsoleApp.Models
{
    public class Moto : Veiculo
    {
        public Moto(string marca, string modelo, int ano, double quilometragem, int cilindradas) : base( marca, modelo, ano, quilometragem)
        {
            this.Cilindradas = cilindradas;
        }
        public int Cilindradas { get; set; }

        public override List<string> ObterChecklistObrigatorio()
        {
            
        }

        public override void Preencher()
        {
            ObterNumero obterNumero = new ObterNumero();
            Console.WriteLine("=-=-=-=-= Vistoria de Moto =-=-=-=-=");
            base.Preencher();
            Cilindradas = obterNumero.ObterInt("Informe as cilindradas: ");
        }
    }
}