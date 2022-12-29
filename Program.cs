namespace Lab03_Search
{
    class Program
    {
        static int BusquedaLinealID(int[] A, int n, int clave)
        {
            int i;
            for (i = 0; i < n; i++)
                if (A[i] == clave)
                    return i;
            return -1;
        }
        static int busquedaBinaria(int[] lista, int n, int clave)
        {
            int bajo = 0, alto = n - 1, central;
            while (bajo <= alto)
                {
                central = (bajo + alto) / 2;
                if (lista[central] == clave)
                {
                    return central;
                }
                else if (clave < lista[central])
                {
                    alto = central - 1; 
                }
                else
                {
                    bajo = central + 1;
                }
            }
            return -1;
        }
        static void Burbuja(int[] A, int n){
        int i,j;
        int auxiliar;
        for(i = 0; i < n-1; i++){
            for(j = 0; j < n-1-i; j++){
                if(A[j] > A[j + 1]){
                    auxiliar = A[j];
                    A[j] = A[j+1];
                    A[j+1] = auxiliar;
                }
            }
        }
    }

        static void Main(string[] args)
        {
            int[] A = {79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24, 11, 18, 74, 95, 69, 27, 87, 8};
            int n = A.Length;

            Console.WriteLine("Búsqueda lineal: ");
            Console.WriteLine("Ingrese el dato a buscar: ");
            int clave = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Arreglo desordenado: ");
            Console.WriteLine("Elemento(posición)");
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + "(" + i + ") ");
            }
            Console.WriteLine();
            DateTime start1 = DateTime.Now;
            int posicionEncontrada1 = BusquedaLinealID(A, n, clave);
            Console.WriteLine("Elemento encontrado en posición: " + posicionEncontrada1);
            DateTime end1 = DateTime.Now;
            TimeSpan ts1 = (end1 - start1);
            Console.WriteLine("Tiempo de ejecucion búsqueda lineal {0} ms", ts1.TotalMilliseconds);

            Console.WriteLine();
            Console.WriteLine("Búsqueda binaria: ");
            Console.WriteLine("Arreglo desordenado: ");
            Console.WriteLine("Elemento(posición)");
            for (int j = 0; j < n; j++)
            {
                Console.Write(A[j] + "(" + j + ") ");
            }
            Console.WriteLine();
            DateTime start2 = DateTime.Now;
            int posicionEncontrada2 = busquedaBinaria(A, n, clave);
            Console.WriteLine("Elemento encontrado en posición: " + posicionEncontrada2);
            DateTime end2 = DateTime.Now;
            TimeSpan ts2 = (end2 - start2);
            Console.WriteLine("Tiempo de ejecucion búsqueda binaria {0} ms", ts2.TotalMilliseconds);

            Random rnd = new Random();
            int num;
            int[] B = new int[100];
            for(int i = 0; i < B.Length; i++){
                num = rnd.Next(1,201);
                B[i] = num;
            }
            int posicionEncontrada3, exitos = 0, buscados = 50;
            int[] C = new int[buscados];
            for(int i = 0; i < buscados; i++){
                num = rnd.Next(1,201);
                C[i] = num;
                posicionEncontrada3 = BusquedaLinealID(A, n, num);
                if(posicionEncontrada3 != -1){
                    exitos++;
                }
            }
            Burbuja(C,C.Length);
            Console.WriteLine();
            Console.WriteLine("Número de búsquedas con éxito: " + exitos);
            Console.WriteLine("Número de búsquedas fallidas: " + (buscados - exitos));
            Console.WriteLine("Porcentaje de búsqueda con éxito: " + (exitos*2) + "%");
            Console.WriteLine("Porcentaje de búsqueda con éxito: " + ((buscados - exitos)*2) + "%");
            Console.WriteLine("Arreglo ordenado: ");
            for(int i = 0; i < C.Length; i++){
                Console.Write(C[i] + " ");
            }
        }
    }
}
