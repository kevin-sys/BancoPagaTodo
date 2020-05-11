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
            if (CmbTipoServicio.Text.Equals("Emdupar"))
            {
                DtgConsultaConsignacion.DataSource = null;
                DtgConsultaConsignacion.DataSource = ConsignacionService.ListarEmdupar().ToList();
                TxtTotalEmdupar.Text = service.TotalizarEmdupar().ToString();
                TxtValorTotalEmdupar.Text = service.ValorTotalEmdupar().ToString();
                TxtTotalConsignaciones.Text = "";
                TxtTotalElectricaribe.Text = "";
                TxtTotalGasCaribe.Text = "";
                TxtValorTotalConsignaciones.Text = "";
                TxtValorTotalElectricaribe.Text = "";
                TxtValorTotalGasCaribe.Text = "";
            }
            if (CmbTipoServicio.Text.Equals("GasCaribe"))
            {
                DtgConsultaConsignacion.DataSource = null;

                DtgConsultaConsignacion.DataSource = ConsignacionService.ListarGasCaribe().ToList();

                TxtTotalConsignaciones.Text = "";
                TxtTotalElectricaribe.Text = "";
                TxtTotalEmdupar.Text = "";
                TxtTotalGasCaribe.Text = service.TotalizarGasCaribe().ToString();
                TxtValorTotalConsignaciones.Text = "";
                TxtValorTotalElectricaribe.Text = "";
                TxtValorTotalEmdupar.Text = "";
                TxtValorTotalGasCaribe.Text = service.ValorTotalGasCaribe().ToString();
            }
            if (CmbTipoServicio.Text.Equals("Electricaribe"))
            {
                DtgConsultaConsignacion.DataSource = null;
                DtgConsultaConsignacion.DataSource = ConsignacionService.ListarElectricaribe().ToList();

                TxtTotalConsignaciones.Text = "";
                TxtTotalElectricaribe.Text = service.TotalizarElectricaribe().ToString();
                TxtTotalEmdupar.Text = "";
                TxtTotalGasCaribe.Text = "";
                TxtValorTotalConsignaciones.Text = "";
                TxtValorTotalElectricaribe.Text = service.ValorTotalElectricaribe().ToString();
                TxtValorTotalEmdupar.Text = "";
                TxtValorTotalGasCaribe.Text = "";
            }
            if (CmbTipoServicio.Text.Equals("TodosFecha"))
            {
                DtgConsultaConsignacion.DataSource = null;
                DateTime fecha = DtpFechaFiltro.Value.Date;
                DtgConsultaConsignacion.DataSource = service.ConsultarTodosFecha(fecha);
                TxtValorTotalConsignaciones.Text = service.ConsultarTodosFecha(fecha).Sum(c => c.ValorPagado).ToString();
                TxtTotalConsignaciones.Text = service.ConsultarTodosFecha(fecha).Count().ToString();
            }
            if (CmbTipoServicio.Text.Equals("GasCaribeFecha"))
            {
                DtgConsultaConsignacion.DataSource = null;
                DateTime fecha = DtpFechaFiltro.Value.Date;
                DtgConsultaConsignacion.DataSource = service.ConsultarGasCaribeFecha(fecha);
                TxtValorTotalGasCaribe.Text = service.ConsultarGasCaribeFecha(fecha).Sum(c => c.ValorPagado).ToString();
                TxtTotalGasCaribe.Text = service.ConsultarGasCaribeFecha(fecha).Count().ToString();
                TxtValorTotalConsignaciones.Text = "";
                TxtValorTotalElectricaribe.Text = "";
                TxtValorTotalEmdupar.Text = "";
                TxtTotalConsignaciones.Text = "";
                TxtTotalElectricaribe.Text = "";
                TxtTotalEmdupar.Text = "";

            }

            if (CmbTipoServicio.Text.Equals("EmduparFecha"))
            {
                DtgConsultaConsignacion.DataSource = null;
                DateTime fecha = DtpFechaFiltro.Value.Date;
                DtgConsultaConsignacion.DataSource = service.ConsultarEmdupar(fecha);
                TxtValorTotalEmdupar.Text = service.ConsultarEmdupar(fecha).Sum(c => c.ValorPagado).ToString();
                TxtTotalEmdupar.Text = service.ConsultarEmdupar(fecha).Count().ToString();
                TxtTotalConsignaciones.Text = "";
                TxtTotalElectricaribe.Text = "";
                TxtTotalGasCaribe.Text = "";
                TxtValorTotalConsignaciones.Text = "";
                TxtValorTotalElectricaribe.Text = "";
                TxtValorTotalGasCaribe.Text = "";
            }
            if (CmbTipoServicio.Text.Equals("ElectricaribeFecha"))
            {
                DtgConsultaConsignacion.DataSource = null;
                DateTime fecha = DtpFechaFiltro.Value.Date;
                DtgConsultaConsignacion.DataSource = service.ConsultarElectricaribeFecha(fecha);
                TxtValorTotalElectricaribe.Text = service.ConsultarElectricaribeFecha(fecha).Sum(c => c.ValorPagado).ToString();
                TxtTotalElectricaribe.Text = service.ConsultarElectricaribeFecha(fecha).Count().ToString();
                TxtTotalGasCaribe.Text = "";
                TxtValorTotalConsignaciones.Text = "";
                TxtValorTotalEmdupar.Text = "";
                TxtValorTotalGasCaribe.Text = "";
                TxtTotalConsignaciones.Text = "";
                TxtTotalEmdupar.Text = "";
            }

        }
    }
}
