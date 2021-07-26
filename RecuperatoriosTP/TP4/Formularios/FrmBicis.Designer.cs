
namespace WindowsFormsApp1
{
    partial class FrmBicis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBicis));
            this.btnFabricar = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbRuedas = new System.Windows.Forms.ComboBox();
            this.LblTituloFábricaBici = new System.Windows.Forms.Label();
            this.LblColor = new System.Windows.Forms.Label();
            this.LblRuedas = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.LblNumeroSerie = new System.Windows.Forms.Label();
            this.cmbNumeroSerie = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rtbBicisFabricadas = new System.Windows.Forms.RichTextBox();
            this.groupBoxBicisFabricadas = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnTraerDatos = new System.Windows.Forms.Button();
            this.btnHilos = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGuardarEnBaseDeDatos = new System.Windows.Forms.Button();
            this.groupBoxBicisFabricadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFabricar
            // 
            this.btnFabricar.BackColor = System.Drawing.Color.Maroon;
            this.btnFabricar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFabricar.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFabricar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFabricar.Location = new System.Drawing.Point(12, 265);
            this.btnFabricar.Name = "btnFabricar";
            this.btnFabricar.Size = new System.Drawing.Size(241, 68);
            this.btnFabricar.TabIndex = 0;
            this.btnFabricar.Text = "Fabricar";
            this.btnFabricar.UseVisualStyleBackColor = false;
            this.btnFabricar.Click += new System.EventHandler(this.btnFabricar_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Specialized",
            "Scott",
            "Trek",
            "Giant"});
            this.cmbMarca.Location = new System.Drawing.Point(12, 210);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(110, 27);
            this.cmbMarca.TabIndex = 10;
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Negro",
            "Blanco",
            "Rojo",
            "Verde",
            "Azul",
            "Rosa",
            "Amarillo",
            "Marrón",
            "Violeta",
            "Naranja"});
            this.cmbColor.Location = new System.Drawing.Point(12, 124);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(91, 27);
            this.cmbColor.TabIndex = 11;
            // 
            // cmbRuedas
            // 
            this.cmbRuedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRuedas.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRuedas.FormattingEnabled = true;
            this.cmbRuedas.Items.AddRange(new object[] {
            "Shimano",
            "Zipp",
            "Supra",
            "HED"});
            this.cmbRuedas.Location = new System.Drawing.Point(137, 124);
            this.cmbRuedas.Name = "cmbRuedas";
            this.cmbRuedas.Size = new System.Drawing.Size(107, 27);
            this.cmbRuedas.TabIndex = 12;
            // 
            // LblTituloFábricaBici
            // 
            this.LblTituloFábricaBici.AutoSize = true;
            this.LblTituloFábricaBici.BackColor = System.Drawing.Color.Transparent;
            this.LblTituloFábricaBici.Font = new System.Drawing.Font("Impact", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloFábricaBici.Location = new System.Drawing.Point(301, 9);
            this.LblTituloFábricaBici.Name = "LblTituloFábricaBici";
            this.LblTituloFábricaBici.Size = new System.Drawing.Size(423, 60);
            this.LblTituloFábricaBici.TabIndex = 13;
            this.LblTituloFábricaBici.Text = "Fabrica tu bicicleta";
            // 
            // LblColor
            // 
            this.LblColor.AutoSize = true;
            this.LblColor.BackColor = System.Drawing.Color.Maroon;
            this.LblColor.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblColor.Location = new System.Drawing.Point(26, 92);
            this.LblColor.Name = "LblColor";
            this.LblColor.Size = new System.Drawing.Size(65, 29);
            this.LblColor.TabIndex = 14;
            this.LblColor.Text = "Color";
            // 
            // LblRuedas
            // 
            this.LblRuedas.AutoSize = true;
            this.LblRuedas.BackColor = System.Drawing.Color.Maroon;
            this.LblRuedas.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRuedas.Location = new System.Drawing.Point(142, 92);
            this.LblRuedas.Name = "LblRuedas";
            this.LblRuedas.Size = new System.Drawing.Size(86, 29);
            this.LblRuedas.TabIndex = 15;
            this.LblRuedas.Text = "Ruedas";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.BackColor = System.Drawing.Color.Maroon;
            this.LblMarca.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarca.Location = new System.Drawing.Point(26, 178);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(75, 29);
            this.LblMarca.TabIndex = 16;
            this.LblMarca.Text = "Marca";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Maroon;
            this.btnLimpiar.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 339);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(241, 68);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // LblNumeroSerie
            // 
            this.LblNumeroSerie.AutoSize = true;
            this.LblNumeroSerie.BackColor = System.Drawing.Color.Maroon;
            this.LblNumeroSerie.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroSerie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblNumeroSerie.Location = new System.Drawing.Point(132, 178);
            this.LblNumeroSerie.Name = "LblNumeroSerie";
            this.LblNumeroSerie.Size = new System.Drawing.Size(118, 26);
            this.LblNumeroSerie.TabIndex = 24;
            this.LblNumeroSerie.Text = "Nro de Serie";
            // 
            // cmbNumeroSerie
            // 
            this.cmbNumeroSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumeroSerie.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumeroSerie.FormattingEnabled = true;
            this.cmbNumeroSerie.Items.AddRange(new object[] {
            "Sin_serie",
            "Serie_1",
            "Serie_2",
            "Serie_3"});
            this.cmbNumeroSerie.Location = new System.Drawing.Point(128, 210);
            this.cmbNumeroSerie.Name = "cmbNumeroSerie";
            this.cmbNumeroSerie.Size = new System.Drawing.Size(122, 27);
            this.cmbNumeroSerie.TabIndex = 25;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(12, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(241, 68);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rtbBicisFabricadas
            // 
            this.rtbBicisFabricadas.Location = new System.Drawing.Point(15, 25);
            this.rtbBicisFabricadas.Name = "rtbBicisFabricadas";
            this.rtbBicisFabricadas.ReadOnly = true;
            this.rtbBicisFabricadas.Size = new System.Drawing.Size(425, 198);
            this.rtbBicisFabricadas.TabIndex = 27;
            this.rtbBicisFabricadas.Text = "";
            // 
            // groupBoxBicisFabricadas
            // 
            this.groupBoxBicisFabricadas.Controls.Add(this.rtbBicisFabricadas);
            this.groupBoxBicisFabricadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBicisFabricadas.Location = new System.Drawing.Point(284, 92);
            this.groupBoxBicisFabricadas.Name = "groupBoxBicisFabricadas";
            this.groupBoxBicisFabricadas.Size = new System.Drawing.Size(459, 241);
            this.groupBoxBicisFabricadas.TabIndex = 28;
            this.groupBoxBicisFabricadas.TabStop = false;
            this.groupBoxBicisFabricadas.Text = "Bicicletas fabricadas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(749, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(375, 391);
            this.dataGridView1.TabIndex = 31;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(866, 48);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 38);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnTraerDatos
            // 
            this.btnTraerDatos.BackColor = System.Drawing.Color.Maroon;
            this.btnTraerDatos.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraerDatos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTraerDatos.Location = new System.Drawing.Point(787, 3);
            this.btnTraerDatos.Name = "btnTraerDatos";
            this.btnTraerDatos.Size = new System.Drawing.Size(150, 39);
            this.btnTraerDatos.TabIndex = 35;
            this.btnTraerDatos.Text = "Traer datos";
            this.btnTraerDatos.UseVisualStyleBackColor = false;
            this.btnTraerDatos.Click += new System.EventHandler(this.btnTraerDatos_Click);
            // 
            // btnHilos
            // 
            this.btnHilos.BackColor = System.Drawing.Color.Maroon;
            this.btnHilos.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHilos.Location = new System.Drawing.Point(372, 339);
            this.btnHilos.Name = "btnHilos";
            this.btnHilos.Size = new System.Drawing.Size(248, 81);
            this.btnHilos.TabIndex = 37;
            this.btnHilos.Text = "Probar hilos";
            this.btnHilos.UseVisualStyleBackColor = false;
            this.btnHilos.Click += new System.EventHandler(this.btnHilos_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGuardarEnBaseDeDatos
            // 
            this.btnGuardarEnBaseDeDatos.BackColor = System.Drawing.Color.Maroon;
            this.btnGuardarEnBaseDeDatos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEnBaseDeDatos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardarEnBaseDeDatos.Location = new System.Drawing.Point(943, 3);
            this.btnGuardarEnBaseDeDatos.Name = "btnGuardarEnBaseDeDatos";
            this.btnGuardarEnBaseDeDatos.Size = new System.Drawing.Size(150, 39);
            this.btnGuardarEnBaseDeDatos.TabIndex = 38;
            this.btnGuardarEnBaseDeDatos.Text = "Guardar en la base de datos";
            this.btnGuardarEnBaseDeDatos.UseVisualStyleBackColor = false;
            this.btnGuardarEnBaseDeDatos.Click += new System.EventHandler(this.btnGuardarEnBaseDeDatos_Click);
            // 
            // FrmBicis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1136, 495);
            this.Controls.Add(this.btnGuardarEnBaseDeDatos);
            this.Controls.Add(this.btnHilos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnTraerDatos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbNumeroSerie);
            this.Controls.Add(this.LblNumeroSerie);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.LblRuedas);
            this.Controls.Add(this.LblColor);
            this.Controls.Add(this.LblTituloFábricaBici);
            this.Controls.Add(this.cmbRuedas);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.btnFabricar);
            this.Controls.Add(this.groupBoxBicisFabricadas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBicis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fábrica";
            this.Load += new System.EventHandler(this.FrmBicis_Load);
            this.groupBoxBicisFabricadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFabricar;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbRuedas;
        private System.Windows.Forms.Label LblTituloFábricaBici;
        private System.Windows.Forms.Label LblColor;
        private System.Windows.Forms.Label LblRuedas;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label LblNumeroSerie;
        private System.Windows.Forms.ComboBox cmbNumeroSerie;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RichTextBox rtbBicisFabricadas;
        private System.Windows.Forms.GroupBox groupBoxBicisFabricadas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnTraerDatos;
        private System.Windows.Forms.Button btnHilos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGuardarEnBaseDeDatos;
    }
}