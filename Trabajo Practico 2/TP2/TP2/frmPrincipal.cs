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
using Accord.Statistics.Testing;
using Accord.Statistics.Distributions.Univariate;
using Accord.Math;

namespace TP2
{
    public partial class frmPrincipal : Form
    {
        private List<double> datos = new List<double>();
        private List<Intervalo> intervalos = new List<Intervalo>();

        const String FRECUENCIA_OBSERVADA = "Frecuencia Observada";
        const String FRECUENCIA_ESPERADA = "Frecuencia Esperada";

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

            distribucionesContinuas.Add(new Distribucion { id=1, descripcion = "Exponencial Negativa", tipoDistribucion = Distribucion.Tipo.continua });
            distribucionesContinuas.Add(new Distribucion { id = 2, descripcion = "Normal", tipoDistribucion = Distribucion.Tipo.continua });
            distribucionesContinuas.Add(new Distribucion { id = 3, descripcion = "Uniforme", tipoDistribucion = Distribucion.Tipo.continua });
            

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
                cargarDatos();

                double min = datos.Min();
                double max = datos.Max() + 0.001f;

                int numeroDeIntervalos = int.Parse(txtCantIntervalos.Text);

                double paso = (max - min) / (double)numeroDeIntervalos;

                double limiteInferior = min;
                double limiteSuperior = min + paso;

                Intervalo intervalo = null;

                for (int i = 0; i < numeroDeIntervalos; i++)
                {
                    intervalo = new Intervalo();

                    intervalo.numero = i + 1;
                    intervalo.limiteInferior = Math.Round(limiteInferior, 4);
                    intervalo.limiteSuperior = Math.Round(limiteSuperior, 4);

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

                grpInfoMuestra.Visible = true;

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
            return true;
        }

        private void cargarDatos()
        {
            string[] textoArchivo = File.ReadAllLines(txtDirectorio.Text);

            double valor = 0;

            for (int i = 0; i < textoArchivo.Length; i++)
            {
                string texto = textoArchivo[i].Replace(".", ",");
                if (double.TryParse(texto, out valor))
                {
                    datos.Add(valor);
                }
                else
                {
                    MessageBox.Show("El valor en la línea " + (i + 1) + " no es numérico.", "Error", MessageBoxButtons.OK);
                    return;
                }
            }
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

                double media = Math.Round((intervalo.limiteInferior + intervalo.limiteSuperior) / 2, 2);
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
            grafico.Titles.Add("FRECUENCIAS OBSERVADAS");
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
                    //TODO: Cargar combo continuas
                    cboDistribucion.DataSource = distribucionesContinuas;
                    cboDistribucion.DisplayMember = "descripcion";
                    cboDistribucion.ValueMember = "id";

                    pictureBox1.Image = Resources.continuas;
                }
                else if(rdbDiscreta.Checked)
                {
                    //TODO: Cargar combo discretas
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

        private double calcularFrecuenciaEsperada(double minimo, double maximo)
        {

            double media = obtenerMedia(datos);
            double frecuenciaTotal = 0;
            double frecuenciaMax = 0;
            double frecuenciaMin = 0;

            

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



                    frecuenciaMax = exponencial.CumulativeDistribution(maximo);
                    frecuenciaMin = exponencial.CumulativeDistribution(minimo);

                    break;
                case TipoDistribucion.continuaUniforme:

                    var uniforme = new ContinuousUniform();

                    frecuenciaMax = uniforme.CumulativeDistribution(maximo);
                    frecuenciaMin = uniforme.CumulativeDistribution(minimo);

                    break;
                case TipoDistribucion.continuaNormal:

                    var normal = new MathNet.Numerics.Distributions.Normal();

                    frecuenciaMax = normal.CumulativeDistribution(maximo);
                    frecuenciaMin = normal.CumulativeDistribution(minimo);

                    break;
                case TipoDistribucion.discretaBinomial:
                    break;
                case TipoDistribucion.discretaPoisson:
                    break;
                case TipoDistribucion.discretaUniforme:
                    break;
                default:
                    break;
            }

            frecuenciaTotal = frecuenciaMax - frecuenciaMin;

            return frecuenciaTotal * datos.Count();
        }


        private double obtenerMedia(List<double> datos)
        {
            return datos.Sum() / datos.Count(); 
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            double media = obtenerMedia(datos);
            double media2 = MathNet.Numerics.Statistics.ArrayStatistics.Mean(datos.ToArray());

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
                    }

                    break;

            }

            graficar(true);
        }

        private void btnRealizarTest_Click(object sender, EventArgs e)
        {
            if(cboTest.Text.ToLower() == "chi cuadrado")
            {
                testChiCuadrado();
            }
            else
            {
                testKolmogorov();
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


        private void testKolmogorov()
        {
            double probabilidadObservadaAcumulada = 0;
            double probabilidadEsperadaAcumulada = 0;

            double maximo = 0;

            foreach (var intervalo in intervalos)
            {
                probabilidadObservadaAcumulada += intervalo.frecuenciaObservada / (double)datos.Count();
                probabilidadEsperadaAcumulada += intervalo.frecuenciaEsperada / (double)datos.Count();

                double bondad = Math.Abs(probabilidadObservadaAcumulada - probabilidadEsperadaAcumulada);

                if(maximo < bondad)
                {
                    maximo = bondad;
                }
            }

            //TODO: obtener valor Kolmogorov
            double valorKolmogorov = 4.17;

            //Accord.Statistics.Distributions.Univariate
            var distribucion = Accord.Statistics.Distributions.Univariate.NormalDistribution.Standard;

            KolmogorovSmirnovTest kTest = new KolmogorovSmirnovTest(datos.ToArray(), distribucion);

            var statistics = kTest.Statistic;
            var pValue = kTest.PValue;
            bool acepta = kTest.Significant;

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

            lblValorObtenido.Text = statistics.ToString("0.0000");
            lblValorTabulado.Text = pValue.ToString("0.0000");

            grpResultado.Visible = true;

        }

        private int getGradosLibertad()
        {
            int gradosDeLibertad = 0;

            if (int.TryParse(txtCantIntervalos.Text, out gradosDeLibertad))
            {
                if (((Distribucion)cboDistribucion.SelectedItem).descripcion == "Poisson")
                {
                    gradosDeLibertad = gradosDeLibertad - 2;
                }
                else
                {
                    gradosDeLibertad = gradosDeLibertad - 1;
                }


                lblGradosDeLibertad.Text = "Grados de Libertad: " + gradosDeLibertad;
            }

            return gradosDeLibertad;
        }
    }
}
