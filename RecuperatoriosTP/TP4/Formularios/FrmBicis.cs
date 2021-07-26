using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;
using System.Data.SqlClient;
using Formularios;
using System.Threading;
using static Entidades.Bicicleta;

namespace WindowsFormsApp1
{
    public partial class FrmBicis : Form
    {
        private Bicicleta.TipoBici biciTipo;
        private BiciMontaña bMontaña;
        private BiciCarrera bCarrera;

        private Fabrica<Bicicleta> miFabrica;
        
        private Fabrica<BiciCarrera> biciCarrera;       
        private Fabrica<BiciMontaña> biciMontaña;


        private SqlConnection cn;
        private SqlDataAdapter da;
        private DataTable dt;

        private delegate void DeleagadoDeTexto(string texto);
        //private delegate void EventHandler(object sender, EventArgs e);

        private Button boton;
        private TextBox txtBox1;
        private Thread hilo = null;

        /// <summary>
        /// Constructor por default del tipo FrmBicis
        /// </summary>
        public FrmBicis()
        {
            InitializeComponent();

            miFabrica = new Fabrica<Bicicleta>();

            //biciMontaña = new Fabrica<BiciMontaña>();
            //biciCarrera = new Fabrica<BiciCarrera>();

            this.dt = new DataTable("BicisTable");
            this.da = new SqlDataAdapter();
            this.cn = new SqlConnection(Formularios.Properties.Settings.Default.ConexionBD);          

            boton = new Button
            {
                Location = new Point(10, 40),
                Size = new Size(240, 50),                
            };

            boton.Hide();            
            boton.Click += new EventHandler(btnHilos_Click);

            txtBox1 = new TextBox
            {
                Location = new Point(15, 15),
                Size = new Size(500, 20)
            };
            Controls.Add(boton);
            Controls.Add(txtBox1);
            this.dt.Columns.Add("id", typeof(int));
            this.dt.Columns["id"].AutoIncrement = true;
            this.dt.Columns["id"].AutoIncrementSeed = 1;
            this.dt.Columns["id"].AutoIncrementStep = 1;

            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Ruedas", typeof(string));
            dt.Columns.Add("Marca", typeof(string));
            dt.Columns.Add("NumeroSerie", typeof(string));

            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.AllowUserToAddRows = false;            
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// Constructor que inicia el formulario del menú
        /// </summary>
        /// <param name="frmFábrica"></param>
        
        public FrmBicis(Fabrica<Bicicleta> frmFábrica) : this()
        {
            miFabrica = frmFábrica;            
        }        

        /// <summary>
        /// Inicia el 2do form con los atributos combox por default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBicis_Load(object sender, EventArgs e)
        {
            cmbColor.SelectedIndex = 0;
            cmbRuedas.SelectedIndex = 0;
            cmbMarca.SelectedIndex = 0;
            cmbNumeroSerie.SelectedIndex = 1;

            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

            
        /// <summary>
        /// Boton fabricar, al presionarlo se fabricará una nueva bicicleta yse agregara al dataGridView para despues guardarlos en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFabricar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(cmbColor.Text) && 
                !String.IsNullOrWhiteSpace(cmbRuedas.Text) && 
                !String.IsNullOrWhiteSpace(cmbMarca.Text) && 
                !String.IsNullOrWhiteSpace(cmbNumeroSerie.Text))
            {
                try
                {                   
                    if(!(cmbNumeroSerie.Text.StartsWith("Sin_serie")))
                    {
                        Enum.TryParse(cmbNumeroSerie.SelectedItem.ToString(), out NumeroDeSerie serie);
                        BiciMontaña miBiciMontaña = new BiciMontaña(cmbColor.Text, cmbRuedas.Text, cmbMarca.Text, serie);
                        miFabrica = miFabrica + miBiciMontaña;                       
                        biciTipo = Bicicleta.TipoBici.BiciMontaña;
                        MessageBox.Show("Bicicleta del tipo montaña fabricada con exito!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                        
                    }
                    else
                    {
                        BiciCarrera miBiciCarrera = new BiciCarrera(cmbColor.Text, cmbRuedas.Text, cmbMarca.Text);
                        miFabrica = miFabrica + miBiciCarrera;
                        biciTipo = Bicicleta.TipoBici.BiciCarrera;                        
                        MessageBox.Show("Bicicleta del tipo carrera fabricada con exito!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    
                    rtbBicisFabricadas.Text = miFabrica.ToString();
                    ActualizarData();                    
                }

                catch(FabricaExcepcion fabricaExcepcion)
                {                                        
                    MessageBox.Show($"{fabricaExcepcion.InformarNovedad()}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                               
                btnLimpiar_Click(sender, e);
            }
        }
        /// <summary>
        /// Boton que limpia los atributos combobox y los resetea por default
        /// </summary>
        private void Limpiar()
        {
            txtBox1.Text = "";
            cmbColor.SelectedIndex = 0;
            cmbRuedas.SelectedIndex = 0;
            cmbMarca.SelectedIndex = 0;
            cmbNumeroSerie.SelectedIndex = 1;
        }
        /// <summary>
        /// Boton que llama al método limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }                
        /// <summary>
        /// Botón que cierra el 2do form y vuelve al menú
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmMenu.miFabrica.Bicicleta = miFabrica.Bicicletas;
            Dispose();
        }                    
        
        /// <summary>
        /// Metodo que trae datos generados desde el SQL Server
        /// </summary>
        /// <returns> Devuelve los datos del DataTable </returns>
        public DataTable TraerDatos()
        {
            try
            {
                this.da.Fill(this.dt);
            }
            catch(Exception e)
            {
                throw e;
            }
            return this.dt;
        }
        /// <summary>
        /// Metodo que guarda los datos hacia el SQL Server
        /// </summary>
        /// <returns> Devuelve true </returns>
        public bool GuardarDatos()
        {
            try
            {
                this.da.Update(this.dt);
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Evento que hace la conexion y llama al metodo TraerDatos desde el SQL Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTraerDatos_Click(object sender, EventArgs e)
        {            
            this.dataGridView1.DataSource = null;
            this.da.SelectCommand = new SqlCommand("SELECT * FROM BicisTable", this.cn);
            this.dataGridView1.DataSource = TraerDatos(); 
        }
                        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                this.da.DeleteCommand = new SqlCommand("DELETE FROM BicisTable WHERE id=@id", this.cn);
                this.da.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 10, "id");            
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
                this.dataGridView1.DataSource = this.dt;
            }

            catch(Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
              
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHilos_Click(object sender, EventArgs e)
        {
            hilo = new Thread(new ThreadStart(TextoHilo));
            hilo.Start();
            Thread.Sleep(10);            
        }

        private void VerificarFuncionamiento(string text)
        {
            if (txtBox1.InvokeRequired)
            {
                var d = new DeleagadoDeTexto(VerificarFuncionamiento);
                txtBox1.Invoke(d, new object[] { text });
            }
            else
            {
                txtBox1.Text = text;
            }
        }
        private void TextoHilo()
        {
            VerificarFuncionamiento("Este texto se ha escrito correctamente");
        }
        /// <summary>
        /// 
        /// </summary>
       
        private void ActualizarData()
        {
            this.dataGridView1.DataSource = null;            
            this.dataGridView1.DataSource = miFabrica.Bicicletas;            
        }
        /// <summary>
        /// Evento que hace la conexion y agrega al metodo TraerDatos desde el SQL Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarEnBaseDeDatos_Click(object sender, EventArgs e)
        {
            this.da.InsertCommand = new SqlCommand("INSERT INTO BicisTable(Color,Ruedas,Marca,NumeroSerie) VALUES(@Color,@Ruedas,@Marca,@NumeroSerie)", this.cn);
            this.da.InsertCommand.Parameters.Add("@Color", SqlDbType.VarChar, 50, "Color");
            this.da.InsertCommand.Parameters.Add("@Ruedas", SqlDbType.VarChar, 50, "Ruedas");
            this.da.InsertCommand.Parameters.Add("@Marca", SqlDbType.VarChar, 50, "Marca");
            this.da.InsertCommand.Parameters.Add("@NumeroSerie", SqlDbType.VarChar, 50, "NumeroSerie");
            
            List<DataRow> listaBicis = new List<DataRow>();
            DataRow fila2 = this.dt.NewRow();
            
            
            
            foreach(Bicicleta item in miFabrica.Bicicletas)
            {                
                DataRow fila = this.dt.NewRow();
                fila[0] = item.Id;
                fila[1] = item.Color;
                fila[2] = item.Ruedas;
                fila[3] = item.Marca;
                fila[4] = item.Serie;
                this.dt.Rows.Add(fila);
            }

            this.dataGridView1.DataSource = this.dt;            
            if(GuardarDatos())
            {
                MessageBox.Show("Datos guardados en el data base con exito!!!");
                this.dataGridView1.DataSource = null;
                this.dt.Clear();
            }
            else
            {
                MessageBox.Show("No se han guardado los datos!!!\n");
            }          
        }                
    }
}
