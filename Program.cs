
using System;

class Program
{
    public static int LerOpcao()
    {
        Console.Write("Qual a sua opção: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public static void Menu()
    {
        Console.WriteLine("1. Inserir operandos");
        Console.WriteLine("2. Adição");
        Console.WriteLine("3. Subtração");
        Console.WriteLine("4. Multiplicação");
        Console.WriteLine("5. Divisão");
        Console.WriteLine("6. Raíz quadrada");
        Console.WriteLine("7. Sair");
    }

    public static void LerOperandos(ref int a, ref int b)
    {
        Console.Write("Digite o primeiro operando: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo operando: ");
        b = Convert.ToInt32(Console.ReadLine());
    }

    public static void Adicionar(int a, int b)
    {
        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
    }

    public static void Subtrair(int a, int b)
    {
        Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
    }
    public static void Multiplicar(int a, int b)
    {
        Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
    }
    public static void Dividir(int a, int b)
    {
        if (b != 0)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, 1F * a / b);
        }
        else
        {
            Console.WriteLine("Divisão por zero.");
        }
    }
    public static void RaizQuadrada(int a)
    {
        if (a < 0)
        {
            Console.WriteLine("Raiz imaginária.");
        }
        else
        {
            Console.WriteLine("Raiz Quadrada de {0} = {1}", a, Math.Sqrt(a));
        }
    }

    public static void Main(string[] args)
    {
        int a = 10, b = 3, op = 0;

        do
        {
            Menu();
            op = LerOpcao();
            switch (op)
            {
                case 1:
                    LerOperandos(ref a, ref b);
                    break;
                case 2:
                    Adicionar(a, b);
                    break;
                case 3:
                    Subtrair(a, b);
                    break;
                case 4:
                    Multiplicar(a, b);
                    break;
                case 5:
                    Dividir(a, b);
                    break;
                case 6:
                    RaizQuadrada(a);
                    break;
                case 7:
                    Console.WriteLine("Até breve!!");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (op != 7);
    }
}
