namespace AnalisisAlgoritmos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpParametros = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBenchmark = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.cboEscenario = new System.Windows.Forms.ComboBox();
            this.lblEscenario = new System.Windows.Forms.Label();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.lblN = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.colN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEscenario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBurbujaMs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBurbujaComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMergeMs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMergeComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemBurbuja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemMerge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGanador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbGrafica = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblEstado = new System.Windows.Forms.Label();
            this.grpParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafica)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 56, 100);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(560, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Burbuja vs Merge Sort: eficiencia y complejidad";
            //
            // grpParametros
            //
            this.grpParametros.Controls.Add(this.btnLimpiar);
            this.grpParametros.Controls.Add(this.btnBenchmark);
            this.grpParametros.Controls.Add(this.btnEjecutar);
            this.grpParametros.Controls.Add(this.cboEscenario);
            this.grpParametros.Controls.Add(this.lblEscenario);
            this.grpParametros.Controls.Add(this.nudN);
            this.grpParametros.Controls.Add(this.lblN);
            this.grpParametros.Location = new System.Drawing.Point(12, 45);
            this.grpParametros.Name = "grpParametros";
            this.grpParametros.Size = new System.Drawing.Size(1076, 75);
            this.grpParametros.TabIndex = 1;
            this.grpParametros.TabStop = false;
            this.grpParametros.Text = "Parametros de la prueba";
            //
            // lblN
            //
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(15, 33);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(103, 15);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "Tamano del arreglo (n):";
            //
            // nudN
            //
            this.nudN.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            this.nudN.Location = new System.Drawing.Point(160, 30);
            this.nudN.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            this.nudN.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(90, 23);
            this.nudN.TabIndex = 1;
            this.nudN.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            //
            // lblEscenario
            //
            this.lblEscenario.AutoSize = true;
            this.lblEscenario.Location = new System.Drawing.Point(280, 33);
            this.lblEscenario.Name = "lblEscenario";
            this.lblEscenario.Size = new System.Drawing.Size(60, 15);
            this.lblEscenario.TabIndex = 2;
            this.lblEscenario.Text = "Escenario:";
            //
            // cboEscenario
            //
            this.cboEscenario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEscenario.FormattingEnabled = true;
            this.cboEscenario.Items.AddRange(new object[] { "Aleatorio", "Ordenado", "Inverso" });
            this.cboEscenario.Location = new System.Drawing.Point(350, 30);
            this.cboEscenario.Name = "cboEscenario";
            this.cboEscenario.Size = new System.Drawing.Size(130, 23);
            this.cboEscenario.TabIndex = 3;
            //
            // btnEjecutar
            //
            this.btnEjecutar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutar.ForeColor = System.Drawing.Color.White;
            this.btnEjecutar.Location = new System.Drawing.Point(520, 25);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(150, 32);
            this.btnEjecutar.TabIndex = 4;
            this.btnEjecutar.Text = "Ejecutar prueba";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            //
            // btnBenchmark
            //
            this.btnBenchmark.BackColor = System.Drawing.Color.FromArgb(31, 56, 100);
            this.btnBenchmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBenchmark.ForeColor = System.Drawing.Color.White;
            this.btnBenchmark.Location = new System.Drawing.Point(685, 25);
            this.btnBenchmark.Name = "btnBenchmark";
            this.btnBenchmark.Size = new System.Drawing.Size(170, 32);
            this.btnBenchmark.TabIndex = 5;
            this.btnBenchmark.Text = "Benchmark completo";
            this.btnBenchmark.UseVisualStyleBackColor = false;
            this.btnBenchmark.Click += new System.EventHandler(this.btnBenchmark_Click);
            //
            // btnLimpiar
            //
            this.btnLimpiar.Location = new System.Drawing.Point(870, 25);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 32);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            //
            // dgvResultados
            //
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colN, this.colEscenario, this.colBurbujaMs, this.colBurbujaComp,
                this.colMergeMs, this.colMergeComp, this.colMemBurbuja, this.colMemMerge, this.colGanador });
            this.dgvResultados.Location = new System.Drawing.Point(12, 130);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.Size = new System.Drawing.Size(1076, 230);
            this.dgvResultados.TabIndex = 2;
            //
            // columnas
            //
            this.colN.HeaderText = "n";
            this.colN.Name = "colN";
            this.colN.ReadOnly = true;
            this.colN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEscenario.HeaderText = "Escenario";
            this.colEscenario.Name = "colEscenario";
            this.colEscenario.ReadOnly = true;
            this.colEscenario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBurbujaMs.HeaderText = "Burbuja (ms)";
            this.colBurbujaMs.Name = "colBurbujaMs";
            this.colBurbujaMs.ReadOnly = true;
            this.colBurbujaMs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBurbujaComp.HeaderText = "Burbuja comparaciones";
            this.colBurbujaComp.Name = "colBurbujaComp";
            this.colBurbujaComp.ReadOnly = true;
            this.colBurbujaComp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMergeMs.HeaderText = "Merge (ms)";
            this.colMergeMs.Name = "colMergeMs";
            this.colMergeMs.ReadOnly = true;
            this.colMergeMs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMergeComp.HeaderText = "Merge comparaciones";
            this.colMergeComp.Name = "colMergeComp";
            this.colMergeComp.ReadOnly = true;
            this.colMergeComp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemBurbuja.HeaderText = "Mem. aux. Burbuja";
            this.colMemBurbuja.Name = "colMemBurbuja";
            this.colMemBurbuja.ReadOnly = true;
            this.colMemBurbuja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemMerge.HeaderText = "Mem. aux. Merge";
            this.colMemMerge.Name = "colMemMerge";
            this.colMemMerge.ReadOnly = true;
            this.colMemMerge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGanador.HeaderText = "Mas rapido";
            this.colGanador.Name = "colGanador";
            this.colGanador.ReadOnly = true;
            this.colGanador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            //
            // pbGrafica
            //
            this.pbGrafica.BackColor = System.Drawing.Color.White;
            this.pbGrafica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGrafica.Location = new System.Drawing.Point(12, 370);
            this.pbGrafica.Name = "pbGrafica";
            this.pbGrafica.Size = new System.Drawing.Size(1076, 235);
            this.pbGrafica.TabIndex = 3;
            this.pbGrafica.TabStop = false;
            this.pbGrafica.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGrafica_Paint);
            //
            // progressBar
            //
            this.progressBar.Location = new System.Drawing.Point(12, 615);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(800, 23);
            this.progressBar.TabIndex = 4;
            //
            // lblEstado
            //
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(825, 619);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(32, 15);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Listo";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pbGrafica);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.grpParametros);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarea 1.3 - Analisis comparativo de algoritmos";
            this.grpParametros.ResumeLayout(false);
            this.grpParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpParametros;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Label lblEscenario;
        private System.Windows.Forms.ComboBox cboEscenario;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnBenchmark;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEscenario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBurbujaMs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBurbujaComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMergeMs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMergeComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemBurbuja;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemMerge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGanador;
        private System.Windows.Forms.PictureBox pbGrafica;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblEstado;
    }
}
