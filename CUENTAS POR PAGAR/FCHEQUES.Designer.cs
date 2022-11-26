
namespace CUENTAS_POR_PAGAR
{
    partial class FCHEQUES
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
            this.BMODIFICAR = new System.Windows.Forms.Button();
            this.BELIMINAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TNUMCHEQ = new System.Windows.Forms.TextBox();
            this.TNUMFACT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVCHEQUES = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCHEQUES)).BeginInit();
            this.SuspendLayout();
            // 
            // BAGREGAR
            // 
            this.BAGREGAR.Location = new System.Drawing.Point(560, 12);
            this.BAGREGAR.Name = "BAGREGAR";
            this.BAGREGAR.Size = new System.Drawing.Size(76, 23);
            this.BAGREGAR.TabIndex = 0;
            this.BAGREGAR.Text = "AGREGAR";
            this.BAGREGAR.UseVisualStyleBackColor = true;
            this.BAGREGAR.Click += new System.EventHandler(this.BAGREGAR_Click);
            // 
            // BMODIFICAR
            // 
            this.BMODIFICAR.Location = new System.Drawing.Point(560, 66);
            this.BMODIFICAR.Name = "BMODIFICAR";
            this.BMODIFICAR.Size = new System.Drawing.Size(76, 23);
            this.BMODIFICAR.TabIndex = 1;
            this.BMODIFICAR.Text = "MODIFICAR";
            this.BMODIFICAR.UseVisualStyleBackColor = true;
            this.BMODIFICAR.Click += new System.EventHandler(this.BMODIFICAR_Click);
            // 
            // BELIMINAR
            // 
            this.BELIMINAR.Location = new System.Drawing.Point(560, 119);
            this.BELIMINAR.Name = "BELIMINAR";
            this.BELIMINAR.Size = new System.Drawing.Size(76, 23);
            this.BELIMINAR.TabIndex = 2;
            this.BELIMINAR.Text = "ELIMINAR";
            this.BELIMINAR.UseVisualStyleBackColor = true;
            this.BELIMINAR.Click += new System.EventHandler(this.BELIMINAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BUSCAR CHEQUES POR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NUMERO CHEQUE";
            // 
            // TNUMCHEQ
            // 
            this.TNUMCHEQ.Location = new System.Drawing.Point(495, 245);
            this.TNUMCHEQ.Name = "TNUMCHEQ";
            this.TNUMCHEQ.Size = new System.Drawing.Size(155, 20);
            this.TNUMCHEQ.TabIndex = 5;
            this.TNUMCHEQ.TextChanged += new System.EventHandler(this.TNUMCHEQ_TextChanged);
            // 
            // TNUMFACT
            // 
            this.TNUMFACT.Location = new System.Drawing.Point(495, 326);
            this.TNUMFACT.Name = "TNUMFACT";
            this.TNUMFACT.Size = new System.Drawing.Size(155, 20);
            this.TNUMFACT.TabIndex = 7;
            this.TNUMFACT.TextChanged += new System.EventHandler(this.TNUMFACT_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "NUMERO FACTURA";
            // 
            // DGVCHEQUES
            // 
            this.DGVCHEQUES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCHEQUES.Location = new System.Drawing.Point(1, 1);
            this.DGVCHEQUES.Name = "DGVCHEQUES";
            this.DGVCHEQUES.Size = new System.Drawing.Size(488, 389);
            this.DGVCHEQUES.TabIndex = 8;
            // 
            // FCHEQUES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVCHEQUES);
            this.Controls.Add(this.TNUMFACT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TNUMCHEQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BELIMINAR);
            this.Controls.Add(this.BMODIFICAR);
            this.Controls.Add(this.BAGREGAR);
            this.Name = "FCHEQUES";
            this.Text = "MANTENIMIENTO DE CHEQUES";
            this.Load += new System.EventHandler(this.FCHEQUES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCHEQUES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAGREGAR;
        private System.Windows.Forms.Button BMODIFICAR;
        private System.Windows.Forms.Button BELIMINAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TNUMCHEQ;
        private System.Windows.Forms.TextBox TNUMFACT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVCHEQUES;
    }
}