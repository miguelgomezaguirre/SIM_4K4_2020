using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TP2.Clases;
using TP2.Properties;
using MathNet.Numerics.Distributions;


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
            discretaBinomial,
            discretaPoisson,
            discretaUniforme
        }

        private TipoDistribucion distribucionElegida;
        public frmPrincipal()
        {
            InitializeComponent();

            distribucionesContinuas.Add(new Distribucion { id=1, descripcion = "Exponencial Negativa", tipoDistribucion = Distribucion.Tipo.continua, parametrosEstimados = 1 });
            distribucionesContinuas.Add(new Distribucion { id = 2, descripcion = "Normal", tipoDistribucion = Distribucion.Tipo.continua, parametrosEstimados = 2 });
            distribucionesContinuas.Add(new Distribucion { id = 3, descripcion = "Uniforme", tipoDistribucion = Distribucion.Tipo.continua, parametrosEstimados = 0 });
            

            distribucionesDiscretas.Add(new Distribucion { id = 1, descripcion = "Binomial", tipoDistribucion = Distribucion.Tipo.discreta });
            distribucionesDiscretas.Add(new Distribucion { id = 2, descripcion = "Poisson", tipoDistribucion = Distribucion.Tipo.discreta });
            distribucionesDiscretas.Add(new Distribucion { id = 3, descripcion = "Uniforme", tipoDistribucion = Distribucion.Tipo.discreta });
        }

        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                txtDirectorio.Text = openFileDialog1.FileName;

                txtDirectorio.Enabled = false;

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
            if(validarTab1(ref mensajeError))
            {
                if(cargarDatos())
                {
                    if (datos.Count < 200)
                    {
                        MessageBox.Show("Debe ingresar una muestra mayor a 200 números. Datos encontrados: " + datos.Count());

                        return;
                    }

                    double min = datos.Min();
                    double max = datos.Max() + 0.001d;

                    int numeroDeIntervalos = int.Parse(txtCantIntervalos.Text);

                    double paso = (max - min) / (double)numeroDeIntervalos;

                    paso = Math.Round(paso, CANTIDAD_DECIMALES);

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

                    graficar(false);

                    lblTamanioMuestra.Text = "Tamaño de la muestra: " + datos.Count().ToString();
                    lblPaso.Text = "Paso: " + paso.ToString("0.0000");
                    lblPaso.Visible = true;

                    btnVerDistribucion.Enabled = true;
                    btnComparar.Enabled = true;
                    grpInfoMuestra.Visible = true;

                    reiniciarTab2();
                }

                

            }
            else
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                fila["Intervalo"] = "[" + intervalo.limiteInferior.ToString("0.0000") + " ; " + intervalo.limiteSuperior.ToString("0.0000") + ")";
                fila["FO"] = intervalo.frecuenciaObservada.ToString("0.0000");

                tabla.Rows.Add(fila);
            }           

            grdTab1.DataSource = tabla;
        }

        #region tab1

        private bool validarTab1(ref string mensajeError)
        {
            #region validacion archivo de datos

            string directorio = txtDirectorio.Text;

            if (string.IsNullOrEmpty(directorio))
            {
                mensajeError = "Debe seleccionar un archivo de datos";
                txtDirectorio.Focus();
                return false;
            }

            if (!File.Exists(directorio))
            {
                mensajeError = "Debe seleccionar un archivo válido";
                txtDirectorio.Focus();
                return false;
            }

            #endregion

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

                if(!int.TryParse(cantidadIntervalosText, out cantidadIntervalos))
                {
                    mensajeError = "El número de intervalos debe ser un valor entero";
                    txtCantIntervalos.Focus();
                    return false;
                }
                else
                {
                    if(cantidadIntervalos <= 0)
                    {
                        mensajeError = "El número de intervalos debe ser mayor a cero";
                        txtCantIntervalos.Focus();
                        return false;
                    }
                }
            }

            #endregion

            #region validacion seleccion tipo de variable

            if(!rdbContinua.Checked && !rdbDiscreta.Checked)
            {
                mensajeError = "Debe seleccionar un tipo de variable";
                grpTipoVariable.Focus();
                return false;
            }

            #endregion


            return true;
        }

        private bool cargarDatos()
        {
            string[] textoArchivo = File.ReadAllLines(txtDirectorio.Text);

            double valor = 0;

            for (int i = 0; i < textoArchivo.Length; i++)
            {
                string texto = textoArchivo[i].Replace(".", ",");

                texto = texto.Trim();

                if (double.TryParse(texto, out valor))
                {
                    datos.Add(valor);
                }
                else
                {
                    if(string.IsNullOrEmpty(texto))
                    {
                        continue;
                    }

                    MessageBox.Show("El valor en la línea " + (i + 1) + " no es numérico.", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }

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

                if(agregarEsperada)
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

            if(agregarEsperada)
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
            if(((TabControl)sender).SelectedTab.Name == "tabSeleccionDistribucion")
            {
                if(rdbContinua.Checked)
                {
                    cboDistribucion.DataSource = distribucionesContinuas;
                    cboDistribucion.DisplayMember = "descripcion";
                    cboDistribucion.ValueMember = "id";

                    pictureBox1.Image = Resources.continuas;
                }
                else if(rdbDiscreta.Checked)
                {
                    cboDistribucion.DataSource = distribucionesDiscretas;
                    cboDistribucion.DisplayMember = "descripcion";
                    cboDistribucion.ValueMember = "id";

                    pictureBox1.Image = Resources.discretas;
                }
            }

            if(!string.IsNullOrEmpty(txtCantIntervalos.Text))
            {
                setLabelGradosDeLibertad();                
            }
        }

        private void setLabelGradosDeLibertad()
        {
            int gradosDeLibertad = getGradosLibertad();
        }

        private void cboDistribucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLabelGradosDeLibertad();

            
            switch (((Distribucion)cboDistribucion.SelectedItem).id)
            {
                case 1:
                    if (((Distribucion)cboDistribucion.SelectedItem).tipoDistribucion == Distribucion.Tipo.continua)
                    {
                        distribucionElegida = TipoDistribucion.continuaExponencial;
                    }
                    else
                    {
                        distribucionElegida = TipoDistribucion.discretaBinomial;
                    }
                        break;

                case 2:
                    if (((Distribucion)cboDistribucion.SelectedItem).tipoDistribucion == Distribucion.Tipo.continua)
                    {
                        distribucionElegida = TipoDistribucion.continuaNormal;
                    }
                    else
                    {
                        distribucionElegida = TipoDistribucion.discretaPoisson;
                    }
                    break;

                case 3:
                    if (((Distribucion)cboDistribucion.SelectedItem).tipoDistribucion == Distribucion.Tipo.continua)
                    {
                        distribucionElegida = TipoDistribucion.continuaUniforme;
                    }
                    else
                    {
                        distribucionElegida = TipoDistribucion.discretaUniforme;
                    }
                    break;
                default:
                    break;
            }
            
        }
            

        private void btnComparar_Click(object sender, EventArgs e)
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

            }

            graficar(true);

            cboAlpha.Enabled = true;
            cboTest.Enabled = true;
            btnRealizarTest.Enabled = true;
        }

        private void reiniciarTab2()
        {
            cboAlpha.SelectedIndex = -1;
            cboTest.SelectedIndex = -1;

            cboAlpha.Enabled = false;
            cboTest.Enabled = false;
            btnRealizarTest.Enabled = false;

            grpResultado.Visible = false;
        }

        private void btnRealizarTest_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(cboTest.Text))
            {
                if (cboTest.Text.ToLower() == "chi cuadrado")
                {
                    if (!string.IsNullOrEmpty(cboAlpha.Text))
                    {
                        testChiCuadrado();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un nivel de significación");
                        cboAlpha.Focus();
                        return;
                    }

                }
                else
                {
                    if (cboAlpha.Text != "0,1" && cboAlpha.Text != "0,01" && cboAlpha.Text != "0,001" &&
                        cboAlpha.Text != "0,2" && cboAlpha.Text != "0,02" && cboAlpha.Text != "0,002" &&
                         cboAlpha.Text != "0,05" && cboAlpha.Text != "0,005")
                    {
                        MessageBox.Show("Debe seleccionar uno de los siguientes valores " + Environment.NewLine + " [0,1; 0,01 ; 0,001 ; 0,2 ; 0,02 ; 0,002 ; 0,05 ; 0,005 ]");
                        cboAlpha.Focus();
                        return;
                    }
                    testKolmogorov();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un método para realizar la prueba");
                cboTest.Focus();
                return;
            }
            
            
        }


        private void testChiCuadrado()
        {
            double chiCuadrado = 0;

            foreach (var intervalo in intervalos)
            {
                chiCuadrado += intervalo.chiCuadradoIntervalo();
            }

            int gradosLibertad = getGradosLibertad();

            if(gradosLibertad > 0)
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

                grpResultado.Visible = true;
            }
            else
            {
                MessageBox.Show("No se puede realizar el test con " + gradosLibertad + " grados de libertad. Ingrese una cantidad de intervalos mayor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tabControl1.SelectedTab = tabSeleccionArchivo;

                txtCantIntervalos.Focus();
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

            if(cboAlpha.Text == "0,05")
            {
                valorKolmogorov = 1.36d;
            }
            else if (cboAlpha.Text == "0,05")
            {
                valorKolmogorov = 1.73d;
            }
            else if(cboAlpha.Text == "0,01")
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

        private void cboTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(cboTest.Text))
            {
                object[] significancia = null;
                if (cboTest.Text.ToLower() == "chi cuadrado")
                {
                    significancia = new object[] { 0.1, 0.01, 0.001, 0.15, 0.2, 0.25, 0.025, 0.0025, 0.3, 0.35, 0.4, 0.45, 0.5, 0.05, 0.005};
                }
                else
                {
                    significancia = new object[] { 0.1, 0.01, 0.001, 0.2, 0.02, 0.002, 0.05, 0.005};
                }

                cboAlpha.Items.Clear();
                cboAlpha.Items.AddRange(significancia);
            }
            
        }
    }
}
