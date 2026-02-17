namespace CapaPresentacion
{
    partial class FrmSesiones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.dgvSesiones = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesiones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sesiones";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnactualizar);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Controls.Add(this.dgvSesiones);
            this.panel1.Location = new System.Drawing.Point(13, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 378);
            this.panel1.TabIndex = 1;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(590, 340);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 2;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(687, 340);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 1;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click_1);
            // 
            // dgvSesiones
            // 
            this.dgvSesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSesiones.Location = new System.Drawing.Point(22, 22);
            this.dgvSesiones.Name = "dgvSesiones";
            this.dgvSesiones.RowHeadersWidth = 51;
            this.dgvSesiones.RowTemplate.Height = 24;
            this.dgvSesiones.Size = new System.Drawing.Size(731, 291);
            this.dgvSesiones.TabIndex = 0;
            // 
            // FrmSesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSesiones";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmSesiones_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSesiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.DataGridView dgvSesiones;
    }
}