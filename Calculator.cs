class Calculadora
{
    public static void Iniciar()
    {
        Console.WriteLine("Escolha a operação desejada:\n" +
            "1) Soma\n" +
            "2) Subtração\n" +
            "3) Multiplicação\n" +
            "4) Divisão");

        Console.Write("> ");
        string operacao = Console.ReadLine();

        Console.Write("Número 1: ");
        float number1 = float.Parse(Console.ReadLine());
        Console.Write("Número 2: ");
        float number2 = float.Parse(Console.ReadLine());

        float? resultado = Calculp(operacao, number1, number2);

        if (resultado == null)
        {
            Console.WriteLine("Faz certo da próxima");
            return;
        }

        Console.WriteLine($"Resultado: {resultado}");
    }

    public static float? Calcula(string operacao, float number1, float number2)
    {
        return operacao switch
        {
            "1" => number1 + number2,
            "2" => number1 - number2,
            "3" => number1 * number2,
            "4" => number1 / number2,
            _ => (float?)null
        };
    }
}