using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Clases;
using Clases.Generadores;
using MathNet.Numerics.Distributions;
using TP3.Properties;

namespace TP2
{
    public partial class frmPrincipal : Form
    {
        private List<double> datos = new List<double>();
        private List<Intervalo> intervalos = new List<Intervalo>();

        const String FRECUENCIA_OBSERVADA = "Frecuencia Observada";
        const String FRECUENCIA_ESPERADA = "Frecuencia Esperada";

        const int CANTIDAD_DECIMALES = 4;

        private List<Distribucion> distribucionesContinuas = new List<Distribucion>();
        private List<Distribucion> distribucionesDiscretas = new List<Distribucion>();

        enum TipoDistribucion
        {
            continuaExponencial,
            continuaUniforme,
            continuaNormal,
            continuaPoisson
        }

        private TipoDistribucion distribucionElegida;
        public frmPrincipal()
        {
            InitializeComponent();

            distribucionesContinuas.Add(new Distribucion { id = 1, descripcion = "Exponencial Negativa", tipoDistribucion = Distribucion.Tipo.continua, parametrosEstimados = 1 });
            distribucionesContinuas.Add(new Distribucion { id = 2, descripcion = "Normal", tipoDistribucion = Distribucion.Tipo.continua, parametrosEstimados = 2 });
            //distribucionesContinuas.Add(new Distribucion { id = 3, descripcion = "Uniforme", tipoDistribucion = Distribucion.Tipo.continua, parametrosEstimados = 2 });
            distribucionesContinuas.Add(new Distribucion { id = 4, descripcion = "Poisson", tipoDistribucion = Distribucion.Tipo.continua, parametrosEstimados = 1 });

            cboDistribucion.DataSource = distribucionesContinuas;
            cboDistribucion.DisplayMember = "descripcion";
            cboDistribucion.ValueMember = "id";
        }

        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                btnVerDistribucion.Enabled = false;

                reiniciarTab2();
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            datos.Clear();
            intervalos.Clear();

            string mensajeError = "";
            if (validarTab1(ref mensajeError))
            {
                btnProcesar.Enabled = false;
                btnProcesar.Text = "Generando...";

                Application.DoEvents();

                generarDatos();


                double min = datos.Min();
                double max = datos.Max() + 0.001d;

                int numeroDeIntervalos = int.Parse(txtCantIntervalos.Text);

                double paso = (max - min) / (double)numeroDeIntervalos;

                paso = Math.Round(paso, CANTIDAD_DECIMALES);

                if (distribucionElegida == TipoDistribucion.continuaPoisson)
                {
                    paso = 1;
                }

                double limiteInferior = min;
                double limiteSuperior = min + paso;

                Intervalo intervalo = null;

                for (int i = 0; i < numeroDeIntervalos; i++)
                {
                    intervalo = new Intervalo();

                    intervalo.numero = i + 1;
                    intervalo.limiteInferior = Math.Round(limiteInferior, CANTIDAD_DECIMALES);
                    intervalo.limiteSuperior = Math.Round(limiteSuperior, CANTIDAD_DECIMALES);

                    intervalos.Add(intervalo);

                    limiteInferior = limiteSuperior;
                    limiteSuperior = limiteInferior + paso;
                }

                for (int i = 0; i < datos.Count; i++)
                {
                    for (int j = 0; j < intervalos.Count; j++)
                    {
                        if (intervalos[j].limiteSuperior > datos[i])
                        {
                            intervalos[j].frecuenciaObservada++;
                            break;
                        }
                    }
                }

                cargarGrillaTab1();

                graficar(true);

                lblTamanioMuestra.Text = "Tamaño de la muestra: " + datos.Count().ToString();

                if(distribucionElegida != TipoDistribucion.continuaPoisson)
                {
                    lblPaso.Text = "Paso: " + paso.ToString("0.0000");
                    lblPaso.Visible = true;
                }
                else
                {
                    lblPaso.Visible = false;
                }
                    

                btnVerDistribucion.Enabled = true;
                grpInfoMuestra.Visible = true;

                reiniciarTab2();

                btnProcesar.Enabled = true;
                btnProcesar.Text = "Generar";

                Application.DoEvents();

            }
            else
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void generarDatos()
        {
            //Tomar distribucion, cant intervalos, cant numeros
            //Usar la libreria
            int cantidadIntervalos = int.Parse(txtCantIntervalos.Text);
            int cantidadDeNumeros = int.Parse(txtCantNumeros.Text);
            datos.Clear();
            

            switch (distribucionElegida)
            {
                case TipoDistribucion.continuaExponencial:

                    double lambdaExponencial = double.Parse(txtLambda.Text);

                    double[] muestraExponencial = DistribucionesContinuas.generarExponencial(lambdaExponencial, cantidadDeNumeros);

                    datos.AddRange(muestraExponencial.ToList());

                    break;
                case TipoDistribucion.continuaUniforme:

                    //double minimo = double.Parse(txtMinimo.Text);
                    //double maximo = double.Parse(txtMaximo.Text);

                    //DistribucionesContinuas.generarUniforme(minimo, maximo);

                    break;
                case TipoDistribucion.continuaNormal:

                    double media = double.Parse(txtMedia.Text);
                    double desviacion = double.Parse(txtDesvEstandar.Text);

                    double[] muestraNormal = DistribucionesContinuas.generarNormal(cantidadDeNumeros, media, desviacion);

                    datos.AddRange(muestraNormal.ToList());

                    break;

                case TipoDistribucion.continuaPoisson:

                    double lambdaPoisson = double.Parse(txtLambda.Text);

                    double[] muestraPoisson = DistribucionesContinuas.generarPoisson(lambdaPoisson, cantidadDeNumeros);

                    datos.AddRange(muestraPoisson.ToList());


                    break;
                default:
                    break;
            }
        }

        private void cargarGrillaTab1()
        {
            DataTable tabla = new DataTable();

            tabla.Columns.Add("Intervalo");
            tabla.Columns.Add("FO");

            DataRow fila;

            foreach (var intervalo in intervalos)
            {
                fila = tabla.NewRow();

                if (distribucionElegida != TipoDistribucion.continuaPoisson)
                {
                    fila["Intervalo"] = "[" + intervalo.limiteInferior.ToString("0.0000") + " ; " + intervalo.limiteSuperior.ToString("0.0000") + ")";
                }
                    
                else
                {
                    fila["Intervalo"] = intervalo.limiteInferior.ToString("0");
                }
                fila["FO"] = intervalo.frecuenciaObservada.ToString("0.0000");

                tabla.Rows.Add(fila);
            }

            grdTab1.DataSource = tabla;
        }

        #region tab1

        private bool validarTab1(ref string mensajeError)
        {

            #region validacion cantidad de intervalos

            string cantidadIntervalosText = txtCantIntervalos.Text;
            if (string.IsNullOrEmpty(cantidadIntervalosText))
            {
                mensajeError = "Debe ingresar la cantidad de intervalos";
                txtCantIntervalos.Focus();
                return false;
            }
            else
            {
                int cantidadIntervalos = 0;

                if (!int.TryParse(cantidadIntervalosText, out cantidadIntervalos))
                {
                    mensajeError = "El número de intervalos debe ser un valor entero";
                    txtCantIntervalos.Focus();
                    return false;
                }
                else
                {
                    if (cantidadIntervalos <= 0)
                    {
                        mensajeError = "El número de intervalos debe ser mayor a cero";
                        txtCantIntervalos.Focus();
                        return false;
                    }
                }
            }

            #endregion

            #region Validación cantidad de números

            string cantidadNumerosText = txtCantNumeros.Text;
            if (string.IsNullOrEmpty(cantidadNumerosText))
            {
                mensajeError = "Debe ingresar la cantidad de números a generar";
                txtCantNumeros.Focus();
                return false;
            }
            else
            {
                int cantidadNumeros = 0;

                if (!int.TryParse(cantidadNumerosText, out cantidadNumeros))
                {
                    mensajeError = "El número de intervalos debe ser un valor entero";
                    txtCantNumeros.Focus();
                    return false;
                }
                else
                {
                    if (cantidadNumeros <= 0)
                    {
                        mensajeError = "El número de intervalos debe ser mayor a cero";
                        txtCantNumeros.Focus();
                        return false;
                    }
                }
            }

            #endregion

            #region Validación Distribución Normal

            if(distribucionElegida == TipoDistribucion.continuaNormal)
            {
                string mediaText = txtMedia.Text;
                if (string.IsNullOrEmpty(mediaText))
                {
                    mensajeError = "Debe ingresar la media";
                    txtMedia.Focus();
                    return false;
                }
                else
                {
                    double media = 0;

                    if (!double.TryParse(mediaText, out media))
                    {
                        mensajeError = "La media debe ser numérica";
                        txtCantNumeros.Focus();
                        return false;
                    }
                }

                string desvEstandarText = txtDesvEstandar.Text;
                if (string.IsNullOrEmpty(desvEstandarText))
                {
                    mensajeError = "Debe ingresar la desviación estándar";
                    txtDesvEstandar.Focus();
                    return false;
                }
                else
                {
                    double desvEstandar = 0;

                    if (!double.TryParse(desvEstandarText, out desvEstandar))
                    {
                        mensajeError = "La desviación estándar debe ser mayor a cero";
                        txtDesvEstandar.Focus();
                        return false;
                    }
                }
            }


            #endregion

            #region Validación Poisson

            if(distribucionElegida == TipoDistribucion.continuaPoisson || distribucionElegida == TipoDistribucion.continuaExponencial)
            {
                string lambdaText = txtLambda.Text;
                if (string.IsNullOrEmpty(lambdaText))
                {
                    mensajeError = "Debe ingresar un valor para lambda";
                    txtLambda.Focus();
                    return false;
                }
                else
                {
                    double lambda = 0;

                    if (!double.TryParse(lambdaText, out lambda))
                    {
                        mensajeError = "El valor de lambda debe ser mayor a cero";
                        txtLambda.Focus();
                        return false;
                    }
                }
            }
            #endregion


            return true;
        }

        private void graficar(bool agregarEsperada)
        {
            generarPaleta(agregarEsperada);

            int maxValue = 0;
            var chart = grafico.ChartAreas[0];
            chart.AxisX.CustomLabels.Clear();
            chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chart.AxisX.Minimum = datos.Min();
            chart.AxisY.Minimum = 0;
            chart.AxisX.Maximum = datos.Max();

            foreach (Intervalo intervalo in intervalos)
            {
                if (intervalo.frecuenciaObservada > maxValue)
                {
                    maxValue = intervalo.frecuenciaObservada;
                }

                double media = Math.Round((intervalo.limiteInferior + intervalo.limiteSuperior) / 2, CANTIDAD_DECIMALES);
                media = Math.Truncate(media * 10000) / 10000;

                chart.AxisX.CustomLabels.Add(intervalo.limiteInferior, intervalo.limiteSuperior, media.ToString());

                grafico.Series[FRECUENCIA_OBSERVADA].Points.AddXY(media, intervalo.frecuenciaObservada);

                if (agregarEsperada)
                    grafico.Series[FRECUENCIA_ESPERADA].Points.AddXY(media, intervalo.frecuenciaEsperada);
            }

            chart.AxisY.Maximum = maxValue * 1.1;
        }


        private void generarPaleta(bool agregarEsperada)
        {
            grafico.Palette = ChartColorPalette.Excel;
            grafico.Titles.Clear();
            grafico.Series.Clear();

            Series serieFObservada = new Series();
            serieFObservada.Name = FRECUENCIA_OBSERVADA;
            grafico.Series.Add(serieFObservada);

            if (agregarEsperada)
            {
                Series serieFEsperada = new Series();
                serieFEsperada.Name = FRECUENCIA_ESPERADA;
                grafico.Series.Add(serieFEsperada);
            }

        }

        private void btnVerDistribucion_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSeleccionDistribucion;
        }


        #endregion

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TabControl)sender).SelectedTab.Name == "tabSeleccionDistribucion")
            {

                cboDistribucion.DataSource = distribucionesContinuas;
                cboDistribucion.DisplayMember = "descripcion";
                cboDistribucion.ValueMember = "id";

            }

            if (!string.IsNullOrEmpty(txtCantIntervalos.Text))
            {
                setLabelGradosDeLibertad();
            }
        }

        private void setLabelGradosDeLibertad()
        {
            int gradosDeLibertad = getGradosLibertad();
        }

        

        private void cboDistribucionGenerador_SelectedIndexChanged(object sender, EventArgs e)
        {
            bloquearControlesGeneracion();
            limpiarCampos();

            switch (((Distribucion)cboDistribucion.SelectedItem).id)
            {
                case 1:
                    distribucionElegida = TipoDistribucion.continuaExponencial;
                    txtLambda.Enabled = true;
                   
                    break;

                case 2:

                    distribucionElegida = TipoDistribucion.continuaNormal;

                    txtDesvEstandar.Enabled = true;
                    txtMedia.Enabled = true;
                    
                    break;

                case 3:

                    distribucionElegida = TipoDistribucion.continuaUniforme;


                    break;

                case 4:
                    distribucionElegida = TipoDistribucion.continuaPoisson;
                    txtLambda.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void limpiarCampos()
        {
            txtMedia.Text = "";
            txtDesvEstandar.Text = "";
            txtLambda.Text = "";
        }

        private void bloquearControlesGeneracion()
        {
            txtMedia.Enabled = false;
            txtDesvEstandar.Enabled = false;
            txtLambda.Enabled = false;
        }

        //private void btnComparar_Click(object sender, EventArgs e)
        //{
        //    double media = MathNet.Numerics.Statistics.ArrayStatistics.Mean(datos.ToArray());

        //    switch (distribucionElegida)
        //    {
        //        case TipoDistribucion.continuaExponencial:
        //            /*
        //             En el caso de haber elegido la distribucion exponencial, tenemos que:

        //                * lambda(media) = 1 / (media muestral);
                        
        //            */

        //            //obtenemos el lambda para esta distribucion
        //            double lambda = 1 / media;

        //            //generamos la distribucion para el lambda dado:
        //            Exponential exponencial = new Exponential(lambda);

        //            //recorremos los intervalos para obtener los valores minimos y maximos, y asi calcular la frecuencia esperada
        //            foreach (Intervalo intervalo in intervalos)
        //            {
        //                intervalo.frecuenciaEsperada = (exponencial.CumulativeDistribution(intervalo.limiteSuperior) - exponencial.CumulativeDistribution(intervalo.limiteInferior)) * datos.Count();

        //                intervalo.frecuenciaEsperada = Math.Round(intervalo.frecuenciaEsperada, CANTIDAD_DECIMALES);
        //            }

        //            break;

        //        case TipoDistribucion.continuaUniforme:
        //            /*
        //             En el caso de haber elegido uniforme, tenemos que:

        //                * FE = cantidad de datos de la muestra / cantidad de intervalos;
                        
        //            */

        //            //Entonces obtenemos este dato y se lo asignamos a todos los intervalos.
        //            double frecuenciaEsperada = (double)datos.Count() / (double)intervalos.Count();

        //            foreach (Intervalo intervalo in intervalos)
        //            {
        //                intervalo.frecuenciaEsperada = frecuenciaEsperada;

        //                intervalo.frecuenciaEsperada = Math.Round(intervalo.frecuenciaEsperada, CANTIDAD_DECIMALES);
        //            }

        //            break;

        //        case TipoDistribucion.continuaNormal:
        //            /*
        //                Para distribucion normal tenemos:
                    
        //                    desviacion estandar (sigma) = raiz cuadrada de la media;
                            
        //             */

        //            //obtenemos la varianza
        //            double varianza = MathNet.Numerics.Statistics.ArrayStatistics.Variance(datos.ToArray());

        //            //calculamos la deviacion estandar
        //            double desviacionEstandar = Math.Sqrt(varianza);

        //            //creo la distribucion normal
        //            MathNet.Numerics.Distributions.Normal normal = new MathNet.Numerics.Distributions.Normal(media, desviacionEstandar);

        //            foreach (Intervalo intervalo in intervalos)
        //            {
        //                intervalo.frecuenciaEsperada = (normal.CumulativeDistribution(intervalo.limiteSuperior) - normal.CumulativeDistribution(intervalo.limiteInferior)) * datos.Count();

        //                intervalo.frecuenciaEsperada = Math.Round(intervalo.frecuenciaEsperada, CANTIDAD_DECIMALES);
        //            }

        //            break;

        //    }

        //    graficar(true);

        //    cboAlpha.Enabled = true;
        //    btnRealizarTest.Enabled = true;
        //}

        private void reiniciarTab2()
        {
            cboAlpha.SelectedIndex = -1;

            cboAlpha.Enabled = true;
            btnRealizarTest.Enabled = true;

            grpResultado.Visible = false;
        }

        private void btnRealizarTest_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboAlpha.Text))
            {
                obtenerFrecuenciasEsperadas();
                testChiCuadrado();

                graficar(chkVerFrecEsperada.Checked);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un nivel de significación");
                cboAlpha.Focus();
                return;
            }
        }

        private void obtenerFrecuenciasEsperadas()
        {
            double media = MathNet.Numerics.Statistics.ArrayStatistics.Mean(datos.ToArray());

            switch (distribucionElegida)
            {
                case TipoDistribucion.continuaExponencial:
                    /*
                     En el caso de haber elegido la distribucion exponencial, tenemos que:

                        * lambda(media) = 1 / (media muestral);
                        
                    */

                    //obtenemos el lambda para esta distribucion
                    double lambda = 1 / media;

                    //generamos la distribucion para el lambda dado:
                    Exponential exponencial = new Exponential(lambda);

                    //recorremos los intervalos para obtener los valores minimos y maximos, y asi calcular la frecuencia esperada
                    foreach (Intervalo intervalo in intervalos)
                    {
                        intervalo.frecuenciaEsperada = (exponencial.CumulativeDistribution(intervalo.limiteSuperior) - exponencial.CumulativeDistribution(intervalo.limiteInferior)) * datos.Count();

                        intervalo.frecuenciaEsperada = Math.Round(intervalo.frecuenciaEsperada, CANTIDAD_DECIMALES);
                    }

                    break;

                case TipoDistribucion.continuaUniforme:
                    /*
                     En el caso de haber elegido uniforme, tenemos que:

                        * FE = cantidad de datos de la muestra / cantidad de intervalos;
                        
                    */

                    //Entonces obtenemos este dato y se lo asignamos a todos los intervalos.
                    double frecuenciaEsperada = (double)datos.Count() / (double)intervalos.Count();

                    foreach (Intervalo intervalo in intervalos)
                    {
                        intervalo.frecuenciaEsperada = frecuenciaEsperada;

                        intervalo.frecuenciaEsperada = Math.Round(intervalo.frecuenciaEsperada, CANTIDAD_DECIMALES);
                    }

                    break;

                case TipoDistribucion.continuaNormal:
                    /*
                        Para distribucion normal tenemos:
                    
                            desviacion estandar (sigma) = raiz cuadrada de la media;
                            
                     */

                    //obtenemos la varianza
                    double varianza = MathNet.Numerics.Statistics.ArrayStatistics.Variance(datos.ToArray());

                    //calculamos la deviacion estandar
                    double desviacionEstandar = Math.Sqrt(varianza);

                    //creo la distribucion normal
                    MathNet.Numerics.Distributions.Normal normal = new MathNet.Numerics.Distributions.Normal(media, desviacionEstandar);

                    foreach (Intervalo intervalo in intervalos)
                    {
                        intervalo.frecuenciaEsperada = (normal.CumulativeDistribution(intervalo.limiteSuperior) - normal.CumulativeDistribution(intervalo.limiteInferior)) * datos.Count();

                        intervalo.frecuenciaEsperada = Math.Round(intervalo.frecuenciaEsperada, CANTIDAD_DECIMALES);
                    }

                    break;

                case TipoDistribucion.continuaPoisson:

                    double lambdaPoisson = 1 / media;

                    Poisson poisson = new Poisson(media);

                    //recorremos los intervalos para obtener los valores minimos y maximos, y asi calcular la frecuencia esperada
                    foreach (Intervalo intervalo in intervalos)
                    {
                        intervalo.frecuenciaEsperada = (poisson.CumulativeDistribution(intervalo.limiteInferior) - poisson.CumulativeDistribution(intervalo.limiteInferior - 1)) * datos.Count();

                        intervalo.frecuenciaEsperada = Math.Round(intervalo.frecuenciaEsperada, CANTIDAD_DECIMALES);
                    }

                    break;

            }

        }

        private void testChiCuadrado()
        {
            try
            {
                double chiCuadrado = 0;

                foreach (var intervalo in intervalos)
                {
                    if (intervalo.frecuenciaEsperada == intervalo.frecuenciaObservada)
                        continue;

                    try
                    {

                        chiCuadrado += intervalo.chiCuadradoIntervalo();
                    }
                    catch (Exception)
                    {

                    }
                }

                int gradosLibertad = getGradosLibertad();

                if (gradosLibertad > 0)
                {
                    MathNet.Numerics.Distributions.ChiSquared chiSquared = new ChiSquared(gradosLibertad);

                    double nivelDeConfianza = double.Parse(cboAlpha.Text);

                    double valorChiCuadradoEnTabla = chiSquared.InverseCumulativeDistribution(1 - nivelDeConfianza);

                    lblValorObtenido.Text = chiCuadrado.ToString("0.0000");
                    lblValorTabulado.Text = valorChiCuadradoEnTabla.ToString("0.0000");

                    if (chiCuadrado < valorChiCuadradoEnTabla)
                    {
                        //No se rechaza la hipotesis
                        lblResultadoPrueba.Text = "No se puede rechazar la hipótesis";
                    }
                    else
                    {
                        //Se rechaza la hipotesis
                        lblResultadoPrueba.Text = "Se rechaza la hipótesis";
                    }

                    lblValorObtenido.Visible = true;
                    lblValorObtenidoTitle.Visible = true;
                    lblValorTabuladoTitle.Visible = true;
                    lblValorTabulado.Visible = true;

                    grpResultado.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se puede realizar el test con " + gradosLibertad + " grados de libertad. Ingrese una cantidad de intervalos mayor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    tabControl1.SelectedTab = tabSeleccionArchivo;

                    txtCantIntervalos.Focus();
                }
            }
            catch (Exception)
            {
                lblResultadoPrueba.Text = "Se rechaza la hipótesis";
                grpResultado.Visible = true;

                lblValorObtenido.Visible = false;
                lblValorObtenidoTitle.Visible = false;
                lblValorTabuladoTitle.Visible = false;
                lblValorTabulado.Visible = false;
            }
            

        }


        private void testKolmogorov()
        {
            double frecuenciaObservadaAcumulada = 0;
            double frecuenciaEsperadaAcumulada = 0;
            double probabilidadObservadaAcumulada = 0;
            double probabilidadEsperadaAcumulada = 0;

            double maximo = 0;

            foreach (var intervalo in intervalos)
            {
                frecuenciaObservadaAcumulada += intervalo.frecuenciaObservada;
                probabilidadObservadaAcumulada = frecuenciaObservadaAcumulada / (double)datos.Count();

                frecuenciaEsperadaAcumulada += intervalo.frecuenciaEsperada;
                probabilidadEsperadaAcumulada = frecuenciaEsperadaAcumulada / (double)datos.Count();

                double bondad = Math.Abs(probabilidadObservadaAcumulada - probabilidadEsperadaAcumulada);

                if (maximo < bondad)
                {
                    maximo = bondad;
                }
            }

            double DCalculado = maximo;
            //valor kolmogorov para alfa de 0.1
            double valorKolmogorov = 1.22d;

            if (cboAlpha.Text == "0,05")
            {
                valorKolmogorov = 1.36d;
            }
            else if (cboAlpha.Text == "0,05")
            {
                valorKolmogorov = 1.73d;
            }
            else if (cboAlpha.Text == "0,01")
            {
                valorKolmogorov = 1.63d;
            }
            else if (cboAlpha.Text == "0,001")
            {
                valorKolmogorov = 1.95d;
            }
            else if (cboAlpha.Text == "0,2")
            {
                valorKolmogorov = 1.07d;
            }
            else if (cboAlpha.Text == "0,02")
            {
                valorKolmogorov = 1.52d;
            }
            else if (cboAlpha.Text == "0,002")
            {
                valorKolmogorov = 1.85d;
            }

            double DCritico = valorKolmogorov / Math.Sqrt(intervalos.Count);

            ////Accord.Statistics.Distributions.Univariate
            //var distribucion = Accord.Statistics.Distributions.Univariate.NormalDistribution.Standard;

            //KolmogorovSmirnovTest kTest = new KolmogorovSmirnovTest(datos.ToArray(), distribucion);


            //var statistics = kTest.Statistic;
            //var pValue = kTest.PValue;
            //bool acepta = kTest.Significant;

            bool acepta = DCalculado < DCritico;


            if (acepta)
            {
                //No se rechaza la hipotesis
                lblResultadoPrueba.Text = "No se puede rechazar la hipótesis";
            }
            else
            {
                //Se rechaza la hipotesis
                lblResultadoPrueba.Text = "Se rechaza la hipótesis";
            }

            lblValorObtenido.Text = DCalculado.ToString("0.0000");
            lblValorTabulado.Text = DCritico.ToString("0.0000");

            grpResultado.Visible = true;

        }

        private int getGradosLibertad()
        {
            int gradosDeLibertad = 0;

            if (int.TryParse(txtCantIntervalos.Text, out gradosDeLibertad))
            {

                gradosDeLibertad = gradosDeLibertad - 1 - ((Distribucion)cboDistribucion.SelectedItem).parametrosEstimados;
                lblGradosDeLibertad.Text = "Grados de Libertad: " + gradosDeLibertad;
            }

            return gradosDeLibertad;
        }

        private void tabSeleccionDistribucion_Click(object sender, EventArgs e)
        {

        }

        private void btnExportarMuestra_Click(object sender, EventArgs e)
        {
            StringBuilder listadoNumeros = new StringBuilder();

            foreach (var numero in datos)
            {
                listadoNumeros.AppendLine(numero.ToString("0.0000"));
            }

            string pathArchivo = Application.StartupPath.TrimEnd('/') + "/list" + DateTime.Now.ToLongTimeString().Replace(":", "_") + ".txt";

            TextWriter tw = new StreamWriter(pathArchivo);

            tw.Write(listadoNumeros.ToString());

            tw.Close();

            Process.Start(pathArchivo);
        }
    }

      
}
