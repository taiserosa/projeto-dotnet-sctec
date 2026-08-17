namespace autocheck_dotnet.AutoCheck.ConsoleApp.Models
{
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public override void ObterChecklistObrigatorio()
        {
            
        }

        public override void Preencher()
        {
            ObterNumero obterNumero = new ObterNumero();
            Console.WriteLine("=-=-=-=-= Vistoria de Moto =-=-=-=-=");
            base.Preencher();
            Console.WriteLine("Informe as cilindradas: ");
            Cilindradas = obterNumero.ObterInt(Console.ReadLine());
        }
    }
}