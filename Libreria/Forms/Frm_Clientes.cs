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
    public partial class Frm_Clientes : Form
    {
        bool editarEstado = false;
        bool DBVacia = true;

        int editarid;

        public Frm_Clientes()
        {
            InitializeComponent();
        }


        /*****************************************       **********************************       *****************************************/
        /*****************************************       ***** MÉTODOS DEL FORMULARIO *****       *****************************************/
        /*****************************************       **********************************       *****************************************/

        /******* MÉTODOS FUNCIONALES *******/

        private void LimpiarForm()
        {

            txt_ClieCUIT.Text = "";
            txt_ClieNombre.Text = "";
            txt_ClieDomicilio.Text = "";
            txt_ClieIngBrutos.Text = "";
            cmb_ClieCondicionIVA.Text = null;
            txt_ClieContacto.Text = "";
            txt_ClieMail.Text = "";
            txt_ClieTelefono1.Text = "";
            txt_ClieTelefono2.Text = "";

            txt_ClieCUIT.Select();
        }
        public void ActualizarClienteLista()
        {
            editarEstado = false;
            string query = "SELECT * FROM cliente";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            MySqlDataAdapter DBAdaptador = new MySqlDataAdapter(query, DB);
            DataTable DBVirtual = new DataTable();
            DBAdaptador.Fill(DBVirtual);
            if (DBVirtual.Rows.Count == 0)
            {
                DBVacia = true;
                dgv_ClieLista.DataSource = DBVirtual;
            }
            else
            {
                DBVacia = false;
                dgv_ClieLista.DataSource = DBVirtual;
            }

            btn_ClieGuardar.Enabled = false;
            btn_ClieEliminar.Enabled = false;
            btn_ClieEditar.Enabled = false;

            ActivarBtnGuardar();
        }
        public void ActivarBtnGuardar()
        {
            bool vacio = false;
            if (txt_ClieCUIT.Text == "")
                vacio = true;
            if (txt_ClieNombre.Text == "")
                vacio = true;
            if (txt_ClieDomicilio.Text == "")
                vacio = true;
            if (txt_ClieIngBrutos.Text == "")
                vacio = true;
            if (cmb_ClieCondicionIVA.Text == "")
                vacio = true;
            if (txt_ClieContacto.Text == "")
                vacio = true;
            if (txt_ClieMail.Text == "")
                vacio = true;
            if (txt_ClieTelefono1.Text == "")
                vacio = true;
            if (txt_ClieTelefono2.Text == "")
                vacio = true;

            if (vacio == false)
                btn_ClieGuardar.Enabled = true;
            else
                btn_ClieGuardar.Enabled = false;
        }

        /*****************************************       **********************************       *****************************************/
        /*****************************************       ***** EVENTOS DEL FORMULARIO *****       *****************************************/
        /*****************************************       **********************************       *****************************************/

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            ActualizarClienteLista();
        }

        /****** EVENTOS DE BOTONES ******/

        private void btn_ClieGuardar_Click(object sender, EventArgs e)
        {
            Clases.Clientes clientA = new Clases.Clientes();


            clientA.ClieCUIT = txt_ClieCUIT.Text.ToString();
            clientA.ClieNombreRS = txt_ClieNombre.Text.ToString();
            clientA.ClieDomicilio = txt_ClieDomicilio.Text.ToString();
            clientA.ClieIngBrutos = txt_ClieIngBrutos.Text.ToString();
            clientA.ClieCondicionIVA = cmb_ClieCondicionIVA.ToString();
            clientA.ClieContacto = txt_ClieContacto.Text.ToString();
            clientA.ClieMail = txt_ClieMail.Text.ToString();
            clientA.ClieTelefono1 = txt_ClieTelefono1.Text.ToString();
            clientA.ClieTelefono2 = txt_ClieTelefono2.Text.ToString();

            if (editarEstado != true)
            {
                Clases.MetodosDB.GuardarCliente(clientA);
            }
            else
            {
                Clases.MetodosDB.EditarCliente(editarid, clientA);
            }

            LimpiarForm();
            ActualizarClienteLista();

        }
        private void btn_ClieEliminar_Click(object sender, EventArgs e)
        {
            if (DBVacia == false)
            {
                DialogResult respuesta = 0;
                respuesta = Clases.MetodosDB.MensajeEliminarPregunta();

                if (respuesta == DialogResult.Yes)
                {
                    int id = 0;
                    id = int.Parse(dgv_ClieLista.SelectedCells[0].Value.ToString());

                    Clases.MetodosDB.EliminarCliente(id);
                    LimpiarForm();
                    ActualizarClienteLista();

                    btn_ClieEditar.Enabled = false;
                    btn_ClieEliminar.Enabled = false;
                }
            }
            else
            {
                Clases.MetodosDB.MensajeBaseVacia();
            }
        }
        private void btn_ClieEditar_Click(object sender, EventArgs e)
        {
            if (DBVacia == false)
            {
                editarEstado = true;
                editarid = 0;
                editarid = int.Parse(dgv_ClieLista.SelectedCells[0].Value.ToString());

                txt_ClieCUIT.Text = dgv_ClieLista.SelectedCells[2].Value.ToString();
                txt_ClieNombre.Text = dgv_ClieLista.SelectedCells[3].Value.ToString();
                txt_ClieDomicilio.Text = dgv_ClieLista.SelectedCells[4].Value.ToString();
                txt_ClieIngBrutos.Text = dgv_ClieLista.SelectedCells[5].Value.ToString();
                cmb_ClieCondicionIVA.Text = dgv_ClieLista.SelectedCells[6].Value.ToString();
                txt_ClieContacto.Text = dgv_ClieLista.SelectedCells[7].Value.ToString();
                txt_ClieMail.Text = dgv_ClieLista.SelectedCells[8].Value.ToString();
                txt_ClieTelefono1.Text = dgv_ClieLista.SelectedCells[9].Value.ToString();
                txt_ClieTelefono2.Text = dgv_ClieLista.SelectedCells[10].Value.ToString();
            }
            else
            {
                Clases.MetodosDB.MensajeBaseVacia();
            }

            txt_ClieCUIT.Select();
            btn_ClieEditar.Enabled = false;
            btn_ClieEliminar.Enabled = false;
        }


        /****** EVENTOS DE TEXTBOX ******/

        private void txt_ClieCUIT_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }

        private void txt_ClieNombre_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }

        private void txt_ClieDomicilio_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }

        private void txt_ClieIngBrutos_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }

        private void txt_ClieContacto_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }

        private void txt_ClieMail_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }

        private void txt_ClieTelefono1_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }

        private void txt_ClieTelefono2_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }


        /****** EVENTOS DE COMBOS ******/

        private void cmb_ClieCondicionIVA_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }


        /****** EVENTOS DE DATA GRID VIEW ******/

        private void dgv_ClieLista_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            btn_ClieEditar.Enabled = true;
            btn_ClieEliminar.Enabled = true;
        }
    }
}
