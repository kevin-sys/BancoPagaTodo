using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace BancoPagaTodo
{
    public partial class FrmConsultaConsignacion : Form
    {

        ConsignacionService service = new ConsignacionService();

        public FrmConsultaConsignacion()
        {
            InitializeComponent();
            LlenarTabla();
        }

        private void LlenarTabla()
        {
            DtgConsultaConsignacion.DataSource = null;
            DtgConsultaConsignacion.DataSource = ConsignacionService.ConsultarTodos();
        }


        private void FrmConsultaConsignacion_Load(object sender, EventArgs e)
        {

        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            if (CmbTipoServicio.Text.Equals("Todos"))
            {
                LlenarTabla();
                TxtTotalConsignaciones.Text = service.TotalizarTodos().ToString();
                TxtTotalElectricaribe.Text = service.TotalizarElectricaribe().ToString();
                TxtTotalEmdupar.Text = service.TotalizarEmdupar().ToString();
                TxtTotalGasCaribe.Text = service.TotalizarGasCaribe().ToString();
                TxtValorTotalConsignaciones.Text = service.ValorTotalconsignaciones().ToString();
                TxtValorTotalElectricaribe.Text = service.ValorTotalElectricaribe().ToString();
                TxtValorTotalEmdupar.Text = service.ValorTotalEmdupar().ToString();
                TxtValorTotalGasCaribe.Text = service.ValorTotalGasCaribe().ToString();


            }
        }
    }
}
