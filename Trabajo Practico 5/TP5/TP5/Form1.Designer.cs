namespace TP5
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
            this.iniciarSimulacion = new System.Windows.Forms.Button();
            this.grdResultado = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grdResultados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPedidosPorHora = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantidadEmpanadas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantidadLomitos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantidadHamburguesas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCantidadSandwich = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCantidadPizzas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIngresoHamburguesas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIngresoLomito = new System.Windows.Forms.Label();
            this.lstRankingCocineros = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSimularDia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // iniciarSimulacion
            // 
            this.iniciarSimulacion.Location = new System.Drawing.Point(12, 12);
            this.iniciarSimulacion.Name = "iniciarSimulacion";
            this.iniciarSimulacion.Size = new System.Drawing.Size(107, 23);
            this.iniciarSimulacion.TabIndex = 0;
            this.iniciarSimulacion.Text = "Iniciar Simulacion";
            this.iniciarSimulacion.UseVisualStyleBackColor = true;
            this.iniciarSimulacion.Click += new System.EventHandler(this.btnIniciarSimulacion_Click);
            // 
            // grdResultado
            // 
            this.grdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultado.Location = new System.Drawing.Point(6, 6);
            this.grdResultado.Name = "grdResultado";
            this.grdResultado.Size = new System.Drawing.Size(954, 470);
            this.grdResultado.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 508);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grdResultado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(966, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grdResultados);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(966, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grdResultados
            // 
            this.grdResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultados.Location = new System.Drawing.Point(3, 6);
            this.grdResultados.Name = "grdResultados";
            this.grdResultados.Size = new System.Drawing.Size(957, 470);
            this.grdResultados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1008, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estadisticas";
            // 
            // lstPedidosPorHora
            // 
            this.lstPedidosPorHora.FormattingEnabled = true;
            this.lstPedidosPorHora.Location = new System.Drawing.Point(1011, 57);
            this.lstPedidosPorHora.Name = "lstPedidosPorHora";
            this.lstPedidosPorHora.Size = new System.Drawing.Size(272, 121);
            this.lstPedidosPorHora.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1008, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad de empanadas";
            // 
            // lblCantidadEmpanadas
            // 
            this.lblCantidadEmpanadas.AutoSize = true;
            this.lblCantidadEmpanadas.Location = new System.Drawing.Point(1206, 202);
            this.lblCantidadEmpanadas.Name = "lblCantidadEmpanadas";
            this.lblCantidadEmpanadas.Size = new System.Drawing.Size(13, 13);
            this.lblCantidadEmpanadas.TabIndex = 6;
            this.lblCantidadEmpanadas.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1008, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad de Lomitos";
            // 
            // lblCantidadLomitos
            // 
            this.lblCantidadLomitos.AutoSize = true;
            this.lblCantidadLomitos.Location = new System.Drawing.Point(1206, 215);
            this.lblCantidadLomitos.Name = "lblCantidadLomitos";
            this.lblCantidadLomitos.Size = new System.Drawing.Size(13, 13);
            this.lblCantidadLomitos.TabIndex = 8;
            this.lblCantidadLomitos.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1008, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad de Hamburguesas";
            // 
            // lblCantidadHamburguesas
            // 
            this.lblCantidadHamburguesas.AutoSize = true;
            this.lblCantidadHamburguesas.Location = new System.Drawing.Point(1206, 228);
            this.lblCantidadHamburguesas.Name = "lblCantidadHamburguesas";
            this.lblCantidadHamburguesas.Size = new System.Drawing.Size(13, 13);
            this.lblCantidadHamburguesas.TabIndex = 8;
            this.lblCantidadHamburguesas.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1008, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cantidad de Sandwich";
            // 
            // lblCantidadSandwich
            // 
            this.lblCantidadSandwich.AutoSize = true;
            this.lblCantidadSandwich.Location = new System.Drawing.Point(1206, 241);
            this.lblCantidadSandwich.Name = "lblCantidadSandwich";
            this.lblCantidadSandwich.Size = new System.Drawing.Size(13, 13);
            this.lblCantidadSandwich.TabIndex = 8;
            this.lblCantidadSandwich.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1008, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cantidad de Pizzas";
            // 
            // lblCantidadPizzas
            // 
            this.lblCantidadPizzas.AutoSize = true;
            this.lblCantidadPizzas.Location = new System.Drawing.Point(1206, 254);
            this.lblCantidadPizzas.Name = "lblCantidadPizzas";
            this.lblCantidadPizzas.Size = new System.Drawing.Size(13, 13);
            this.lblCantidadPizzas.TabIndex = 8;
            this.lblCantidadPizzas.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1008, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingreso por Hamburguesas";
            // 
            // lblIngresoHamburguesas
            // 
            this.lblIngresoHamburguesas.AutoSize = true;
            this.lblIngresoHamburguesas.Location = new System.Drawing.Point(1206, 286);
            this.lblIngresoHamburguesas.Name = "lblIngresoHamburguesas";
            this.lblIngresoHamburguesas.Size = new System.Drawing.Size(13, 13);
            this.lblIngresoHamburguesas.TabIndex = 10;
            this.lblIngresoHamburguesas.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1008, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ingreso por Lomitos";
            // 
            // lblIngresoLomito
            // 
            this.lblIngresoLomito.AutoSize = true;
            this.lblIngresoLomito.Location = new System.Drawing.Point(1206, 299);
            this.lblIngresoLomito.Name = "lblIngresoLomito";
            this.lblIngresoLomito.Size = new System.Drawing.Size(13, 13);
            this.lblIngresoLomito.TabIndex = 10;
            this.lblIngresoLomito.Text = "0";
            // 
            // lstRankingCocineros
            // 
            this.lstRankingCocineros.FormattingEnabled = true;
            this.lstRankingCocineros.Location = new System.Drawing.Point(1011, 340);
            this.lstRankingCocineros.Name = "lstRankingCocineros";
            this.lstRankingCocineros.Size = new System.Drawing.Size(272, 56);
            this.lstRankingCocineros.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1008, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ranking uso de cocineros";
            // 
            // btnSimularDia
            // 
            this.btnSimularDia.Location = new System.Drawing.Point(125, 12);
            this.btnSimularDia.Name = "btnSimularDia";
            this.btnSimularDia.Size = new System.Drawing.Size(123, 23);
            this.btnSimularDia.TabIndex = 13;
            this.btnSimularDia.Text = "Simular Dia";
            this.btnSimularDia.UseVisualStyleBackColor = true;
            this.btnSimularDia.Click += new System.EventHandler(this.btnSimularDia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 561);
            this.Controls.Add(this.btnSimularDia);
            this.Controls.Add(this.lstRankingCocineros);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblIngresoLomito);
            this.Controls.Add(this.lblIngresoHamburguesas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCantidadPizzas);
            this.Controls.Add(this.lblCantidadSandwich);
            this.Controls.Add(this.lblCantidadHamburguesas);
            this.Controls.Add(this.lblCantidadLomitos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCantidadEmpanadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPedidosPorHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.iniciarSimulacion);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iniciarSimulacion;
        private System.Windows.Forms.DataGridView grdResultado;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grdResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPedidosPorHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantidadEmpanadas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantidadLomitos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantidadHamburguesas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCantidadSandwich;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCantidadPizzas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIngresoHamburguesas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIngresoLomito;
        private System.Windows.Forms.ListBox lstRankingCocineros;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSimularDia;
    }
}

