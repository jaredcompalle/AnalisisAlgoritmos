using System.Diagnostics;

namespace AnalisisAlgoritmos
{
    /// <summary>Metricas obtenidas al ejecutar un algoritmo de ordenamiento.</summary>
    public sealed class Resultado
    {
        public long Comparaciones;
        public long Asignaciones;
        public double Milisegundos;
        public long MemoriaAuxiliar;   // elementos extra reservados (sin contar variables simples)
    }

    public static class Algoritmos
    {
        // ------------------------------------------------------------------
        // ALGORITMO 1: Ordenamiento burbuja con bandera de intercambio
        // Tiempo: O(n^2) peor/promedio, O(n) mejor caso. Espacio: O(1)
        // ------------------------------------------------------------------
        public static Resultado BurbujaMejorada(int[] a)
        {
            var r = new Resultado { MemoriaAuxiliar = 0 };
            int n = a.Length;
            var sw = Stopwatch.StartNew();

            for (int i = 0; i < n - 1; i++)
            {
                bool huboIntercambio = false;
                for (int j = 0; j < n - 1 - i; j++)
                {
                    r.Comparaciones++;
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        r.Asignaciones += 3;
                        huboIntercambio = true;
                    }
                }
                if (!huboIntercambio) break;   // ya esta ordenado
            }

            sw.Stop();
            r.Milisegundos = sw.Elapsed.TotalMilliseconds;
            return r;
        }

        // ------------------------------------------------------------------
        // ALGORITMO 2: Merge Sort (divide y venceras, top-down)
        // Tiempo: Theta(n log n) en todos los casos. Espacio: O(n)
        // ------------------------------------------------------------------
        public static Resultado MergeSort(int[] a)
        {
            var r = new Resultado();
            int[] aux = new int[a.Length];
            r.MemoriaAuxiliar = a.Length;      // arreglo auxiliar de n elementos

            var sw = Stopwatch.StartNew();
            if (a.Length > 1) Ordenar(a, aux, 0, a.Length - 1, r);
            sw.Stop();

            r.Milisegundos = sw.Elapsed.TotalMilliseconds;
            return r;
        }

        private static void Ordenar(int[] a, int[] aux, int izq, int der, Resultado r)
        {
            if (izq >= der) return;
            int medio = izq + (der - izq) / 2;
            Ordenar(a, aux, izq, medio, r);        // T(n/2)
            Ordenar(a, aux, medio + 1, der, r);    // T(n/2)
            Mezclar(a, aux, izq, medio, der, r);   // Theta(n)
        }

        private static void Mezclar(int[] a, int[] aux, int izq, int medio, int der, Resultado r)
        {
            int cantidad = der - izq + 1;
            Array.Copy(a, izq, aux, izq, cantidad);
            r.Asignaciones += cantidad;

            int i = izq, j = medio + 1, k = izq;
            while (i <= medio && j <= der)
            {
                r.Comparaciones++;
                if (aux[i] <= aux[j]) a[k++] = aux[i++];   // <= mantiene la estabilidad
                else a[k++] = aux[j++];
                r.Asignaciones++;
            }
            while (i <= medio)
            {
                a[k++] = aux[i++];
                r.Asignaciones++;
            }
            // Lo que sobre de la mitad derecha ya esta en su posicion correcta.
        }
    }
}
