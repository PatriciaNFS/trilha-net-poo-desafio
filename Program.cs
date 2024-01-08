using DesafioPOO.Models;


                           
Console.Clear();
Console.WriteLine("Escolha o tipo de Smartphone: ");
Console.WriteLine("1- Nokia");
Console.WriteLine("2- Iphone");                    
int tipoSmartphone = Int32.Parse(Console.ReadLine());
                    
Smartphone smartphone = null; 
switch (tipoSmartphone)
    {
        case 1:
            smartphone = new Nokia ("(81) 998575899", "Nokia C2", "111222333444555", 32);
            break;
        case 2:
            smartphone = new Iphone("(81) 998778144", "Iphone 10", "555444333222111", 64);
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opção inválida, encerrando o programa.");                        
            break;
    }
        

bool encerrar = false;

while (!encerrar)
{
    Console.Clear();
    Console.WriteLine("Menu do Smartphone:");
    Console.WriteLine("1- Receber ligação");
    Console.WriteLine("2- Efetuar ligação");
    Console.WriteLine("3- Instalar aplicativo");
    Console.WriteLine("4- Encerrar");

    int opcao = Int32.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1: 
            smartphone.ReceberLigacao();
        break;
        case 2:
            smartphone.Ligar();
        break;
        case 3:
            Console.Write("Qual aplicativo você deseja instalar? ");
            string nomeApp = Console.ReadLine();
            smartphone.InstalarAplicativo(nomeApp);
        break;
        case 4:
            encerrar = true;
            Console.WriteLine("Desligando o Smartphone.");
        break;

        default:
            Console.WriteLine("Opção inválida.");
        break;
    } 
    Console.WriteLine("Pressione Enter para continuar!");
    Console.ReadLine();

}

