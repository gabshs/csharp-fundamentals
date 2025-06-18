class Challanges
{
    public static void SayHello()
    {
        Console.Write("Digite seu nome: ");
        string name = Console.ReadLine()!;
        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
    }

    public static void SayHelloFullName()
    {
        Console.Write("Digite seu primeiro nome: ");
        string firstName = Console.ReadLine()!;
        Console.Write("Digite seu sobrenome: ");
        string lastName = Console.ReadLine()!;
        Console.WriteLine($"Olá, {firstName} {lastName}! Seja muito bem-vindo!");
    }

    public static void CalculateNumbers()
    {
        Console.Write("Digite o primeiro número: ");
        double number1 = double.Parse(Console.ReadLine()!);
        Console.Write("Digite o segundo número: ");
        double number2 = double.Parse(Console.ReadLine()!);
        Console.WriteLine($"A soma é: {number1 + number2}");
        Console.WriteLine($"A subtração é: {number1 - number2}");
        Console.WriteLine($"A multiplicação é: {number1 * number2}");
        Console.WriteLine($"A divisão é: {number1 / number2}");
        Console.WriteLine($"A media é: {(number1 + number2) / 2}");
    }

    public static void CountCharacters()
    {
        Console.Write("Digite uma palavra: ");
        string word = Console.ReadLine()!;
        int count = 0;

        foreach (char c in word)
        {
            if (char.IsLetter(c))
            {
                count++;
            }
        }
        Console.WriteLine($"A palavra contém {count} letras.");
    }

    public static void validateLicensePlate()
    {
        Console.Write("Digite a placa do veículo (formato ABC1234): ");
        string plate = Console.ReadLine()!.ToUpper();

        if (plate.Length != 7 || !char.IsLetter(plate[0]) || !char.IsLetter(plate[1]) || !char.IsLetter(plate[2]) ||
            !char.IsDigit(plate[3]) || !char.IsDigit(plate[4]) || !char.IsDigit(plate[5]) || !char.IsDigit(plate[6]))
        {
            Console.WriteLine("Placa inválida.");
        }
        else
        {
            Console.WriteLine("Placa válida.");
        }
    }

    public static void FormatCurrentDate()
    {
        var menu = true;
        while (menu)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
            Console.WriteLine("2. Formato DD/MM/YYYY");
            Console.WriteLine("3. Formato HH:MM");
            Console.WriteLine("4. Formato por extenso");
            Console.WriteLine("0. Sair");
            string option = Console.ReadLine()!;

            switch (option)
            {
                case "1":
                    FormatAndDisplayCurrentDate();
                    Console.WriteLine();
                    break;
                case "2":
                    FormatDateWithTime();
                    Console.WriteLine();
                    break;
                case "3":
                    FormatTime();
                    Console.WriteLine();
                    break;
                case "4":
                    FormatDateInWords();
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
        DateTime currentDate = DateTime.Now;
        string formattedDate = currentDate.ToString("dd/MM/yyyy");
        Console.WriteLine($"Data atual formatada: {formattedDate}");
    }

    public static void FormatAndDisplayCurrentDate()
    {
        DateTime currentDate = DateTime.Now;
        string formattedDate = currentDate.ToString("dddd, dd 'de' MMMM 'de' yyyy 'às' HH:mm:ss");
        Console.WriteLine($"Data atual formatada: {formattedDate}");
    }
    public static void FormatDateWithTime()
    {
        DateTime currentDate = DateTime.Now;
        string formattedDate = currentDate.ToString("dd/MM/yyyy HH:mm");
        Console.WriteLine($"Data e hora atual formatada: {formattedDate}");
    }
    public static void FormatDateInWords()
    {
        DateTime currentDate = DateTime.Now;
        string formattedDate = currentDate.ToString("dd 'de' MMMM 'de' yyyy");
        Console.WriteLine($"Data atual por extenso: {formattedDate}");
    }
    public static void FormatTime()
    {
        DateTime currentDate = DateTime.Now;
        string formattedTime = currentDate.ToString("HH:mm");
        Console.WriteLine($"Hora atual formatada: {formattedTime}");
    }
}