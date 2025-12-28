class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Digite valor do Produto: ");
        double valorProduto = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite valor passado pelo cliente: ");
        double valorPassadoCliente = Convert.ToDouble(Console.ReadLine());

        double resultado = valorPassadoCliente - valorProduto;

        Console.WriteLine("..............Resultado..............");
        if (resultado < 0)
        {
            Console.WriteLine("Valor Pago é insuficiente!");
        }
        else
        {

            Console.WriteLine($"Preço Produto: {valorProduto:C}");
            Console.WriteLine($"Valor Pago:{valorPassadoCliente:C}");
            Console.WriteLine($"Valor Troco:{resultado:C}");

        }

    }
}