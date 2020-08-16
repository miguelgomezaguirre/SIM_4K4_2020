namespace TP2
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSeleccionArchivo = new System.Windows.Forms.TabPage();
            this.btnVerDistribucion = new System.Windows.Forms.Button();
            this.grdTab1 = new System.Windows.Forms.DataGridView();
            this.txtCantIntervalos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbContinua = new System.Windows.Forms.RadioButton();
            this.rdbDiscreta = new System.Windows.Forms.RadioButton();
            this.btnDirectorio = new System.Windows.Forms.Button();
            this.txtDirectorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSeleccionDistribucion = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDistribucion = new System.Windows.Forms.ComboBox();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabSeleccionArchivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTab1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabSeleccionDistribucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSeleccionArchivo);
            this.tabControl1.Controls.Add(this.tabSeleccionDistribucion);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1154, 635);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabSeleccionArchivo
            // 
            this.tabSeleccionArchivo.Controls.Add(this.btnVerDistribucion);
            this.tabSeleccionArchivo.Controls.Add(this.grdTab1);
            this.tabSeleccionArchivo.Controls.Add(this.txtCantIntervalos);
            this.tabSeleccionArchivo.Controls.Add(this.label2);
            this.tabSeleccionArchivo.Controls.Add(this.btnProcesar);
            this.tabSeleccionArchivo.Controls.Add(this.groupBox1);
            this.tabSeleccionArchivo.Controls.Add(this.btnDirectorio);
            this.tabSeleccionArchivo.Controls.Add(this.txtDirectorio);
            this.tabSeleccionArchivo.Controls.Add(this.label1);
            this.tabSeleccionArchivo.Location = new System.Drawing.Point(4, 22);
            this.tabSeleccionArchivo.Name = "tabSeleccionArchivo";
            this.tabSeleccionArchivo.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeleccionArchivo.Size = new System.Drawing.Size(1146, 609);
            this.tabSeleccionArchivo.TabIndex = 0;
            this.tabSeleccionArchivo.Text = "Paso 1";
            this.tabSeleccionArchivo.UseVisualStyleBackColor = true;
            // 
            // btnVerDistribucion
            // 
            this.btnVerDistribucion.Location = new System.Drawing.Point(6, 181);
            this.btnVerDistribucion.Name = "btnVerDistribucion";
            this.btnVerDistribucion.Size = new System.Drawing.Size(278, 42);
            this.btnVerDistribucion.TabIndex = 8;
            this.btnVerDistribucion.Text = "Ver Gráfico";
            this.btnVerDistribucion.UseVisualStyleBackColor = true;
            this.btnVerDistribucion.Click += new System.EventHandler(this.btnVerDistribucion_Click);
            // 
            // grdTab1
            // 
            this.grdTab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTab1.Location = new System.Drawing.Point(290, 6);
            this.grdTab1.Name = "grdTab1";
            this.grdTab1.Size = new System.Drawing.Size(472, 412);
            this.grdTab1.TabIndex = 7;
            // 
            // txtCantIntervalos
            // 
            this.txtCantIntervalos.Location = new System.Drawing.Point(164, 93);
            this.txtCantIntervalos.Name = "txtCantIntervalos";
            this.txtCantIntervalos.Size = new System.Drawing.Size(110, 20);
            this.txtCantIntervalos.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad de Intervalos";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(6, 133);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(278, 42);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbContinua);
            this.groupBox1.Controls.Add(this.rdbDiscreta);
            this.groupBox1.Location = new System.Drawing.Point(6, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Variable";
            // 
            // rdbContinua
            // 
            this.rdbContinua.AutoSize = true;
            this.rdbContinua.Location = new System.Drawing.Point(6, 42);
            this.rdbContinua.Name = "rdbContinua";
            this.rdbContinua.Size = new System.Drawing.Size(67, 17);
            this.rdbContinua.TabIndex = 1;
            this.rdbContinua.TabStop = true;
            this.rdbContinua.Text = "Continua";
            this.rdbContinua.UseVisualStyleBackColor = true;
            // 
            // rdbDiscreta
            // 
            this.rdbDiscreta.AutoSize = true;
            this.rdbDiscreta.Location = new System.Drawing.Point(6, 19);
            this.rdbDiscreta.Name = "rdbDiscreta";
            this.rdbDiscreta.Size = new System.Drawing.Size(64, 17);
            this.rdbDiscreta.TabIndex = 0;
            this.rdbDiscreta.TabStop = true;
            this.rdbDiscreta.Text = "Discreta";
            this.rdbDiscreta.UseVisualStyleBackColor = true;
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.Location = new System.Drawing.Point(209, 27);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(75, 23);
            this.btnDirectorio.TabIndex = 2;
            this.btnDirectorio.Text = "Examinar";
            this.btnDirectorio.UseVisualStyleBackColor = true;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Location = new System.Drawing.Point(6, 29);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.Size = new System.Drawing.Size(197, 20);
            this.txtDirectorio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Archivo de Datos (.txt)";
            // 
            // tabSeleccionDistribucion
            // 
            this.tabSeleccionDistribucion.Controls.Add(this.button1);
            this.tabSeleccionDistribucion.Controls.Add(this.txtAlpha);
            this.tabSeleccionDistribucion.Controls.Add(this.label4);
            this.tabSeleccionDistribucion.Controls.Add(this.pictureBox1);
            this.tabSeleccionDistribucion.Controls.Add(this.label3);
            this.tabSeleccionDistribucion.Controls.Add(this.cboDistribucion);
            this.tabSeleccionDistribucion.Controls.Add(this.grafico);
            this.tabSeleccionDistribucion.Location = new System.Drawing.Point(4, 22);
            this.tabSeleccionDistribucion.Name = "tabSeleccionDistribucion";
            this.tabSeleccionDistribucion.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeleccionDistribucion.Size = new System.Drawing.Size(1146, 609);
            this.tabSeleccionDistribucion.TabIndex = 1;
            this.tabSeleccionDistribucion.Text = "Paso 2";
            this.tabSeleccionDistribucion.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Realizar Test";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(136, 426);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(79, 20);
            this.txtAlpha.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nivel de significación (α)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(466, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distribución a asimilar";
            // 
            // cboDistribucion
            // 
            this.cboDistribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistribucion.FormattingEnabled = true;
            this.cboDistribucion.Location = new System.Drawing.Point(466, 22);
            this.cboDistribucion.Name = "cboDistribucion";
            this.cboDistribucion.Size = new System.Drawing.Size(218, 21);
            this.cboDistribucion.TabIndex = 1;
            // 
            // grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(3, 30);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(451, 388);
            this.grafico.TabIndex = 0;
            this.grafico.Text = "chart1";
            this.grafico.Click += new System.EventHandler(this.chart1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1146, 609);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 635);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.tabControl1.ResumeLayout(false);
            this.tabSeleccionArchivo.ResumeLayout(false);
            this.tabSeleccionArchivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTab1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabSeleccionDistribucion.ResumeLayout(false);
            this.tabSeleccionDistribucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSeleccionArchivo;
        private System.Windows.Forms.TabPage tabSeleccionDistribucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirectorio;
        private System.Windows.Forms.Button btnDirectorio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbContinua;
        private System.Windows.Forms.RadioButton rdbDiscreta;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantIntervalos;
        private System.Windows.Forms.DataGridView grdTab1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDistribucion;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerDistribucion;
    }
}