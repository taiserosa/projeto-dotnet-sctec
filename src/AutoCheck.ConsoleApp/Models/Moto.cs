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
            List<string> itensChecklist= new List<string>{"Estado da Corrente de Transmissão", "Estado dos Manetes", "Estado do Guidão"};
            return itensChecklist;
        }

        public override void Preencher()
        {
            ObterEntrada obterNumero = new ObterEntrada();
            Console.WriteLine("=-=-=-=-= Vistoria de Moto =-=-=-=-=");
            base.Preencher();
            Cilindradas = obterNumero.ObterInt("Informe as cilindradas: ");
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("> ATRIBUTOS(S) ESPECÍFICO(S)");
            Console.WriteLine($"- Cilindradas: {Cilindradas}");
        }
    }
}