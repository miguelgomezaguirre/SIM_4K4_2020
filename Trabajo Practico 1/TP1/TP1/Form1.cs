﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        List<string> numeros = new List<string>();
        List<double> numerosDouble = new List<double>();
        Generador generador = new Generador();
        List<Intervalo> intervalos = new List<Intervalo>();

        double Xn = 0;

        public Form1()
        {
            InitializeComponent();

            //Semilla = 37
            //a = 91
            //c = 43
            //m = 100

            txt_semilla.Text = "37";
            txt_a.Text = "91";
            txt_c.Text = "43";
            txt_m.Text = "100";

        }

        private void btnCalcular_Click(object sender, EventArgs e)
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
                    
                }            

            cargarGrilla(ref grdResultado);

            btnAgregarUno.Enabled = true;

            DateTime fechaHasta = DateTime.Now;

            TimeSpan ts = fechaHasta - fechaDesde;

            lblTiempo.Text = ts.Minutes.ToString() + ":" + ts.Seconds.ToString() + " mm:ss";

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
            double c = double.Parse(txt_c.Text);
            double numeroGenerado = 0;

            if (cboMetodo.SelectedItem.ToString() == "Congruencial Multiplicativo")
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


            cargarGrilla(ref grdResultado);

            

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
            if(cboMetodo.SelectedItem.ToString() == "Congruencial Multiplicativo")
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

        private void cboOrigenNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboOrigenNumeros.SelectedIndex == 0)
            {
                txtSemilla_puntoC.Enabled = false;
                txt_a_puntoC.Enabled = false;
                txt_c_puntoC.Enabled = false;
                txt_m_puntoC.Enabled = false;
            }
            else
            {
                txtSemilla_puntoC.Enabled = true;
                txt_a_puntoC.Enabled = true;
                txt_c_puntoC.Enabled = true;
                txt_m_puntoC.Enabled = true;
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
            }
            else
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK);
            }
            
            
        }

        private bool validarFormularioPuntoByC(ref string mensajeError)
        {
            if(cboOrigenNumeros.SelectedIndex == -1)
            {
                mensajeError = "Seleccione un origen de números aleatorios";
                cboOrigenNumeros.Focus();
                return false;
            }

            if(cboOrigenNumeros.SelectedIndex == 1)
            {
                //Metodo congruente mixto
                if(string.IsNullOrEmpty(txtSemilla_puntoC.Text))
                {
                    mensajeError = "Debe ingresar la semilla";
                    txtSemilla_puntoC.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txt_a_puntoC.Text))
                {
                    mensajeError = "Debe ingresar un valor para a";
                    txt_a_puntoC.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txt_m_puntoC.Text))
                {
                    mensajeError = "Debe ingresar un valor para m";
                    txt_m_puntoC.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txt_c_puntoC.Text))
                {
                    mensajeError = "Debe ingresar un valor para c";
                    txt_c_puntoC.Focus();
                    return false;
                }

                double valorText = 0;

                if(!double.TryParse(txtSemilla_puntoC.Text, out valorText))
                {
                    mensajeError = "Debe ingresar un número válido para la semilla";
                    txtSemilla_puntoC.Focus();
                    return false;
                }
                else
                {
                    if(valorText <= 0)
                    {
                        mensajeError = "El valor de c debe ser mayor a 0";
                        txtSemilla_puntoC.Focus();
                        return false;
                    }
                }

                if (!double.TryParse(txt_a_puntoC.Text, out valorText))
                {
                    mensajeError = "Debe ingresar un número válido para a";
                    txt_a_puntoC.Focus();
                    return false;
                }
                else
                {
                    if (valorText <= 0)
                    {
                        mensajeError = "El valor de a debe ser mayor a 0";
                        txt_a_puntoC.Focus();
                        return false;
                    }

                    if(valorText % 1 != 0)
                    {
                        mensajeError = "El valor de a debe ser entero";
                        txt_a_puntoC.Focus();
                        return false;
                    }
                }

                if (!double.TryParse(txt_m_puntoC.Text, out valorText))
                {
                    mensajeError = "Debe ingresar un número válido para m";
                    txt_m_puntoC.Focus();
                    return false;
                }
                else
                {
                    if(valorText <= 1)
                    {
                        mensajeError = "El valor de m debe ser mayor a 1";
                        txt_m_puntoC.Focus();
                        return false;
                    }

                    if (valorText % 1 != 0)
                    {
                        mensajeError = "El valor de m debe ser entero";
                        txt_m_puntoC.Focus();
                        return false;
                    }
                }

                if (!double.TryParse(txt_c_puntoC.Text, out valorText))
                {
                    mensajeError = "Debe ingresar un número válido para c";
                    txt_c_puntoC.Focus();
                    return false;
                }
                else
                {
                    if (valorText <= 0)
                    {
                        mensajeError = "El valor de c debe ser mayor a 1";
                        txt_c_puntoC.Focus();
                        return false;
                    }

                    if (valorText % 1 != 0)
                    {
                        mensajeError = "El valor de c debe ser entero";
                        txt_c_puntoC.Focus();
                        return false;
                    }
                }

            }

            return true;
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

                fila["Intervalo"] = "[ " + intervalo.limiteInferior + " ; " + intervalo.limiteSuperior + " )";
                fila["FO"] = intervalo.frecuenciaObservada;
                fila["FE"] = intervalo.frecuenciaEsperada;
                fila["DifFrec"] = intervalo.diferenciaDeFrecuencias();
                fila["DifFrecCuadrado"] = intervalo.diferenciaCuadradaDeFrecuencias();
                fila["chiCuadrado"] = intervalo.chiCuadradoIntervalo();

                acumulador += intervalo.chiCuadradoIntervalo();

                tabla.Rows.Add(fila);
            }

            fila = tabla.NewRow();

            fila["chiCuadrado"] = acumulador;

            tabla.Rows.Add(fila);

            lblChiCuadrado.Text = acumulador.ToString();
            lblChiCuadrado.Visible = true;

            grdPuntoB.DataSource = tabla;
        }

        private double truncar(double numero)
        {
            return Math.Truncate(numero * 10000) / 10000;
        }

        private void btnVerGrafico_Click(object sender, EventArgs e)
        {
            graficar();

            tabGrafico.Select();
            //for (int i = 0; i < intervalos.Count; i++)
            //{
            //    Series serie = grafico.Series.Add("titulo" + i);

            //    serie.Label = "etiqueta";
            //    serie.Points.Add(3);
            //}
        }

        private void graficar()
        {
            grafico.Palette = ChartColorPalette.Excel;

            grafico.Titles.Clear();
            grafico.Titles.Add("FRECUENCIAS OBSERVADAS VS ESPERADAS");
            grafico.Series.Clear();

            
            List<double> fObservada = new List<double>();
            List<double> fEsperada = new List<double>();

            foreach (Intervalo intervalo in intervalos)
            {
                fObservada.Add(intervalo.frecuenciaObservada);
                fEsperada.Add(intervalo.frecuenciaEsperada);
            }

            Series serieFObservada = new Series();
            serieFObservada.Name = "Frecuencia Observada";

            grafico.Series.Add(serieFObservada);

            Series serieFEsperada = new Series();
            serieFEsperada.Name = "Frecuencia Esperada";

            grafico.Series.Add(serieFEsperada);

            for (int i = 0; i < intervalos.Count; i++)
            {
                Intervalo aux = intervalos[i];
                double mediaIntervalo = Math.Round((aux.limiteInferior + aux.limiteSuperior) / 2d, 4);

                //grafico.Series["Frecuencia Esperada"].AxisLabel = mediaIntervalo.ToString();

                grafico.Series["Frecuencia Observada"].Points.AddXY(mediaIntervalo, fObservada[i]);
                grafico.Series["Frecuencia Esperada"].Points.AddXY(mediaIntervalo, fEsperada[i]);
            }


        }
    }

}
