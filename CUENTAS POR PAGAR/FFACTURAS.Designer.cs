
namespace CUENTAS_POR_PAGAR
{
    partial class FFACTURAS
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
            this.label3 = new System.Windows.Forms.Label();
            this.TNUMFACT = new System.Windows.Forms.TextBox();
            this.TCODIGO = new System.Windows.Forms.TextBox();
            this.DGVFACTURAS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFACTURAS)).BeginInit();
            this.SuspendLayout();
            // 
            // BAGREGAR
            // 
            this.BAGREGAR.Location = new System.Drawing.Point(522, 12);
            this.BAGREGAR.Name = "BAGREGAR";
            this.BAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.BAGREGAR.TabIndex = 0;
            this.BAGREGAR.Text = "AGREGAR";
            this.BAGREGAR.UseVisualStyleBackColor = true;
            this.BAGREGAR.Click += new System.EventHandler(this.BAGREGAR_Click);
            // 
            // BMODIFICAR
            // 
            this.BMODIFICAR.Location = new System.Drawing.Point(522, 54);
            this.BMODIFICAR.Name = "BMODIFICAR";
            this.BMODIFICAR.Size = new System.Drawing.Size(75, 23);
            this.BMODIFICAR.TabIndex = 1;
            this.BMODIFICAR.Text = "MODIFICAR";
            this.BMODIFICAR.UseVisualStyleBackColor = true;
            this.BMODIFICAR.Click += new System.EventHandler(this.BMODIFICAR_Click);
            // 
            // BELIMINAR
            // 
            this.BELIMINAR.Location = new System.Drawing.Point(522, 94);
            this.BELIMINAR.Name = "BELIMINAR";
            this.BELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.BELIMINAR.TabIndex = 2;
            this.BELIMINAR.Text = "ELIMINAR";
            this.BELIMINAR.UseVisualStyleBackColor = true;
            this.BELIMINAR.Click += new System.EventHandler(this.BELIMINAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BUSCAR FACTURAS POR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NUMERO DE FACTURA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CODIGO DE CLIENTE";
            // 
            // TNUMFACT
            // 
            this.TNUMFACT.Location = new System.Drawing.Point(474, 215);
            this.TNUMFACT.Name = "TNUMFACT";
            this.TNUMFACT.Size = new System.Drawing.Size(161, 20);
            this.TNUMFACT.TabIndex = 6;
            this.TNUMFACT.TextChanged += new System.EventHandler(this.TNUMFACT_TextChanged);
            // 
            // TCODIGO
            // 
            this.TCODIGO.Location = new System.Drawing.Point(474, 297);
            this.TCODIGO.Name = "TCODIGO";
            this.TCODIGO.Size = new System.Drawing.Size(161, 20);
            this.TCODIGO.TabIndex = 7;
            this.TCODIGO.TextChanged += new System.EventHandler(this.TCODIGO_TextChanged);
            // 
            // DGVFACTURAS
            // 
            this.DGVFACTURAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFACTURAS.Location = new System.Drawing.Point(2, 3);
            this.DGVFACTURAS.Name = "DGVFACTURAS";
            this.DGVFACTURAS.Size = new System.Drawing.Size(443, 361);
            this.DGVFACTURAS.TabIndex = 8;
            // 
            // FFACTURAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 368);
            this.Controls.Add(this.DGVFACTURAS);
            this.Controls.Add(this.TCODIGO);
            this.Controls.Add(this.TNUMFACT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BELIMINAR);
            this.Controls.Add(this.BMODIFICAR);
            this.Controls.Add(this.BAGREGAR);
            this.Name = "FFACTURAS";
            this.Text = "MANTENIMIENTO DE FACTURAS";
            this.Load += new System.EventHandler(this.FFACTURAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFACTURAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAGREGAR;
        private System.Windows.Forms.Button BMODIFICAR;
        private System.Windows.Forms.Button BELIMINAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TNUMFACT;
        private System.Windows.Forms.TextBox TCODIGO;
        private System.Windows.Forms.DataGridView DGVFACTURAS;
    }
}