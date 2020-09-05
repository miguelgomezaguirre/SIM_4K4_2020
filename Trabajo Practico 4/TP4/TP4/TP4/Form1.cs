using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4.clases;

namespace TP4
{
    public partial class Form1 : Form
    {
        private Random random;

        private int cantFrascosCompra; // cantidad de frascos que se compran por vez
        private int cantMaximaFrascosEnStock; // cantidad maxima de frascos que puede haber en stock al final del dia
        private int frecuenciaDiasCompra; // frecuencia de compra de frascos en unidad de tiempo dias
        private int cantDiasSimular;
        private Double cantHorasTurnoManana;
        private Double cantHorasTurnoTarde;
        private Double gramosPorFrasco; // cantidad de gramos que contiene un frasco
        private Double importeVentaGramo; 
        private Double importeCostoGramo;
        private String metodoGeneradorNrosAleatorios;
        private Double congruencial_A;
        private Double congruencial_C;
        private Double congruencial_M;
        private Double congruencialSemilla;
        private Double? congruencialUltimaSemilla;


        VectorEstado anterior;
        VectorEstado actual;


        public Form1()
        {
            InitializeComponent();
            random = new Random();

            
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcular() {            

            getValores();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = cantDiasSimular;

            grdSimulacion.DataSource = null;

            congruencialUltimaSemilla = null;

            List<VectorEstado> diasSimulados = new List<VectorEstado>();

            tabPrincipal.SelectedTab = tabResultado;

            // Configuro el dia 0
            actual = new VectorEstado();
            actual.NroDia = 0;
            actual.CorrespondeCompra = false;
            actual.StockFinal = (Double) cantFrascosCompra * gramosPorFrasco; // Suponemos comienza con stock de 2 latas de cafe

            diasSimulados.Add(actual);

            for (int nroDiaSimulado = 1; nroDiaSimulado <= cantDiasSimular; nroDiaSimulado++) {
                
                simularDia(nroDiaSimulado);

                if(!chkMostrarSolo10.Checked)
                {
                    if (nroDiaSimulado % 10000 == 0 || (chk50DiasAPartirDe.Checked && nroDiaSimulado >= int.Parse(txt50DiasAPartirDe.Text) && nroDiaSimulado < (int.Parse(txt50DiasAPartirDe.Text) + 50)))
                    {
                        diasSimulados.Add(actual);

                        lblSimulacionesGeneradas.Text = "Simulaciones Generadas: " + nroDiaSimulado.ToString() + "/" + cantDiasSimular;

                        progressBar1.Value = nroDiaSimulado;

                        Application.DoEvents();
                    }
                }
                else
                {
                    diasSimulados.Add(actual);

                    lblSimulacionesGeneradas.Text = "Simulaciones Generadas: " + nroDiaSimulado.ToString() + "/" + cantDiasSimular;

                    progressBar1.Value = nroDiaSimulado;

                    Application.DoEvents();
                }
                
                
            }


            cargarEnTabla(diasSimulados);

            cargarResumen(actual);

            grdSimulacion.FirstDisplayedScrollingRowIndex = grdSimulacion.RowCount - 1;

        }

        private void cargarResumen(VectorEstado actual)
        {
            string formatoDecimal = "0.0000";

            lblContribucionPromedio.Text = "$ " + actual.ContribucionDiariaPromedio.ToString(formatoDecimal);
            lblDemandaNoAbastecidaPromedio.Text = actual.DemandaNoAbastecidaPromedio.ToString(formatoDecimal) + " g";
            lblIngresioDiarioPromedio.Text = "$ " + actual.IngresoDiarioPromedio.ToString(formatoDecimal);
            lblPorcentajeConFaltanteDeStock.Text = actual.PorcentajeDiasConFaltanteStock.ToString(formatoDecimal) + " días";
            lblPorcentajeSinFaltanteDeStock.Text = actual.PorcentajeDiasSinFaltanteStock.ToString(formatoDecimal) + " días";
            lblPromedioHorasPerdidas.Text = actual.HorasPerdidasPromedio.ToString(formatoDecimal) + " Hs";
            lblPorcentaje2Frascos.Text = (actual.PorcentajeDiasConHasta2Frascos * 100).ToString(formatoDecimal) + " %";
            lblPorcentaje2y5Frascos.Text = (actual.PorcentajeDiasConMasDe2Hasta5Frascos * 100).ToString(formatoDecimal) + " %";
            lblPorcentaje5y8Frascos.Text = (actual.PorcentajeDiasConMasDe5Hasta8Frascos * 100).ToString(formatoDecimal) + " %";
            lblPorcentajeMasDe8Frascos.Text = (actual.PorcentajeDiasConMasDe8Frascos * 100).ToString(formatoDecimal) + " %";
        }

        private void cargarEnTabla(List<VectorEstado> listDiasSimulados)
        {
            DataTable tabla = new DataTable();

            tabla.Columns.Add("Dia Simulado");
            tabla.Columns.Add("Dia de Compra");
            tabla.Columns.Add("Random Demora");
            tabla.Columns.Add("Demora de Pedido");
            tabla.Columns.Add("Stock Inicial");
            tabla.Columns.Add("Demanda Diaria");
            tabla.Columns.Add("Stock Final");
            tabla.Columns.Add("Stock Final Promedio");
            tabla.Columns.Add("Random Venta TM");
            tabla.Columns.Add("Random Venta TM X1 (Normal)");
            tabla.Columns.Add("Random Venta TM X2 (Normal)");
            tabla.Columns.Add("Demanda TM");
            tabla.Columns.Add("Random Venta TT");
            tabla.Columns.Add("Demanda TT");
            tabla.Columns.Add("Demanda No Abastecida");
            tabla.Columns.Add("Demanda No Abastecida Promedio");
            tabla.Columns.Add("Ingreso Diario");
            tabla.Columns.Add("Ingreso Promedio Diario");
            tabla.Columns.Add("Contribucion Diaria");
            tabla.Columns.Add("Contribucion Promedio Diaria");

            DataRow fila = null;

            string formatoDecimal = "0.0000";

            foreach (var diaSimulado in listDiasSimulados)
            {
                fila = tabla.NewRow();

                fila["Dia Simulado"] = diaSimulado.NroDia;
                fila["Dia de Compra"] = hoyCorrespondeComprar(diaSimulado.NroDia) ? "Si" : "No";
                fila["Random Demora"] = diaSimulado.NroRandomLlegadaCompra.ToString(formatoDecimal);
                fila["Demora de Pedido"] = diaSimulado.NroDiaLlegadaCompra - diaSimulado.NroDia < 0 ? 0 : diaSimulado.NroDiaLlegadaCompra - diaSimulado.NroDia;
                fila["Stock Inicial"] = diaSimulado.StockInicial.ToString(formatoDecimal);
                fila["Demanda Diaria"] = diaSimulado.DemandaDiaria.ToString(formatoDecimal);
                fila["Stock Final"] = diaSimulado.StockFinal.ToString(formatoDecimal);
                fila["Stock Final Promedio"] = diaSimulado.StockFinalPromedio.ToString(formatoDecimal);
                fila["Random Venta TM"] = diaSimulado.NroRandomDemandaTurnoManana1.ToString(formatoDecimal);
                fila["Random Venta TM X1 (Normal)"] = diaSimulado.NroRandomDemandaTurnoManana2.ToString(formatoDecimal);
                fila["Random Venta TM X2 (Normal)"] = diaSimulado.NroRandomDemandaTurnoManana3.ToString(formatoDecimal);
                fila["Demanda TM"] = diaSimulado.DemandaTurnoManana.ToString(formatoDecimal);
                fila["Random Venta TT"] = diaSimulado.NroRandomDemandaTurnoTarde.ToString(formatoDecimal);
                fila["Demanda TT"] = diaSimulado.DemandaTurnoTarde.ToString(formatoDecimal);
                fila["Demanda No Abastecida"] = diaSimulado.DemandaNoAbastecida.ToString(formatoDecimal);
                fila["Demanda No Abastecida Promedio"] = diaSimulado.DemandaNoAbastecidaPromedio.ToString(formatoDecimal);
                fila["Ingreso Diario"] = diaSimulado.IngresoDiario.ToString(formatoDecimal);
                fila["Ingreso Promedio Diario"] = diaSimulado.IngresoDiarioPromedio.ToString(formatoDecimal);
                fila["Contribucion Diaria"] = diaSimulado.ContribucionDiaria.ToString(formatoDecimal);
                fila["Contribucion Promedio Diaria"] = diaSimulado.ContribucionDiariaPromedio.ToString(formatoDecimal);
                

                tabla.Rows.Add(fila);
            }

            grdSimulacion.DataSource = tabla;
        }

        private void getValores()
        {
            cantFrascosCompra = int.Parse(txtFrascosPorCompra.Text); // se compran de a 2 frascos
            cantMaximaFrascosEnStock = int.Parse(txtStockMaximo.Text); // hasta 10 frascos en stock al final del dia
            frecuenciaDiasCompra = int.Parse(txtFrecuenciaCompra.Text); // se compran cada 2 dias

            if(!string.IsNullOrEmpty(txtDiasASimular.Text))
                cantDiasSimular = int.Parse(txtDiasASimular.Text);

            gramosPorFrasco = double.Parse(txtGramosPorFrasco.Text);
            importeCostoGramo = double.Parse(txtPrecioFrasco.Text) / gramosPorFrasco; // El costo del café es de 250 pesos por frasco
            importeVentaGramo = double.Parse(txtPrecioVenta.Text) / 100d; // se vende a 150 pesos cada 100 gramos
            cantHorasTurnoManana = int.Parse(txtHorasTM.Text);
            cantHorasTurnoTarde = int.Parse(txtHorasTT.Text);
            //

            if(chkCongruencial.Checked)
            {
                congruencial_A = double.Parse(txtA.Text);
                congruencial_C = double.Parse(txtC.Text);
                congruencial_M = double.Parse(txtM.Text);
                congruencialSemilla = double.Parse(txtSemilla.Text);

                if(chkMostrarSolo10.Checked)
                {
                    cantDiasSimular = 10;
                }
            }
            
        }

        private void simularDia(int nroDiaSimulado) {
            String tipoDemandaTurnoManana;
            //
            anterior = actual;
            actual = new VectorEstado();

            actual.NroDia = nroDiaSimulado;
            //
            actual.StockInicial = anterior.StockFinal;
            //
            actual.CantDiasConHasta2Frascos = anterior.CantDiasConHasta2Frascos;
            actual.CantDiasConMasDe2Hasta5Frascos = anterior.CantDiasConMasDe2Hasta5Frascos;
            actual.CantDiasConMasDe5Hasta8Frascos = anterior.CantDiasConMasDe5Hasta8Frascos;
            actual.CantDiasConMasDe8Frascos = anterior.CantDiasConMasDe8Frascos;
            //
            actual.CantDiasConFaltanteStock = anterior.CantDiasConFaltanteStock;

            // Controlo si hoy llega una compra
            if (nroDiaSimulado == anterior.NroDiaLlegadaCompra)
            {
                actual.StockInicial += (Double)cantFrascosCompra * gramosPorFrasco;
            }
            actual.NroDiaLlegadaCompra = anterior.NroDiaLlegadaCompra;

            if (hoyCorrespondeComprar(nroDiaSimulado))
            {
                actual.CorrespondeCompra = true;
                actual.NroRandomLlegadaCompra = getNroRandom();
                actual.NroDiaLlegadaCompra = actual.NroDia + getCantDiasParaLlegadaCompra(actual.NroRandomLlegadaCompra);
                // Puede pasar que hoy llegue una compra anterior y ademas se hace otra compra que llega  inmediatamente
                if (nroDiaSimulado == actual.NroDiaLlegadaCompra)
                {
                    actual.StockInicial += (Double)cantFrascosCompra * gramosPorFrasco;
                }
                //actual.NroDiaLlegadaCompra = anterior.NroDiaLlegadaCompra;
            }

            // Calculo de la demanda del dia
            // Turno Mañana
            actual.NroRandomDemandaTurnoManana1 = getNroRandom();
            tipoDemandaTurnoManana = getTipoDemandaTurnoManana(actual.NroRandomDemandaTurnoManana1);
            if (tipoDemandaTurnoManana.Equals("FIJA"))
            {
                actual.DemandaTurnoManana = getDemandaTurnoMananaFija();
            }
            else if (tipoDemandaTurnoManana.Equals("DISTRIBUCION_NORMAL"))
            {
                actual.NroRandomDemandaTurnoManana2 = getNroRandom();
                actual.NroRandomDemandaTurnoManana3 = getNroRandom();
                actual.DemandaTurnoManana = getDemandaTurnoMananaDistriNormal(actual.NroRandomDemandaTurnoManana2, actual.NroRandomDemandaTurnoManana3);
            }
            // Turno Tarde
            actual.NroRandomDemandaTurnoTarde = getNroRandom();
            actual.DemandaTurnoTarde = getDemandaTurnoTarde(actual.NroRandomDemandaTurnoTarde);
            // Demanda Diaria 
            actual.DemandaDiaria = actual.DemandaTurnoManana + actual.DemandaTurnoTarde;

            // Venta diaria
            // Caso se demanda mas de lo que hay en stock => demanda total insatisfecha
            if (actual.DemandaDiaria > actual.StockInicial)
            {
                actual.VentaDiaria = actual.StockInicial;
                actual.StockFinal = 0d;
                actual.DemandaNoAbastecida = actual.DemandaDiaria - actual.StockInicial;
                actual.CantDiasConFaltanteStock++;
            }
            // Caso se demanda menos de lo que hay en stock => demanda total satisfecha
            else
            {
                actual.VentaDiaria = actual.DemandaDiaria;
                actual.StockFinal = actual.StockInicial - actual.DemandaDiaria;
                actual.DemandaNoAbastecida = 0d;
            }

            // Hay una capacidad máxima de almacenamiento de 10 frascos al final del día. Los
            // demás se tiran o regalan a los clientes.
            if (actual.StockFinal > (Double)cantMaximaFrascosEnStock * gramosPorFrasco)
            {
                actual.StockFinal = (Double)cantMaximaFrascosEnStock * gramosPorFrasco;
            }

            // Punto 4
            // Ingreso diario
            actual.IngresoDiario = actual.VentaDiaria * importeVentaGramo;
            actual.ContribucionDiaria = actual.IngresoDiario - (actual.VentaDiaria * importeCostoGramo);

            // Punto 7
            // Cantidad de dias con x cantidad de frascos en stock. Como el enunciador no aclaraba 
            // consideramos el stock al final del dia. Luego los porcentajes se calcularian diviendo
            // la cantidad de las variables acumuladoras sobre la cantidad de dias simulados.
            if (actual.StockFinal / gramosPorFrasco <= 2d)
            {
                actual.CantDiasConHasta2Frascos++;
            }
            else if (2d < actual.StockFinal / gramosPorFrasco && actual.StockFinal / gramosPorFrasco <= 5d)
            {
                actual.CantDiasConMasDe2Hasta5Frascos++;
            }
            else if (5d < actual.StockFinal / gramosPorFrasco && actual.StockFinal / gramosPorFrasco <= 8d)
            {
                actual.CantDiasConMasDe5Hasta8Frascos++;
            }
            else if (8d < actual.StockFinal / gramosPorFrasco) {
                actual.CantDiasConMasDe8Frascos++;
            }
            actual.PorcentajeDiasConHasta2Frascos = (Double) actual.CantDiasConHasta2Frascos / (Double) actual.NroDia;
            actual.PorcentajeDiasConMasDe2Hasta5Frascos = (Double) actual.CantDiasConMasDe2Hasta5Frascos / (Double) actual.NroDia;
            actual.PorcentajeDiasConMasDe5Hasta8Frascos = (Double) actual.CantDiasConMasDe5Hasta8Frascos / (Double) actual.NroDia;
            actual.PorcentajeDiasConMasDe8Frascos = (Double) actual.CantDiasConMasDe8Frascos / (Double) actual.NroDia;
            // Punto 6
            actual.PorcentajeDiasConFaltanteStock = (Double) actual.CantDiasConFaltanteStock / (Double) actual.NroDia;
            // Punto 9. Porcentaje de dias que terminal con stock final != 0 
            actual.PorcentajeDiasSinFaltanteStock = (Double)(actual.NroDia - actual.CantDiasConFaltanteStock) / (Double)actual.NroDia;

            // Punto 2. Stock final promedio diario
            actual.StockFinalPromedio = ((anterior.StockFinalPromedio * anterior.NroDia) + actual.StockFinal) / actual.NroDia;
            // Punto 3. Demanda faltante promedio diaria
            actual.DemandaNoAbastecidaPromedio = ((anterior.DemandaNoAbastecidaPromedio * anterior.NroDia) + actual.DemandaNoAbastecida) / actual.NroDia;
            // Punto 4. Ingreso promedio diario
            actual.IngresoDiarioPromedio = ((anterior.IngresoDiarioPromedio * anterior.NroDia) + actual.IngresoDiario) / actual.NroDia;
            // Punto 5. contribución promedio diaria.
            actual.ContribucionDiariaPromedio = ((anterior.ContribucionDiariaPromedio * anterior.NroDia) + actual.ContribucionDiaria) / actual.NroDia;
            // Punto 8. Promedio de cuantas horas se perdieron si se considera que cada turno es de 8 horas y el porcentaje 
            // de café faltante es la proporción al a las horas perdidas del cibercafé.
            actual.HorasPerdidasPromedio = 
                (
                  (anterior.HorasPerdidasPromedio * (Double) anterior.NroDia) +
                  ((actual.DemandaDiaria != 0d ? actual.DemandaNoAbastecida/actual.DemandaDiaria : 0d) * (cantHorasTurnoManana + cantHorasTurnoTarde))) / actual.NroDia;

        }

        private Double getNroRandom() {
            // depende el generador elegido usa esto o el congruencial
            return metodoGeneradorNrosAleatorios.Equals("LENGUAJE") ? random.NextDouble() : getNroRandomCongruencial();
        }

        private Double getNroRandomCongruencial() {
            //if (Double.IsNaN(congruencialUltimaSemilla))
            if(congruencialUltimaSemilla == null)
            {
                congruencialUltimaSemilla = congruencialSemilla;
            }
            congruencialUltimaSemilla = (congruencial_A * congruencialUltimaSemilla + congruencial_C) % congruencial_M;
            return congruencialUltimaSemilla.Value / (congruencial_M);
        }

        private int getCantDiasParaLlegadaCompra(double nroRandom) {
            // Los frascos se compran on-line al inicio del día que se corresponde comprar e incluyen
            // la entrega que es inmediata la mitad de las veces o puede entregarse al día siguiente o
            // a los 2 días con igual probabilidad.
            if (0d <= nroRandom && nroRandom < 0.5d)
            {
                return 0;
            }
            else if (0.5d <= nroRandom && nroRandom < 0.75d)
            {
                return 1;
            }
            else {
                return 2;
            }
        }

        private Boolean hoyCorrespondeComprar(int nroDiaSimulado) {
            if (nroDiaSimulado % frecuenciaDiasCompra == 0) {
                return true;
            }
            return false;
        }

        private String getTipoDemandaTurnoManana(double nroRandom) {
            // a la mañana donde el 50% de las veces se consumen 50 gramos y los restantes la demanda es 
            // con distribución normal con media 75 gramos y desviación 15 gramos.
            if (0d <= nroRandom && nroRandom < 0.5d)
            {
                return "FIJA";
            }
            else {
                return "DISTRIBUCION_NORMAL";
            }
        }

        private Double getDemandaTurnoMananaFija() {
            return 50d;
        }

        private Double getDemandaTurnoMananaDistriNormal(double nroRandom1, double nroRandom2) {
            Double media = 75d;
            Double desviacion = 15d;

            // ESTARIA PERDIENDO SIEMPRE UN NUMERO Y ESO NO PUEDE AFECTAR QUE LUEGO NO TERMINE PARECIENDO 
            // UNA DISTRIBUCION NORMAL ?????

            double z1 = Math.Sqrt(-2 * Math.Log(nroRandom1)) * (Math.Sin(2 * Math.PI * nroRandom2));
            //double z2 = Math.Sqrt(-2 * Math.Log(nroRandom1)) * (Math.Cos(2 * Math.PI * nroRandom2));

            return media + desviacion * (z1);
        }


        private Double getDemandaTurnoTarde(double nroRandom)
        {
            // en el turno tarde el consumo es exponencial en gramos con una media de 70 para el consumo 
            // de ese turno.
            Double media = 70d;
            return (-1) * media * Math.Log(1 - nroRandom);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcular();
        }

        private void chkCongruencial_CheckedChanged(object sender, EventArgs e)
        {
            metodoGeneradorNrosAleatorios = "CONGRUENCIAL";
        }

        private void btnValoresPorDefecto_Click(object sender, EventArgs e)
        {
            //// Valores dados por el enunciado
            //cantFrascosCompra = 2; // se compran de a 2 frascos
            //cantMaximaFrascosEnStock = 10; // hasta 10 frascos en stock al final del dia
            //frecuenciaDiasCompra = 2; // se compran cada 2 dias
            //cantDiasSimular = 100000;
            //gramosPorFrasco = 170d;
            //importeCostoGramo = 250d / gramosPorFrasco; // El costo del café es de 250 pesos por frasco
            //importeVentaGramo = 150d / 100d; // se vende a 150 pesos cada 100 gramos
            //cantHorasTurnoManana = 8;
            //cantHorasTurnoTarde = 8;
            ////
            //metodoGeneradorNrosAleatorios = "LENGUAJE";
            //congruencial_A = 13d;
            //congruencial_C = 43d;
            //congruencial_M = 101d;
            //congruencialSemilla = 37d;
            //congruencialUltimaSemilla = null;

            txtFrascosPorCompra.Text = "2";
            txtStockMaximo.Text = "10";
            txtFrecuenciaCompra.Text = "2";
            txtDiasASimular.Text = "100000";
            txtGramosPorFrasco.Text = "170";
            txtPrecioFrasco.Text = "250";
            txtPrecioVenta.Text = "150";
            txtHorasTM.Text = "8";
            txtHorasTT.Text = "8";

            if(chkCongruencial.Checked)
            {
                metodoGeneradorNrosAleatorios = "CONGRUENCIAL";
                txtA.Text = "13";
                txtM.Text = "101";
                txtSemilla.Text = "37";
                txtC.Text = "43";
            }
            else
            {
                metodoGeneradorNrosAleatorios = "LENGUAJE";
            }
        }

        private void chk50DiasAPartirDe_CheckedChanged(object sender, EventArgs e)
        {
            if(chk50DiasAPartirDe.Checked)
            {
                txt50DiasAPartirDe.Enabled = true;
            }
            else
            {
                txt50DiasAPartirDe.Enabled = false;
            }
        }

        private void chkMostrarSolo10_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMostrarSolo10.Checked)
            {
                txtDiasASimular.Text = "";
                txtDiasASimular.Enabled = false;
            }
            else
            {
                txtDiasASimular.Enabled = true;
            }
        }
    }
}
