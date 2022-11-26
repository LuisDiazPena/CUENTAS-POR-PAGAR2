
namespace CUENTAS_POR_PAGAR
{
    partial class FAGREGARCHEQUES
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
            this.label1 = new System.Windows.Forms.Label();
            this.TNUMCHEQ = new System.Windows.Forms.TextBox();
            this.BAGREGAR = new System.Windows.Forms.Button();
            this.TNUMFACT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TVALCHEQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TFECHACHEQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NUMERO CHEQUE";
            // 
            // TNUMCHEQ
            // 
            this.TNUMCHEQ.Location = new System.Drawing.Point(156, 60);
            this.TNUMCHEQ.Name = "TNUMCHEQ";
            this.TNUMCHEQ.Size = new System.Drawing.Size(100, 20);
            this.TNUMCHEQ.TabIndex = 2;
            this.TNUMCHEQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNUMCHEQ_KeyPress);
            // 
            // BAGREGAR
            // 
            this.BAGREGAR.Location = new System.Drawing.Point(69, 262);
            this.BAGREGAR.Name = "BAGREGAR";
            this.BAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.BAGREGAR.TabIndex = 3;
            this.BAGREGAR.Text = "AGREGAR";
            this.BAGREGAR.UseVisualStyleBackColor = true;
            this.BAGREGAR.Click += new System.EventHandler(this.BAGREGAR_Click);
            // 
            // TNUMFACT
            // 
            this.TNUMFACT.Location = new System.Drawing.Point(156, 103);
            this.TNUMFACT.Name = "TNUMFACT";
            this.TNUMFACT.Size = new System.Drawing.Size(100, 20);
            this.TNUMFACT.TabIndex = 5;
            this.TNUMFACT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNUMFACT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NUMERO FACTURA";
            // 
            // TVALCHEQ
            // 
            this.TVALCHEQ.Location = new System.Drawing.Point(156, 142);
            this.TVALCHEQ.Name = "TVALCHEQ";
            this.TVALCHEQ.Size = new System.Drawing.Size(100, 20);
            this.TVALCHEQ.TabIndex = 7;
            this.TVALCHEQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TVALCHEQ_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "VALOR CHEQUE";
            // 
            // TFECHACHEQ
            // 
            this.TFECHACHEQ.Location = new System.Drawing.Point(156, 182);
            this.TFECHACHEQ.Name = "TFECHACHEQ";
            this.TFECHACHEQ.Size = new System.Drawing.Size(100, 20);
            this.TFECHACHEQ.TabIndex = 9;
            this.TFECHACHEQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TFECHACHEQ_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "FECHA CHEQUE";
            // 
            // FAGREGARCHEQUES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 333);
            this.Controls.Add(this.TFECHACHEQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TVALCHEQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TNUMFACT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BAGREGAR);
            this.Controls.Add(this.TNUMCHEQ);
            this.Controls.Add(this.label1);
            this.Name = "FAGREGARCHEQUES";
            this.Text = "REGISTRAR DATOS DE CHEQUES";
            this.Load += new System.EventHandler(this.FAGREGARCHEQUES_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TNUMCHEQ;
        private System.Windows.Forms.Button BAGREGAR;
        private System.Windows.Forms.TextBox TNUMFACT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TVALCHEQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TFECHACHEQ;
        private System.Windows.Forms.Label label4;
    }
}