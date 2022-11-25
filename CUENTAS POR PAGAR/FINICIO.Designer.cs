
namespace CUENTAS_POR_PAGAR
{
    partial class FINICIO
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
            this.label2 = new System.Windows.Forms.Label();
            this.TUSUARIO = new System.Windows.Forms.TextBox();
            this.TCLAVE = new System.Windows.Forms.TextBox();
            this.DAGVUSUARIOS = new System.Windows.Forms.DataGridView();
            this.BENTRADA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DAGVUSUARIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ESCRIBA EL NOMBRE DE USUARIO\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ESCRIBA LA CONTRASEÑA\r\n";
            // 
            // TUSUARIO
            // 
            this.TUSUARIO.Location = new System.Drawing.Point(449, 28);
            this.TUSUARIO.Name = "TUSUARIO";
            this.TUSUARIO.Size = new System.Drawing.Size(319, 20);
            this.TUSUARIO.TabIndex = 3;
            // 
            // TCLAVE
            // 
            this.TCLAVE.Location = new System.Drawing.Point(449, 86);
            this.TCLAVE.Name = "TCLAVE";
            this.TCLAVE.Size = new System.Drawing.Size(319, 20);
            this.TCLAVE.TabIndex = 4;
            // 
            // DAGVUSUARIOS
            // 
            this.DAGVUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DAGVUSUARIOS.Location = new System.Drawing.Point(3, 299);
            this.DAGVUSUARIOS.Name = "DAGVUSUARIOS";
            this.DAGVUSUARIOS.Size = new System.Drawing.Size(795, 150);
            this.DAGVUSUARIOS.TabIndex = 5;
            // 
            // BENTRADA
            // 
            this.BENTRADA.Location = new System.Drawing.Point(396, 240);
            this.BENTRADA.Name = "BENTRADA";
            this.BENTRADA.Size = new System.Drawing.Size(75, 23);
            this.BENTRADA.TabIndex = 6;
            this.BENTRADA.Text = "ENTRAR";
            this.BENTRADA.UseVisualStyleBackColor = true;
            this.BENTRADA.Click += new System.EventHandler(this.BENTRADA_Click);
            // 
            // FINICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BENTRADA);
            this.Controls.Add(this.DAGVUSUARIOS);
            this.Controls.Add(this.TCLAVE);
            this.Controls.Add(this.TUSUARIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FINICIO";
            this.Text = "FINICIO";
            this.Load += new System.EventHandler(this.FINICIO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DAGVUSUARIOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TUSUARIO;
        private System.Windows.Forms.TextBox TCLAVE;
        private System.Windows.Forms.DataGridView DAGVUSUARIOS;
        private System.Windows.Forms.Button BENTRADA;
    }
}