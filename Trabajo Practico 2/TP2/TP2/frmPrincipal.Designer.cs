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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.lblGradosDeLibertad = new System.Windows.Forms.Label();
            this.btnComparar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDistribucion = new System.Windows.Forms.ComboBox();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grdResultadoTest = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnRealizarTest = new System.Windows.Forms.Button();
            this.cboTest = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblValorObtenido = new System.Windows.Forms.Label();
            this.lblValorTabulado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.lblResultadoPrueba = new System.Windows.Forms.Label();
            this.cboAlpha = new System.Windows.Forms.ComboBox();
            this.grpInfoMuestra = new System.Windows.Forms.GroupBox();
            this.lblTamanioMuestra = new System.Windows.Forms.Label();
            this.lblPaso = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabSeleccionArchivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTab1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabSeleccionDistribucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultadoTest)).BeginInit();
            this.grpResultado.SuspendLayout();
            this.grpInfoMuestra.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1154, 723);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabSeleccionArchivo
            // 
            this.tabSeleccionArchivo.Controls.Add(this.grpInfoMuestra);
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
            this.tabSeleccionArchivo.Size = new System.Drawing.Size(1146, 697);
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
            this.grdTab1.Size = new System.Drawing.Size(472, 685);
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
            this.tabSeleccionDistribucion.Controls.Add(this.cboAlpha);
            this.tabSeleccionDistribucion.Controls.Add(this.grpResultado);
            this.tabSeleccionDistribucion.Controls.Add(this.label5);
            this.tabSeleccionDistribucion.Controls.Add(this.cboTest);
            this.tabSeleccionDistribucion.Controls.Add(this.btnRealizarTest);
            this.tabSeleccionDistribucion.Controls.Add(this.lblGradosDeLibertad);
            this.tabSeleccionDistribucion.Controls.Add(this.btnComparar);
            this.tabSeleccionDistribucion.Controls.Add(this.label4);
            this.tabSeleccionDistribucion.Controls.Add(this.pictureBox1);
            this.tabSeleccionDistribucion.Controls.Add(this.label3);
            this.tabSeleccionDistribucion.Controls.Add(this.cboDistribucion);
            this.tabSeleccionDistribucion.Controls.Add(this.grafico);
            this.tabSeleccionDistribucion.Location = new System.Drawing.Point(4, 22);
            this.tabSeleccionDistribucion.Name = "tabSeleccionDistribucion";
            this.tabSeleccionDistribucion.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeleccionDistribucion.Size = new System.Drawing.Size(1146, 697);
            this.tabSeleccionDistribucion.TabIndex = 1;
            this.tabSeleccionDistribucion.Text = "Paso 2";
            this.tabSeleccionDistribucion.UseVisualStyleBackColor = true;
            // 
            // lblGradosDeLibertad
            // 
            this.lblGradosDeLibertad.AutoSize = true;
            this.lblGradosDeLibertad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradosDeLibertad.Location = new System.Drawing.Point(17, 513);
            this.lblGradosDeLibertad.Name = "lblGradosDeLibertad";
            this.lblGradosDeLibertad.Size = new System.Drawing.Size(150, 16);
            this.lblGradosDeLibertad.TabIndex = 10;
            this.lblGradosDeLibertad.Text = "Grados de Libertad: ";
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(1038, 22);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(102, 23);
            this.btnComparar.TabIndex = 9;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nivel de significación (α)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::TP2.Properties.Resources.continuas;
            this.pictureBox1.Location = new System.Drawing.Point(760, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 475);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(757, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distribución a asimilar";
            // 
            // cboDistribucion
            // 
            this.cboDistribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistribucion.FormattingEnabled = true;
            this.cboDistribucion.Location = new System.Drawing.Point(760, 22);
            this.cboDistribucion.Name = "cboDistribucion";
            this.cboDistribucion.Size = new System.Drawing.Size(250, 21);
            this.cboDistribucion.TabIndex = 1;
            this.cboDistribucion.SelectedIndexChanged += new System.EventHandler(this.cboDistribucion_SelectedIndexChanged);
            // 
            // grafico
            // 
            chartArea2.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafico.Legends.Add(legend2);
            this.grafico.Location = new System.Drawing.Point(6, 51);
            this.grafico.Name = "grafico";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.grafico.Series.Add(series2);
            this.grafico.Size = new System.Drawing.Size(738, 459);
            this.grafico.TabIndex = 0;
            this.grafico.Text = "chart1";
            this.grafico.Click += new System.EventHandler(this.chart1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grdResultadoTest);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1146, 609);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grdResultadoTest
            // 
            this.grdResultadoTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultadoTest.Location = new System.Drawing.Point(8, 6);
            this.grdResultadoTest.Name = "grdResultadoTest";
            this.grdResultadoTest.Size = new System.Drawing.Size(511, 595);
            this.grdResultadoTest.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnRealizarTest
            // 
            this.btnRealizarTest.Location = new System.Drawing.Point(372, 542);
            this.btnRealizarTest.Name = "btnRealizarTest";
            this.btnRealizarTest.Size = new System.Drawing.Size(172, 46);
            this.btnRealizarTest.TabIndex = 11;
            this.btnRealizarTest.Text = "Realizar Test";
            this.btnRealizarTest.UseVisualStyleBackColor = true;
            this.btnRealizarTest.Click += new System.EventHandler(this.btnRealizarTest_Click);
            // 
            // cboTest
            // 
            this.cboTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTest.FormattingEnabled = true;
            this.cboTest.Items.AddRange(new object[] {
            "Chi Cuadrado",
            "Kolmogorov-Smirnov"});
            this.cboTest.Location = new System.Drawing.Point(176, 567);
            this.cboTest.Name = "cboTest";
            this.cboTest.Size = new System.Drawing.Size(188, 21);
            this.cboTest.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 568);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Test a efectuar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Valor obtenido";
            // 
            // lblValorObtenido
            // 
            this.lblValorObtenido.AutoSize = true;
            this.lblValorObtenido.Location = new System.Drawing.Point(33, 43);
            this.lblValorObtenido.Name = "lblValorObtenido";
            this.lblValorObtenido.Size = new System.Drawing.Size(35, 13);
            this.lblValorObtenido.TabIndex = 16;
            this.lblValorObtenido.Text = "label8";
            // 
            // lblValorTabulado
            // 
            this.lblValorTabulado.AutoSize = true;
            this.lblValorTabulado.Location = new System.Drawing.Point(150, 43);
            this.lblValorTabulado.Name = "lblValorTabulado";
            this.lblValorTabulado.Size = new System.Drawing.Size(35, 13);
            this.lblValorTabulado.TabIndex = 18;
            this.lblValorTabulado.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(123, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Valor tabulado";
            // 
            // grpResultado
            // 
            this.grpResultado.Controls.Add(this.lblResultadoPrueba);
            this.grpResultado.Controls.Add(this.label7);
            this.grpResultado.Controls.Add(this.lblValorTabulado);
            this.grpResultado.Controls.Add(this.lblValorObtenido);
            this.grpResultado.Controls.Add(this.label9);
            this.grpResultado.Location = new System.Drawing.Point(550, 532);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(315, 124);
            this.grpResultado.TabIndex = 19;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "Resultado de la prueba";
            this.grpResultado.Visible = false;
            // 
            // lblResultadoPrueba
            // 
            this.lblResultadoPrueba.AutoSize = true;
            this.lblResultadoPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoPrueba.Location = new System.Drawing.Point(19, 78);
            this.lblResultadoPrueba.Name = "lblResultadoPrueba";
            this.lblResultadoPrueba.Size = new System.Drawing.Size(57, 20);
            this.lblResultadoPrueba.TabIndex = 19;
            this.lblResultadoPrueba.Text = "label6";
            // 
            // cboAlpha
            // 
            this.cboAlpha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlpha.FormattingEnabled = true;
            this.cboAlpha.Items.AddRange(new object[] {
            "0,001",
            "0,0025",
            "0,005",
            "0,01",
            "0,025",
            "0,05",
            "0,1",
            "0,15",
            "0,2",
            "0,25",
            "0,3",
            "0,35",
            "0,4",
            "0,45",
            "0,5"});
            this.cboAlpha.Location = new System.Drawing.Point(176, 541);
            this.cboAlpha.Name = "cboAlpha";
            this.cboAlpha.Size = new System.Drawing.Size(188, 21);
            this.cboAlpha.TabIndex = 20;
            // 
            // grpInfoMuestra
            // 
            this.grpInfoMuestra.Controls.Add(this.lblPaso);
            this.grpInfoMuestra.Controls.Add(this.lblTamanioMuestra);
            this.grpInfoMuestra.Location = new System.Drawing.Point(6, 229);
            this.grpInfoMuestra.Name = "grpInfoMuestra";
            this.grpInfoMuestra.Size = new System.Drawing.Size(278, 94);
            this.grpInfoMuestra.TabIndex = 9;
            this.grpInfoMuestra.TabStop = false;
            this.grpInfoMuestra.Text = "Información de muestra";
            this.grpInfoMuestra.Visible = false;
            // 
            // lblTamanioMuestra
            // 
            this.lblTamanioMuestra.AutoSize = true;
            this.lblTamanioMuestra.Location = new System.Drawing.Point(6, 26);
            this.lblTamanioMuestra.Name = "lblTamanioMuestra";
            this.lblTamanioMuestra.Size = new System.Drawing.Size(96, 13);
            this.lblTamanioMuestra.TabIndex = 0;
            this.lblTamanioMuestra.Text = "lblTamanioMuestra";
            // 
            // lblPaso
            // 
            this.lblPaso.AutoSize = true;
            this.lblPaso.Location = new System.Drawing.Point(6, 54);
            this.lblPaso.Name = "lblPaso";
            this.lblPaso.Size = new System.Drawing.Size(96, 13);
            this.lblPaso.TabIndex = 1;
            this.lblPaso.Text = "lblTamanioMuestra";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 723);
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
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdResultadoTest)).EndInit();
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            this.grpInfoMuestra.ResumeLayout(false);
            this.grpInfoMuestra.PerformLayout();
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
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerDistribucion;
        private System.Windows.Forms.Label lblGradosDeLibertad;
        private System.Windows.Forms.DataGridView grdResultadoTest;
        private System.Windows.Forms.Button btnRealizarTest;
        private System.Windows.Forms.ComboBox cboTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblValorObtenido;
        private System.Windows.Forms.Label lblValorTabulado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.Label lblResultadoPrueba;
        private System.Windows.Forms.ComboBox cboAlpha;
        private System.Windows.Forms.GroupBox grpInfoMuestra;
        private System.Windows.Forms.Label lblTamanioMuestra;
        private System.Windows.Forms.Label lblPaso;
    }
}