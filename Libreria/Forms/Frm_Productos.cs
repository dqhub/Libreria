using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Libreria.Forms
{
    public partial class Frm_Productos : Form
    {
        bool editarEstado = false;
        bool DBVacia = true;

        int editarid;

        public Frm_Productos()
        {
            InitializeComponent();
        }

        /*****************************************       **********************************       *****************************************/
        /*****************************************       ***** MÉTODOS DEL FORMULARIO *****       *****************************************/
        /*****************************************       **********************************       *****************************************/

        /******* MÉTODOS FUNCIONALES *******/

        private void LimpiarForm()
        {
            txt_ProdCodigo.Text = "";
            txt_ProdDescripcion.Text = "";
            txt_ProdCantStock.Text = "";
            cmb_ProdUnidadMed.Text = "";
            txt_ProdMargenGanancia.Text = "";
            txt_ProdPrecioVenta.Text = "";

            txt_ProdCodigo.Select();
        }
        public void ActualizarLista()
        {
            editarEstado = false;
            string query = "SELECT prodid, codigo as Codigo, descripcion as Descripcion, stock as 'Cantidad en Stock', unidadmedida as 'Unidad de Medidad', margen as 'Margen de Ganancia' " +
                           "FROM producto";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            MySqlDataAdapter DBAdaptador = new MySqlDataAdapter(query, DB);
            DataTable DBVirtual = new DataTable();
            DBAdaptador.Fill(DBVirtual);
            if (DBVirtual.Rows.Count == 0)
            {
                DBVacia = true;
                dgv_ProdLista.DataSource = DBVirtual;
                dgv_ProdLista.Columns[0].Visible = false;
            }
            else
            {
                DBVacia = false;
                dgv_ProdLista.DataSource = DBVirtual;
                dgv_ProdLista.Columns[0].Visible = false;
            }

            btn_ProdGuardar.Enabled = false;
            btn_ProdEliminar.Enabled = false;
            btn_ProdEditar.Enabled = false;

            ActivarBtnGuardar();
        }
        public void ActivarBtnGuardar()
        {
            bool vacio = false;
            if (txt_ProdCodigo.Text == "") { vacio = true; }
            if (txt_ProdDescripcion.Text == "") { vacio = true; }
            if (txt_ProdCantStock.Text == "") { vacio = true; }
            if (cmb_ProdUnidadMed.Text == "") { vacio = true; }
            if (txt_ProdMargenGanancia.Text == "") { vacio = true; }

            if (vacio == false) { btn_ProdGuardar.Enabled = true; }
            else { btn_ProdGuardar.Enabled = false; }
        }


        /*****************************************       **********************************       *****************************************/
        /*****************************************       ***** EVENTOS DEL FORMULARIO *****       *****************************************/
        /*****************************************       **********************************       *****************************************/

        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        /****** EVENTOS DE BOTONES ******/

        private void btn_ProdGuardar_Click(object sender, EventArgs e)
        {
            Clases.Productos ProdA = new Clases.Productos();

            ProdA.ProdCodigo = txt_ProdCodigo.Text.ToString();
            ProdA.ProdDescripcion = txt_ProdDescripcion.Text.ToString();
            ProdA.ProdCantStock = txt_ProdCantStock.Text.ToString();
            ProdA.ProdUnidadMed = cmb_ProdUnidadMed.SelectedItem.ToString();
            ProdA.ProMargenGanancia = txt_ProdMargenGanancia.Text.ToString();

            if (editarEstado != true)
            {
                Clases.Metodos.GuardarProducto(ProdA);
            }
            else
            {
                Clases.Metodos.EditarProducto(editarid, ProdA);
            }

            LimpiarForm();
            ActualizarLista();

        }
        private void btn_ProdEliminar_Click(object sender, EventArgs e)
        {
            if (DBVacia == false)
            {
                DialogResult respuesta = 0;
                respuesta = Clases.Metodos.MensajeEliminarPregunta();

                if (respuesta == DialogResult.Yes)
                {
                    int id = 0;
                    id = int.Parse(dgv_ProdLista.SelectedCells[0].Value.ToString());

                    Clases.Metodos.EliminarProveedor(id);
                    LimpiarForm();
                    ActualizarLista();

                    btn_ProdEditar.Enabled = false;
                    btn_ProdEliminar.Enabled = false;
                }
            }
            else
            {
                Clases.Metodos.MensajeBaseVacia();
            }
        }
        private void btn_ProdEditar_Click(object sender, EventArgs e)
        {
            if (DBVacia == false)
            {
                editarEstado = true;
                editarid = 0;
                editarid = int.Parse(dgv_ProdLista.SelectedCells[0].Value.ToString());

                txt_ProdCodigo.Text = dgv_ProdLista.SelectedCells[1].Value.ToString();
                txt_ProdDescripcion.Text = dgv_ProdLista.SelectedCells[2].Value.ToString();
                txt_ProdCantStock.Text = dgv_ProdLista.SelectedCells[3].Value.ToString();
                cmb_ProdUnidadMed.Text = dgv_ProdLista.SelectedCells[4].Value.ToString();
                txt_ProdMargenGanancia.Text = dgv_ProdLista.SelectedCells[5].Value.ToString();
            }
            else
            {
                Clases.Metodos.MensajeBaseVacia();
            }

            txt_ProdCodigo.Select();
            btn_ProdEditar.Enabled = false;
            btn_ProdEliminar.Enabled = false;
        }


        /****** EVENTOS DE TEXTBOX ******/

        private void txt_ProdCodigo_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }
        private void txt_ProdDescripcion_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }
        private void txt_ProdCantStock_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }
        private void cmb_ProdUnidadMed_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }
        private void txt_ProdMargenGanancia_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }


        /****** EVENTOS DE DATA GRID VIEW ******/

        private void dgv_ProdLista_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            btn_ProdEditar.Enabled = true;
            btn_ProdEliminar.Enabled = true;
        }
    }
}
