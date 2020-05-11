﻿using System;
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
        }
    }
}
