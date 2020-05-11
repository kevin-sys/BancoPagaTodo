namespace BancoPagaTodo
{
    partial class FrmConsultaConsignacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DtgConsultaConsignacion = new System.Windows.Forms.DataGridView();
            this.BtnValidar = new System.Windows.Forms.Button();
            this.CmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.TxtTotalConsignaciones = new System.Windows.Forms.TextBox();
            this.TxtTotalGasCaribe = new System.Windows.Forms.TextBox();
            this.TxtTotalElectricaribe = new System.Windows.Forms.TextBox();
            this.TxtTotalEmdupar = new System.Windows.Forms.TextBox();
            this.TxtValorTotalEmdupar = new System.Windows.Forms.TextBox();
            this.TxtValorTotalGasCaribe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtValorTotalElectricaribe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtValorTotalConsignaciones = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsultaConsignacion)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgConsultaConsignacion
            // 
            this.DtgConsultaConsignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgConsultaConsignacion.Location = new System.Drawing.Point(115, 50);
            this.DtgConsultaConsignacion.Name = "DtgConsultaConsignacion";
            this.DtgConsultaConsignacion.Size = new System.Drawing.Size(596, 150);
            this.DtgConsultaConsignacion.TabIndex = 0;
            // 
            // BtnValidar
            // 
            this.BtnValidar.Location = new System.Drawing.Point(266, 233);
            this.BtnValidar.Name = "BtnValidar";
            this.BtnValidar.Size = new System.Drawing.Size(75, 23);
            this.BtnValidar.TabIndex = 1;
            this.BtnValidar.Text = "Cargar";
            this.BtnValidar.UseVisualStyleBackColor = true;
            this.BtnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // CmbTipoServicio
            // 
            this.CmbTipoServicio.FormattingEnabled = true;
            this.CmbTipoServicio.Items.AddRange(new object[] {
            "Todos",
            "GasCaribe",
            "Emdupar",
            "Electricaribe"});
            this.CmbTipoServicio.Location = new System.Drawing.Point(115, 233);
            this.CmbTipoServicio.Name = "CmbTipoServicio";
            this.CmbTipoServicio.Size = new System.Drawing.Size(121, 21);
            this.CmbTipoServicio.TabIndex = 2;
            // 
            // TxtTotalConsignaciones
            // 
            this.TxtTotalConsignaciones.Location = new System.Drawing.Point(69, 293);
            this.TxtTotalConsignaciones.Name = "TxtTotalConsignaciones";
            this.TxtTotalConsignaciones.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalConsignaciones.TabIndex = 3;
            // 
            // TxtTotalGasCaribe
            // 
            this.TxtTotalGasCaribe.Location = new System.Drawing.Point(266, 293);
            this.TxtTotalGasCaribe.Name = "TxtTotalGasCaribe";
            this.TxtTotalGasCaribe.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalGasCaribe.TabIndex = 4;
            // 
            // TxtTotalElectricaribe
            // 
            this.TxtTotalElectricaribe.Location = new System.Drawing.Point(582, 293);
            this.TxtTotalElectricaribe.Name = "TxtTotalElectricaribe";
            this.TxtTotalElectricaribe.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalElectricaribe.TabIndex = 6;
            // 
            // TxtTotalEmdupar
            // 
            this.TxtTotalEmdupar.Location = new System.Drawing.Point(411, 293);
            this.TxtTotalEmdupar.Name = "TxtTotalEmdupar";
            this.TxtTotalEmdupar.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalEmdupar.TabIndex = 5;
            // 
            // TxtValorTotalEmdupar
            // 
            this.TxtValorTotalEmdupar.Location = new System.Drawing.Point(411, 361);
            this.TxtValorTotalEmdupar.Name = "TxtValorTotalEmdupar";
            this.TxtValorTotalEmdupar.Size = new System.Drawing.Size(100, 20);
            this.TxtValorTotalEmdupar.TabIndex = 8;
            // 
            // TxtValorTotalGasCaribe
            // 
            this.TxtValorTotalGasCaribe.Location = new System.Drawing.Point(266, 361);
            this.TxtValorTotalGasCaribe.Name = "TxtValorTotalGasCaribe";
            this.TxtValorTotalGasCaribe.Size = new System.Drawing.Size(100, 20);
            this.TxtValorTotalGasCaribe.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Número total de consignaciones\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "GasCaribe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Emdupar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Electricaribe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "TOTAL Electricaribe";
            // 
            // TxtValorTotalElectricaribe
            // 
            this.TxtValorTotalElectricaribe.Location = new System.Drawing.Point(582, 361);
            this.TxtValorTotalElectricaribe.Name = "TxtValorTotalElectricaribe";
            this.TxtValorTotalElectricaribe.Size = new System.Drawing.Size(100, 20);
            this.TxtValorTotalElectricaribe.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "TOTAL Emdupar\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "TOTAL GasCaribe\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "VALOR total de consignaciones\r\n";
            // 
            // TxtValorTotalConsignaciones
            // 
            this.TxtValorTotalConsignaciones.Location = new System.Drawing.Point(69, 361);
            this.TxtValorTotalConsignaciones.Name = "TxtValorTotalConsignaciones";
            this.TxtValorTotalConsignaciones.Size = new System.Drawing.Size(100, 20);
            this.TxtValorTotalConsignaciones.TabIndex = 17;
            // 
            // FrmConsultaConsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtValorTotalConsignaciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtValorTotalElectricaribe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtValorTotalEmdupar);
            this.Controls.Add(this.TxtValorTotalGasCaribe);
            this.Controls.Add(this.TxtTotalElectricaribe);
            this.Controls.Add(this.TxtTotalEmdupar);
            this.Controls.Add(this.TxtTotalGasCaribe);
            this.Controls.Add(this.TxtTotalConsignaciones);
            this.Controls.Add(this.CmbTipoServicio);
            this.Controls.Add(this.BtnValidar);
            this.Controls.Add(this.DtgConsultaConsignacion);
            this.Name = "FrmConsultaConsignacion";
            this.Text = "FrmConsultaConsignacion";
            this.Load += new System.EventHandler(this.FrmConsultaConsignacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsultaConsignacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgConsultaConsignacion;
        private System.Windows.Forms.Button BtnValidar;
        private System.Windows.Forms.ComboBox CmbTipoServicio;
        private System.Windows.Forms.TextBox TxtTotalConsignaciones;
        private System.Windows.Forms.TextBox TxtTotalGasCaribe;
        private System.Windows.Forms.TextBox TxtTotalElectricaribe;
        private System.Windows.Forms.TextBox TxtTotalEmdupar;
        private System.Windows.Forms.TextBox TxtValorTotalEmdupar;
        private System.Windows.Forms.TextBox TxtValorTotalGasCaribe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtValorTotalElectricaribe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtValorTotalConsignaciones;
    }
}