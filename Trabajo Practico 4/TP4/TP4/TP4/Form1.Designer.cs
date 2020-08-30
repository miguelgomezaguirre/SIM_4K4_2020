namespace TP4
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtStockFinalDia = new System.Windows.Forms.TextBox();
            this.txtStockFinalDiaPromedio = new System.Windows.Forms.TextBox();
            this.txtCantCafeFaltantePromedio = new System.Windows.Forms.TextBox();
            this.txtIngresoPromedioDiario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStockFinalDia
            // 
            this.txtStockFinalDia.Location = new System.Drawing.Point(58, 194);
            this.txtStockFinalDia.Name = "txtStockFinalDia";
            this.txtStockFinalDia.Size = new System.Drawing.Size(100, 20);
            this.txtStockFinalDia.TabIndex = 1;
            // 
            // txtStockFinalDiaPromedio
            // 
            this.txtStockFinalDiaPromedio.Location = new System.Drawing.Point(199, 194);
            this.txtStockFinalDiaPromedio.Name = "txtStockFinalDiaPromedio";
            this.txtStockFinalDiaPromedio.Size = new System.Drawing.Size(100, 20);
            this.txtStockFinalDiaPromedio.TabIndex = 2;
            // 
            // txtCantCafeFaltantePromedio
            // 
            this.txtCantCafeFaltantePromedio.Location = new System.Drawing.Point(346, 194);
            this.txtCantCafeFaltantePromedio.Name = "txtCantCafeFaltantePromedio";
            this.txtCantCafeFaltantePromedio.Size = new System.Drawing.Size(100, 20);
            this.txtCantCafeFaltantePromedio.TabIndex = 3;
            // 
            // txtIngresoPromedioDiario
            // 
            this.txtIngresoPromedioDiario.Location = new System.Drawing.Point(476, 194);
            this.txtIngresoPromedioDiario.Name = "txtIngresoPromedioDiario";
            this.txtIngresoPromedioDiario.Size = new System.Drawing.Size(100, 20);
            this.txtIngresoPromedioDiario.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIngresoPromedioDiario);
            this.Controls.Add(this.txtCantCafeFaltantePromedio);
            this.Controls.Add(this.txtStockFinalDiaPromedio);
            this.Controls.Add(this.txtStockFinalDia);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStockFinalDia;
        private System.Windows.Forms.TextBox txtStockFinalDiaPromedio;
        private System.Windows.Forms.TextBox txtCantCafeFaltantePromedio;
        private System.Windows.Forms.TextBox txtIngresoPromedioDiario;
    }
}

