namespace CapaPresentacion
{
    partial class FrmRegistrarCliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.txtrfc = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.rbtactivo = new System.Windows.Forms.RadioButton();
            this.rbtinactivo = new System.Windows.Forms.RadioButton();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Nuevo Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "RFC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Documento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Seleccione Estado";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(42, 118);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(230, 22);
            this.txtnombre.TabIndex = 7;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(45, 199);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(227, 22);
            this.txtapellidos.TabIndex = 8;
            // 
            // txtdocumento
            // 
            this.txtdocumento.Location = new System.Drawing.Point(45, 278);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(227, 22);
            this.txtdocumento.TabIndex = 9;
            // 
            // txtrfc
            // 
            this.txtrfc.Location = new System.Drawing.Point(294, 118);
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Size = new System.Drawing.Size(211, 22);
            this.txtrfc.TabIndex = 10;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(297, 198);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(208, 22);
            this.txttelefono.TabIndex = 11;
            // 
            // rbtactivo
            // 
            this.rbtactivo.AutoSize = true;
            this.rbtactivo.Location = new System.Drawing.Point(297, 278);
            this.rbtactivo.Name = "rbtactivo";
            this.rbtactivo.Size = new System.Drawing.Size(65, 20);
            this.rbtactivo.TabIndex = 12;
            this.rbtactivo.TabStop = true;
            this.rbtactivo.Text = "Activo";
            this.rbtactivo.UseVisualStyleBackColor = true;
            // 
            // rbtinactivo
            // 
            this.rbtinactivo.AutoSize = true;
            this.rbtinactivo.Location = new System.Drawing.Point(380, 278);
            this.rbtinactivo.Name = "rbtinactivo";
            this.rbtinactivo.Size = new System.Drawing.Size(74, 20);
            this.rbtinactivo.TabIndex = 13;
            this.rbtinactivo.TabStop = true;
            this.rbtinactivo.Text = "Inactivo";
            this.rbtinactivo.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(320, 342);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(95, 23);
            this.btnguardar.TabIndex = 14;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(430, 342);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 23);
            this.btncancelar.TabIndex = 15;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(158, 84);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 16;
            this.textBox6.Visible = false;
            // 
            // FrmRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 403);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.rbtinactivo);
            this.Controls.Add(this.rbtactivo);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtrfc);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrarCliente";
            this.Text = "FrmRegistrarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.TextBox txtrfc;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.RadioButton rbtactivo;
        private System.Windows.Forms.RadioButton rbtinactivo;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox textBox6;
    }
}