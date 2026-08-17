namespace autocheck_dotnet.AutoCheck.ConsoleApp.Models
{
    public class ItemVistoria
    {
        public string Nome { get; set; }
        public string Status { get; set; }

        public ItemVistoria(string nome, string status)
        {
            this.Nome = nome;
            this.Status = status;
            ValidaStatus(status);
        }
        public void ValidaStatus(string status)
        {
            ObterEntrada obterString = new ObterEntrada();
            status = status.ToUpper();
            while (status != "BOM" && status != "REGULAR" && status != "RUIM")
            {
                status = obterString.ObterString("Informe o status (Bom, Regular ou Ruim): ").ToUpper();
            }
            this.Status = status;
        }
    }
}