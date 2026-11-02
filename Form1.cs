using System.Drawing.Drawing2D;

namespace AnalisisAlgoritmos
{
    public partial class Form1 : Form
    {
        // Datos de la grafica (se llenan con el benchmark)
        private readonly List<int> _n = new List<int>();
        private readonly List<double> _tBurbuja = new List<double>();
        private readonly List<double> _tMerge = new List<double>();

        public Form1()
        {
            InitializeComponent();
            cboEscenario.SelectedIndex = 0;
        }

        // ---------------- Logica de medicion ----------------
        private static (Resultado burbuja, Resultado merge) Medir(int n, string escenario)
        {
            // Calentamiento del JIT para no penalizar la primera medicion
            Algoritmos.BurbujaMejorada(GeneradorDatos.Crear(200, "Aleatorio"));
            Algoritmos.MergeSort(GeneradorDatos.Crear(200, "Aleatorio"));

            int[] datos = GeneradorDatos.Crear(n, escenario);
            int[] copiaB = (int[])datos.Clone();
            int[] copiaM = (int[])datos.Clone();

            Resultado rb = Algoritmos.BurbujaMejorada(copiaB);
            Resultado rm = Algoritmos.MergeSort(copiaM);

            if (!GeneradorDatos.EstaOrdenado(copiaB) || !GeneradorDatos.EstaOrdenado(copiaM))
                throw new InvalidOperationException("Un algoritmo no ordeno correctamente el arreglo.");

            return (rb, rm);
        }

        private void AgregarFila(int n, string escenario, Resultado rb, Resultado rm)
        {
            string ganador = rb.Milisegundos < rm.Milisegundos ? "Burbuja" : "Merge Sort";
            dgvResultados.Rows.Add(
                n.ToString("N0"), escenario,
                rb.Milisegundos.ToString("F3"), rb.Comparaciones.ToString("N0"),
                rm.Milisegundos.ToString("F3"), rm.Comparaciones.ToString("N0"),
                rb.MemoriaAuxiliar.ToString("N0"), rm.MemoriaAuxiliar.ToString("N0"),
                ganador);
        }

        private void SetOcupado(bool ocupado, string mensaje = "Listo")
        {
            btnEjecutar.Enabled = !ocupado;
            btnBenchmark.Enabled = !ocupado;
            btnLimpiar.Enabled = !ocupado;
            lblEstado.Text = ocupado ? "Ejecutando..." : mensaje;
        }

        // ---------------- Eventos ----------------
        private async void btnEjecutar_Click(object sender, EventArgs e)
        {
            int n = (int)nudN.Value;
            string escenario = cboEscenario.Text;

            SetOcupado(true);
            try
            {
                var (rb, rm) = await Task.Run(() => Medir(n, escenario));
                AgregarFila(n, escenario, rb, rm);
                SetOcupado(false, "Prueba terminada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetOcupado(false, "Error.");
            }
        }

        private async void btnBenchmark_Click(object sender, EventArgs e)
        {
            int[] tamanios = { 1000, 2000, 4000, 8000, 16000 };
            string escenario = cboEscenario.Text;

            _n.Clear(); _tBurbuja.Clear(); _tMerge.Clear();
            pbGrafica.Invalidate();
            progressBar.Maximum = tamanios.Length;
            progressBar.Value = 0;

            SetOcupado(true);
            try
            {
                foreach (int n in tamanios)
                {
                    var (rb, rm) = await Task.Run(() => Medir(n, escenario));
                    AgregarFila(n, escenario, rb, rm);

                    _n.Add(n);
                    _tBurbuja.Add(rb.Milisegundos);
                    _tMerge.Add(rm.Milisegundos);
                    pbGrafica.Invalidate();
                    progressBar.Value++;
                }
                SetOcupado(false, "Benchmark terminado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetOcupado(false, "Error.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvResultados.Rows.Clear();
            _n.Clear(); _tBurbuja.Clear(); _tMerge.Clear();
            progressBar.Value = 0;
            pbGrafica.Invalidate();
            lblEstado.Text = "Listo";
        }

        // ---------------- Grafica dibujada a mano ----------------
        private void pbGrafica_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            const int mIzq = 70, mArr = 30, mDer = 20, mAbj = 35;
            var area = new Rectangle(mIzq, mArr,
                pbGrafica.Width - mIzq - mDer, pbGrafica.Height - mArr - mAbj);

            g.DrawString("Tiempo de ejecucion (ms) vs tamano n", Font, Brushes.Black, mIzq, 6);
            g.DrawRectangle(Pens.Gray, area);

            if (_n.Count < 2)
            {
                g.DrawString("Pulsa \"Benchmark completo\" para generar la grafica.",
                    Font, Brushes.Gray, area.Left + 15, area.Top + 15);
                return;
            }

            double maxT = Math.Max(_tBurbuja.Max(), _tMerge.Max());
            if (maxT <= 0) maxT = 1;
            double maxN = _n.Max();

            PointF Punto(int i, double t) => new PointF(
                area.Left + (float)(_n[i] / maxN * area.Width),
                area.Bottom - (float)(t / maxT * area.Height));

            PointF[] puntosB = _n.Select((_, i) => Punto(i, _tBurbuja[i])).ToArray();
            PointF[] puntosM = _n.Select((_, i) => Punto(i, _tMerge[i])).ToArray();

            using (var penB = new Pen(Color.Firebrick, 2.5f))
            using (var penM = new Pen(Color.SteelBlue, 2.5f))
            {
                g.DrawLines(penB, puntosB);
                g.DrawLines(penM, puntosM);
                foreach (var p in puntosB) g.FillEllipse(Brushes.Firebrick, p.X - 4, p.Y - 4, 8, 8);
                foreach (var p in puntosM) g.FillEllipse(Brushes.SteelBlue, p.X - 4, p.Y - 4, 8, 8);
            }

            // Etiquetas de ejes
            g.DrawString(maxT.ToString("F1"), Font, Brushes.Black, 8, area.Top - 6);
            g.DrawString("0", Font, Brushes.Black, 40, area.Bottom - 8);
            for (int i = 0; i < _n.Count; i++)
                g.DrawString(_n[i].ToString("N0"), Font, Brushes.Black, puntosB[i].X - 20, area.Bottom + 6);

            // Leyenda
            g.FillRectangle(Brushes.Firebrick, area.Left + 15, area.Top + 12, 14, 14);
            g.DrawString("Burbuja  O(n^2)", Font, Brushes.Black, area.Left + 35, area.Top + 11);
            g.FillRectangle(Brushes.SteelBlue, area.Left + 15, area.Top + 36, 14, 14);
            g.DrawString("Merge Sort  O(n log n)", Font, Brushes.Black, area.Left + 35, area.Top + 35);
        }
    }
}
