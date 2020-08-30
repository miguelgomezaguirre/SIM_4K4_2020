﻿using System;

namespace TP4.clases
{
    class VectorEstado
    {
        private int nroDia;
        private Boolean correspondeCompra; // cada 2 dias sera true
        private Double nroRandomLlegadaCompra; // aleatorio entre 0 y 1
        private Double nroRandomDemandaTurnoManana1;
        private Double nroRandomDemandaTurnoManana2;
        private Double nroRandomDemandaTurnoManana3;
        private Double nroRandomDemandaTurnoTarde;
        private Double demandaTurnoManana;
        private Double demandaTurnoTarde;
        private Double demandaDiaria; // suma de demanda del turno manana y tarde
        private Double ventaDiaria;
        private Double demandaNoAbastecida; // es lo que se perdio de vender por no contar con stock
        private int nroDiaLlegadaCompra; // nro de dia en que llegara una compra realizada
        private Double stockInicial; // lo que hay al principio del dia en gramos
        private Double stockFinal;
        private Double ingresoDiario;
        private int diaConFaltante; // 1: hubo faltante. 0: no hubo
        private Double contribucionDiaria;

        // promedios
        private Double stockFinalPromedio;
        private Double demandaNoAbastecidaPromedio;
        private Double ingresoDiarioPromedio;
        private Double diaConFaltantePromedio;
        private Double diaConStockFinalPromedio; // promedio de dias en los que hay stock final distinto de 0
        private Double contribucionDiariaPromedio;

        public VectorEstado()
        {
        }

        public int NroDia { get => nroDia; set => nroDia = value; }
        public bool CorrespondeCompra { get => correspondeCompra; set => correspondeCompra = value; }
        public double NroRandomLlegadaCompra { get => nroRandomLlegadaCompra; set => nroRandomLlegadaCompra = value; }
        public int NroDiaLlegadaCompra { get => nroDiaLlegadaCompra; set => nroDiaLlegadaCompra = value; }
        public double StockInicial { get => stockInicial; set => stockInicial = value; }
        public double StockFinal { get => stockFinal; set => stockFinal = value; }
        public double NroRandomDemandaTurnoManana1 { get => nroRandomDemandaTurnoManana1; set => nroRandomDemandaTurnoManana1 = value; }
        public double NroRandomDemandaTurnoTarde { get => nroRandomDemandaTurnoTarde; set => nroRandomDemandaTurnoTarde = value; }
        public double DemandaTurnoManana { get => demandaTurnoManana; set => demandaTurnoManana = value; }
        public double DemandaTurnoTarde { get => demandaTurnoTarde; set => demandaTurnoTarde = value; }
        public double DemandaDiaria { get => demandaDiaria; set => demandaDiaria = value; }
        public double VentaDiaria { get => ventaDiaria; set => ventaDiaria = value; }
        public double DemandaNoAbastecida { get => demandaNoAbastecida; set => demandaNoAbastecida = value; }
        public double StockFinalPromedio { get => stockFinalPromedio; set => stockFinalPromedio = value; }
        public double DemandaNoAbastecidaPromedio { get => demandaNoAbastecidaPromedio; set => demandaNoAbastecidaPromedio = value; }
        public double IngresoDiario { get => ingresoDiario; set => ingresoDiario = value; }
        public double IngresoDiarioPromedio { get => ingresoDiarioPromedio; set => ingresoDiarioPromedio = value; }
        public int DiaConFaltante { get => diaConFaltante; set => diaConFaltante = value; }
        public double DiaConFaltantePromedio { get => diaConFaltantePromedio; set => diaConFaltantePromedio = value; }
        public double DiaConStockFinalPromedio { get => diaConStockFinalPromedio; set => diaConStockFinalPromedio = value; }
        public double ContribucionDiaria { get => contribucionDiaria; set => contribucionDiaria = value; }
        public double ContribucionDiariaPromedio { get => contribucionDiariaPromedio; set => contribucionDiariaPromedio = value; }
        public double NroRandomDemandaTurnoManana2 { get => nroRandomDemandaTurnoManana2; set => nroRandomDemandaTurnoManana2 = value; }
        public double NroRandomDemandaTurnoManana3 { get => nroRandomDemandaTurnoManana3; set => nroRandomDemandaTurnoManana3 = value; }
    }
}
