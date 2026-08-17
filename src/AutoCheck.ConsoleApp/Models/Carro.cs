namespace autocheck_dotnet.AutoCheck.ConsoleApp.Models
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }

        public override void ObterChecklistObrigatorio() {
        
        }

        public override void Preencher()
        {
            ObterNumero obterNumero = new ObterNumero();
            Console.WriteLine("=-=-=-=-= Vistoria de Carro =-=-=-=-=");
            base.Preencher();
            Console.WriteLine("Informe a quantidade de portas: ");
            QuantidadePortas = obterNumero.ObterInt(Console.ReadLine());
        }
    }
}