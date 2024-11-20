namespace _5M13konSortowanieProsteWybieranie
{
    /*
     * zadeklaruj tablicę N elementową w Main()
     * napisz funkcję wypełniającą tablicę wartościami losowymi
     * z przedziału [0,m], funkcja ma dwa parametry: taablica 
     * oraz liczba m, jezeli użytkownik nie poda tej wartości 
     * przymowane jest 5*N
     * napisz funkcję wypisująca tablicę,tablica podawana jest jako parametr
     * napisz funkcję sortująca tablicę metodą przez proste wybieranie
     * algorytm dla sortowania w porządku rosnącym:
     * - w tablicy dla pozycji i znajdowana jest najmniejsza wartość
     *   w zakresie od i do końca i zamieniana z elementem na pozycji i
     * -to wykonywane jest dla wszystkich i od 0 do końca tablicy 
     * napisz funkcję wyszukująca najmniejszy element i zwracającą 
     * indeks tego elementu, funkcja przyjnuje tablicę i indeks 
     * początkowego elementu do przeszukiwania
     */
    internal class Program
    {
        private const int N = 50;
        static void Main(string[] args)
        {
            int[] tablica = new int[N];
            wylosujTablice(tablica);
            Console.WriteLine("tablica nieposortowana");
            wypisztablice(tablica);
            sortuj(tablica);
            Console.WriteLine("tablica posortowana");
            wypisztablice(tablica);
        }
        private static void wylosujTablice(int[] t, int m=5*N)
        {
            Random r = new Random();
            for (int i = 0; i < N; i++) 
                t[i] = r.Next(0, m+1);
        }
        private static void wypisztablice(int[] t)
        {
            foreach(int i in t)
                Console.Write($"{i}; ");
            Console.WriteLine();
        }
        private static int wyszujkajMin(int[]t , int poz)
        {
            int mi = poz;
            int mw = t[mi];
            for(int i = poz+1; i<N; i++)
                if(t[i] < mw)
                {
                    mw = t[i];
                    mi = i;
                }
            return mi;
        }
        private static void sortuj(int[] t)
        {
            for(int i = 0;i<N-1;i++)
            {
                int mi = wyszujkajMin(t,i);
                int temp = t[i];
                t[i] = t[mi];
                t[mi] = temp;
            }
        }

    }
}
