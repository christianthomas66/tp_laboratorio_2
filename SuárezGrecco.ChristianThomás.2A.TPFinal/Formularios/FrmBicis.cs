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
        

        /// <summary>
        /// Constructor por default del tipo FrmBicis
        /// </summary>
        public FrmBicis()
        {
            InitializeComponent();

            miFabrica = new Fabrica<Bicicleta>();

            biciMontaña = new Fabrica<BiciMontaña>();
            biciCarrera = new Fabrica<BiciCarrera>();
            this.dt = new DataTable("bicicletas");
            this.dt.Columns.Add("id", typeof(int));
            this.dt.Columns["id"].AutoIncrement = true;
            this.dt.Columns["id"].AutoIncrementSeed = 1;
            this.dt.Columns["id"].AutoIncrementStep = 1;

            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.AllowUserToAddRows = false;

            this.StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// Constructor que inicia el formulario del menú
        /// </summary>
        /// <param name="frmFábrica"></param>
        
        public FrmBicis(Fabrica<Bicicleta> frmFábrica)
        {
            miFabrica = frmFábrica;
            InitializeComponent();
        }
        /// <summary>
        /// Propiedad de miFábrica
        /// </summary>
       //public Fabrica GetFrmFábrica{ get=> miFabrica;}

        /// <summary>
        /// Inicia el 2do form con los atributos combox por default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBicis_Load(object sender, EventArgs e)
        {
            cmbColor.SelectedIndex = 1;
            cmbRuedas.SelectedIndex = 1;
            cmbMarca.SelectedIndex = 1;
            cmbNumeroSerie.SelectedIndex = 1;
        }

            
        /// <summary>
        /// Boton fabricar, al presionarlo se fabricará una nueva bicicleta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFabricar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(cmbColor.Text) && !String.IsNullOrWhiteSpace(cmbRuedas.Text) && !String.IsNullOrWhiteSpace(cmbMarca.Text))
            {
                try
                {                   
                    if(!(cmbNumeroSerie.Text.StartsWith("Sin_serie")))
                    {
                        BiciMontaña miBiciMontaña = new BiciMontaña(cmbColor.Text, cmbRuedas.Text, cmbMarca.Text, (BiciMontaña.NumeroDeSerie)cmbNumeroSerie.SelectedIndex);
                        miFabrica = miFabrica + miBiciMontaña;
                        biciTipo = BiciMontaña.TipoBici.BiciMontaña;
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
                }

                catch(FabricaExcepcion fabricaExcepcion)
                {                                        
                    MessageBox.Show($"{fabricaExcepcion.InformarNovedad()}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                               
                btnLimpiar_Click(sender, e);
            }
        }
        /// <summary>
        /// Boton que limpia los atributos combobox y los resetea
        /// </summary>
        private void Limpiar()
        {
            cmbColor.SelectedIndex = 1;
            cmbRuedas.SelectedIndex = 1;
            cmbMarca.SelectedIndex = 1;
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

        private void btnFactura_Click(object sender, EventArgs e)
        {
            try
            {
                this.biciCarrera.EventoFactura += new EventoDelegadoFactura(bici_Carrera_EventoFactura);
                this.biciCarrera += new BiciCarrera("Negro", "Shimano", "Scott");
                this.biciMontaña.EventoFactura += new EventoDelegadoFactura(bici_Montaña_EventoFactura);
                this.biciMontaña += new BiciMontaña("Blanco","Shimano", "Scott", BiciMontaña.NumeroDeSerie.Serie_1);
            }

            catch(FabricaExcepcion)
            {

            }
        }

        private void bici_Carrera_EventoFactura(object sender, EventArgs e)
        {
            bool todoOK = Facturas.GenerarFactura(biciCarrera.PrecioTotal);//Reemplazar por la llamada al método de clase ImprimirTicket

            if(todoOK)
            {
                MessageBox.Show("factura generada correctamente!!!");
            }
            else
            {
                MessageBox.Show("No se pudo generar la factura!!!");
            }
        }

        private void bici_Montaña_EventoFactura(object sender, EventArgs e)
        {
            bool todoOK = Facturas.GenerarFactura(biciMontaña.PrecioTotal);//Reemplazar por la llamada al método de clase ImprimirTicket

            if (todoOK)
            {
                MessageBox.Show("factura generada correctamente!!!");
            }
            else
            {
                MessageBox.Show("No se pudo generar la factura!!!");
            }
        }




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

        private bool GuardarDatos()
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

        private void btnGenerarDatos_Click(object sender, EventArgs e)
        {
            //Configurar el SqlConnection
            this.cn = new SqlConnection(Formularios.Properties.Settings.Default.ConexionBD);
            this.da = new SqlDataAdapter();
            //Configurar el SqlDataAdapter (y su selectCommand)                        

            this.da.SelectCommand = new SqlCommand("SELECT id, Color,Marca,Ruedas,NumeroSerie FROM BicisTable", this.cn);
            TraerDatos();
            this.da.Fill(this.dt);
            this.dataGridView1.DataSource = this.dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.da.InsertCommand = new SqlCommand("INSERT INTO BicisTable(marca,tipo,precio) VALUES(@marca,@tipo,@precio)", this.cn);
            this.da.InsertCommand.Parameters.Add("@Color", SqlDbType.VarChar, 50, "Color");
            this.da.InsertCommand.Parameters.Add("@Marca", SqlDbType.VarChar, 50, "Marca");
            this.da.InsertCommand.Parameters.Add("@Ruedas", SqlDbType.VarChar, 50, "Ruedas");
            this.da.InsertCommand.Parameters.Add("@NumeroSerie", SqlDbType.Int, 50, "NumeroSerie");

            //Configurar el insertCommand del SqlDataAdapter y sus parámetros            
            //Agregar los utiles del formulario al dataTable (crear filas)                       
            DataRow fila = this.dt.NewRow();
            DataRow fila2 = this.dt.NewRow();

            fila[1] = bMontaña.Color;
            fila[4] = bMontaña.Marca;
            fila[3] = bMontaña.Ruedas;
            fila[2] = bMontaña.GetType().Name;

            fila2[1] = bCarrera.Color;
            fila2[4] = bCarrera.Marca;
            fila2[3] = bCarrera.Ruedas;
            fila2[2] = bCarrera.GetType().Name;


            this.dt.Rows.Add(fila);
            this.dt.Rows.Add(fila2);            

            this.dataGridView1.DataSource = this.dt;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.da.DeleteCommand = new SqlCommand("DELETE FROM BicisTable WHERE id=@id", this.cn);
            this.da.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 10, "id");
            //this.dt.Rows[0].Delete();
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            this.dataGridView1.DataSource = this.dt;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.da.UpdateCommand = new SqlCommand("UPDATE BicisTable SET Color=@Color,Marca=@Marca,Ruedas=@Ruedas,NumeroSerie=@NumeroSerie WHERE id=@id", this.cn);
            this.da.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 10, "id");
            this.da.UpdateCommand.Parameters.Add("@Color", SqlDbType.VarChar, 50, "Color");
            this.da.UpdateCommand.Parameters.Add("@Marca", SqlDbType.VarChar, 10, "Marca");
            this.da.UpdateCommand.Parameters.Add("@Ruedas", SqlDbType.VarChar, 10, "Ruedas");
            this.da.UpdateCommand.Parameters.Add("@NumeroSerie", SqlDbType.Int, 10, "NumeroSerie");

            //Modificar el último registro del dataTable
            DataRow fila = dt.Rows[dt.Rows.Count - 1];

            fila[2] = "Bmx";
            fila[1] = "Marron";
        }

        private void btnVerUbicacionLog_Click(object sender, EventArgs e)
        {          
            this.openFileDialog1.Title = "Abrir archivo de tickets";
            this.openFileDialog1.InitialDirectory = @"C:\Users\Thomas Pc\Documentos";
            this.openFileDialog1.DefaultExt = ".log";
            this.openFileDialog1.FileName = "facturas";

            DialogResult ruta = this.openFileDialog1.ShowDialog();

            if (ruta == DialogResult.OK)
            {
                txtFactura.Text = new System.IO.StreamReader(this.openFileDialog1.OpenFile(), Encoding.UTF8).ReadToEnd();                
            }
        }
    }
}
