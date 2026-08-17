using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace autocheck_dotnet.AutoCheck.ConsoleApp.Models
{
    public class Caminhao : Veiculo
    {
        public int QuantidadeEixos { get; set; }
        public double CapacidadeCargaToneladas { get; set; }

        public override void ChecklistObrigatorio()
        {
            
        }

        public override void Preencher()
        {
            ObterNumero obterNumero = new ObterNumero();
            Console.WriteLine("=-=-=-=-= Vistoria de Caminhão =-=-=-=-=");
            base.Preencher();
            Console.WriteLine("Informe a quantidade de eixos: ");
            QuantidadeEixos = obterNumero.ObterInt(Console.ReadLine());
            Console.WriteLine("Informe a capacidade de carga (em toneladas): ");
            CapacidadeCargaToneladas = obterNumero.ObterDouble(Console.ReadLine());
        }
    }
}