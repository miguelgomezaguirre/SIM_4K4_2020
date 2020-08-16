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
        public frmPrincipal()
        {
            InitializeComponent();

            distribucionesContinuas.Add(new Distribucion { id=1, descripcion = "Exponencial Negativa" });
            distribucionesContinuas.Add(new Distribucion { id = 2, descripcion = "Uniforme" });
            distribucionesContinuas.Add(new Distribucion { id = 3, descripcion = "Normal" });

            distribucionesDiscretas.Add(new Distribucion { id = 1, descripcion = "Binomial" });
            distribucionesDiscretas.Add(new Distribucion { id = 2, descripcion = "Poisson" });
            distribucionesDiscretas.Add(new Distribucion { id = 3, descripcion = "Uniforme" });
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
            string mensajeError = "";
            if(validarTab1(ref mensajeError))
            {
                cargarDatos();

                double min = datos.Min();
                double max = datos.Max();

                int numeroDeIntervalos = int.Parse(txtCantIntervalos.Text);

                double paso = (max - min) / (double)numeroDeIntervalos;

                double limiteInferior = min;
                double limiteSuperior = min + paso;

                Intervalo intervalo = null;

                for (int i = 0; i < numeroDeIntervalos; i++)
                {
                    intervalo = new Intervalo();

                    intervalo.numero = i + 1;
                    intervalo.limiteInferior = limiteInferior;
                    intervalo.limiteSuperior = limiteSuperior;

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

                graficar();

                

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

                fila["Intervalo"] = "[" + intervalo.limiteInferior + " ; " + intervalo.limiteSuperior + ")";
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
                if (double.TryParse(textoArchivo[i], out valor))
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

        private void graficar()
        {
            generarPaleta();

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
                //grafico.Series[FRECUENCIA_ESPERADA].Points.AddXY(media, intervalo.frecuenciaEsperada);
            }

            chart.AxisY.Maximum = maxValue * 1.1;
        }


        private void generarPaleta()
        {
            grafico.Palette = ChartColorPalette.Excel;
            grafico.Titles.Clear();
            grafico.Titles.Add("FRECUENCIAS OBSERVADAS");
            grafico.Series.Clear();

            Series serieFObservada = new Series();
            serieFObservada.Name = FRECUENCIA_OBSERVADA;
            grafico.Series.Add(serieFObservada);

            //Series serieFEsperada = new Series();
            //serieFEsperada.Name = FRECUENCIA_ESPERADA;
            //grafico.Series.Add(serieFEsperada);
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
        }
    }
}
