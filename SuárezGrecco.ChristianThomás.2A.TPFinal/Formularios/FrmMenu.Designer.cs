
namespace WindowsFormsApp1
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
            this.btnFabrica = new System.Windows.Forms.Button();
            this.btnGuardarXML = new System.Windows.Forms.Button();
            this.btnCargarXML = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargarSQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFabrica
            // 
            this.btnFabrica.Location = new System.Drawing.Point(101, 27);
            this.btnFabrica.Name = "btnFabrica";
            this.btnFabrica.Size = new System.Drawing.Size(258, 56);
            this.btnFabrica.TabIndex = 0;
            this.btnFabrica.Text = "Fábrica";
            this.btnFabrica.UseVisualStyleBackColor = true;
            this.btnFabrica.Click += new System.EventHandler(this.btnFabrica_Click);
            // 
            // btnGuardarXML
            // 
            this.btnGuardarXML.Location = new System.Drawing.Point(101, 89);
            this.btnGuardarXML.Name = "btnGuardarXML";
            this.btnGuardarXML.Size = new System.Drawing.Size(258, 60);
            this.btnGuardarXML.TabIndex = 1;
            this.btnGuardarXML.Text = "Guardar datos XML";
            this.btnGuardarXML.UseVisualStyleBackColor = true;
            this.btnGuardarXML.Click += new System.EventHandler(this.btnGuardarXML_Click);
            // 
            // btnCargarXML
            // 
            this.btnCargarXML.Location = new System.Drawing.Point(101, 155);
            this.btnCargarXML.Name = "btnCargarXML";
            this.btnCargarXML.Size = new System.Drawing.Size(258, 61);
            this.btnCargarXML.TabIndex = 2;
            this.btnCargarXML.Text = "Cargar datos XML";
            this.btnCargarXML.UseVisualStyleBackColor = true;
            this.btnCargarXML.Click += new System.EventHandler(this.btnCargarXML_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(101, 289);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(258, 60);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargarSQL
            // 
            this.btnCargarSQL.Location = new System.Drawing.Point(101, 222);
            this.btnCargarSQL.Name = "btnCargarSQL";
            this.btnCargarSQL.Size = new System.Drawing.Size(258, 61);
            this.btnCargarSQL.TabIndex = 4;
            this.btnCargarSQL.Text = "Cargar a la base de datos SQL";
            this.btnCargarSQL.UseVisualStyleBackColor = true;
            this.btnCargarSQL.Click += new System.EventHandler(this.btnCargarSQL_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 380);
            this.Controls.Add(this.btnCargarSQL);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargarXML);
            this.Controls.Add(this.btnGuardarXML);
            this.Controls.Add(this.btnFabrica);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFabrica;
        private System.Windows.Forms.Button btnGuardarXML;
        private System.Windows.Forms.Button btnCargarXML;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargarSQL;
    }
}

