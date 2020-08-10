namespace TP1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_semilla = new System.Windows.Forms.TextBox();
            this.grdResultado = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_m = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.btnAgregarUno = new System.Windows.Forms.Button();
            this.cboMetodo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExportarSerie = new System.Windows.Forms.Button();
            this.lblChiCuadrado = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_c_puntoC = new System.Windows.Forms.TextBox();
            this.lbl_c_puntoC = new System.Windows.Forms.Label();
            this.lblSemila_puntoC = new System.Windows.Forms.Label();
            this.txtSemilla_puntoC = new System.Windows.Forms.TextBox();
            this.lbl_m_puntoC = new System.Windows.Forms.Label();
            this.txt_m_puntoC = new System.Windows.Forms.TextBox();
            this.lbl_a_puntoC = new System.Windows.Forms.Label();
            this.txt_a_puntoC = new System.Windows.Forms.TextBox();
            this.grdPuntoB = new System.Windows.Forms.DataGridView();
            this.btnRealizarTest = new System.Windows.Forms.Button();
            this.txtCantNumerosAGenerar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantIntervalos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboOrigenNumeros = new System.Windows.Forms.ComboBox();
            this.tabGrafico = new System.Windows.Forms.TabPage();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabIntegrantes = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPuntoB)).BeginInit();
            this.tabGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.tabIntegrantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 245);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(283, 39);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Semilla";
            // 
            // txt_semilla
            // 
            this.txt_semilla.Location = new System.Drawing.Point(88, 46);
            this.txt_semilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_semilla.Name = "txt_semilla";
            this.txt_semilla.Size = new System.Drawing.Size(205, 22);
            this.txt_semilla.TabIndex = 1;
            // 
            // grdResultado
            // 
            this.grdResultado.AllowUserToAddRows = false;
            this.grdResultado.AllowUserToDeleteRows = false;
            this.grdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultado.Location = new System.Drawing.Point(303, 12);
            this.grdResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdResultado.Name = "grdResultado";
            this.grdResultado.ReadOnly = true;
            this.grdResultado.RowHeadersWidth = 51;
            this.grdResultado.Size = new System.Drawing.Size(585, 530);
            this.grdResultado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "m";
            // 
            // txt_m
            // 
            this.txt_m.Location = new System.Drawing.Point(88, 110);
            this.txt_m.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(205, 22);
            this.txt_m.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "a";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(88, 78);
            this.txt_a.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(205, 22);
            this.txt_a.TabIndex = 2;
            // 
            // btnAgregarUno
            // 
            this.btnAgregarUno.Enabled = false;
            this.btnAgregarUno.Location = new System.Drawing.Point(12, 292);
            this.btnAgregarUno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarUno.Name = "btnAgregarUno";
            this.btnAgregarUno.Size = new System.Drawing.Size(283, 46);
            this.btnAgregarUno.TabIndex = 7;
            this.btnAgregarUno.Text = "Agregar Uno";
            this.btnAgregarUno.UseVisualStyleBackColor = true;
            this.btnAgregarUno.Click += new System.EventHandler(this.btnAgregarUno_Click);
            // 
            // cboMetodo
            // 
            this.cboMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodo.FormattingEnabled = true;
            this.cboMetodo.Items.AddRange(new object[] {
            "Congruencial Multiplicativo",
            "Congruencial Mixto"});
            this.cboMetodo.Location = new System.Drawing.Point(69, 12);
            this.cboMetodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.Size = new System.Drawing.Size(224, 24);
            this.cboMetodo.TabIndex = 0;
            this.cboMetodo.SelectedIndexChanged += new System.EventHandler(this.cboMetodo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Metodo";
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Location = new System.Drawing.Point(8, 145);
            this.lbl_c.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(15, 17);
            this.lbl_c.TabIndex = 11;
            this.lbl_c.Text = "c";
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(88, 142);
            this.txt_c.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(205, 22);
            this.txt_c.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 39);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad por primera vez";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(177, 185);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(116, 22);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.Text = "20000";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(28, 414);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(55, 17);
            this.lblTiempo.TabIndex = 15;
            this.lblTiempo.Text = "Tiempo";
            this.lblTiempo.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabGrafico);
            this.tabControl1.Controls.Add(this.tabIntegrantes);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 582);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.cboMetodo);
            this.tabPage1.Controls.Add(this.grdResultado);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_semilla);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_m);
            this.tabPage1.Controls.Add(this.lblTiempo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_c);
            this.tabPage1.Controls.Add(this.lbl_c);
            this.tabPage1.Controls.Add(this.txtCantidad);
            this.tabPage1.Controls.Add(this.btnAgregarUno);
            this.tabPage1.Controls.Add(this.txt_a);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnCalcular);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(899, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generador";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(12, 345);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(283, 46);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExportarSerie);
            this.tabPage2.Controls.Add(this.lblChiCuadrado);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txt_c_puntoC);
            this.tabPage2.Controls.Add(this.lbl_c_puntoC);
            this.tabPage2.Controls.Add(this.lblSemila_puntoC);
            this.tabPage2.Controls.Add(this.txtSemilla_puntoC);
            this.tabPage2.Controls.Add(this.lbl_m_puntoC);
            this.tabPage2.Controls.Add(this.txt_m_puntoC);
            this.tabPage2.Controls.Add(this.lbl_a_puntoC);
            this.tabPage2.Controls.Add(this.txt_a_puntoC);
            this.tabPage2.Controls.Add(this.grdPuntoB);
            this.tabPage2.Controls.Add(this.btnRealizarTest);
            this.tabPage2.Controls.Add(this.txtCantNumerosAGenerar);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtCantIntervalos);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cboOrigenNumeros);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(899, 553);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "chi^2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExportarSerie
            // 
            this.btnExportarSerie.Location = new System.Drawing.Point(141, 114);
            this.btnExportarSerie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportarSerie.Name = "btnExportarSerie";
            this.btnExportarSerie.Size = new System.Drawing.Size(117, 41);
            this.btnExportarSerie.TabIndex = 18;
            this.btnExportarSerie.Text = "Exportar Serie";
            this.btnExportarSerie.UseVisualStyleBackColor = true;
            this.btnExportarSerie.Visible = false;
            this.btnExportarSerie.Click += new System.EventHandler(this.btnExportarSerie_Click);
            // 
            // lblChiCuadrado
            // 
            this.lblChiCuadrado.AutoSize = true;
            this.lblChiCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiCuadrado.Location = new System.Drawing.Point(765, 170);
            this.lblChiCuadrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiCuadrado.Name = "lblChiCuadrado";
            this.lblChiCuadrado.Size = new System.Drawing.Size(69, 20);
            this.lblChiCuadrado.TabIndex = 17;
            this.lblChiCuadrado.Text = "label15";
            this.lblChiCuadrado.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(621, 170);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "chi cuadrado:";
            // 
            // txt_c_puntoC
            // 
            this.txt_c_puntoC.Location = new System.Drawing.Point(492, 114);
            this.txt_c_puntoC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_c_puntoC.Name = "txt_c_puntoC";
            this.txt_c_puntoC.Size = new System.Drawing.Size(153, 22);
            this.txt_c_puntoC.TabIndex = 6;
            this.txt_c_puntoC.Visible = false;
            // 
            // lbl_c_puntoC
            // 
            this.lbl_c_puntoC.AutoSize = true;
            this.lbl_c_puntoC.Location = new System.Drawing.Point(431, 118);
            this.lbl_c_puntoC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_c_puntoC.Name = "lbl_c_puntoC";
            this.lbl_c_puntoC.Size = new System.Drawing.Size(15, 17);
            this.lbl_c_puntoC.TabIndex = 14;
            this.lbl_c_puntoC.Text = "c";
            this.lbl_c_puntoC.Visible = false;
            // 
            // lblSemila_puntoC
            // 
            this.lblSemila_puntoC.AutoSize = true;
            this.lblSemila_puntoC.Location = new System.Drawing.Point(431, 22);
            this.lblSemila_puntoC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSemila_puntoC.Name = "lblSemila_puntoC";
            this.lblSemila_puntoC.Size = new System.Drawing.Size(53, 17);
            this.lblSemila_puntoC.TabIndex = 8;
            this.lblSemila_puntoC.Text = "Semilla";
            this.lblSemila_puntoC.Visible = false;
            // 
            // txtSemilla_puntoC
            // 
            this.txtSemilla_puntoC.Location = new System.Drawing.Point(492, 18);
            this.txtSemilla_puntoC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSemilla_puntoC.Name = "txtSemilla_puntoC";
            this.txtSemilla_puntoC.Size = new System.Drawing.Size(153, 22);
            this.txtSemilla_puntoC.TabIndex = 3;
            this.txtSemilla_puntoC.Visible = false;
            // 
            // lbl_m_puntoC
            // 
            this.lbl_m_puntoC.AutoSize = true;
            this.lbl_m_puntoC.Location = new System.Drawing.Point(431, 86);
            this.lbl_m_puntoC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_m_puntoC.Name = "lbl_m_puntoC";
            this.lbl_m_puntoC.Size = new System.Drawing.Size(19, 17);
            this.lbl_m_puntoC.TabIndex = 10;
            this.lbl_m_puntoC.Text = "m";
            this.lbl_m_puntoC.Visible = false;
            // 
            // txt_m_puntoC
            // 
            this.txt_m_puntoC.Location = new System.Drawing.Point(492, 82);
            this.txt_m_puntoC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_m_puntoC.Name = "txt_m_puntoC";
            this.txt_m_puntoC.Size = new System.Drawing.Size(153, 22);
            this.txt_m_puntoC.TabIndex = 5;
            this.txt_m_puntoC.Visible = false;
            // 
            // lbl_a_puntoC
            // 
            this.lbl_a_puntoC.AutoSize = true;
            this.lbl_a_puntoC.Location = new System.Drawing.Point(431, 54);
            this.lbl_a_puntoC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_a_puntoC.Name = "lbl_a_puntoC";
            this.lbl_a_puntoC.Size = new System.Drawing.Size(16, 17);
            this.lbl_a_puntoC.TabIndex = 12;
            this.lbl_a_puntoC.Text = "a";
            this.lbl_a_puntoC.Visible = false;
            // 
            // txt_a_puntoC
            // 
            this.txt_a_puntoC.Location = new System.Drawing.Point(492, 50);
            this.txt_a_puntoC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_a_puntoC.Name = "txt_a_puntoC";
            this.txt_a_puntoC.Size = new System.Drawing.Size(153, 22);
            this.txt_a_puntoC.TabIndex = 4;
            this.txt_a_puntoC.Visible = false;
            // 
            // grdPuntoB
            // 
            this.grdPuntoB.AllowUserToAddRows = false;
            this.grdPuntoB.AllowUserToDeleteRows = false;
            this.grdPuntoB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPuntoB.Location = new System.Drawing.Point(8, 193);
            this.grdPuntoB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdPuntoB.Name = "grdPuntoB";
            this.grdPuntoB.ReadOnly = true;
            this.grdPuntoB.RowHeadersWidth = 51;
            this.grdPuntoB.Size = new System.Drawing.Size(880, 350);
            this.grdPuntoB.TabIndex = 7;
            // 
            // btnRealizarTest
            // 
            this.btnRealizarTest.Location = new System.Drawing.Point(267, 114);
            this.btnRealizarTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRealizarTest.Name = "btnRealizarTest";
            this.btnRealizarTest.Size = new System.Drawing.Size(117, 41);
            this.btnRealizarTest.TabIndex = 7;
            this.btnRealizarTest.Text = "Realizar TEST";
            this.btnRealizarTest.UseVisualStyleBackColor = true;
            this.btnRealizarTest.Click += new System.EventHandler(this.btnRealizarTest_Click);
            // 
            // txtCantNumerosAGenerar
            // 
            this.txtCantNumerosAGenerar.Location = new System.Drawing.Point(223, 82);
            this.txtCantNumerosAGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantNumerosAGenerar.Name = "txtCantNumerosAGenerar";
            this.txtCantNumerosAGenerar.Size = new System.Drawing.Size(69, 22);
            this.txtCantNumerosAGenerar.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cantidad de números a generar";
            // 
            // txtCantIntervalos
            // 
            this.txtCantIntervalos.Location = new System.Drawing.Point(223, 50);
            this.txtCantIntervalos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantIntervalos.Name = "txtCantIntervalos";
            this.txtCantIntervalos.Size = new System.Drawing.Size(69, 22);
            this.txtCantIntervalos.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cantidad de intervalos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Origen de Numeros Aleatorios";
            // 
            // cboOrigenNumeros
            // 
            this.cboOrigenNumeros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrigenNumeros.FormattingEnabled = true;
            this.cboOrigenNumeros.Items.AddRange(new object[] {
            "Mecanismo provisto por el lenguaje (C#)",
            "Metodo congruencial mixto"});
            this.cboOrigenNumeros.Location = new System.Drawing.Point(223, 17);
            this.cboOrigenNumeros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboOrigenNumeros.Name = "cboOrigenNumeros";
            this.cboOrigenNumeros.Size = new System.Drawing.Size(160, 24);
            this.cboOrigenNumeros.TabIndex = 0;
            this.cboOrigenNumeros.SelectedIndexChanged += new System.EventHandler(this.cboOrigenNumeros_SelectedIndexChanged);
            // 
            // tabGrafico
            // 
            this.tabGrafico.Controls.Add(this.grafico);
            this.tabGrafico.Location = new System.Drawing.Point(4, 25);
            this.tabGrafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGrafico.Name = "tabGrafico";
            this.tabGrafico.Size = new System.Drawing.Size(899, 553);
            this.tabGrafico.TabIndex = 2;
            this.tabGrafico.Text = "Graficos";
            this.tabGrafico.UseVisualStyleBackColor = true;
            // 
            // grafico
            // 
            chartArea2.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafico.Legends.Add(legend2);
            this.grafico.Location = new System.Drawing.Point(4, 4);
            this.grafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grafico.Name = "grafico";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.grafico.Series.Add(series2);
            this.grafico.Size = new System.Drawing.Size(888, 543);
            this.grafico.TabIndex = 0;
            this.grafico.Text = "chart1";
            // 
            // tabIntegrantes
            // 
            this.tabIntegrantes.Controls.Add(this.listBox1);
            this.tabIntegrantes.Controls.Add(this.label7);
            this.tabIntegrantes.Location = new System.Drawing.Point(4, 25);
            this.tabIntegrantes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabIntegrantes.Name = "tabIntegrantes";
            this.tabIntegrantes.Size = new System.Drawing.Size(899, 553);
            this.tabIntegrantes.TabIndex = 3;
            this.tabIntegrantes.Text = "Integrantes";
            this.tabIntegrantes.UseVisualStyleBackColor = true;
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
            this.listBox1.Location = new System.Drawing.Point(33, 59);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 132);
            this.listBox1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Integrantes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 615);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(957, 662);
            this.MinimumSize = new System.Drawing.Size(957, 662);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP 1 - Grupo K";
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPuntoB)).EndInit();
            this.tabGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.tabIntegrantes.ResumeLayout(false);
            this.tabIntegrantes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_semilla;
        private System.Windows.Forms.DataGridView grdResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_m;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Button btnAgregarUno;
        private System.Windows.Forms.ComboBox cboMetodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboOrigenNumeros;
        private System.Windows.Forms.TextBox txtCantNumerosAGenerar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantIntervalos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRealizarTest;
        private System.Windows.Forms.DataGridView grdPuntoB;
        private System.Windows.Forms.TextBox txt_c_puntoC;
        private System.Windows.Forms.Label lbl_c_puntoC;
        private System.Windows.Forms.Label lblSemila_puntoC;
        private System.Windows.Forms.TextBox txtSemilla_puntoC;
        private System.Windows.Forms.Label lbl_m_puntoC;
        private System.Windows.Forms.TextBox txt_m_puntoC;
        private System.Windows.Forms.Label lbl_a_puntoC;
        private System.Windows.Forms.TextBox txt_a_puntoC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblChiCuadrado;
        private System.Windows.Forms.Button btnExportarSerie;
        private System.Windows.Forms.TabPage tabGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TabPage tabIntegrantes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
    }
}

