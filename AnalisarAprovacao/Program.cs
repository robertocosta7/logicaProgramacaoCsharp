/*O seu programa deve receber a nota do aluno pelo console e depois você vai fazer uma operação lógica para saber se a nota do aluno
 * é maior que 70. O resultado dessa operação lógica deve ser atribuido a uma variável do tipo Boolean*/
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informar sua nota: ");
        double nota = Convert.ToDouble(Console.ReadLine());

        bool aprovado = nota > 7;

        if (aprovado)
        {
            Console.WriteLine($"{nota} -> Aprovado!");
        }
        else
        {
            Console.WriteLine($"{nota} -> Reprovado!");
        }

    }

}
