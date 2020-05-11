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
    public partial class FrmRegistroConsignacion : Form
    {
        Consignacion consignacion;
        public FrmRegistroConsignacion()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            ConsignacionService service = new ConsignacionService();
            Consignacion consignacion = MapearConsignacion();
            string mensaje = service.Guardar(consignacion);
            MessageBox.Show(mensaje, "MENSAJE DE GUARDADO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private Consignacion MapearConsignacion()
        {
            consignacion = new Consignacion();
            consignacion.EntidadServicios = CmbServiciosPublicos.Text;
            consignacion.NumeroRecibo = TxtNumeroRecibo.Text;
            consignacion.FechaPago = DtpFechaPago.Value.Date;
            consignacion.ValorPagado = double.Parse(TxtValorPagado.Text);
            return consignacion;
        }
    }
}
