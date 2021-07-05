using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria.Forms
{
    public partial class Frm_Proveedores : Form
    {
        bool editarEstado = false;
        bool DBVacia = true;

        int editarid;

        public Frm_Proveedores()
        {
            InitializeComponent();
        }


        /*****************************************       **********************************       *****************************************/
        /*****************************************       ***** MÉTODOS DEL FORMULARIO *****       *****************************************/
        /*****************************************       **********************************       *****************************************/

        /******* MÉTODOS FUNCIONALES *******/

        private void LimpiarForm()
        {

            txt_ProvCUIT.Text = "";
            txt_ProvNombre.Text = "";
            txt_ProvDomicilio.Text = "";
            txt_ProvIngBrutos.Text = "";
            cmb_ProvCondicionIVA.Text = null;
            cmb_ProvCondicionVenta.Text = null;
            txt_ProvContacto.Text = "";
            txt_ProvMail.Text = "";
            txt_ProvTelefono1.Text = "";
            txt_ProvTelefono2.Text = "";

            txt_ProvCUIT.Select();
        }
        public void ActualizarLista()
        {
            editarEstado = false;
            string query = "SELECT provid, fechaalta as 'Fecha de Alta', cuit as CUIT, razonsocial as 'Razon Social', domicilio as Domicilio, ingresosbrutos as 'Ingresos Brutos', " +
                                "condicioniva as 'Condicion frente IVA', condicionventa as 'Condicion de Venta', nombrecontacto as 'Nombre de Contacto', email as Email, " +
                                "telefono as 'Telefono 1', telefono2 as 'Telefono 2' " +
                           "FROM proveedor";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();

            MySqlDataAdapter DBAdaptador = new MySqlDataAdapter(query, DB);
            DataTable DBVirtualp = new DataTable();
            DBAdaptador.Fill(DBVirtualp);

            if (DBVirtualp.Rows.Count == 0)
            {
                DBVacia = true;
                dgv_ProvLista.DataSource = DBVirtualp;
                dgv_ProvLista.Columns[0].Visible = false;
            }
            else
            {
                DBVacia = false;
                dgv_ProvLista.DataSource = DBVirtualp;
                dgv_ProvLista.Columns[0].Visible = false;
            }

            btn_ProvGuardar.Enabled = false;
            btn_ProvEliminar.Enabled = false;
            btn_ProvEditar.Enabled = false;

            ActivarBtnGuardar();
        }
        public void ActivarBtnGuardar()
        {
            bool vacio = false;
            if (txt_ProvCUIT.Text == "") { vacio = true; }
            if (txt_ProvNombre.Text == "") { vacio = true; }
            if (txt_ProvDomicilio.Text == "") { vacio = true; }
            if (txt_ProvIngBrutos.Text == "") { vacio = true; }
            if (cmb_ProvCondicionIVA.Text == "") { vacio = true; }
            if (cmb_ProvCondicionVenta.Text == "") { vacio = true; }
            if (txt_ProvContacto.Text == "") { vacio = true; }
            if (txt_ProvMail.Text == "") { vacio = true; }
            if (txt_ProvTelefono1.Text == "") { vacio = true; }
            if (txt_ProvTelefono2.Text == "") { vacio = true; }

            if (vacio == false) { btn_ProvGuardar.Enabled = true; }
            else { btn_ProvGuardar.Enabled = false; }
        }


        /*****************************************       **********************************       *****************************************/
        /*****************************************       ***** EVENTOS DEL FORMULARIO *****       *****************************************/
        /*****************************************       **********************************       *****************************************/

        private void Frm_Proveedores_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        /****** EVENTOS DE BOTONES ******/

        private void btn_ProvGuardar_Click(object sender, EventArgs e)
        {
            Clases.Proveedores ProvA = new Clases.Proveedores();

            ProvA.ProvCUIT = txt_ProvCUIT.Text.ToString();
            ProvA.ProvNombreRS = txt_ProvNombre.Text.ToString();
            ProvA.ProvDomicilio = txt_ProvDomicilio.Text.ToString();
            ProvA.ProvIngBrutos = txt_ProvIngBrutos.Text.ToString();
            ProvA.ProvCondicionIVA = cmb_ProvCondicionIVA.SelectedItem.ToString();
            ProvA.ProvCondicionVenta = cmb_ProvCondicionVenta.SelectedItem.ToString();
            ProvA.ProvContacto = txt_ProvContacto.Text.ToString();
            ProvA.ProvMail = txt_ProvMail.Text.ToString();
            ProvA.ProvTelefono1 = txt_ProvTelefono1.Text.ToString();
            ProvA.ProvTelefono2 = txt_ProvTelefono2.Text.ToString();

            if (editarEstado != true)
            {
                Clases.Metodos.GuardarProveedor(ProvA);
            }
            else
            {
                Clases.Metodos.EditarProveedor(editarid, ProvA);
            }

            LimpiarForm();
            ActualizarLista();

        }
        private void btn_ProvEliminar_Click(object sender, EventArgs e)
        {
            if (DBVacia == false)
            {
                DialogResult respuesta = 0;
                respuesta = Clases.Metodos.MensajeEliminarPregunta();

                if (respuesta == DialogResult.Yes)
                {
                    int id = 0;
                    id = int.Parse(dgv_ProvLista.SelectedCells[0].Value.ToString());

                    Clases.Metodos.EliminarProveedor(id);
                    LimpiarForm();
                    ActualizarLista();

                    btn_ProvEditar.Enabled = false;
                    btn_ProvEliminar.Enabled = false;
                }
            }
            else
            {
                Clases.Metodos.MensajeBaseVacia();
            }
        }
        private void btn_ProvEditar_Click(object sender, EventArgs e)
        {
            if (DBVacia == false)
            {
                editarEstado = true;
                editarid = 0;
                editarid = int.Parse(dgv_ProvLista.SelectedCells[0].Value.ToString());

                txt_ProvCUIT.Text = dgv_ProvLista.SelectedCells[2].Value.ToString();
                txt_ProvNombre.Text = dgv_ProvLista.SelectedCells[3].Value.ToString();
                txt_ProvDomicilio.Text = dgv_ProvLista.SelectedCells[4].Value.ToString();
                txt_ProvIngBrutos.Text = dgv_ProvLista.SelectedCells[5].Value.ToString();
                cmb_ProvCondicionIVA.Text = dgv_ProvLista.SelectedCells[6].Value.ToString();
                cmb_ProvCondicionVenta.Text = dgv_ProvLista.SelectedCells[7].Value.ToString();
                txt_ProvContacto.Text = dgv_ProvLista.SelectedCells[8].Value.ToString();
                txt_ProvMail.Text = dgv_ProvLista.SelectedCells[9].Value.ToString();
                txt_ProvTelefono1.Text = dgv_ProvLista.SelectedCells[10].Value.ToString();
                txt_ProvTelefono2.Text = dgv_ProvLista.SelectedCells[11].Value.ToString();
            }
            else
            {
                Clases.Metodos.MensajeBaseVacia();
            }

            txt_ProvCUIT.Select();
            btn_ProvEditar.Enabled = false;
            btn_ProvEliminar.Enabled = false;
        }


        /****** EVENTOS DE TEXTBOX ******/

        private void txt_ProvCUIT_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }
        private void txt_ProvNombre_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }
        private void txt_ProvDomicilio_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }
        private void txt_ProvIngBrutos_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }
        private void txt_ProvContacto_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }
        private void txt_ProvMail_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }
        private void txt_ProvTelefono1_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }
        private void txt_ProvTelefono2_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }


        /****** EVENTOS DE COMBOS ******/

        private void cmb_ProvCondicionIVA_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }
        private void cmb_ProvCondicionVenta_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }

        /****** EVENTOS DE DATA GRID VIEW ******/

        private void dgv_ProvLista_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            btn_ProvEditar.Enabled = true;
            btn_ProvEliminar.Enabled = true;
        }
    }
}