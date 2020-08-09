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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnVerGrafico = new System.Windows.Forms.Button();
            this.lblChiCuadrado = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_c_puntoC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSemilla_puntoC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_m_puntoC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPuntoB)).BeginInit();
            this.tabGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(9, 199);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(212, 32);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Semilla";
            // 
            // txt_semilla
            // 
            this.txt_semilla.Location = new System.Drawing.Point(66, 37);
            this.txt_semilla.Name = "txt_semilla";
            this.txt_semilla.Size = new System.Drawing.Size(155, 20);
            this.txt_semilla.TabIndex = 1;
            // 
            // grdResultado
            // 
            this.grdResultado.AllowUserToAddRows = false;
            this.grdResultado.AllowUserToDeleteRows = false;
            this.grdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultado.Location = new System.Drawing.Point(227, 10);
            this.grdResultado.Name = "grdResultado";
            this.grdResultado.ReadOnly = true;
            this.grdResultado.Size = new System.Drawing.Size(439, 431);
            this.grdResultado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "m";
            // 
            // txt_m
            // 
            this.txt_m.Location = new System.Drawing.Point(66, 89);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(155, 20);
            this.txt_m.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "a";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(66, 63);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(155, 20);
            this.txt_a.TabIndex = 2;
            // 
            // btnAgregarUno
            // 
            this.btnAgregarUno.Enabled = false;
            this.btnAgregarUno.Location = new System.Drawing.Point(9, 237);
            this.btnAgregarUno.Name = "btnAgregarUno";
            this.btnAgregarUno.Size = new System.Drawing.Size(212, 37);
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
            this.cboMetodo.Location = new System.Drawing.Point(52, 10);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.Size = new System.Drawing.Size(169, 21);
            this.cboMetodo.TabIndex = 0;
            this.cboMetodo.SelectedIndexChanged += new System.EventHandler(this.cboMetodo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Metodo";
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Location = new System.Drawing.Point(6, 118);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(13, 13);
            this.lbl_c.TabIndex = 11;
            this.lbl_c.Text = "c";
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(66, 115);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(155, 20);
            this.txt_c.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad por primera vez";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(133, 150);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(88, 20);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.Text = "20000";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(21, 336);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(42, 13);
            this.lblTiempo.TabIndex = 15;
            this.lblTiempo.Text = "Tiempo";
            this.lblTiempo.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabGrafico);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 473);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(672, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Punto A";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnVerGrafico);
            this.tabPage2.Controls.Add(this.lblChiCuadrado);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txt_c_puntoC);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtSemilla_puntoC);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txt_m_puntoC);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txt_a_puntoC);
            this.tabPage2.Controls.Add(this.grdPuntoB);
            this.tabPage2.Controls.Add(this.btnRealizarTest);
            this.tabPage2.Controls.Add(this.txtCantNumerosAGenerar);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtCantIntervalos);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cboOrigenNumeros);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "B y C";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnVerGrafico
            // 
            this.btnVerGrafico.Location = new System.Drawing.Point(106, 93);
            this.btnVerGrafico.Name = "btnVerGrafico";
            this.btnVerGrafico.Size = new System.Drawing.Size(88, 33);
            this.btnVerGrafico.TabIndex = 18;
            this.btnVerGrafico.Text = "Ver Gráfico";
            this.btnVerGrafico.UseVisualStyleBackColor = true;
            this.btnVerGrafico.Visible = false;
            this.btnVerGrafico.Click += new System.EventHandler(this.btnVerGrafico_Click);
            // 
            // lblChiCuadrado
            // 
            this.lblChiCuadrado.AutoSize = true;
            this.lblChiCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiCuadrado.Location = new System.Drawing.Point(574, 138);
            this.lblChiCuadrado.Name = "lblChiCuadrado";
            this.lblChiCuadrado.Size = new System.Drawing.Size(59, 16);
            this.lblChiCuadrado.TabIndex = 17;
            this.lblChiCuadrado.Text = "label15";
            this.lblChiCuadrado.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(466, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "chi cuadrado:";
            // 
            // txt_c_puntoC
            // 
            this.txt_c_puntoC.Enabled = false;
            this.txt_c_puntoC.Location = new System.Drawing.Point(369, 93);
            this.txt_c_puntoC.Name = "txt_c_puntoC";
            this.txt_c_puntoC.Size = new System.Drawing.Size(116, 20);
            this.txt_c_puntoC.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(323, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "c";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(323, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Semilla";
            // 
            // txtSemilla_puntoC
            // 
            this.txtSemilla_puntoC.Enabled = false;
            this.txtSemilla_puntoC.Location = new System.Drawing.Point(369, 15);
            this.txtSemilla_puntoC.Name = "txtSemilla_puntoC";
            this.txtSemilla_puntoC.Size = new System.Drawing.Size(116, 20);
            this.txtSemilla_puntoC.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(323, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "m";
            // 
            // txt_m_puntoC
            // 
            this.txt_m_puntoC.Enabled = false;
            this.txt_m_puntoC.Location = new System.Drawing.Point(369, 67);
            this.txt_m_puntoC.Name = "txt_m_puntoC";
            this.txt_m_puntoC.Size = new System.Drawing.Size(116, 20);
            this.txt_m_puntoC.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(323, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "a";
            // 
            // txt_a_puntoC
            // 
            this.txt_a_puntoC.Enabled = false;
            this.txt_a_puntoC.Location = new System.Drawing.Point(369, 41);
            this.txt_a_puntoC.Name = "txt_a_puntoC";
            this.txt_a_puntoC.Size = new System.Drawing.Size(116, 20);
            this.txt_a_puntoC.TabIndex = 4;
            // 
            // grdPuntoB
            // 
            this.grdPuntoB.AllowUserToAddRows = false;
            this.grdPuntoB.AllowUserToDeleteRows = false;
            this.grdPuntoB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPuntoB.Location = new System.Drawing.Point(6, 157);
            this.grdPuntoB.Name = "grdPuntoB";
            this.grdPuntoB.ReadOnly = true;
            this.grdPuntoB.Size = new System.Drawing.Size(660, 284);
            this.grdPuntoB.TabIndex = 7;
            // 
            // btnRealizarTest
            // 
            this.btnRealizarTest.Location = new System.Drawing.Point(200, 93);
            this.btnRealizarTest.Name = "btnRealizarTest";
            this.btnRealizarTest.Size = new System.Drawing.Size(88, 33);
            this.btnRealizarTest.TabIndex = 7;
            this.btnRealizarTest.Text = "Realizar TEST";
            this.btnRealizarTest.UseVisualStyleBackColor = true;
            this.btnRealizarTest.Click += new System.EventHandler(this.btnRealizarTest_Click);
            // 
            // txtCantNumerosAGenerar
            // 
            this.txtCantNumerosAGenerar.Location = new System.Drawing.Point(167, 67);
            this.txtCantNumerosAGenerar.Name = "txtCantNumerosAGenerar";
            this.txtCantNumerosAGenerar.Size = new System.Drawing.Size(53, 20);
            this.txtCantNumerosAGenerar.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cantidad de números a generar";
            // 
            // txtCantIntervalos
            // 
            this.txtCantIntervalos.Location = new System.Drawing.Point(167, 41);
            this.txtCantIntervalos.Name = "txtCantIntervalos";
            this.txtCantIntervalos.Size = new System.Drawing.Size(53, 20);
            this.txtCantIntervalos.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cantidad de intervalos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
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
            this.cboOrigenNumeros.Location = new System.Drawing.Point(167, 14);
            this.cboOrigenNumeros.Name = "cboOrigenNumeros";
            this.cboOrigenNumeros.Size = new System.Drawing.Size(121, 21);
            this.cboOrigenNumeros.TabIndex = 0;
            this.cboOrigenNumeros.SelectedIndexChanged += new System.EventHandler(this.cboOrigenNumeros_SelectedIndexChanged);
            // 
            // tabGrafico
            // 
            this.tabGrafico.Controls.Add(this.grafico);
            this.tabGrafico.Location = new System.Drawing.Point(4, 22);
            this.tabGrafico.Name = "tabGrafico";
            this.tabGrafico.Size = new System.Drawing.Size(672, 447);
            this.tabGrafico.TabIndex = 2;
            this.tabGrafico.Text = "Graficos";
            this.tabGrafico.UseVisualStyleBackColor = true;
            // 
            // grafico
            // 
            chartArea12.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.grafico.Legends.Add(legend12);
            this.grafico.Location = new System.Drawing.Point(3, 3);
            this.grafico.Name = "grafico";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.grafico.Series.Add(series12);
            this.grafico.Size = new System.Drawing.Size(666, 441);
            this.grafico.TabIndex = 0;
            this.grafico.Text = "chart1";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(9, 280);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(212, 37);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPuntoB)).EndInit();
            this.tabGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSemilla_puntoC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_m_puntoC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_a_puntoC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblChiCuadrado;
        private System.Windows.Forms.Button btnVerGrafico;
        private System.Windows.Forms.TabPage tabGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

