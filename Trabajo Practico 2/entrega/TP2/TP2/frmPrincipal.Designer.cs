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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSeleccionArchivo = new System.Windows.Forms.TabPage();
            this.grpInfoMuestra = new System.Windows.Forms.GroupBox();
            this.lblPaso = new System.Windows.Forms.Label();
            this.lblTamanioMuestra = new System.Windows.Forms.Label();
            this.btnVerDistribucion = new System.Windows.Forms.Button();
            this.grdTab1 = new System.Windows.Forms.DataGridView();
            this.txtCantIntervalos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.grpTipoVariable = new System.Windows.Forms.GroupBox();
            this.rdbContinua = new System.Windows.Forms.RadioButton();
            this.rdbDiscreta = new System.Windows.Forms.RadioButton();
            this.btnDirectorio = new System.Windows.Forms.Button();
            this.txtDirectorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSeleccionDistribucion = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.cboAlpha = new System.Windows.Forms.ComboBox();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.lblResultadoPrueba = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblValorTabulado = new System.Windows.Forms.Label();
            this.lblValorObtenido = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTest = new System.Windows.Forms.ComboBox();
            this.btnRealizarTest = new System.Windows.Forms.Button();
            this.lblGradosDeLibertad = new System.Windows.Forms.Label();
            this.btnComparar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDistribucion = new System.Windows.Forms.ComboBox();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabSeleccionArchivo.SuspendLayout();
            this.grpInfoMuestra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTab1)).BeginInit();
            this.grpTipoVariable.SuspendLayout();
            this.tabSeleccionDistribucion.SuspendLayout();
            this.grpResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1539, 843);
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
            this.tabSeleccionArchivo.Controls.Add(this.grpTipoVariable);
            this.tabSeleccionArchivo.Controls.Add(this.btnDirectorio);
            this.tabSeleccionArchivo.Controls.Add(this.txtDirectorio);
            this.tabSeleccionArchivo.Controls.Add(this.label1);
            this.tabSeleccionArchivo.Location = new System.Drawing.Point(4, 25);
            this.tabSeleccionArchivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSeleccionArchivo.Name = "tabSeleccionArchivo";
            this.tabSeleccionArchivo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSeleccionArchivo.Size = new System.Drawing.Size(1531, 814);
            this.tabSeleccionArchivo.TabIndex = 0;
            this.tabSeleccionArchivo.Text = "Paso 1";
            this.tabSeleccionArchivo.UseVisualStyleBackColor = true;
            // 
            // grpInfoMuestra
            // 
            this.grpInfoMuestra.Controls.Add(this.lblPaso);
            this.grpInfoMuestra.Controls.Add(this.lblTamanioMuestra);
            this.grpInfoMuestra.Location = new System.Drawing.Point(8, 282);
            this.grpInfoMuestra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInfoMuestra.Name = "grpInfoMuestra";
            this.grpInfoMuestra.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInfoMuestra.Size = new System.Drawing.Size(371, 116);
            this.grpInfoMuestra.TabIndex = 9;
            this.grpInfoMuestra.TabStop = false;
            this.grpInfoMuestra.Text = "Información de muestra";
            this.grpInfoMuestra.Visible = false;
            // 
            // lblPaso
            // 
            this.lblPaso.AutoSize = true;
            this.lblPaso.Location = new System.Drawing.Point(8, 66);
            this.lblPaso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaso.Name = "lblPaso";
            this.lblPaso.Size = new System.Drawing.Size(128, 17);
            this.lblPaso.TabIndex = 1;
            this.lblPaso.Text = "lblTamanioMuestra";
            // 
            // lblTamanioMuestra
            // 
            this.lblTamanioMuestra.AutoSize = true;
            this.lblTamanioMuestra.Location = new System.Drawing.Point(8, 32);
            this.lblTamanioMuestra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTamanioMuestra.Name = "lblTamanioMuestra";
            this.lblTamanioMuestra.Size = new System.Drawing.Size(128, 17);
            this.lblTamanioMuestra.TabIndex = 0;
            this.lblTamanioMuestra.Text = "lblTamanioMuestra";
            // 
            // btnVerDistribucion
            // 
            this.btnVerDistribucion.Enabled = false;
            this.btnVerDistribucion.Location = new System.Drawing.Point(8, 223);
            this.btnVerDistribucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerDistribucion.Name = "btnVerDistribucion";
            this.btnVerDistribucion.Size = new System.Drawing.Size(371, 52);
            this.btnVerDistribucion.TabIndex = 8;
            this.btnVerDistribucion.Text = "Ver Gráfico";
            this.btnVerDistribucion.UseVisualStyleBackColor = true;
            this.btnVerDistribucion.Click += new System.EventHandler(this.btnVerDistribucion_Click);
            // 
            // grdTab1
            // 
            this.grdTab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTab1.Location = new System.Drawing.Point(387, 7);
            this.grdTab1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdTab1.Name = "grdTab1";
            this.grdTab1.RowHeadersWidth = 51;
            this.grdTab1.Size = new System.Drawing.Size(629, 793);
            this.grdTab1.TabIndex = 7;
            // 
            // txtCantIntervalos
            // 
            this.txtCantIntervalos.Location = new System.Drawing.Point(219, 114);
            this.txtCantIntervalos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantIntervalos.Name = "txtCantIntervalos";
            this.txtCantIntervalos.Size = new System.Drawing.Size(145, 22);
            this.txtCantIntervalos.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad de Intervalos";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(8, 164);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(371, 52);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // grpTipoVariable
            // 
            this.grpTipoVariable.Controls.Add(this.rdbContinua);
            this.grpTipoVariable.Controls.Add(this.rdbDiscreta);
            this.grpTipoVariable.Location = new System.Drawing.Point(8, 68);
            this.grpTipoVariable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTipoVariable.Name = "grpTipoVariable";
            this.grpTipoVariable.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTipoVariable.Size = new System.Drawing.Size(168, 89);
            this.grpTipoVariable.TabIndex = 3;
            this.grpTipoVariable.TabStop = false;
            this.grpTipoVariable.Text = "Tipo de Variable";
            this.grpTipoVariable.Visible = false;
            // 
            // rdbContinua
            // 
            this.rdbContinua.AutoSize = true;
            this.rdbContinua.Checked = true;
            this.rdbContinua.Location = new System.Drawing.Point(8, 52);
            this.rdbContinua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbContinua.Name = "rdbContinua";
            this.rdbContinua.Size = new System.Drawing.Size(85, 21);
            this.rdbContinua.TabIndex = 1;
            this.rdbContinua.TabStop = true;
            this.rdbContinua.Text = "Continua";
            this.rdbContinua.UseVisualStyleBackColor = true;
            // 
            // rdbDiscreta
            // 
            this.rdbDiscreta.AutoSize = true;
            this.rdbDiscreta.Location = new System.Drawing.Point(8, 23);
            this.rdbDiscreta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbDiscreta.Name = "rdbDiscreta";
            this.rdbDiscreta.Size = new System.Drawing.Size(81, 21);
            this.rdbDiscreta.TabIndex = 0;
            this.rdbDiscreta.TabStop = true;
            this.rdbDiscreta.Text = "Discreta";
            this.rdbDiscreta.UseVisualStyleBackColor = true;
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.Location = new System.Drawing.Point(279, 33);
            this.btnDirectorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(100, 28);
            this.btnDirectorio.TabIndex = 2;
            this.btnDirectorio.Text = "Examinar";
            this.btnDirectorio.UseVisualStyleBackColor = true;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Location = new System.Drawing.Point(8, 36);
            this.txtDirectorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.Size = new System.Drawing.Size(261, 22);
            this.txtDirectorio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Archivo de Datos (.txt)";
            // 
            // tabSeleccionDistribucion
            // 
            this.tabSeleccionDistribucion.Controls.Add(this.label6);
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
            this.tabSeleccionDistribucion.Location = new System.Drawing.Point(4, 25);
            this.tabSeleccionDistribucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSeleccionDistribucion.Name = "tabSeleccionDistribucion";
            this.tabSeleccionDistribucion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSeleccionDistribucion.Size = new System.Drawing.Size(1531, 814);
            this.tabSeleccionDistribucion.TabIndex = 1;
            this.tabSeleccionDistribucion.Text = "Paso 2";
            this.tabSeleccionDistribucion.UseVisualStyleBackColor = true;
            this.tabSeleccionDistribucion.Click += new System.EventHandler(this.tabSeleccionDistribucion_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1021, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ejemplo de Distribuciones";
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
            this.cboAlpha.Location = new System.Drawing.Point(235, 698);
            this.cboAlpha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboAlpha.Name = "cboAlpha";
            this.cboAlpha.Size = new System.Drawing.Size(249, 24);
            this.cboAlpha.TabIndex = 20;
            // 
            // grpResultado
            // 
            this.grpResultado.Controls.Add(this.lblResultadoPrueba);
            this.grpResultado.Controls.Add(this.label7);
            this.grpResultado.Controls.Add(this.lblValorTabulado);
            this.grpResultado.Controls.Add(this.lblValorObtenido);
            this.grpResultado.Controls.Add(this.label9);
            this.grpResultado.Location = new System.Drawing.Point(733, 655);
            this.grpResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpResultado.Size = new System.Drawing.Size(420, 153);
            this.grpResultado.TabIndex = 19;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "Resultado de la prueba";
            this.grpResultado.Visible = false;
            // 
            // lblResultadoPrueba
            // 
            this.lblResultadoPrueba.AutoSize = true;
            this.lblResultadoPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoPrueba.Location = new System.Drawing.Point(25, 96);
            this.lblResultadoPrueba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultadoPrueba.Name = "lblResultadoPrueba";
            this.lblResultadoPrueba.Size = new System.Drawing.Size(70, 25);
            this.lblResultadoPrueba.TabIndex = 19;
            this.lblResultadoPrueba.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Valor obtenido";
            // 
            // lblValorTabulado
            // 
            this.lblValorTabulado.AutoSize = true;
            this.lblValorTabulado.Location = new System.Drawing.Point(200, 53);
            this.lblValorTabulado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTabulado.Name = "lblValorTabulado";
            this.lblValorTabulado.Size = new System.Drawing.Size(46, 17);
            this.lblValorTabulado.TabIndex = 18;
            this.lblValorTabulado.Text = "label8";
            // 
            // lblValorObtenido
            // 
            this.lblValorObtenido.AutoSize = true;
            this.lblValorObtenido.Location = new System.Drawing.Point(44, 53);
            this.lblValorObtenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorObtenido.Name = "lblValorObtenido";
            this.lblValorObtenido.Size = new System.Drawing.Size(46, 17);
            this.lblValorObtenido.TabIndex = 16;
            this.lblValorObtenido.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(164, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Valor tabulado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 668);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Test a efectuar";
            // 
            // cboTest
            // 
            this.cboTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTest.Enabled = false;
            this.cboTest.FormattingEnabled = true;
            this.cboTest.Items.AddRange(new object[] {
            "Chi Cuadrado",
            "Kolmogorov-Smirnov"});
            this.cboTest.Location = new System.Drawing.Point(235, 667);
            this.cboTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTest.Name = "cboTest";
            this.cboTest.Size = new System.Drawing.Size(249, 24);
            this.cboTest.TabIndex = 12;
            this.cboTest.SelectedIndexChanged += new System.EventHandler(this.cboTest_SelectedIndexChanged);
            // 
            // btnRealizarTest
            // 
            this.btnRealizarTest.Enabled = false;
            this.btnRealizarTest.Location = new System.Drawing.Point(496, 667);
            this.btnRealizarTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRealizarTest.Name = "btnRealizarTest";
            this.btnRealizarTest.Size = new System.Drawing.Size(229, 57);
            this.btnRealizarTest.TabIndex = 11;
            this.btnRealizarTest.Text = "Realizar Test";
            this.btnRealizarTest.UseVisualStyleBackColor = true;
            this.btnRealizarTest.Click += new System.EventHandler(this.btnRealizarTest_Click);
            // 
            // lblGradosDeLibertad
            // 
            this.lblGradosDeLibertad.AutoSize = true;
            this.lblGradosDeLibertad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradosDeLibertad.Location = new System.Drawing.Point(23, 631);
            this.lblGradosDeLibertad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGradosDeLibertad.Name = "lblGradosDeLibertad";
            this.lblGradosDeLibertad.Size = new System.Drawing.Size(183, 20);
            this.lblGradosDeLibertad.TabIndex = 10;
            this.lblGradosDeLibertad.Text = "Grados de Libertad: ";
            // 
            // btnComparar
            // 
            this.btnComparar.Enabled = false;
            this.btnComparar.Location = new System.Drawing.Point(368, 37);
            this.btnComparar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(136, 28);
            this.btnComparar.TabIndex = 9;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 699);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nivel de significación (α)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::TP2.Properties.Resources.continuas;
            this.pictureBox1.Location = new System.Drawing.Point(1013, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 475);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distribución a asimilar";
            // 
            // cboDistribucion
            // 
            this.cboDistribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistribucion.FormattingEnabled = true;
            this.cboDistribucion.Location = new System.Drawing.Point(27, 39);
            this.cboDistribucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDistribucion.Name = "cboDistribucion";
            this.cboDistribucion.Size = new System.Drawing.Size(332, 24);
            this.cboDistribucion.TabIndex = 1;
            this.cboDistribucion.SelectedIndexChanged += new System.EventHandler(this.cboDistribucion_SelectedIndexChanged);
            // 
            // grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(8, 63);
            this.grafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(984, 565);
            this.grafico.TabIndex = 0;
            this.grafico.Text = "chart1";
            this.grafico.Click += new System.EventHandler(this.chart1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1531, 814);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Integrantes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Integrantes";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "62476 - Ardiles Hernan Ulises",
            "53756 - Brizuela Marcelo",
            "40684 - Fabro Juan Pablo",
            "65130 - Gomez Aguirre Miguel",
            "64813 - Vildoza Gianni Luca"});
            this.listBox1.Location = new System.Drawing.Point(16, 48);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 100);
            this.listBox1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 843);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.tabControl1.ResumeLayout(false);
            this.tabSeleccionArchivo.ResumeLayout(false);
            this.tabSeleccionArchivo.PerformLayout();
            this.grpInfoMuestra.ResumeLayout(false);
            this.grpInfoMuestra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTab1)).EndInit();
            this.grpTipoVariable.ResumeLayout(false);
            this.grpTipoVariable.PerformLayout();
            this.tabSeleccionDistribucion.ResumeLayout(false);
            this.tabSeleccionDistribucion.PerformLayout();
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpTipoVariable;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
    }
}