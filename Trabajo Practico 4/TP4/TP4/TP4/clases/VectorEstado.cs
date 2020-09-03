using System;

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
        private Double contribucionDiaria;
        private int cantDiasConHasta2Frascos;
        private int cantDiasConMasDe2Hasta5Frascos;
        private int cantDiasConMasDe5Hasta8Frascos;
        private int cantDiasConMasDe8Frascos;
        private int cantDiasConFaltanteStock;

        // porcentaejes
        private Double porcentajeDiasConHasta2Frascos;
        private Double porcentajeDiasConMasDe2Hasta5Frascos;
        private Double porcentajeDiasConMasDe5Hasta8Frascos;
        private Double porcentajeDiasConMasDe8Frascos;
        private Double porcentajeDiasConFaltanteStock;
        private Double porcentajeDiasSinFaltanteStock;

        // promedios
        private Double stockFinalPromedio;
        private Double demandaNoAbastecidaPromedio;
        private Double ingresoDiarioPromedio;
        private Double contribucionDiariaPromedio;
        private Double horasPerdidasPromedio;

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
        public double ContribucionDiaria { get => contribucionDiaria; set => contribucionDiaria = value; }
        public double ContribucionDiariaPromedio { get => contribucionDiariaPromedio; set => contribucionDiariaPromedio = value; }
        public double NroRandomDemandaTurnoManana2 { get => nroRandomDemandaTurnoManana2; set => nroRandomDemandaTurnoManana2 = value; }
        public double NroRandomDemandaTurnoManana3 { get => nroRandomDemandaTurnoManana3; set => nroRandomDemandaTurnoManana3 = value; }
        public int CantDiasConHasta2Frascos { get => cantDiasConHasta2Frascos; set => cantDiasConHasta2Frascos = value; }
        public int CantDiasConMasDe2Hasta5Frascos { get => cantDiasConMasDe2Hasta5Frascos; set => cantDiasConMasDe2Hasta5Frascos = value; }
        public int CantDiasConMasDe5Hasta8Frascos { get => cantDiasConMasDe5Hasta8Frascos; set => cantDiasConMasDe5Hasta8Frascos = value; }
        public int CantDiasConMasDe8Frascos { get => cantDiasConMasDe8Frascos; set => cantDiasConMasDe8Frascos = value; }
        public double PorcentajeDiasConHasta2Frascos { get => porcentajeDiasConHasta2Frascos; set => porcentajeDiasConHasta2Frascos = value; }
        public double PorcentajeDiasConMasDe2Hasta5Frascos { get => porcentajeDiasConMasDe2Hasta5Frascos; set => porcentajeDiasConMasDe2Hasta5Frascos = value; }
        public double PorcentajeDiasConMasDe5Hasta8Frascos { get => porcentajeDiasConMasDe5Hasta8Frascos; set => porcentajeDiasConMasDe5Hasta8Frascos = value; }
        public double PorcentajeDiasConMasDe8Frascos { get => porcentajeDiasConMasDe8Frascos; set => porcentajeDiasConMasDe8Frascos = value; }
        public int CantDiasConFaltanteStock { get => cantDiasConFaltanteStock; set => cantDiasConFaltanteStock = value; }
        public double PorcentajeDiasConFaltanteStock { get => porcentajeDiasConFaltanteStock; set => porcentajeDiasConFaltanteStock = value; }
        public double PorcentajeDiasSinFaltanteStock { get => porcentajeDiasSinFaltanteStock; set => porcentajeDiasSinFaltanteStock = value; }
        public double HorasPerdidasPromedio { get => horasPerdidasPromedio; set => horasPerdidasPromedio = value; }
    }
}
