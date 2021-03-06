﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TP1.Clases;

namespace TP1
{
    public partial class Form1 : Form
    {
        const String FRECUENCIA_OBSERVADA = "Frecuencia Observada";
        const String FRECUENCIA_ESPERADA = "Frecuencia Esperada";

        List<string> numeros = new List<string>();
        List<double> numerosDouble = new List<double>();
        Generador generador = new Generador();
        List<Intervalo> intervalos = new List<Intervalo>();

        double Xn = 0;

        public Form1()
        {
            InitializeComponent();

            //txt_semilla.Text = "37";
            //txt_a.Text = "91";
            //txt_c.Text = "43";
            //txt_m.Text = "100";

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string mensajeError = "";
            if(validarFormularioPuntoA(ref mensajeError))
            {
                numeros = new List<string>();

                DateTime fechaDesde = DateTime.Now;
                //Congruencial Mixto
                //Xn+1 = (a*Xn + c) mod m (%)

                //Congruencial Multiplicativo
                //Xn+1 = (a * Xn) mod m (%)

                Xn = 0;

                int cantidadPorPrimeraVez = int.Parse(txtCantidad.Text);

                double siguienteValor = 0;
                double numeroGenerado = 0;

                double a = double.Parse(txt_a.Text);
                double m = double.Parse(txt_m.Text);
                double c = 0;

                if (!string.IsNullOrEmpty(txt_c.Text))
                    c = double.Parse(txt_c.Text);


                string metodoSeleccionado = cboMetodo.SelectedItem.ToString();

                for (int i = 0; i < cantidadPorPrimeraVez; i++)
                {
                    if (i == 0)
                    {
                        Xn = double.Parse(txt_semilla.Text);
                    }

                    if (metodoSeleccionado == "Congruencial Multiplicativo")
                    {
                        siguienteValor = generarMultiplicativo(Xn, a, m);
                    }
                    else
                    {
                        siguienteValor = generarMixto(Xn, a, m, c);
                    }

                    Xn = siguienteValor;

                    numeroGenerado = siguienteValor / (m - 1);

                    numeroGenerado = Math.Truncate(numeroGenerado * 10000) / 10000;

                    numeros.Add(numeroGenerado.ToString("0.0000"));
                    //numeros.Add(siguienteValor.ToString("0.0000"));

                }

                cargarGrilla(ref grdResultado);

                btnAgregarUno.Enabled = true;

                DateTime fechaHasta = DateTime.Now;

                TimeSpan ts = fechaHasta - fechaDesde;

                lblTiempo.Text = ts.TotalSeconds.ToString("0.0000") + " segundos";
                lblTiempo.Visible = true;

                btnLimpiar.Enabled = true;
            }
            else
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK);
            }
            

        }

        private bool validarFormularioPuntoA(ref string mensajeError)
        {
            if(cboMetodo.SelectedIndex == -1)
            {
                cboMetodo.Focus();
                mensajeError = "Seleccione un método de generación aleatoria";
                return false;
            }

            if(cboMetodo.SelectedIndex == 0)
            {
                if(!validarAM(ref mensajeError, ref txt_a, ref txt_m))
                {
                    return false;
                }
            }
            else
            {
                if (!validarAMC(ref mensajeError, ref txt_a, ref txt_m, ref txt_c))
                {
                    return false;
                }
            }

            if(string.IsNullOrEmpty(txtCantidad.Text))
            {
                mensajeError = "Debe ingresar una cantidad de números a generar";
                return false;
            }
            else
            {
                int cantidad = 0;

                if(!int.TryParse(txtCantidad.Text, out cantidad))
                {
                    mensajeError = "La cantidad debe ser un número entero";
                    return false;
                }

                if(cantidad % 1 != 0)
                {
                    mensajeError = "La cantidad debe ser un número entero";
                    return false;
                }

                if(cantidad <= 0)
                {
                    mensajeError = "La cantidad debe ser un número mayor a cero";
                    return false;
                }
            }
            

            return true;
        }

        private bool validarFormularioPuntoByC(ref string mensajeError)
        {
            if (cboOrigenNumeros.SelectedIndex == -1)
            {
                mensajeError = "Seleccione un origen de números aleatorios";
                cboOrigenNumeros.Focus();
                return false;
            }

            if (cboOrigenNumeros.SelectedIndex == 1)
            {
                //Metodo congruente mixto
                if (string.IsNullOrEmpty(txtSemilla_puntoC.Text))
                {
                    mensajeError = "Debe ingresar la semilla";
                    txtSemilla_puntoC.Focus();
                    return false;
                }

                string a = txt_a_puntoC.Text;
                string m = txt_m_puntoC.Text;
                string c = txt_c_puntoC.Text;

                if (!validarAMC(ref mensajeError, ref txt_a_puntoC, ref txt_m_puntoC, ref txt_c_puntoC))
                {
                    return false;
                }



            }

            int cantidad = 0;

            if(string.IsNullOrEmpty(txtCantNumerosAGenerar.Text))
            {
                mensajeError = "Debe ingresar la cantidad de números a generar";
                txtCantNumerosAGenerar.Focus();
                return false;
            }

            if(!int.TryParse(txtCantNumerosAGenerar.Text, out cantidad))
            {
                mensajeError = "La cantidad de números a generar debe ser entera";
                txtCantNumerosAGenerar.Focus();
                return false;
            }

            if(cantidad <= 0)
            {
                mensajeError = "La cantidad de números a generar debe ser mayor a cero";
                txtCantNumerosAGenerar.Focus();
                return false;
            }

            if(string.IsNullOrEmpty(txtCantIntervalos.Text))
            {
                mensajeError = "Debe ingresar una cantidad de intervalos";
                txtCantIntervalos.Focus();
                return false;
            }

            if (!int.TryParse(txtCantIntervalos.Text, out cantidad))
            {
                mensajeError = "La cantidad de intervalos debe ser entera";
                txtCantIntervalos.Focus();
                return false;
            }

            if (cantidad <= 0)
            {
                mensajeError = "La cantidad de intervalos debe ser mayor a cero";
                txtCantIntervalos.Focus();
                return false;
            }

            return true;
        }

        private bool validarAMC(ref string mensajeError, ref TextBox txtA, ref TextBox txtM, ref TextBox txtC)
        {
            if(!validarAM(ref mensajeError, ref txtA, ref txtM))
            {
                return false;
            }

            if (string.IsNullOrEmpty(txtC.Text))
            {
                mensajeError = "Debe ingresar un valor para c";
                txtC.Focus();
                return false;
            }

            double valorText = 0;

            if (!double.TryParse(txtC.Text, out valorText))
            {
                mensajeError = "Debe ingresar un número válido para la semilla";
                txtC.Focus();
                return false;
            }
            else
            {
                if (valorText <= 0)
                {
                    mensajeError = "El valor de c debe ser mayor a 0";
                    txtC.Focus();
                    return false;
                }
            }

            

            if (!double.TryParse(txtC.Text, out valorText))
            {
                mensajeError = "Debe ingresar un número válido para c";
                txtC.Focus();
                return false;
            }
            else
            {
                if (valorText <= 0)
                {
                    mensajeError = "El valor de c debe ser mayor a 1";
                    txtC.Focus();
                    return false;
                }

                if (valorText % 1 != 0)
                {
                    mensajeError = "El valor de c debe ser entero";
                    txtC.Focus();
                    return false;
                }
            }


            return true;
        }

        private bool validarAM(ref string mensajeError, ref TextBox txtA, ref TextBox txtM)
        {
            double valorText = 0;

            if (string.IsNullOrEmpty(txtA.Text))
            {
                mensajeError = "Debe ingresar un valor para a";
                txtA.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtM.Text))
            {
                mensajeError = "Debe ingresar un valor para m";
                txtM.Focus();
                return false;
            }

            if (!double.TryParse(txtA.Text, out valorText))
            {
                mensajeError = "Debe ingresar un número válido para a";
                txtA.Focus();
                return false;
            }
            else
            {
                if (valorText <= 0)
                {
                    mensajeError = "El valor de a debe ser mayor a 0";
                    txtA.Focus();
                    return false;
                }

                if (valorText % 1 != 0)
                {
                    mensajeError = "El valor de a debe ser entero";
                    txtA.Focus();
                    return false;
                }
            }

            if (!double.TryParse(txtM.Text, out valorText))
            {
                mensajeError = "Debe ingresar un número válido para m";
                txtM.Focus();
                return false;
            }
            else
            {
                if (valorText <= 1)
                {
                    mensajeError = "El valor de m debe ser mayor a 1";
                    txtM.Focus();
                    return false;
                }

                if (valorText % 1 != 0)
                {
                    mensajeError = "El valor de m debe ser entero";
                    txtM.Focus();
                    return false;
                }
            }

            return true;
        }

        private double generarMixto(double Xn, double a, double m, double c)
        {
            double resultado = generador.generarMixto(Xn, a, m, c);

            return resultado;
        }

        private double generarMultiplicativo(double Xn, double a, double m)
        {
            double resultado = generador.generarMultiplicativo(Xn, a, m);

            return resultado;
        }

        private void btnAgregarUno_Click(object sender, EventArgs e)
        {
            double siguienteValor = 0;
            double a = double.Parse(txt_a.Text);
            double m = double.Parse(txt_m.Text);

            double c = 0;
            double numeroGenerado = 0;

            if (cboMetodo.SelectedItem.ToString() == "Congruencial Multiplicativo")
            {
                siguienteValor = generarMultiplicativo(Xn, a, m);
            }
            else
            {
                c = double.Parse(txt_c.Text);

                siguienteValor = generarMixto(Xn, a, m, c);                
            }

            Xn = siguienteValor;

            numeroGenerado = siguienteValor / (m - 1);

            numeroGenerado = Math.Truncate(numeroGenerado * 10000) / 10000;

            numeros.Add(numeroGenerado.ToString("0.0000"));

            cargarGrilla(ref grdResultado);

            grdResultado.FirstDisplayedScrollingRowIndex = grdResultado.RowCount - 1;

        }

        private void cargarGrilla(ref DataGridView grilla)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Indice");
            table.Columns.Add("Numeros Aleatorios");

            int indice = 1;            

            foreach (var numero in numeros)   
            {
                DataRow fila = table.NewRow();

                fila["Indice"] = indice;
                fila["Numeros Aleatorios"] = numero;

                table.Rows.Add(fila);

                indice++;
            }

            grilla.DataSource = table;

            
        }

        private void cboMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboMetodo.SelectedItem != null)
            {
                if (cboMetodo.SelectedItem.ToString() == "Congruencial Multiplicativo")
                {
                    txt_c.Text = "";
                    txt_c.Visible = false;
                    lbl_c.Visible = false;
                }
                else
                {
                    txt_c.Text = "";
                    txt_c.Visible = true;
                    lbl_c.Visible = true;
                }
            }

            btnAgregarUno.Enabled = false;
        }

        private void cboOrigenNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboOrigenNumeros.SelectedIndex == 0)
            {
                txtSemilla_puntoC.Visible = false;
                txt_a_puntoC.Visible = false;
                txt_c_puntoC.Visible = false;
                txt_m_puntoC.Visible = false;

                lblSemila_puntoC.Visible = false;
                lbl_a_puntoC.Visible = false;
                lbl_m_puntoC.Visible = false;
                lbl_c_puntoC.Visible = false;
            }
            else
            {

                txtSemilla_puntoC.Visible = true;
                txt_a_puntoC.Visible = true;
                txt_c_puntoC.Visible = true;
                txt_m_puntoC.Visible = true;

                lblSemila_puntoC.Visible = true;
                lbl_a_puntoC.Visible = true;
                lbl_m_puntoC.Visible = true;
                lbl_c_puntoC.Visible = true;
            }
        }

        private void btnRealizarTest_Click(object sender, EventArgs e)
        {
            string mensajeError = "";

            if(validarFormularioPuntoByC(ref mensajeError))
            {
                numeros = new List<string>();

                intervalos = new List<Intervalo>();

                numerosDouble = new List<double>();

                int cantidadDeNumerosAGenerar = int.Parse(txtCantNumerosAGenerar.Text);
                int numeroDeIntervalos = int.Parse(txtCantIntervalos.Text);

                double tamanioIntervalo = Math.Round(1f / (double)numeroDeIntervalos, 5);

                double limiteInferior = 0;
                double frecuenciaEsperada = Math.Round((double)cantidadDeNumerosAGenerar / (double)numeroDeIntervalos, 5);

                for (int i = 0; i < numeroDeIntervalos; i++)
                {
                    Intervalo intervalo = new Intervalo();

                    intervalo.numero = i + 1;
                    intervalo.limiteInferior = limiteInferior;
                    intervalo.limiteSuperior = Math.Round(limiteInferior + tamanioIntervalo, 5);
                    intervalo.frecuenciaEsperada = frecuenciaEsperada;

                    limiteInferior = intervalo.limiteSuperior;

                    intervalos.Add(intervalo);
                }

                double numeroGenerado = 0;

                if (cboOrigenNumeros.SelectedIndex == 0)
                {
                    Random rnd = new Random();

                    for (int i = 0; i < cantidadDeNumerosAGenerar; i++)
                    {
                        numeroGenerado = rnd.NextDouble();

                        numeroGenerado = truncar(numeroGenerado);

                        numerosDouble.Add(numeroGenerado);

                        for (int j = 0; j < intervalos.Count; j++)
                        {
                            if (intervalos[j].limiteSuperior > numeroGenerado)
                            {
                                intervalos[j].frecuenciaObservada++;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    if (cboOrigenNumeros.SelectedIndex == 1)
                    {
                        //TODO: ACA Generar numeros aleatorios por metodo mixto

                        Xn = double.Parse(txtSemilla_puntoC.Text);

                        double a = double.Parse(txt_a_puntoC.Text);
                        double m = double.Parse(txt_m_puntoC.Text);
                        double c = double.Parse(txt_c_puntoC.Text);

                        for (int i = 0; i < cantidadDeNumerosAGenerar; i++)
                        {
                            Xn = generarMixto(Xn, a, m, c);

                            numeroGenerado = Xn / (m - 1);

                            numeroGenerado = Math.Truncate(numeroGenerado * 10000) / 10000;

                            numerosDouble.Add(numeroGenerado);

                            for (int j = 0; j < intervalos.Count; j++)
                            {
                                if (intervalos[j].limiteSuperior > numeroGenerado)
                                {
                                    intervalos[j].frecuenciaObservada++;
                                    break;
                                }
                            }
                        }
                    }

                }


                cargarGrillaPuntoB(intervalos);

                graficar();

                btnExportarSerie.Visible = true;
            }
            else
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK);
            }
            
            
        }

        

        private void cargarGrillaPuntoB(List<Intervalo> intervalos)
        {
            DataTable tabla = new DataTable();

            tabla.Columns.Add("Intervalo");
            tabla.Columns.Add("FO");
            tabla.Columns.Add("FE");
            tabla.Columns.Add("DifFrec");
            tabla.Columns.Add("DifFrecCuadrado");
            tabla.Columns.Add("chiCuadrado");

            

            double acumulador = 0;

            DataRow fila;

            foreach (var intervalo in intervalos)
            {
                fila = tabla.NewRow();

                fila["Intervalo"] = "[" + intervalo.limiteInferior + " ; " + intervalo.limiteSuperior + ")";
                fila["FO"] = intervalo.frecuenciaObservada.ToString("0.0000");
                fila["FE"] = intervalo.frecuenciaEsperada.ToString("0.0000");
                fila["DifFrec"] = intervalo.diferenciaDeFrecuencias().ToString("0.0000");
                fila["DifFrecCuadrado"] = intervalo.diferenciaCuadradaDeFrecuencias().ToString("0.0000");
                fila["chiCuadrado"] = intervalo.chiCuadradoIntervalo().ToString("0.0000");

                acumulador += intervalo.chiCuadradoIntervalo();

                tabla.Rows.Add(fila);
            }

            fila = tabla.NewRow();

            fila["chiCuadrado"] = acumulador.ToString("0.0000");

            tabla.Rows.Add(fila);

            lblChiCuadrado.Text = acumulador.ToString("0.0000");
            lblChiCuadrado.Visible = true;

            grdPuntoB.DataSource = tabla;
        }

        private double truncar(double numero)
        {
            return Math.Truncate(numero * 10000) / 10000;
        }

        

        private void graficar()
        {
            generarPaleta();

            int maxValue = 0;
            var chart = grafico.ChartAreas[0];
            chart.AxisX.CustomLabels.Clear();
            chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chart.AxisX.Minimum = 0;
            chart.AxisY.Minimum = 0;
            chart.AxisX.Maximum = 1;

            foreach (Intervalo intervalo in intervalos)
            {
                if (intervalo.frecuenciaObservada > maxValue) {
                    maxValue = intervalo.frecuenciaObservada;
                }

                double media = Math.Round((intervalo.limiteInferior + intervalo.limiteSuperior)/2, 2);
                media = Math.Truncate( media * 10000) / 10000;

                chart.AxisX.CustomLabels.Add(intervalo.limiteInferior, intervalo.limiteSuperior, media.ToString());

                grafico.Series[FRECUENCIA_OBSERVADA].Points.AddXY(media, intervalo.frecuenciaObservada);
                grafico.Series[FRECUENCIA_ESPERADA].Points.AddXY(media, intervalo.frecuenciaEsperada);
            }

            chart.AxisY.Maximum = maxValue * 1.1;
        }


        private void generarPaleta()
        {
            grafico.Palette = ChartColorPalette.Excel;
            grafico.Titles.Clear();
            grafico.Titles.Add("FRECUENCIAS OBSERVADAS VS ESPERADAS");
            grafico.Series.Clear();

            Series serieFObservada = new Series();
            serieFObservada.Name = FRECUENCIA_OBSERVADA;
            grafico.Series.Add(serieFObservada);

            Series serieFEsperada = new Series();
            serieFEsperada.Name = FRECUENCIA_ESPERADA;
            grafico.Series.Add(serieFEsperada);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void limpiarFormulario()
        {
            cboMetodo.SelectedIndex = -1;
            txt_semilla.Text = "";
            txt_a.Text = "";
            txt_m.Text = "";
            txt_c.Text = "";
            txtCantidad.Text = "";
            lblTiempo.Visible = false;

            btnAgregarUno.Enabled = false;
            btnLimpiar.Enabled = false;
            grdResultado.DataSource = null;
        }

        private void btnExportarSerie_Click(object sender, EventArgs e)
        {
            StringBuilder listadoNumeros = new StringBuilder();

            foreach (var numero in numerosDouble)
            {
                listadoNumeros.AppendLine(numero.ToString("0.0000"));
            }



            string pathArchivo = Application.StartupPath.TrimEnd('/') + "/list" + DateTime.Now.ToLongTimeString().Replace(":","_") + ".txt";
                       
            TextWriter tw = new StreamWriter(pathArchivo);

            tw.Write(listadoNumeros.ToString());

            tw.Close();

            Process.Start(pathArchivo);
        }
    }

}
