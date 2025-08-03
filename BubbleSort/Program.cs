using System.Runtime.CompilerServices;
using BubbleSort;

class Program
{
    private static ListaLigada miLista = new ListaLigada();
    static void Main(string[] args)
    {
        //Bubble Sort
        miLista.Adicionar(3);
        miLista.Adicionar(15);
        miLista.Adicionar(15);
        miLista.Adicionar(7);
        miLista.Adicionar(19);
        miLista.Adicionar(11);
        miLista.Adicionar(1);

        miLista.Transversa();

        //Swap(1, 2);
        //miLista.Transversa();

        double m = 0;
        double n = 0;
        double cantidad = miLista.Cantidad();

        //Console.WriteLine($"Son {cantidad} elementos");

        //Hacemos los pases correspondientes

        for (m = 1;  m< cantidad; m++)
        {
            //Recorremos la lista verificando si hay que hacer swap.
            //los elementos hasta la derecha ya van qedando ordenados.
            for (n = 0;  n< cantidad-m; n++)
            {
                if (miLista[n]> miLista[n+1])
                {
                    Swap(n, n + 1);
                }
            }
            Console.WriteLine($"Ciclo {m}");
            miLista.Transversa();
        }
        Console.WriteLine();
        Console.WriteLine("La lista ordenada es:");
        Console.WriteLine();
        miLista.Transversa();
        Console.ReadLine();
    }
    private static void Swap(double indice1, double indice2)
    {
        double temp = miLista[indice1];
        miLista[indice1] = miLista[indice2];
        miLista[indice2] = temp;
    }
}