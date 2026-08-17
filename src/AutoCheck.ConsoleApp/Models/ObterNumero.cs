namespace autocheck_dotnet.AutoCheck.ConsoleApp.Models
{
   public class ObterNumero
    {
        public int ObterInt(string msg) {
            Console.WriteLine(msg);

            bool ehNumero = int.TryParse(Console.ReadLine(), out int num);
            
            while (!ehNumero)
            {
                Console.WriteLine("Número inválido! Digite novamente!");
                ehNumero = int.TryParse(Console.ReadLine(), out num);
            }
            return num;
        }

        public double ObterDouble(string msg) {
            Console.WriteLine(msg);

            bool ehNumero = double.TryParse(Console.ReadLine(), out double num);
            
            while (!ehNumero)
            {
                Console.WriteLine("Número inválido! Digite novamente!");
                ehNumero = double.TryParse(Console.ReadLine(), out num);
            }
            return num;
        }
    }
}