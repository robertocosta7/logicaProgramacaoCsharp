using System.Linq.Expressions;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("Informe Primeiro Número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe Primeiro Número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n1 - Adição \n2 - Subtração \n3 - Multiplicação \n4 - Divisão");

        Console.Write("Informe o operador: ");
        string operador = Console.ReadLine();

        double resultado = 0;

        switch (operador)
        {
            case "1":
                resultado = numero1 + numero2;
                Console.Write($"Resultado: {resultado}");
                break;
            case "2":
                resultado = numero1 - numero2;
                Console.Write($"Resultado: {resultado}");
                break;
            case "3":
                resultado = numero1 * numero2;
                Console.Write($"Resultado: {resultado}");
                break;
            case "4":
                if (numero2 != 0)
                {
                    resultado = (double)numero1 / numero2;
                    Console.Write($"Resultado: {resultado}");
                }
                else
                {
                    Console.Write("Erro: Divisão por zero não é permitida.");
                }
            break;
            default:
                Console.WriteLine("Operador Inválido");
                break;
        }
    }
}