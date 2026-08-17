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
            Console.WriteLine("Informe a marca: ");
            Marca = Console.ReadLine();

            Console.WriteLine("Informe o modelo: ");
            Modelo = Console.ReadLine();

            Console.WriteLine("Informe o ano: ");
            Ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quilometragem: ");
            Quilometragem = Convert.ToDouble(Console.ReadLine());
        }

        public virtual void Imprimir()
        {
            Console.WriteLine($"=-=-=-=-=-= DADOS DO VEÍCULO =-=-=-=-=");
            Console.WriteLine($"- Marca: {Marca}");
            Console.WriteLine($"- Modelo: {Modelo}");
            Console.WriteLine($"- Ano: {Ano}");
            Console.WriteLine($"- Quilometragem: {Quilometragem}");            
        }



        public void RealizarVistoria()
        {
            
        }



        public int CalculaPontuacao()
        {
            int pontuacao = 0;
            foreach (var item in VistoriaRealizada)
            {
                if (item.Status.ToUpper() == "BOM")
                {
                    pontuacao += 10;
                } else if (item.Status.ToUpper() == "REGULAR")
                {
                    pontuacao += 5;
                } 
            } 
            return pontuacao;   
        }

        public double CalculaPercentual()
        {
            int totalItens = 0;
            foreach (var item in VistoriaRealizada)
            {
                totalItens += 1;
            }
            double percentual = (double)CalculaPontuacao() / (double)(totalItens * 10)  * 100;
            return percentual;
        }

        public void ClassificaVeiculo()
        {
            double percentual = CalculaPercentual();
            if (percentual <= 59)
            {
                Console.WriteLine("Reprovado na Vistoria!");
            } else if (percentual >= 60 && percentual <= 89)
            {
                Console.WriteLine("Aprovado com Apontamentos!");
            } else if (percentual >= 90 && percentual <= 100)
            {
                Console.WriteLine("Aprovado com Excelência!");
            }
        }

        public void ExibePendencias()
        {
            if (VistoriaRealizada.Count == 0)
            {
                Console.WriteLine("Nenhuma pendência registrada!");
            }
            foreach(var item in VistoriaRealizada)
            {
                if (item.Status.ToUpper() == "REGULAR")
                {
                    Console.WriteLine($"{item.Nome} - {item.Status} - Item de Atenção!");
                } else if (item.Status.ToUpper() == "RUIM")
                {
                    Console.WriteLine($"{item.Nome} - Status: {item.Status} - Item Crítico!");
                }
            }
        }

        public void ExibeRelatorioFinal()
        {
            Imprimir();
            Console.WriteLine("");
            CalculaPontuacao();
            CalculaPercentual();
            ClassificaVeiculo();
            ExibePendencias();
        }
    }
}