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
    public partial class Frm_AdminUsr : Form
    {
        bool editarEstado = false;
        bool DBVacia = true;

        int editarid;


        public Frm_AdminUsr()
        {
            InitializeComponent();
        }

        /*****************************************       **********************************       *****************************************/
        /*****************************************       ***** MÉTODOS DEL FORMULARIO *****       *****************************************/
        /*****************************************       **********************************       *****************************************/

        /******* MÉTODOS FUNCIONALES *******/

        private void LimpiarForm()
        {
            txt_UserNombre.Text = "";
            txt_UserCuenta.Text = "";
            txt_UserContraseña.Text = "";
            cmb_UserTipoCuenta.Text = null;
            cmb_UserEstadoCuenta.Text = null;

            txt_UserNombre.Select();
        }
        public void ActualizarUserLista()
        {
            editarEstado = false;
            string query = "SELECT * FROM usuario";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            MySqlDataAdapter DBAdaptador = new MySqlDataAdapter(query, DB);
            DataTable DBVirtual = new DataTable();
            DBAdaptador.Fill(DBVirtual);
            if (DBVirtual.Rows.Count == 0)
            {
                DBVacia = true;
                dgv_UserLista.DataSource = DBVirtual;
            }
            else
            {
                DBVacia = false;
                dgv_UserLista.DataSource = DBVirtual;
            }

            btn_UserGuardar.Enabled = false;
            btn_UserEliminar.Enabled = false;
            btn_UserEditar.Enabled = false;

            ActivarBtnGuardar();
        }
        public void ActivarBtnGuardar()
        {
            bool vacio = false;
            if (txt_UserNombre.Text == "")
                vacio = true;
            if (txt_UserCuenta.Text == "")
                vacio = true;
            if (txt_UserContraseña.Text == "")
                vacio = true;
            if (cmb_UserTipoCuenta.Text == "")
                vacio = true;
            if (cmb_UserEstadoCuenta.Text == "")
                vacio = true;

            if (vacio == false)
                btn_UserGuardar.Enabled = true;
            else
                btn_UserGuardar.Enabled = false;
        }



        /****** MÉTODOS DE APARIENCIA ******/

        //public void AperienciaDataGridView()
        //{
        //    dgv_UserLista.BorderStyle = BorderStyle.None;
        //    dgv_UserLista.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        //    dgv_UserLista.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        //    DataGridViewCellStyle style = dgv_UserLista.ColumnHeadersDefaultCellStyle;
        //    style.BackColor = Color.Black;
        //    style.Font = new Font("Century Gothic", 9, FontStyle.Regular);
        //    style.ForeColor = Color.White;
        //    style.SelectionBackColor = Color.RoyalBlue;
        //    style.SelectionForeColor = Color.White;
        //    style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgv_UserLista.ColumnHeadersHeight = 19;
        //    DataGridViewCellStyle style2 = dgv_UserLista.DefaultCellStyle;
        //    style2.BackColor = Color.Black;
        //    style2.Font = new Font("Century Gothic", 8, FontStyle.Regular);
        //    style2.ForeColor = Color.White;
        //    style2.SelectionBackColor = Color.RoyalBlue;
        //    style2.SelectionForeColor = Color.White;
        //    style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //}


        /*****************************************       **********************************       *****************************************/
        /*****************************************       ***** EVENTOS DEL FORMULARIO *****       *****************************************/
        /*****************************************       **********************************       *****************************************/

        private void Frm_AdminUsr_Load(object sender, EventArgs e)
        {
            ActualizarUserLista();
        }

        /****** EVENTOS DE BOTONES ******/

        private void btn_UserGuardar_Click(object sender, EventArgs e)
        {
            Clases.Usuarios userA = new Clases.Usuarios();

            userA.UserNombre = txt_UserNombre.Text.ToString();
            userA.UserCuenta = txt_UserCuenta.Text.ToString();
            userA.UserContraseña = txt_UserContraseña.Text.ToString();
            userA.UserTipoCuenta = cmb_UserTipoCuenta.Text.ToString();
            userA.UserEstadoCuenta = cmb_UserEstadoCuenta.Text.ToString();
            
            if (editarEstado != true)
            {
                Clases.MetodosDB.GuardarUsuario(userA);
            }
            else
            {
                //bool compara = false;
                //var userB = new Clases.Usuarios();

                //userB.UserNombre = dgv_UserLista.SelectedCells[2].Value.ToString();
                //userB.UserCuenta = dgv_UserLista.SelectedCells[3].Value.ToString();
                //userB.UserContraseña = dgv_UserLista.SelectedCells[4].Value.ToString();
                //userB.UserTipoCuenta = dgv_UserLista.SelectedCells[5].Value.ToString();
                //userB.UserEstadoCuenta = dgv_UserLista.SelectedCells[6].Value.ToString();

                //compara = userA.Equals(userB);
                //if (compara == false)
                //{
                    Clases.MetodosDB.EditarUsuario(editarid, userA);
                //}
                //else
                //{
                //    Clases.MetodosDB.MensajeValoresIguales();
                //}
            }

            LimpiarForm();
            ActualizarUserLista();
        }
        private void btn_UserEliminar_Click(object sender, EventArgs e)
        {
            if (DBVacia == false)
            {
                DialogResult respuesta = 0;
                respuesta = Clases.MetodosDB.MensajeEliminarPregunta();

                if (respuesta == DialogResult.Yes)
                {
                    int id = 0;
                    id = int.Parse(dgv_UserLista.SelectedCells[0].Value.ToString());

                    Clases.MetodosDB.EliminarUsuario(id);
                    LimpiarForm();
                    ActualizarUserLista();

                    btn_UserEditar.Enabled = false;
                    btn_UserEliminar.Enabled = false;
                }
            }
            else
            {
                Clases.MetodosDB.MensajeBaseVacia();
            }
        }
        private void btn_UserEditar_Click(object sender, EventArgs e)
        {
            if (DBVacia == false)
            {
                editarEstado = true;
                editarid = 0;
                editarid = int.Parse(dgv_UserLista.SelectedCells[0].Value.ToString());

                txt_UserNombre.Text = dgv_UserLista.SelectedCells[2].Value.ToString();
                txt_UserCuenta.Text = dgv_UserLista.SelectedCells[3].Value.ToString();
                txt_UserContraseña.Text = dgv_UserLista.SelectedCells[4].Value.ToString();
                cmb_UserTipoCuenta.Text = dgv_UserLista.SelectedCells[5].Value.ToString();
                cmb_UserEstadoCuenta.Text = dgv_UserLista.SelectedCells[6].Value.ToString();
            }
            else
            {
                Clases.MetodosDB.MensajeBaseVacia();
            }

            txt_UserNombre.Select();
            btn_UserEditar.Enabled = false;
            btn_UserEliminar.Enabled = false;
        }


        /****** EVENTOS DE TEXTBOX ******/

        private void txt_UserNombre_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }
        private void txt_UserCuenta_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }
        private void txt_UserContraseña_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }


        /****** EVENTOS DE COMBOS ******/

        private void cmb_UserTipoCuenta_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }

        private void cmb_UserEstadoCuenta_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnGuardar();
        }


        /****** EVENTOS DE DATA GRID VIEW ******/

        private void dgv_UserLista_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            btn_UserEditar.Enabled = true;
            btn_UserEliminar.Enabled = true;
        }
    }
}
