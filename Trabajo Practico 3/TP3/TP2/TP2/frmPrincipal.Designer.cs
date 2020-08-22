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
            this.cboDistribucion = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDesvEstandar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCantIntervalos = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCantNumeros = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpInfoMuestra = new System.Windows.Forms.GroupBox();
            this.lblPaso = new System.Windows.Forms.Label();
            this.lblTamanioMuestra = new System.Windows.Forms.Label();
            this.btnVerDistribucion = new System.Windows.Forms.Button();
            this.grdTab1 = new System.Windows.Forms.DataGridView();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.tabSeleccionDistribucion = new System.Windows.Forms.TabPage();
            this.cboAlpha = new System.Windows.Forms.ComboBox();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.lblResultadoPrueba = new System.Windows.Forms.Label();
            this.lblValorObtenidoTitle = new System.Windows.Forms.Label();
            this.lblValorTabulado = new System.Windows.Forms.Label();
            this.lblValorObtenido = new System.Windows.Forms.Label();
            this.lblValorTabuladoTitle = new System.Windows.Forms.Label();
            this.btnRealizarTest = new System.Windows.Forms.Button();
            this.lblGradosDeLibertad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabSeleccionArchivo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpInfoMuestra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTab1)).BeginInit();
            this.tabSeleccionDistribucion.SuspendLayout();
            this.grpResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.tabPage3.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1028, 688);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabSeleccionArchivo
            // 
            this.tabSeleccionArchivo.Controls.Add(this.cboDistribucion);
            this.tabSeleccionArchivo.Controls.Add(this.groupBox3);
            this.tabSeleccionArchivo.Controls.Add(this.label1);
            this.tabSeleccionArchivo.Controls.Add(this.grpInfoMuestra);
            this.tabSeleccionArchivo.Controls.Add(this.btnVerDistribucion);
            this.tabSeleccionArchivo.Controls.Add(this.grdTab1);
            this.tabSeleccionArchivo.Controls.Add(this.btnProcesar);
            this.tabSeleccionArchivo.Location = new System.Drawing.Point(4, 22);
            this.tabSeleccionArchivo.Name = "tabSeleccionArchivo";
            this.tabSeleccionArchivo.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeleccionArchivo.Size = new System.Drawing.Size(1020, 662);
            this.tabSeleccionArchivo.TabIndex = 0;
            this.tabSeleccionArchivo.Text = "Paso 1";
            this.tabSeleccionArchivo.UseVisualStyleBackColor = true;
            // 
            // cboDistribucion
            // 
            this.cboDistribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistribucion.FormattingEnabled = true;
            this.cboDistribucion.Location = new System.Drawing.Point(76, 15);
            this.cboDistribucion.Name = "cboDistribucion";
            this.cboDistribucion.Size = new System.Drawing.Size(182, 21);
            this.cboDistribucion.TabIndex = 21;
            this.cboDistribucion.SelectedIndexChanged += new System.EventHandler(this.cboDistribucionGenerador_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLambda);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtDesvEstandar);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtMedia);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtMaximo);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtMinimo);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtCantIntervalos);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtCantNumeros);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Location = new System.Drawing.Point(11, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 119);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parámetros";
            // 
            // txtLambda
            // 
            this.txtLambda.Enabled = false;
            this.txtLambda.Location = new System.Drawing.Point(373, 48);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(48, 20);
            this.txtLambda.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(290, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Lambda";
            // 
            // txtDesvEstandar
            // 
            this.txtDesvEstandar.Enabled = false;
            this.txtDesvEstandar.Location = new System.Drawing.Point(373, 22);
            this.txtDesvEstandar.Name = "txtDesvEstandar";
            this.txtDesvEstandar.Size = new System.Drawing.Size(48, 20);
            this.txtDesvEstandar.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(290, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Desv Estándar";
            // 
            // txtMedia
            // 
            this.txtMedia.Enabled = false;
            this.txtMedia.Location = new System.Drawing.Point(236, 74);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(48, 20);
            this.txtMedia.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(190, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Media";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Enabled = false;
            this.txtMaximo.Location = new System.Drawing.Point(236, 48);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(48, 20);
            this.txtMaximo.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(190, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Máximo";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Enabled = false;
            this.txtMinimo.Location = new System.Drawing.Point(236, 22);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(48, 20);
            this.txtMinimo.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(190, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Mínimo";
            // 
            // txtCantIntervalos
            // 
            this.txtCantIntervalos.Location = new System.Drawing.Point(128, 48);
            this.txtCantIntervalos.Name = "txtCantIntervalos";
            this.txtCantIntervalos.Size = new System.Drawing.Size(51, 20);
            this.txtCantIntervalos.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Cantidad de intervalos";
            // 
            // txtCantNumeros
            // 
            this.txtCantNumeros.Location = new System.Drawing.Point(128, 22);
            this.txtCantNumeros.Name = "txtCantNumeros";
            this.txtCantNumeros.Size = new System.Drawing.Size(51, 20);
            this.txtCantNumeros.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Cantidad de números";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Distribución";
            // 
            // grpInfoMuestra
            // 
            this.grpInfoMuestra.Controls.Add(this.lblPaso);
            this.grpInfoMuestra.Controls.Add(this.lblTamanioMuestra);
            this.grpInfoMuestra.Location = new System.Drawing.Point(11, 263);
            this.grpInfoMuestra.Name = "grpInfoMuestra";
            this.grpInfoMuestra.Size = new System.Drawing.Size(278, 94);
            this.grpInfoMuestra.TabIndex = 9;
            this.grpInfoMuestra.TabStop = false;
            this.grpInfoMuestra.Text = "Información de muestra";
            this.grpInfoMuestra.Visible = false;
            // 
            // lblPaso
            // 
            this.lblPaso.AutoSize = true;
            this.lblPaso.Location = new System.Drawing.Point(6, 54);
            this.lblPaso.Name = "lblPaso";
            this.lblPaso.Size = new System.Drawing.Size(41, 13);
            this.lblPaso.TabIndex = 1;
            this.lblPaso.Text = "lblPaso";
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
            // btnVerDistribucion
            // 
            this.btnVerDistribucion.Enabled = false;
            this.btnVerDistribucion.Location = new System.Drawing.Point(11, 215);
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
            this.grdTab1.Location = new System.Drawing.Point(540, 6);
            this.grdTab1.Name = "grdTab1";
            this.grdTab1.RowHeadersWidth = 51;
            this.grdTab1.Size = new System.Drawing.Size(472, 644);
            this.grdTab1.TabIndex = 7;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(11, 167);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(278, 42);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Generar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // tabSeleccionDistribucion
            // 
            this.tabSeleccionDistribucion.Controls.Add(this.cboAlpha);
            this.tabSeleccionDistribucion.Controls.Add(this.grpResultado);
            this.tabSeleccionDistribucion.Controls.Add(this.btnRealizarTest);
            this.tabSeleccionDistribucion.Controls.Add(this.lblGradosDeLibertad);
            this.tabSeleccionDistribucion.Controls.Add(this.label4);
            this.tabSeleccionDistribucion.Controls.Add(this.grafico);
            this.tabSeleccionDistribucion.Location = new System.Drawing.Point(4, 22);
            this.tabSeleccionDistribucion.Name = "tabSeleccionDistribucion";
            this.tabSeleccionDistribucion.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeleccionDistribucion.Size = new System.Drawing.Size(1020, 662);
            this.tabSeleccionDistribucion.TabIndex = 1;
            this.tabSeleccionDistribucion.Text = "Paso 2";
            this.tabSeleccionDistribucion.UseVisualStyleBackColor = true;
            this.tabSeleccionDistribucion.Click += new System.EventHandler(this.tabSeleccionDistribucion_Click);
            // 
            // cboAlpha
            // 
            this.cboAlpha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlpha.Enabled = false;
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
            this.cboAlpha.Location = new System.Drawing.Point(755, 36);
            this.cboAlpha.Name = "cboAlpha";
            this.cboAlpha.Size = new System.Drawing.Size(188, 21);
            this.cboAlpha.TabIndex = 20;
            // 
            // grpResultado
            // 
            this.grpResultado.Controls.Add(this.lblResultadoPrueba);
            this.grpResultado.Controls.Add(this.lblValorObtenidoTitle);
            this.grpResultado.Controls.Add(this.lblValorTabulado);
            this.grpResultado.Controls.Add(this.lblValorObtenido);
            this.grpResultado.Controls.Add(this.lblValorTabuladoTitle);
            this.grpResultado.Location = new System.Drawing.Point(716, 153);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(266, 131);
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
            // lblValorObtenidoTitle
            // 
            this.lblValorObtenidoTitle.AutoSize = true;
            this.lblValorObtenidoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorObtenidoTitle.Location = new System.Drawing.Point(6, 16);
            this.lblValorObtenidoTitle.Name = "lblValorObtenidoTitle";
            this.lblValorObtenidoTitle.Size = new System.Drawing.Size(96, 16);
            this.lblValorObtenidoTitle.TabIndex = 15;
            this.lblValorObtenidoTitle.Text = "Valor obtenido";
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
            // lblValorObtenido
            // 
            this.lblValorObtenido.AutoSize = true;
            this.lblValorObtenido.Location = new System.Drawing.Point(33, 43);
            this.lblValorObtenido.Name = "lblValorObtenido";
            this.lblValorObtenido.Size = new System.Drawing.Size(35, 13);
            this.lblValorObtenido.TabIndex = 16;
            this.lblValorObtenido.Text = "label8";
            // 
            // lblValorTabuladoTitle
            // 
            this.lblValorTabuladoTitle.AutoSize = true;
            this.lblValorTabuladoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTabuladoTitle.Location = new System.Drawing.Point(123, 16);
            this.lblValorTabuladoTitle.Name = "lblValorTabuladoTitle";
            this.lblValorTabuladoTitle.Size = new System.Drawing.Size(96, 16);
            this.lblValorTabuladoTitle.TabIndex = 17;
            this.lblValorTabuladoTitle.Text = "Valor tabulado";
            // 
            // btnRealizarTest
            // 
            this.btnRealizarTest.Enabled = false;
            this.btnRealizarTest.Location = new System.Drawing.Point(755, 101);
            this.btnRealizarTest.Name = "btnRealizarTest";
            this.btnRealizarTest.Size = new System.Drawing.Size(188, 46);
            this.btnRealizarTest.TabIndex = 11;
            this.btnRealizarTest.Text = "Realizar Test";
            this.btnRealizarTest.UseVisualStyleBackColor = true;
            this.btnRealizarTest.Click += new System.EventHandler(this.btnRealizarTest_Click);
            // 
            // lblGradosDeLibertad
            // 
            this.lblGradosDeLibertad.AutoSize = true;
            this.lblGradosDeLibertad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradosDeLibertad.Location = new System.Drawing.Point(755, 71);
            this.lblGradosDeLibertad.Name = "lblGradosDeLibertad";
            this.lblGradosDeLibertad.Size = new System.Drawing.Size(150, 16);
            this.lblGradosDeLibertad.TabIndex = 10;
            this.lblGradosDeLibertad.Text = "Grados de Libertad: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(752, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nivel de significación (α)";
            // 
            // grafico
            // 
            chartArea2.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafico.Legends.Add(legend2);
            this.grafico.Location = new System.Drawing.Point(8, 6);
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
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1020, 662);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Integrantes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Integrantes";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "62476 - Ardiles Hernan Ulises",
            "53756 - Brizuela Marcelo",
            "40684 - Fabro Juan Pablo",
            "65130 - Gomez Aguirre Miguel",
            "64813 - Vildoza Gianni Luca"});
            this.listBox1.Location = new System.Drawing.Point(12, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 82);
            this.listBox1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 688);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.tabControl1.ResumeLayout(false);
            this.tabSeleccionArchivo.ResumeLayout(false);
            this.tabSeleccionArchivo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpInfoMuestra.ResumeLayout(false);
            this.grpInfoMuestra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTab1)).EndInit();
            this.tabSeleccionDistribucion.ResumeLayout(false);
            this.tabSeleccionDistribucion.PerformLayout();
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSeleccionArchivo;
        private System.Windows.Forms.TabPage tabSeleccionDistribucion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.DataGridView grdTab1;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerDistribucion;
        private System.Windows.Forms.Label lblGradosDeLibertad;
        private System.Windows.Forms.Button btnRealizarTest;
        private System.Windows.Forms.Label lblValorObtenidoTitle;
        private System.Windows.Forms.Label lblValorObtenido;
        private System.Windows.Forms.Label lblValorTabulado;
        private System.Windows.Forms.Label lblValorTabuladoTitle;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.Label lblResultadoPrueba;
        private System.Windows.Forms.ComboBox cboAlpha;
        private System.Windows.Forms.GroupBox grpInfoMuestra;
        private System.Windows.Forms.Label lblTamanioMuestra;
        private System.Windows.Forms.Label lblPaso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDesvEstandar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCantIntervalos;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCantNumeros;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboDistribucion;
        private System.Windows.Forms.Label label1;
    }
}