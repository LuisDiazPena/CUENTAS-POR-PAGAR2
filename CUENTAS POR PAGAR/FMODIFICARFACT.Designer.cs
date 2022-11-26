
namespace CUENTAS_POR_PAGAR
{
    partial class FMODIFICARFACT
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
            this.BACTUALIZAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TNUMFACT = new System.Windows.Forms.TextBox();
            this.TCODIGO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TVALFACT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TFECHAFACT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TFECHAVENC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BACTUALIZAR
            // 
            this.BACTUALIZAR.Location = new System.Drawing.Point(112, 288);
            this.BACTUALIZAR.Name = "BACTUALIZAR";
            this.BACTUALIZAR.Size = new System.Drawing.Size(95, 37);
            this.BACTUALIZAR.TabIndex = 0;
            this.BACTUALIZAR.Text = "ACTUALIZAR";
            this.BACTUALIZAR.UseVisualStyleBackColor = true;
            this.BACTUALIZAR.Click += new System.EventHandler(this.BACTUALIZAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NUMERO FACTURA";
            // 
            // TNUMFACT
            // 
            this.TNUMFACT.Location = new System.Drawing.Point(150, 46);
            this.TNUMFACT.Name = "TNUMFACT";
            this.TNUMFACT.Size = new System.Drawing.Size(100, 20);
            this.TNUMFACT.TabIndex = 2;
            // 
            // TCODIGO
            // 
            this.TCODIGO.Location = new System.Drawing.Point(150, 99);
            this.TCODIGO.Name = "TCODIGO";
            this.TCODIGO.Size = new System.Drawing.Size(142, 20);
            this.TCODIGO.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CODIGO";
            // 
            // TVALFACT
            // 
            this.TVALFACT.Location = new System.Drawing.Point(150, 135);
            this.TVALFACT.Name = "TVALFACT";
            this.TVALFACT.Size = new System.Drawing.Size(142, 20);
            this.TVALFACT.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "VALOR FACTURA";
            // 
            // TFECHAFACT
            // 
            this.TFECHAFACT.Location = new System.Drawing.Point(150, 180);
            this.TFECHAFACT.Name = "TFECHAFACT";
            this.TFECHAFACT.Size = new System.Drawing.Size(142, 20);
            this.TFECHAFACT.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "FECHA FACTURA";
            // 
            // TFECHAVENC
            // 
            this.TFECHAVENC.Location = new System.Drawing.Point(150, 226);
            this.TFECHAVENC.Name = "TFECHAVENC";
            this.TFECHAVENC.Size = new System.Drawing.Size(142, 20);
            this.TFECHAVENC.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "FECHA VENCIMIENTO";
            // 
            // FMODIFICARFACT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 379);
            this.Controls.Add(this.TFECHAVENC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TFECHAFACT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TVALFACT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TCODIGO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TNUMFACT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BACTUALIZAR);
            this.Name = "FMODIFICARFACT";
            this.Text = "MODIFICAR FACTURAS";
            this.Load += new System.EventHandler(this.FMODIFICARFACT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BACTUALIZAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TNUMFACT;
        private System.Windows.Forms.TextBox TCODIGO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TVALFACT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TFECHAFACT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TFECHAVENC;
        private System.Windows.Forms.Label label5;
    }
}