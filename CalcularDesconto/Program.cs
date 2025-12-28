class Program
{
    static void Main(String[] args) 
    {
        Console.Write("Informe valor produto:");
        double precoProduto = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe Quantidade de Produtos:");
        double quantidade = Convert.ToDouble(Console.ReadLine());

        double subTotal = precoProduto * quantidade;

        double total;
        double desconto;

        if (quantidade >= 10)
        {
            desconto = (subTotal * 0.10);
            total = subTotal - desconto;
            Console.Write($"Total: {total:C}");
        }
        else
        {
            total = subTotal;
            Console.Write($"Total: {total:C}");
        }
    }
}