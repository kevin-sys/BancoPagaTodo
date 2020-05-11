namespace BancoPagaTodo
{
    partial class FrmRegistroConsignacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmbServiciosPublicos = new System.Windows.Forms.ComboBox();
            this.TxtNumeroRecibo = new System.Windows.Forms.TextBox();
            this.TxtValorPagado = new System.Windows.Forms.TextBox();
            this.DtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbServiciosPublicos
            // 
            this.CmbServiciosPublicos.FormattingEnabled = true;
            this.CmbServiciosPublicos.Items.AddRange(new object[] {
            "Electricaribe",
            "GasCaribe",
            "Emdupar"});
            this.CmbServiciosPublicos.Location = new System.Drawing.Point(206, 43);
            this.CmbServiciosPublicos.Name = "CmbServiciosPublicos";
            this.CmbServiciosPublicos.Size = new System.Drawing.Size(121, 21);
            this.CmbServiciosPublicos.TabIndex = 0;
            // 
            // TxtNumeroRecibo
            // 
            this.TxtNumeroRecibo.Location = new System.Drawing.Point(215, 93);
            this.TxtNumeroRecibo.Name = "TxtNumeroRecibo";
            this.TxtNumeroRecibo.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroRecibo.TabIndex = 1;
            // 
            // TxtValorPagado
            // 
            this.TxtValorPagado.Location = new System.Drawing.Point(215, 187);
            this.TxtValorPagado.Name = "TxtValorPagado";
            this.TxtValorPagado.Size = new System.Drawing.Size(100, 20);
            this.TxtValorPagado.TabIndex = 2;
            // 
            // DtpFechaPago
            // 
            this.DtpFechaPago.Location = new System.Drawing.Point(215, 142);
            this.DtpFechaPago.Name = "DtpFechaPago";
            this.DtpFechaPago.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaPago.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entidad de servicios publicos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor pagado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero recibo";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(340, 255);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 8;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // FrmRegistroConsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 327);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtpFechaPago);
            this.Controls.Add(this.TxtValorPagado);
            this.Controls.Add(this.TxtNumeroRecibo);
            this.Controls.Add(this.CmbServiciosPublicos);
            this.Name = "FrmRegistroConsignacion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbServiciosPublicos;
        private System.Windows.Forms.TextBox TxtNumeroRecibo;
        private System.Windows.Forms.TextBox TxtValorPagado;
        private System.Windows.Forms.DateTimePicker DtpFechaPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnRegistrar;
    }
}

