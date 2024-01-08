namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero {get; set;}
        private string Modelo {get; }
        private string Imei {get; }
        private int Memoria {get; }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
        public void ReceberLigacao()
        {
            Console.Clear();
            Console.WriteLine("Recebendo ligação...");
            Console.WriteLine("Spam...");
            Thread.Sleep(500);
            Console.WriteLine("Ligação perigosa");
            Thread.Sleep(800);
            Console.WriteLine("\nAtender ligação?(S/N)");
            string opcao = Console.ReadLine();

            if (opcao == "S" || opcao == "s") 
            {
              Console.WriteLine("Oi, a TIM tem uma nova oferta para você!...");
              
            }
            else if (opcao == "N" || opcao == "n")
            {
                Console.WriteLine("Chamada recusada...");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção inválida, tente novamente.");
                ReceberLigacao();
            }

        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
