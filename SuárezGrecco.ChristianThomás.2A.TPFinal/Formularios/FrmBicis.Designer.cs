
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
            this.btnFactura = new System.Windows.Forms.Button();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGenerarDatos = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnVerUbicacionLog = new System.Windows.Forms.Button();
            this.groupBoxBicisFabricadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFabricar
            // 
            this.btnFabricar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFabricar.Location = new System.Drawing.Point(13, 274);
            this.btnFabricar.Name = "btnFabricar";
            this.btnFabricar.Size = new System.Drawing.Size(231, 56);
            this.btnFabricar.TabIndex = 0;
            this.btnFabricar.Text = "Fabricar";
            this.btnFabricar.UseVisualStyleBackColor = true;
            this.btnFabricar.Click += new System.EventHandler(this.btnFabricar_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "1. Specialized",
            "2. Scott",
            "3. Trek",
            "4. Giant"});
            this.cmbMarca.Location = new System.Drawing.Point(85, 210);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(77, 21);
            this.cmbMarca.TabIndex = 10;
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbColor.Location = new System.Drawing.Point(26, 124);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(77, 21);
            this.cmbColor.TabIndex = 11;
            // 
            // cmbRuedas
            // 
            this.cmbRuedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRuedas.FormattingEnabled = true;
            this.cmbRuedas.Items.AddRange(new object[] {
            "1. Shimano",
            "2. Zipp",
            "3. Supra",
            "4. HED"});
            this.cmbRuedas.Location = new System.Drawing.Point(147, 124);
            this.cmbRuedas.Name = "cmbRuedas";
            this.cmbRuedas.Size = new System.Drawing.Size(80, 21);
            this.cmbRuedas.TabIndex = 12;
            // 
            // LblTituloFábricaBici
            // 
            this.LblTituloFábricaBici.AutoSize = true;
            this.LblTituloFábricaBici.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloFábricaBici.Location = new System.Drawing.Point(301, 9);
            this.LblTituloFábricaBici.Name = "LblTituloFábricaBici";
            this.LblTituloFábricaBici.Size = new System.Drawing.Size(442, 55);
            this.LblTituloFábricaBici.TabIndex = 13;
            this.LblTituloFábricaBici.Text = "Fabrica tu bicicleta";
            // 
            // LblColor
            // 
            this.LblColor.AutoSize = true;
            this.LblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblColor.Location = new System.Drawing.Point(26, 92);
            this.LblColor.Name = "LblColor";
            this.LblColor.Size = new System.Drawing.Size(77, 29);
            this.LblColor.TabIndex = 14;
            this.LblColor.Text = "Color";
            // 
            // LblRuedas
            // 
            this.LblRuedas.AutoSize = true;
            this.LblRuedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRuedas.Location = new System.Drawing.Point(142, 92);
            this.LblRuedas.Name = "LblRuedas";
            this.LblRuedas.Size = new System.Drawing.Size(102, 29);
            this.LblRuedas.TabIndex = 15;
            this.LblRuedas.Text = "Ruedas";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarca.Location = new System.Drawing.Point(85, 178);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(84, 29);
            this.LblMarca.TabIndex = 16;
            this.LblMarca.Text = "Marca";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(13, 356);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(231, 58);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // LblNumeroSerie
            // 
            this.LblNumeroSerie.AutoSize = true;
            this.LblNumeroSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroSerie.Location = new System.Drawing.Point(403, 92);
            this.LblNumeroSerie.Name = "LblNumeroSerie";
            this.LblNumeroSerie.Size = new System.Drawing.Size(188, 25);
            this.LblNumeroSerie.TabIndex = 24;
            this.LblNumeroSerie.Text = "Numero de Serie";
            // 
            // cmbNumeroSerie
            // 
            this.cmbNumeroSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumeroSerie.FormattingEnabled = true;
            this.cmbNumeroSerie.Items.AddRange(new object[] {
            "Sin_serie",
            "Serie_1",
            "Serie_2",
            "Serie_3"});
            this.cmbNumeroSerie.Location = new System.Drawing.Point(408, 124);
            this.cmbNumeroSerie.Name = "cmbNumeroSerie";
            this.cmbNumeroSerie.Size = new System.Drawing.Size(183, 21);
            this.cmbNumeroSerie.TabIndex = 25;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(65, 445);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 58);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rtbBicisFabricadas
            // 
            this.rtbBicisFabricadas.Location = new System.Drawing.Point(31, 18);
            this.rtbBicisFabricadas.Name = "rtbBicisFabricadas";
            this.rtbBicisFabricadas.ReadOnly = true;
            this.rtbBicisFabricadas.Size = new System.Drawing.Size(334, 397);
            this.rtbBicisFabricadas.TabIndex = 27;
            this.rtbBicisFabricadas.Text = "";
            // 
            // groupBoxBicisFabricadas
            // 
            this.groupBoxBicisFabricadas.Controls.Add(this.rtbBicisFabricadas);
            this.groupBoxBicisFabricadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBicisFabricadas.Location = new System.Drawing.Point(296, 274);
            this.groupBoxBicisFabricadas.Name = "groupBoxBicisFabricadas";
            this.groupBoxBicisFabricadas.Size = new System.Drawing.Size(447, 229);
            this.groupBoxBicisFabricadas.TabIndex = 28;
            this.groupBoxBicisFabricadas.TabStop = false;
            this.groupBoxBicisFabricadas.Text = "Bicis fabricadas";
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(462, 150);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(68, 39);
            this.btnFactura.TabIndex = 29;
            this.btnFactura.Text = "Generar factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(408, 195);
            this.txtFactura.Multiline = true;
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(183, 73);
            this.txtFactura.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(749, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 419);
            this.dataGridView1.TabIndex = 31;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(943, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 23);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(790, 42);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 23);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(943, 42);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 23);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGenerarDatos
            // 
            this.btnGenerarDatos.Location = new System.Drawing.Point(790, 13);
            this.btnGenerarDatos.Name = "btnGenerarDatos";
            this.btnGenerarDatos.Size = new System.Drawing.Size(135, 23);
            this.btnGenerarDatos.TabIndex = 35;
            this.btnGenerarDatos.Text = "Generar datos";
            this.btnGenerarDatos.UseVisualStyleBackColor = true;
            this.btnGenerarDatos.Click += new System.EventHandler(this.btnGenerarDatos_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnVerUbicacionLog
            // 
            this.btnVerUbicacionLog.Location = new System.Drawing.Point(296, 195);
            this.btnVerUbicacionLog.Name = "btnVerUbicacionLog";
            this.btnVerUbicacionLog.Size = new System.Drawing.Size(106, 73);
            this.btnVerUbicacionLog.TabIndex = 36;
            this.btnVerUbicacionLog.Text = "Ver log";
            this.btnVerUbicacionLog.UseVisualStyleBackColor = true;
            this.btnVerUbicacionLog.Click += new System.EventHandler(this.btnVerUbicacionLog_Click);
            // 
            // FrmBicis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Formularios.Properties.Resources._57_577559_s;
            this.ClientSize = new System.Drawing.Size(1136, 515);
            this.Controls.Add(this.btnVerUbicacionLog);
            this.Controls.Add(this.btnGenerarDatos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbNumeroSerie);
            this.Controls.Add(this.LblNumeroSerie);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.LblRuedas);
            this.Controls.Add(this.LblColor);
            this.Controls.Add(this.LblTituloFábricaBici);
            this.Controls.Add(this.cmbRuedas);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.btnFabricar);
            this.Controls.Add(this.groupBoxBicisFabricadas);
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
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGenerarDatos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnVerUbicacionLog;
    }
}