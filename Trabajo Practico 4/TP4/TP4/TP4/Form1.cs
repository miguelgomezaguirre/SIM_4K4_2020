using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private int cantFrascosCompra = 2;
        private int cantMaximaFrascosEnStock = 10;
        private int frecuenciaDiasCompra = 2;
        private double gramosPorFrasco = 170;
        int cantDiasSimular = 1000;
        private Random random;
        private Double importeVentaGramo = 150d / 100d; // vende a 150 pesos cada 100 gramos
        private Double importeCostoGramo = 250d / gramosPorFrasco; // El costo del café es de 250 pesos por frasco


        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcular() {

            VectorEstado anterior = new VectorEstado();
            VectorEstado actual = new VectorEstado();

            // Configuro el dia 0
            actual.NroDia = 0;
            actual.CorrespondeCompra = false;
            // Suponemos comienza con stock de 2 latas de cafe
            actual.StockFinal = (Double) (cantFrascosCompra * gramosPorFrasco);

            for (int nroDiaSimulado = 1; nroDiaSimulado <= cantDiasSimular; nroDiaSimulado++) {
                anterior = actual; 
                actual = new VectorEstado();

                actual.NroDia = nroDiaSimulado;

                actual.StockInicial = anterior.StockFinal;
                // Controlo si hoy llega una compra
                if (nroDiaSimulado == anterior.NroDiaLlegadaCompra) {
                    actual.StockInicial += (Double) (cantFrascosCompra * gramosPorFrasco);
                }
                actual.NroDiaLlegadaCompra = anterior.NroDiaLlegadaCompra;

                if (hoyCorrespondeComprar(nroDiaSimulado)) {
                    actual.CorrespondeCompra = true;
                    actual.NroRandomLlegadaCompra = getNroRandom();
                    actual.NroDiaLlegadaCompra = actual.NroDia + getCantDiasParaLlegadaCompra(actual.NroRandomLlegadaCompra);
                    // Puede pasar que hoy llegue una compra anterior y ademas se hace otra compra que llega  inmediatamente
                    if (nroDiaSimulado == actual.NroDiaLlegadaCompra)
                    {
                        actual.StockInicial += (Double) (cantFrascosCompra * gramosPorFrasco);
                    }
                    actual.NroDiaLlegadaCompra = anterior.NroDiaLlegadaCompra;
                }

                // Calculo de la demanda del dia
                actual.NroRandomDemandaTurnoManana = getNroRandom();
                actual.DemandaTurnoManana = getDemandaTurnoManana(actual.NroRandomDemandaTurnoManana);
                actual.NroRandomDemandaTurnoTarde = getNroRandom();
                actual.DemandaTurnoTarde = getDemandaTurnoTarde(actual.NroRandomDemandaTurnoTarde);
                actual.DemandaDiaria = actual.DemandaTurnoManana + actual.DemandaTurnoTarde;

                // Venta diaria
                // Caso se demanda mas de lo que hay en stock => demanda total insatisfecha
                if (actual.DemandaDiaria > actual.StockInicial)
                {
                    actual.VentaDiaria = actual.StockInicial;
                    actual.StockFinal = 0d;
                    actual.DemandaNoAbastecida = actual.DemandaDiaria - actual.StockInicial;
                    actual.DiaConFaltante = 1;
                }
                // Caso se demanda menos de lo que hay en stock => demanda total satisfecha
                else {
                    actual.VentaDiaria = actual.DemandaDiaria;
                    actual.StockFinal = actual.StockInicial - actual.DemandaDiaria;
                    actual.DemandaNoAbastecida = 0d;
                    actual.DiaConFaltante = 0;
                }

                // Hay una capacidad máxima de almacenamiento de 10 frascos al final del día. Los
                // demás se tiran o regalan a los clientes.
                if (actual.StockFinal > (Double)cantMaximaFrascosEnStock * gramosPorFrasco) {
                    actual.StockFinal = (Double)cantMaximaFrascosEnStock * gramosPorFrasco;
                }

                // Ingreso diario
                actual.IngresoDiario = actual.VentaDiaria * importeVentaGramo;
                actual.ContribucionDiaria = actual.IngresoDiario - (actual.VentaDiaria * importeCostoGramo);

                // Stock final promedio diario (punto 2)
                actual.StockFinalPromedio = ((anterior.StockFinalPromedio * anterior.NroDia) + actual.StockFinal) / actual.NroDia;
                // Demanda faltante promedio diaria (punto 3)
                actual.DemandaNoAbastecidaPromedio = ((anterior.DemandaNoAbastecidaPromedio * anterior.NroDia) + actual.DemandaNoAbastecida) / actual.NroDia;
                // ingreso promedio diario (punto 4)
                actual.IngresoDiarioPromedio = ((anterior.IngresoDiarioPromedio * anterior.NroDia) + actual.IngresoDiario) / actual.NroDia;
                // contribución promedio diaria (punto 5)
                actual.ContribucionDiariaPromedio = ((anterior.ContribucionDiariaPromedio * anterior.NroDia) + actual.ContribucionDiaria) / actual.NroDia;
                // Porcentaje de días en los que hubo faltante (punto 6)
                actual.DiaConFaltantePromedio = ((anterior.DiaConFaltantePromedio * anterior.NroDia) + actual.DiaConFaltante) / actual.NroDia;
                // Porcentaje de dias que terminal con stock final != 0 (punto 9)
                actual.DiaConStockFinalPromedio = ((anterior.DiaConStockFinalPromedio * anterior.NroDia) + (actual.StockFinal > 0 ? 1 : 0)) / actual.NroDia;
            }
        }

        private Double getNroRandom() { 
            return random.NextDouble();
        }

        private int getCantDiasParaLlegadaCompra(double nroRandom) {
            return 1;
        }

        private Boolean hoyCorrespondeComprar(int nroDiaSimulado) {
            if (nroDiaSimulado % frecuenciaDiasCompra == 0) {
                return true;
            }
            return false;
        }

        private Double getDemandaTurnoManana(double nroRandom) {
            return 50;
        }

        private Double getDemandaTurnoTarde(double nroRandom)
        {
            return 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcular();
        }
    }
}
