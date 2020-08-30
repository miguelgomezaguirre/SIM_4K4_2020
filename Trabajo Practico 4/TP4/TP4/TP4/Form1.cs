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
        private Random random;

        private int cantFrascosCompra; // cantidad de frascos que se compran por vez
        private int cantMaximaFrascosEnStock; // cantidad maxima de frascos que puede haber en stock al final del dia
        private int frecuenciaDiasCompra; // frecuencia de compra de frascos en unidad de tiempo dias
        private int cantDiasSimular;
        private Double gramosPorFrasco; // cantidad de gramos que contiene un frasco
        private Double importeVentaGramo; 
        private Double importeCostoGramo;

        VectorEstado anterior;
        VectorEstado actual;


        public Form1()
        {
            InitializeComponent();
            random = new Random();

            // Valores dados por el enunciado
            cantFrascosCompra = 2; // se compran de a 2 frascos
            cantMaximaFrascosEnStock = 10; // hasta 10 frascos en stock al final del dia
            frecuenciaDiasCompra = 2; // se compran cada 2 dias
            cantDiasSimular = 100000;
            gramosPorFrasco = 170d;
            importeCostoGramo = 250d / gramosPorFrasco; // El costo del café es de 250 pesos por frasco
            importeVentaGramo = 150d / 100d; // se vende a 150 pesos cada 100 gramos
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcular() {

            // Configuro el dia 0
            actual = new VectorEstado();
            actual.NroDia = 0;
            actual.CorrespondeCompra = false;
            actual.StockFinal = (Double) cantFrascosCompra * gramosPorFrasco; // Suponemos comienza con stock de 2 latas de cafe

            for (int nroDiaSimulado = 1; nroDiaSimulado <= cantDiasSimular; nroDiaSimulado++) {
                simularDia(nroDiaSimulado);
            }

            txtStockFinalDia.Text = actual.StockFinal.ToString();
            txtStockFinalDiaPromedio.Text = actual.StockFinalPromedio.ToString();
            txtCantCafeFaltantePromedio.Text = actual.DemandaNoAbastecidaPromedio.ToString();
            txtIngresoPromedioDiario.Text = actual.IngresoDiarioPromedio.ToString();
        }

        private void simularDia(int nroDiaSimulado) {
            String tipoDemandaTurnoManana;
            //
            anterior = actual;
            actual = new VectorEstado();

            actual.NroDia = nroDiaSimulado;
            actual.StockInicial = anterior.StockFinal;

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
                actual.NroDiaLlegadaCompra = anterior.NroDiaLlegadaCompra;
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
            else
            {
                actual.VentaDiaria = actual.DemandaDiaria;
                actual.StockFinal = actual.StockInicial - actual.DemandaDiaria;
                actual.DemandaNoAbastecida = 0d;
                actual.DiaConFaltante = 0;
            }

            // Hay una capacidad máxima de almacenamiento de 10 frascos al final del día. Los
            // demás se tiran o regalan a los clientes.
            if (actual.StockFinal > (Double)cantMaximaFrascosEnStock * gramosPorFrasco)
            {
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

        private Double getNroRandom() { 
            // depende el generador elegido usa esto o el congruencial
            return random.NextDouble();
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
    }
}
