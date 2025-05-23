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
        miLista.Adicionar(7);
        miLista.Adicionar(19);
        miLista.Adicionar(11);
        miLista.Adicionar(1);

        miLista.Transversa();

        //Swap(1,3);
        // miLista.Transversa();

        double m = 0;
        double n = 0;
        
        miLista.Transversa();
    }
    private static void Swap(double indice1, double indice2)
    {
        double temp = miLista[indice1];
        miLista[indice1] = miLista[indice2];
        miLista[indice2] = temp;
    }
}