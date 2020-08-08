﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.Clases;

namespace TP1
{
    public partial class Form1 : Form
    {
        List<string> numeros = new List<string>();
        Generador generador = new Generador();

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

            cargarGrilla();

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


            cargarGrilla();

            

        }

        private void cargarGrilla()
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

            grdResultado.DataSource = table;
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
    }
}
