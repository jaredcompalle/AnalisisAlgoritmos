namespace AnalisisAlgoritmos
{
    public static class GeneradorDatos
    {
        /// <summary>Crea un arreglo de n enteros segun el escenario elegido.</summary>
        public static int[] Crear(int n, string escenario)
        {
            int[] datos = new int[n];

            switch (escenario)
            {
                case "Ordenado":                 // mejor caso para burbuja con bandera
                    for (int i = 0; i < n; i++) datos[i] = i;
                    break;

                case "Inverso":                  // peor caso para burbuja
                    for (int i = 0; i < n; i++) datos[i] = n - i;
                    break;

                default:                         // Aleatorio (semilla fija = reproducible)
                    var rnd = new Random(12345);
                    for (int i = 0; i < n; i++) datos[i] = rnd.Next(0, 1_000_000);
                    break;
            }
            return datos;
        }

        public static bool EstaOrdenado(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
                if (a[i - 1] > a[i]) return false;
            return true;
        }
    }
}
