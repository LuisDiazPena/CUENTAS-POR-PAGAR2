
namespace CUENTAS_POR_PAGAR
{
    partial class FMODIFICARPROV
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
            this.TCODIGO = new System.Windows.Forms.TextBox();
            this.BACTUALIZAR = new System.Windows.Forms.Button();
            this.TNOMBRES = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TAPELLIDOS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TDIRECCION = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TCIUDAD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TTELEFONO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO\r\n";
            // 
            // TCODIGO
            // 
            this.TCODIGO.Location = new System.Drawing.Point(109, 49);
            this.TCODIGO.Name = "TCODIGO";
            this.TCODIGO.Size = new System.Drawing.Size(100, 20);
            this.TCODIGO.TabIndex = 1;
            // 
            // BACTUALIZAR
            // 
            this.BACTUALIZAR.Location = new System.Drawing.Point(79, 300);
            this.BACTUALIZAR.Name = "BACTUALIZAR";
            this.BACTUALIZAR.Size = new System.Drawing.Size(75, 23);
            this.BACTUALIZAR.TabIndex = 2;
            this.BACTUALIZAR.Text = "ACTUALIZAR";
            this.BACTUALIZAR.UseVisualStyleBackColor = true;
            this.BACTUALIZAR.Click += new System.EventHandler(this.BACTUALIZAR_Click);
            // 
            // TNOMBRES
            // 
            this.TNOMBRES.Location = new System.Drawing.Point(109, 90);
            this.TNOMBRES.Name = "TNOMBRES";
            this.TNOMBRES.Size = new System.Drawing.Size(100, 20);
            this.TNOMBRES.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRES";
            // 
            // TAPELLIDOS
            // 
            this.TAPELLIDOS.Location = new System.Drawing.Point(109, 131);
            this.TAPELLIDOS.Name = "TAPELLIDOS";
            this.TAPELLIDOS.Size = new System.Drawing.Size(100, 20);
            this.TAPELLIDOS.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "APELLIDOS";
            // 
            // TDIRECCION
            // 
            this.TDIRECCION.Location = new System.Drawing.Point(109, 173);
            this.TDIRECCION.Name = "TDIRECCION";
            this.TDIRECCION.Size = new System.Drawing.Size(100, 20);
            this.TDIRECCION.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DIRECCION";
            // 
            // TCIUDAD
            // 
            this.TCIUDAD.Location = new System.Drawing.Point(109, 213);
            this.TCIUDAD.Name = "TCIUDAD";
            this.TCIUDAD.Size = new System.Drawing.Size(100, 20);
            this.TCIUDAD.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CIUDAD";
            // 
            // TTELEFONO
            // 
            this.TTELEFONO.Location = new System.Drawing.Point(109, 249);
            this.TTELEFONO.Name = "TTELEFONO";
            this.TTELEFONO.Size = new System.Drawing.Size(100, 20);
            this.TTELEFONO.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "TELEFONO\r\n";
            // 
            // FMODIFICARPROV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 345);
            this.Controls.Add(this.TTELEFONO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TCIUDAD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TDIRECCION);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TAPELLIDOS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TNOMBRES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BACTUALIZAR);
            this.Controls.Add(this.TCODIGO);
            this.Controls.Add(this.label1);
            this.Name = "FMODIFICARPROV";
            this.Text = "MODIFICAR DATOS DE PROVEEDOR";
            this.Load += new System.EventHandler(this.FMODIFICARPROV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TCODIGO;
        private System.Windows.Forms.Button BACTUALIZAR;
        private System.Windows.Forms.TextBox TNOMBRES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TAPELLIDOS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TDIRECCION;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TCIUDAD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TTELEFONO;
        private System.Windows.Forms.Label label6;
    }
}