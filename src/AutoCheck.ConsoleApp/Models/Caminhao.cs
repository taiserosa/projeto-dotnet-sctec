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

        public override ChecklistObrigatorio()
        {
            
        }
    }
}