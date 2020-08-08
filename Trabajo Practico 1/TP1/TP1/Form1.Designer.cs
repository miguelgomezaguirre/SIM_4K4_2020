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
            this.txt_m = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarUno = new System.Windows.Forms.Button();
            this.cboMetodo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(188, 118);
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
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Semilla";
            // 
            // txt_semilla
            // 
            this.txt_semilla.Location = new System.Drawing.Point(58, 39);
            this.txt_semilla.Name = "txt_semilla";
            this.txt_semilla.Size = new System.Drawing.Size(116, 20);
            this.txt_semilla.TabIndex = 2;
            // 
            // grdResultado
            // 
            this.grdResultado.AllowUserToAddRows = false;
            this.grdResultado.AllowUserToDeleteRows = false;
            this.grdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultado.Location = new System.Drawing.Point(12, 160);
            this.grdResultado.Name = "grdResultado";
            this.grdResultado.ReadOnly = true;
            this.grdResultado.Size = new System.Drawing.Size(468, 278);
            this.grdResultado.TabIndex = 3;
            // 
            // txt_m
            // 
            this.txt_m.Location = new System.Drawing.Point(58, 91);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(116, 20);
            this.txt_m.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "m";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(58, 65);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(116, 20);
            this.txt_a.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "a";
            // 
            // btnAgregarUno
            // 
            this.btnAgregarUno.Enabled = false;
            this.btnAgregarUno.Location = new System.Drawing.Point(297, 118);
            this.btnAgregarUno.Name = "btnAgregarUno";
            this.btnAgregarUno.Size = new System.Drawing.Size(106, 36);
            this.btnAgregarUno.TabIndex = 8;
            this.btnAgregarUno.Text = "Agregar";
            this.btnAgregarUno.UseVisualStyleBackColor = true;
            // 
            // cboMetodo
            // 
            this.cboMetodo.FormattingEnabled = true;
            this.cboMetodo.Items.AddRange(new object[] {
            "Congruencial Multiplicativo",
            "Congruencial Mixto"});
            this.cboMetodo.Location = new System.Drawing.Point(58, 12);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.Size = new System.Drawing.Size(116, 21);
            this.cboMetodo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Metodo";
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(204, 65);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(116, 20);
            this.txt_c.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "c";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMetodo);
            this.Controls.Add(this.btnAgregarUno);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_m);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdResultado);
            this.Controls.Add(this.txt_semilla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_semilla;
        private System.Windows.Forms.DataGridView grdResultado;
        private System.Windows.Forms.TextBox txt_m;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarUno;
        private System.Windows.Forms.ComboBox cboMetodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label label5;
    }
}

