using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class frmPrincipal : Form
    {
        private double minimo;
        private double maximo;
        private int cantidad_numeros;
        private int cantidad_intervalos;

        private List<Distribucion> distribucionesContinuas = new List<Distribucion>();

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
            distribucionesContinuas.Add(new Distribucion { id = 3, descripcion = "Uniforme", tipoDistribucion = Distribucion.Tipo.continua, parametrosEstimados = 2 });

            cboDistribucion.DataSource = distribucionesContinuas;
            cboDistribucion.DisplayMember = "descripcion";
            cboDistribucion.ValueMember = "id";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
        }

        private void cboDistribucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((Distribucion)cboDistribucion.SelectedItem).id)
            {
                case 1:
                        distribucionElegida = TipoDistribucion.continuaExponencial;
                   
                    break;

                case 2:                    
                        distribucionElegida = TipoDistribucion.continuaNormal;
                    break;

                case 3:
                        distribucionElegida = TipoDistribucion.continuaUniforme;
                    break;
                default:
                    break;
            }
        }
    }
}
