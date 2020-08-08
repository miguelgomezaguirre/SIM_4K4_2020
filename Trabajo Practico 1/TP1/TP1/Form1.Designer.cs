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
            this.btnAnterior = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cboPagina = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cboOrigenNumeros = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantIntervalos = new System.Windows.Forms.TextBox();
            this.txtCantNumerosAGenerar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRealizarTest = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Intervalos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifFrec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifFrecCuadrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiCuadrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(195, 116);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(103, 36);
            this.btnCalcular.TabIndex = 0;
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
            this.txt_semilla.Location = new System.Drawing.Point(52, 37);
            this.txt_semilla.Name = "txt_semilla";
            this.txt_semilla.Size = new System.Drawing.Size(116, 20);
            this.txt_semilla.TabIndex = 2;
            // 
            // grdResultado
            // 
            this.grdResultado.AllowUserToAddRows = false;
            this.grdResultado.AllowUserToDeleteRows = false;
            this.grdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultado.Location = new System.Drawing.Point(6, 194);
            this.grdResultado.Name = "grdResultado";
            this.grdResultado.ReadOnly = true;
            this.grdResultado.Size = new System.Drawing.Size(541, 247);
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
            this.txt_m.Location = new System.Drawing.Point(52, 89);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(116, 20);
            this.txt_m.TabIndex = 5;
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
            this.txt_a.Location = new System.Drawing.Point(52, 63);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(116, 20);
            this.txt_a.TabIndex = 7;
            // 
            // btnAgregarUno
            // 
            this.btnAgregarUno.Enabled = false;
            this.btnAgregarUno.Location = new System.Drawing.Point(304, 116);
            this.btnAgregarUno.Name = "btnAgregarUno";
            this.btnAgregarUno.Size = new System.Drawing.Size(106, 36);
            this.btnAgregarUno.TabIndex = 8;
            this.btnAgregarUno.Text = "Agregar";
            this.btnAgregarUno.UseVisualStyleBackColor = true;
            this.btnAgregarUno.Click += new System.EventHandler(this.btnAgregarUno_Click);
            // 
            // cboMetodo
            // 
            this.cboMetodo.FormattingEnabled = true;
            this.cboMetodo.Items.AddRange(new object[] {
            "Congruencial Multiplicativo",
            "Congruencial Mixto"});
            this.cboMetodo.Location = new System.Drawing.Point(52, 10);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.Size = new System.Drawing.Size(116, 21);
            this.cboMetodo.TabIndex = 9;
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
            this.lbl_c.Location = new System.Drawing.Point(192, 66);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(13, 13);
            this.lbl_c.TabIndex = 11;
            this.lbl_c.Text = "c";
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(211, 63);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(116, 20);
            this.txt_c.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad por primera vez";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(318, 10);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(81, 20);
            this.txtCantidad.TabIndex = 14;
            this.txtCantidad.Text = "20";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(192, 92);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(42, 13);
            this.lblTiempo.TabIndex = 15;
            this.lblTiempo.Text = "Tiempo";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(331, 165);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 16;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Siguiente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // cboPagina
            // 
            this.cboPagina.FormattingEnabled = true;
            this.cboPagina.Location = new System.Drawing.Point(265, 167);
            this.cboPagina.Name = "cboPagina";
            this.cboPagina.Size = new System.Drawing.Size(60, 21);
            this.cboPagina.TabIndex = 18;
            this.cboPagina.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Pagina";
            this.label7.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 473);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboMetodo);
            this.tabPage1.Controls.Add(this.grdResultado);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cboPagina);
            this.tabPage1.Controls.Add(this.txt_semilla);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnAnterior);
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
            this.tabPage1.Size = new System.Drawing.Size(553, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Punto A";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
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
            this.tabPage2.Size = new System.Drawing.Size(553, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "B y C";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cboOrigenNumeros
            // 
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Origen de Numeros Aleatorios";
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
            // txtCantIntervalos
            // 
            this.txtCantIntervalos.Location = new System.Drawing.Point(167, 41);
            this.txtCantIntervalos.Name = "txtCantIntervalos";
            this.txtCantIntervalos.Size = new System.Drawing.Size(53, 20);
            this.txtCantIntervalos.TabIndex = 3;
            // 
            // txtCantNumerosAGenerar
            // 
            this.txtCantNumerosAGenerar.Location = new System.Drawing.Point(167, 67);
            this.txtCantNumerosAGenerar.Name = "txtCantNumerosAGenerar";
            this.txtCantNumerosAGenerar.Size = new System.Drawing.Size(53, 20);
            this.txtCantNumerosAGenerar.TabIndex = 5;
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
            // btnRealizarTest
            // 
            this.btnRealizarTest.Location = new System.Drawing.Point(167, 93);
            this.btnRealizarTest.Name = "btnRealizarTest";
            this.btnRealizarTest.Size = new System.Drawing.Size(88, 33);
            this.btnRealizarTest.TabIndex = 6;
            this.btnRealizarTest.Text = "Realizar TEST";
            this.btnRealizarTest.UseVisualStyleBackColor = true;
            this.btnRealizarTest.Click += new System.EventHandler(this.btnRealizarTest_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Intervalos,
            this.Cantidad,
            this.FO,
            this.FE,
            this.DifFrec,
            this.DifFrecCuadrado,
            this.chiCuadrado});
            this.dataGridView1.Location = new System.Drawing.Point(6, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(541, 309);
            this.dataGridView1.TabIndex = 7;
            // 
            // Intervalos
            // 
            this.Intervalos.HeaderText = "Intervalos";
            this.Intervalos.Name = "Intervalos";
            this.Intervalos.ReadOnly = true;
            this.Intervalos.Width = 50;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad en Intervalo";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 50;
            // 
            // FO
            // 
            this.FO.HeaderText = "Frecuencia Observada";
            this.FO.Name = "FO";
            this.FO.ReadOnly = true;
            this.FO.Width = 50;
            // 
            // FE
            // 
            this.FE.HeaderText = "Frecuencia Esperada";
            this.FE.Name = "FE";
            this.FE.ReadOnly = true;
            this.FE.Width = 50;
            // 
            // DifFrec
            // 
            this.DifFrec.HeaderText = "FE-FO";
            this.DifFrec.Name = "DifFrec";
            this.DifFrec.ReadOnly = true;
            this.DifFrec.Width = 50;
            // 
            // DifFrecCuadrado
            // 
            this.DifFrecCuadrado.HeaderText = "(FE-FO)^2";
            this.DifFrecCuadrado.Name = "DifFrecCuadrado";
            this.DifFrecCuadrado.ReadOnly = true;
            this.DifFrecCuadrado.Width = 50;
            // 
            // chiCuadrado
            // 
            this.chiCuadrado.HeaderText = "(FE-FO)^2/FE";
            this.chiCuadrado.Name = "chiCuadrado";
            this.chiCuadrado.ReadOnly = true;
            this.chiCuadrado.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboPagina;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intervalos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifFrec;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifFrecCuadrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiCuadrado;
    }
}

