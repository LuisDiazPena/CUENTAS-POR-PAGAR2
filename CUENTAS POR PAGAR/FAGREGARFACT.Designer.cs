
namespace CUENTAS_POR_PAGAR
{
    partial class FAGREGARFACT
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
            this.BAGREGAR = new System.Windows.Forms.Button();
            this.TNUMFACT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TCODIGO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TVALFACT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TFECHAFACT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TFECHAVENC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BAGREGAR
            // 
            this.BAGREGAR.Location = new System.Drawing.Point(132, 332);
            this.BAGREGAR.Name = "BAGREGAR";
            this.BAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.BAGREGAR.TabIndex = 0;
            this.BAGREGAR.Text = "AGREGAR";
            this.BAGREGAR.UseVisualStyleBackColor = true;
            this.BAGREGAR.Click += new System.EventHandler(this.BAGREGAR_Click);
            // 
            // TNUMFACT
            // 
            this.TNUMFACT.Location = new System.Drawing.Point(147, 57);
            this.TNUMFACT.Name = "TNUMFACT";
            this.TNUMFACT.Size = new System.Drawing.Size(126, 20);
            this.TNUMFACT.TabIndex = 4;
            this.TNUMFACT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNUMFACT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NUMERO FACTURA";
            // 
            // TCODIGO
            // 
            this.TCODIGO.Location = new System.Drawing.Point(183, 137);
            this.TCODIGO.Name = "TCODIGO";
            this.TCODIGO.Size = new System.Drawing.Size(153, 20);
            this.TCODIGO.TabIndex = 6;
            this.TCODIGO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCODIGO_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CODIGO CLIENTE";
            // 
            // TVALFACT
            // 
            this.TVALFACT.Location = new System.Drawing.Point(183, 177);
            this.TVALFACT.Name = "TVALFACT";
            this.TVALFACT.Size = new System.Drawing.Size(153, 20);
            this.TVALFACT.TabIndex = 8;
            this.TVALFACT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TVALFACT_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "VALOR FACTURA";
            // 
            // TFECHAFACT
            // 
            this.TFECHAFACT.Location = new System.Drawing.Point(183, 223);
            this.TFECHAFACT.Name = "TFECHAFACT";
            this.TFECHAFACT.Size = new System.Drawing.Size(153, 20);
            this.TFECHAFACT.TabIndex = 10;
            this.TFECHAFACT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TFECHAFACT_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "FECHA FACTURA";
            // 
            // TFECHAVENC
            // 
            this.TFECHAVENC.Location = new System.Drawing.Point(183, 273);
            this.TFECHAVENC.Name = "TFECHAVENC";
            this.TFECHAVENC.Size = new System.Drawing.Size(153, 20);
            this.TFECHAVENC.TabIndex = 12;
            this.TFECHAVENC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TFECHAVENC_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "FECHA VENCIMIENTO";
            // 
            // FAGREGARFACT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 381);
            this.Controls.Add(this.TFECHAVENC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TFECHAFACT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TVALFACT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TCODIGO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TNUMFACT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BAGREGAR);
            this.Name = "FAGREGARFACT";
            this.Text = "REGISTRAR DATOS DE FACTURAS POR PAGAR";
            this.Load += new System.EventHandler(this.FAGREGARFACT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAGREGAR;
        private System.Windows.Forms.TextBox TNUMFACT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TCODIGO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TVALFACT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TFECHAFACT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TFECHAVENC;
        private System.Windows.Forms.Label label6;
    }
}