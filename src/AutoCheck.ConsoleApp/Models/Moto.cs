namespace autocheck_dotnet.AutoCheck.ConsoleApp.Models
{
    public class Moto : Veiculo
    {
        public Moto()
        {
            
        }
        public Moto(string marca, string modelo, int ano, double quilometragem, int cilindradas) : base( marca, modelo, ano, quilometragem)
        {
            this.Cilindradas = cilindradas;
        }
        public int Cilindradas { get; set; }

        public override List<string> ObterChecklistObrigatorio()
        {
            List<string> itensPai = base.ObterChecklistObrigatorio();
            List<string> itens = new List<string>{"Estado da Corrente de Transmissão", "Estado dos Manetes", "Estado do Guidão"};
            itensPai.AddRange(itens);
            return itensPai;
        }

        public override void Preencher()
        {
            ObterEntrada obterEntrada = new ObterEntrada();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=- Vistoria de Moto -=-=-=-=-=-=-=-=-=-=-=-");
            base.Preencher();
            Cilindradas = obterEntrada.ObterInt("- Informe as cilindradas: ");
        }

        public override void Imprimir()
        {
            Console.WriteLine($"-=-=-=-=-=-=-=-=--=-=- DADOS DA MOTO -=-=-=-=-=-=-=-=-=-=-=-");
            base.Imprimir();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=- ATRIBUTO ESPECÍFICO -=-=-=-=-=-=-=-=-=-");
            Console.WriteLine($"- Cilindradas: {Cilindradas}");
        }
    }
}
