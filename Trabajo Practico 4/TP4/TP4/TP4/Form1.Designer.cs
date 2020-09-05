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
            this.txtDiasASimular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGramosPorFrasco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grdSimulacion = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSimulacionesGeneradas = new System.Windows.Forms.Label();
            this.chkCongruencial = new System.Windows.Forms.CheckBox();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabParametros = new System.Windows.Forms.TabPage();
            this.tabResultado = new System.Windows.Forms.TabPage();
            this.txtStockMaximo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFrecuenciaCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioFrasco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHorasTM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHorasTT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnValoresPorDefecto = new System.Windows.Forms.Button();
            this.txtFrascosPorCompra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chk50DiasAPartirDe = new System.Windows.Forms.CheckBox();
            this.txt50DiasAPartirDe = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl1 = new System.Windows.Forms.Label();
            this.grpResumen = new System.Windows.Forms.GroupBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.chkMostrarSolo10 = new System.Windows.Forms.CheckBox();
            this.lblContribucionPromedio = new System.Windows.Forms.Label();
            this.lblDemandaNoAbastecidaPromedio = new System.Windows.Forms.Label();
            this.lblIngresioDiarioPromedio = new System.Windows.Forms.Label();
            this.lblPorcentajeConFaltanteDeStock = new System.Windows.Forms.Label();
            this.lblPorcentajeSinFaltanteDeStock = new System.Windows.Forms.Label();
            this.lblPromedioHorasPerdidas = new System.Windows.Forms.Label();
            this.lblPorcentaje2Frascos = new System.Windows.Forms.Label();
            this.lblPorcentaje2y5Frascos = new System.Windows.Forms.Label();
            this.lblPorcentaje5y8Frascos = new System.Windows.Forms.Label();
            this.lblPorcentajeMasDe8Frascos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSimulacion)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tabParametros.SuspendLayout();
            this.tabResultado.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(488, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Simular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDiasASimular
            // 
            this.txtDiasASimular.Location = new System.Drawing.Point(6, 38);
            this.txtDiasASimular.Name = "txtDiasASimular";
            this.txtDiasASimular.Size = new System.Drawing.Size(100, 20);
            this.txtDiasASimular.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad dias a simular";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt50DiasAPartirDe);
            this.groupBox1.Controls.Add(this.chk50DiasAPartirDe);
            this.groupBox1.Controls.Add(this.txtFrascosPorCompra);
            this.groupBox1.Controls.Add(this.txtHorasTT);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtHorasTM);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPrecioVenta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPrecioFrasco);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFrecuenciaCompra);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtStockMaximo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGramosPorFrasco);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDiasASimular);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 321);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros de Simulación";
            // 
            // txtGramosPorFrasco
            // 
            this.txtGramosPorFrasco.Location = new System.Drawing.Point(150, 122);
            this.txtGramosPorFrasco.Name = "txtGramosPorFrasco";
            this.txtGramosPorFrasco.Size = new System.Drawing.Size(100, 20);
            this.txtGramosPorFrasco.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gramos por frasco";
            // 
            // grdSimulacion
            // 
            this.grdSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSimulacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSimulacion.Location = new System.Drawing.Point(3, 16);
            this.grdSimulacion.Name = "grdSimulacion";
            this.grdSimulacion.Size = new System.Drawing.Size(1057, 304);
            this.grdSimulacion.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdSimulacion);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1063, 323);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // lblSimulacionesGeneradas
            // 
            this.lblSimulacionesGeneradas.AutoSize = true;
            this.lblSimulacionesGeneradas.Location = new System.Drawing.Point(6, 332);
            this.lblSimulacionesGeneradas.Name = "lblSimulacionesGeneradas";
            this.lblSimulacionesGeneradas.Size = new System.Drawing.Size(35, 13);
            this.lblSimulacionesGeneradas.TabIndex = 11;
            this.lblSimulacionesGeneradas.Text = "label4";
            // 
            // chkCongruencial
            // 
            this.chkCongruencial.AutoSize = true;
            this.chkCongruencial.Location = new System.Drawing.Point(332, 6);
            this.chkCongruencial.Name = "chkCongruencial";
            this.chkCongruencial.Size = new System.Drawing.Size(195, 17);
            this.chkCongruencial.TabIndex = 10;
            this.chkCongruencial.Text = "Aleatorios con método congruencial";
            this.chkCongruencial.UseVisualStyleBackColor = true;
            this.chkCongruencial.CheckedChanged += new System.EventHandler(this.chkCongruencial_CheckedChanged);
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabParametros);
            this.tabPrincipal.Controls.Add(this.tabResultado);
            this.tabPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1083, 558);
            this.tabPrincipal.TabIndex = 12;
            // 
            // tabParametros
            // 
            this.tabParametros.Controls.Add(this.btnValoresPorDefecto);
            this.tabParametros.Controls.Add(this.groupBox3);
            this.tabParametros.Controls.Add(this.chkCongruencial);
            this.tabParametros.Controls.Add(this.groupBox1);
            this.tabParametros.Controls.Add(this.button1);
            this.tabParametros.Location = new System.Drawing.Point(4, 22);
            this.tabParametros.Name = "tabParametros";
            this.tabParametros.Padding = new System.Windows.Forms.Padding(3);
            this.tabParametros.Size = new System.Drawing.Size(1075, 532);
            this.tabParametros.TabIndex = 0;
            this.tabParametros.Text = "Parámetros";
            this.tabParametros.UseVisualStyleBackColor = true;
            // 
            // tabResultado
            // 
            this.tabResultado.Controls.Add(this.grpResumen);
            this.tabResultado.Controls.Add(this.progressBar1);
            this.tabResultado.Controls.Add(this.groupBox2);
            this.tabResultado.Controls.Add(this.lblSimulacionesGeneradas);
            this.tabResultado.Location = new System.Drawing.Point(4, 22);
            this.tabResultado.Name = "tabResultado";
            this.tabResultado.Padding = new System.Windows.Forms.Padding(3);
            this.tabResultado.Size = new System.Drawing.Size(1075, 532);
            this.tabResultado.TabIndex = 1;
            this.tabResultado.Text = "Resultado";
            this.tabResultado.UseVisualStyleBackColor = true;
            // 
            // txtStockMaximo
            // 
            this.txtStockMaximo.Location = new System.Drawing.Point(6, 167);
            this.txtStockMaximo.Name = "txtStockMaximo";
            this.txtStockMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtStockMaximo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stock Maximo";
            // 
            // txtFrecuenciaCompra
            // 
            this.txtFrecuenciaCompra.Location = new System.Drawing.Point(6, 214);
            this.txtFrecuenciaCompra.Name = "txtFrecuenciaCompra";
            this.txtFrecuenciaCompra.Size = new System.Drawing.Size(100, 20);
            this.txtFrecuenciaCompra.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Frecuencia De Compra";
            // 
            // txtPrecioFrasco
            // 
            this.txtPrecioFrasco.Location = new System.Drawing.Point(150, 167);
            this.txtPrecioFrasco.Name = "txtPrecioFrasco";
            this.txtPrecioFrasco.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioFrasco.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Importe por frasco (compra)";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(150, 214);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Precio Venta (c/100 g)";
            // 
            // txtHorasTM
            // 
            this.txtHorasTM.Location = new System.Drawing.Point(9, 262);
            this.txtHorasTM.Name = "txtHorasTM";
            this.txtHorasTM.Size = new System.Drawing.Size(100, 20);
            this.txtHorasTM.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Horas TM";
            // 
            // txtHorasTT
            // 
            this.txtHorasTT.Location = new System.Drawing.Point(150, 262);
            this.txtHorasTT.Name = "txtHorasTT";
            this.txtHorasTT.Size = new System.Drawing.Size(100, 20);
            this.txtHorasTT.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Horas TT";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkMostrarSolo10);
            this.groupBox3.Controls.Add(this.txtM);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtSemilla);
            this.groupBox3.Controls.Add(this.txtC);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtA);
            this.groupBox3.Location = new System.Drawing.Point(332, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 260);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parámetros Congruencial";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(9, 179);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 20);
            this.txtM.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "m";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(9, 131);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "c";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(9, 84);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Semilla";
            // 
            // txtSemilla
            // 
            this.txtSemilla.Location = new System.Drawing.Point(9, 35);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(100, 20);
            this.txtSemilla.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "a";
            // 
            // btnValoresPorDefecto
            // 
            this.btnValoresPorDefecto.Location = new System.Drawing.Point(500, 29);
            this.btnValoresPorDefecto.Name = "btnValoresPorDefecto";
            this.btnValoresPorDefecto.Size = new System.Drawing.Size(95, 63);
            this.btnValoresPorDefecto.TabIndex = 12;
            this.btnValoresPorDefecto.Text = "Valores Por Defecto";
            this.btnValoresPorDefecto.UseVisualStyleBackColor = true;
            this.btnValoresPorDefecto.Click += new System.EventHandler(this.btnValoresPorDefecto_Click);
            // 
            // txtFrascosPorCompra
            // 
            this.txtFrascosPorCompra.Location = new System.Drawing.Point(6, 122);
            this.txtFrascosPorCompra.Name = "txtFrascosPorCompra";
            this.txtFrascosPorCompra.Size = new System.Drawing.Size(100, 20);
            this.txtFrascosPorCompra.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Frascos Por Compra";
            // 
            // chk50DiasAPartirDe
            // 
            this.chk50DiasAPartirDe.AutoSize = true;
            this.chk50DiasAPartirDe.Location = new System.Drawing.Point(6, 69);
            this.chk50DiasAPartirDe.Name = "chk50DiasAPartirDe";
            this.chk50DiasAPartirDe.Size = new System.Drawing.Size(149, 17);
            this.chk50DiasAPartirDe.TabIndex = 24;
            this.chk50DiasAPartirDe.Text = "Detallar 50 dias a partir de";
            this.chk50DiasAPartirDe.UseVisualStyleBackColor = true;
            this.chk50DiasAPartirDe.CheckedChanged += new System.EventHandler(this.chk50DiasAPartirDe_CheckedChanged);
            // 
            // txt50DiasAPartirDe
            // 
            this.txt50DiasAPartirDe.Enabled = false;
            this.txt50DiasAPartirDe.Location = new System.Drawing.Point(161, 67);
            this.txt50DiasAPartirDe.Name = "txt50DiasAPartirDe";
            this.txt50DiasAPartirDe.Size = new System.Drawing.Size(89, 20);
            this.txt50DiasAPartirDe.TabIndex = 25;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 357);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1057, 20);
            this.progressBar1.TabIndex = 13;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(119, 13);
            this.lbl1.TabIndex = 14;
            this.lbl1.Text = "Contribución Promedio: ";
            // 
            // grpResumen
            // 
            this.grpResumen.Controls.Add(this.lblPorcentajeMasDe8Frascos);
            this.grpResumen.Controls.Add(this.lblPorcentaje5y8Frascos);
            this.grpResumen.Controls.Add(this.lblPorcentaje2y5Frascos);
            this.grpResumen.Controls.Add(this.lblPorcentaje2Frascos);
            this.grpResumen.Controls.Add(this.lblPromedioHorasPerdidas);
            this.grpResumen.Controls.Add(this.lblPorcentajeSinFaltanteDeStock);
            this.grpResumen.Controls.Add(this.lblPorcentajeConFaltanteDeStock);
            this.grpResumen.Controls.Add(this.lblIngresioDiarioPromedio);
            this.grpResumen.Controls.Add(this.lblDemandaNoAbastecidaPromedio);
            this.grpResumen.Controls.Add(this.lblContribucionPromedio);
            this.grpResumen.Controls.Add(this.label19);
            this.grpResumen.Controls.Add(this.label18);
            this.grpResumen.Controls.Add(this.label17);
            this.grpResumen.Controls.Add(this.label16);
            this.grpResumen.Controls.Add(this.label15);
            this.grpResumen.Controls.Add(this.label1);
            this.grpResumen.Controls.Add(this.lbl5);
            this.grpResumen.Controls.Add(this.lbl4);
            this.grpResumen.Controls.Add(this.lbl3);
            this.grpResumen.Controls.Add(this.lbl2);
            this.grpResumen.Controls.Add(this.lbl1);
            this.grpResumen.Location = new System.Drawing.Point(9, 383);
            this.grpResumen.Name = "grpResumen";
            this.grpResumen.Size = new System.Drawing.Size(1057, 143);
            this.grpResumen.TabIndex = 15;
            this.grpResumen.TabStop = false;
            this.grpResumen.Text = "Resumen";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(6, 47);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(179, 13);
            this.lbl2.TabIndex = 15;
            this.lbl2.Text = "Demanda No Abastecida Promedio: ";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(6, 71);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(125, 13);
            this.lbl3.TabIndex = 16;
            this.lbl3.Text = "Ingreso Diario Promedio: ";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(6, 94);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(208, 13);
            this.lbl4.TabIndex = 17;
            this.lbl4.Text = "Porcentaje de días con faltante de Stock: ";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(6, 117);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(203, 13);
            this.lbl5.TabIndex = 18;
            this.lbl5.Text = "Porcentaje de días sin faltante de Stock: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Promedio Horas Perdidas: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(700, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(193, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Porcentaje de Dias con hasta 2 frascos";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(700, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Stock";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(700, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(208, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Porcentaje de Dias con frascos entre 2 y 5";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(700, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(208, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Porcentaje de Dias con frascos entre 5 y 8";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(700, 117);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(201, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Porcentaje de Dias con mas de 8 frascos";
            // 
            // chkMostrarSolo10
            // 
            this.chkMostrarSolo10.AutoSize = true;
            this.chkMostrarSolo10.Location = new System.Drawing.Point(9, 205);
            this.chkMostrarSolo10.Name = "chkMostrarSolo10";
            this.chkMostrarSolo10.Size = new System.Drawing.Size(119, 17);
            this.chkMostrarSolo10.TabIndex = 30;
            this.chkMostrarSolo10.Text = "Mostrar Primeros 10";
            this.chkMostrarSolo10.UseVisualStyleBackColor = true;
            this.chkMostrarSolo10.CheckedChanged += new System.EventHandler(this.chkMostrarSolo10_CheckedChanged);
            // 
            // lblContribucionPromedio
            // 
            this.lblContribucionPromedio.AutoSize = true;
            this.lblContribucionPromedio.Location = new System.Drawing.Point(247, 25);
            this.lblContribucionPromedio.Name = "lblContribucionPromedio";
            this.lblContribucionPromedio.Size = new System.Drawing.Size(41, 13);
            this.lblContribucionPromedio.TabIndex = 25;
            this.lblContribucionPromedio.Text = "label20";
            this.lblContribucionPromedio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDemandaNoAbastecidaPromedio
            // 
            this.lblDemandaNoAbastecidaPromedio.AutoSize = true;
            this.lblDemandaNoAbastecidaPromedio.Location = new System.Drawing.Point(247, 47);
            this.lblDemandaNoAbastecidaPromedio.Name = "lblDemandaNoAbastecidaPromedio";
            this.lblDemandaNoAbastecidaPromedio.Size = new System.Drawing.Size(41, 13);
            this.lblDemandaNoAbastecidaPromedio.TabIndex = 26;
            this.lblDemandaNoAbastecidaPromedio.Text = "label20";
            this.lblDemandaNoAbastecidaPromedio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblIngresioDiarioPromedio
            // 
            this.lblIngresioDiarioPromedio.AutoSize = true;
            this.lblIngresioDiarioPromedio.Location = new System.Drawing.Point(247, 71);
            this.lblIngresioDiarioPromedio.Name = "lblIngresioDiarioPromedio";
            this.lblIngresioDiarioPromedio.Size = new System.Drawing.Size(41, 13);
            this.lblIngresioDiarioPromedio.TabIndex = 27;
            this.lblIngresioDiarioPromedio.Text = "label20";
            this.lblIngresioDiarioPromedio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPorcentajeConFaltanteDeStock
            // 
            this.lblPorcentajeConFaltanteDeStock.AutoSize = true;
            this.lblPorcentajeConFaltanteDeStock.Location = new System.Drawing.Point(247, 94);
            this.lblPorcentajeConFaltanteDeStock.Name = "lblPorcentajeConFaltanteDeStock";
            this.lblPorcentajeConFaltanteDeStock.Size = new System.Drawing.Size(41, 13);
            this.lblPorcentajeConFaltanteDeStock.TabIndex = 28;
            this.lblPorcentajeConFaltanteDeStock.Text = "label20";
            this.lblPorcentajeConFaltanteDeStock.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPorcentajeSinFaltanteDeStock
            // 
            this.lblPorcentajeSinFaltanteDeStock.AutoSize = true;
            this.lblPorcentajeSinFaltanteDeStock.Location = new System.Drawing.Point(247, 117);
            this.lblPorcentajeSinFaltanteDeStock.Name = "lblPorcentajeSinFaltanteDeStock";
            this.lblPorcentajeSinFaltanteDeStock.Size = new System.Drawing.Size(41, 13);
            this.lblPorcentajeSinFaltanteDeStock.TabIndex = 29;
            this.lblPorcentajeSinFaltanteDeStock.Text = "label20";
            this.lblPorcentajeSinFaltanteDeStock.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPromedioHorasPerdidas
            // 
            this.lblPromedioHorasPerdidas.AutoSize = true;
            this.lblPromedioHorasPerdidas.Location = new System.Drawing.Point(534, 25);
            this.lblPromedioHorasPerdidas.Name = "lblPromedioHorasPerdidas";
            this.lblPromedioHorasPerdidas.Size = new System.Drawing.Size(41, 13);
            this.lblPromedioHorasPerdidas.TabIndex = 30;
            this.lblPromedioHorasPerdidas.Text = "label20";
            // 
            // lblPorcentaje2Frascos
            // 
            this.lblPorcentaje2Frascos.AutoSize = true;
            this.lblPorcentaje2Frascos.Location = new System.Drawing.Point(972, 47);
            this.lblPorcentaje2Frascos.Name = "lblPorcentaje2Frascos";
            this.lblPorcentaje2Frascos.Size = new System.Drawing.Size(41, 13);
            this.lblPorcentaje2Frascos.TabIndex = 31;
            this.lblPorcentaje2Frascos.Text = "label20";
            this.lblPorcentaje2Frascos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPorcentaje2y5Frascos
            // 
            this.lblPorcentaje2y5Frascos.AutoSize = true;
            this.lblPorcentaje2y5Frascos.Location = new System.Drawing.Point(972, 71);
            this.lblPorcentaje2y5Frascos.Name = "lblPorcentaje2y5Frascos";
            this.lblPorcentaje2y5Frascos.Size = new System.Drawing.Size(41, 13);
            this.lblPorcentaje2y5Frascos.TabIndex = 32;
            this.lblPorcentaje2y5Frascos.Text = "label20";
            this.lblPorcentaje2y5Frascos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPorcentaje5y8Frascos
            // 
            this.lblPorcentaje5y8Frascos.AutoSize = true;
            this.lblPorcentaje5y8Frascos.Location = new System.Drawing.Point(972, 94);
            this.lblPorcentaje5y8Frascos.Name = "lblPorcentaje5y8Frascos";
            this.lblPorcentaje5y8Frascos.Size = new System.Drawing.Size(41, 13);
            this.lblPorcentaje5y8Frascos.TabIndex = 33;
            this.lblPorcentaje5y8Frascos.Text = "label20";
            this.lblPorcentaje5y8Frascos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPorcentajeMasDe8Frascos
            // 
            this.lblPorcentajeMasDe8Frascos.AutoSize = true;
            this.lblPorcentajeMasDe8Frascos.Location = new System.Drawing.Point(972, 117);
            this.lblPorcentajeMasDe8Frascos.Name = "lblPorcentajeMasDe8Frascos";
            this.lblPorcentajeMasDe8Frascos.Size = new System.Drawing.Size(41, 13);
            this.lblPorcentajeMasDe8Frascos.TabIndex = 34;
            this.lblPorcentajeMasDe8Frascos.Text = "label20";
            this.lblPorcentajeMasDe8Frascos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 577);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSimulacion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.tabParametros.ResumeLayout(false);
            this.tabParametros.PerformLayout();
            this.tabResultado.ResumeLayout(false);
            this.tabResultado.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpResumen.ResumeLayout(false);
            this.grpResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDiasASimular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGramosPorFrasco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdSimulacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSimulacionesGeneradas;
        private System.Windows.Forms.CheckBox chkCongruencial;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabParametros;
        private System.Windows.Forms.TabPage tabResultado;
        private System.Windows.Forms.TextBox txtStockMaximo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFrecuenciaCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioFrasco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHorasTM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHorasTT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnValoresPorDefecto;
        private System.Windows.Forms.TextBox txtFrascosPorCompra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt50DiasAPartirDe;
        private System.Windows.Forms.CheckBox chk50DiasAPartirDe;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox grpResumen;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chkMostrarSolo10;
        private System.Windows.Forms.Label lblContribucionPromedio;
        private System.Windows.Forms.Label lblDemandaNoAbastecidaPromedio;
        private System.Windows.Forms.Label lblIngresioDiarioPromedio;
        private System.Windows.Forms.Label lblPorcentajeConFaltanteDeStock;
        private System.Windows.Forms.Label lblPorcentajeSinFaltanteDeStock;
        private System.Windows.Forms.Label lblPromedioHorasPerdidas;
        private System.Windows.Forms.Label lblPorcentaje2Frascos;
        private System.Windows.Forms.Label lblPorcentajeMasDe8Frascos;
        private System.Windows.Forms.Label lblPorcentaje5y8Frascos;
        private System.Windows.Forms.Label lblPorcentaje2y5Frascos;
    }
}

