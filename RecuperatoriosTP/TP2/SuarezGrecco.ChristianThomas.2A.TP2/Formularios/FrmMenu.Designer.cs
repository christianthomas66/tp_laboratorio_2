
namespace Formularios
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btnMetalurgica = new System.Windows.Forms.Button();
            this.btnMostrarListaAcero = new System.Windows.Forms.Button();
            this.btnMostrarListaCobre = new System.Windows.Forms.Button();
            this.btnMostrarListaHierro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMetalurgica
            // 
            this.btnMetalurgica.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMetalurgica.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetalurgica.ForeColor = System.Drawing.Color.Black;
            this.btnMetalurgica.Location = new System.Drawing.Point(86, 60);
            this.btnMetalurgica.Name = "btnMetalurgica";
            this.btnMetalurgica.Size = new System.Drawing.Size(238, 72);
            this.btnMetalurgica.TabIndex = 0;
            this.btnMetalurgica.Text = "Metalurgica";
            this.btnMetalurgica.UseVisualStyleBackColor = false;
            this.btnMetalurgica.Click += new System.EventHandler(this.btnMetalurgica_Click);
            // 
            // btnMostrarListaAcero
            // 
            this.btnMostrarListaAcero.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMostrarListaAcero.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarListaAcero.ForeColor = System.Drawing.Color.Black;
            this.btnMostrarListaAcero.Location = new System.Drawing.Point(86, 129);
            this.btnMostrarListaAcero.Name = "btnMostrarListaAcero";
            this.btnMostrarListaAcero.Size = new System.Drawing.Size(238, 72);
            this.btnMostrarListaAcero.TabIndex = 1;
            this.btnMostrarListaAcero.Text = "Lista Acero";
            this.btnMostrarListaAcero.UseVisualStyleBackColor = false;
            this.btnMostrarListaAcero.Click += new System.EventHandler(this.btnMostrarListaAcero_Click);
            // 
            // btnMostrarListaCobre
            // 
            this.btnMostrarListaCobre.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMostrarListaCobre.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarListaCobre.ForeColor = System.Drawing.Color.Black;
            this.btnMostrarListaCobre.Location = new System.Drawing.Point(86, 198);
            this.btnMostrarListaCobre.Name = "btnMostrarListaCobre";
            this.btnMostrarListaCobre.Size = new System.Drawing.Size(238, 72);
            this.btnMostrarListaCobre.TabIndex = 2;
            this.btnMostrarListaCobre.Text = "Lista Cobre";
            this.btnMostrarListaCobre.UseVisualStyleBackColor = false;
            this.btnMostrarListaCobre.Click += new System.EventHandler(this.btnMostrarListaCobre_Click);
            // 
            // btnMostrarListaHierro
            // 
            this.btnMostrarListaHierro.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMostrarListaHierro.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarListaHierro.ForeColor = System.Drawing.Color.Black;
            this.btnMostrarListaHierro.Location = new System.Drawing.Point(86, 267);
            this.btnMostrarListaHierro.Name = "btnMostrarListaHierro";
            this.btnMostrarListaHierro.Size = new System.Drawing.Size(238, 72);
            this.btnMostrarListaHierro.TabIndex = 3;
            this.btnMostrarListaHierro.Text = "Lista Hierro";
            this.btnMostrarListaHierro.UseVisualStyleBackColor = false;
            this.btnMostrarListaHierro.Click += new System.EventHandler(this.btnMostrarListaHierro_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(86, 336);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(238, 72);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(419, 482);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarListaHierro);
            this.Controls.Add(this.btnMostrarListaCobre);
            this.Controls.Add(this.btnMostrarListaAcero);
            this.Controls.Add(this.btnMetalurgica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMetalurgica;
        private System.Windows.Forms.Button btnMostrarListaAcero;
        private System.Windows.Forms.Button btnMostrarListaCobre;
        private System.Windows.Forms.Button btnMostrarListaHierro;
        private System.Windows.Forms.Button btnSalir;
    }
}

