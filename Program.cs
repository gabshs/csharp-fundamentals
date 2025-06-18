class Program
{
    static void Main(string[] args)
    {
        var menu = true;

        while (menu)
        {
            Console.WriteLine("Escolha uma opção:\n");
            Console.WriteLine("1. Dizer Olá");
            Console.WriteLine("2. Dizer Olá com nome completo");
            Console.WriteLine("3. Calcular números");
            Console.WriteLine("4. Contar caracteres em uma palavra");
            Console.WriteLine("5. Validar placa de veículo");
            Console.WriteLine("6. Formatar data atual");
            Console.WriteLine("0. Sair");

            string option = Console.ReadLine()!;

            switch (option)
            {
                case "1":
                    Challanges.SayHello();
                    Console.WriteLine();
                    break;
                case "2":
                    Challanges.SayHelloFullName();
                    Console.WriteLine();
                    break;
                case "3":
                    Challanges.CalculateNumbers();
                    Console.WriteLine();
                    break;
                case "4":
                    Challanges.CountCharacters();
                    Console.WriteLine();
                    break;
                case "5":
                    Challanges.validateLicensePlate();
                    Console.WriteLine();
                    break;
                case "6":
                    Challanges.FormatCurrentDate();
                    Console.WriteLine();
                    break;
                case "0":
                    menu = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}