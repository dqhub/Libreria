using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Libreria
{
    public partial class frmMenu : Form
    {
        private IconButton actualBtn;
        private Panel bordeIzqBtn;
        private Form formHijoActual;

        //Constructor
        public frmMenu()
        {

            InitializeComponent();

            bordeIzqBtn = new Panel();
            bordeIzqBtn.Size = new Size(10,50);
            panelMenu.Controls.Add(bordeIzqBtn);
        }

        //Colores Predeterminados
        private struct Colores
        {
            public static Color colorBtnTxtOriginal = Color.FromArgb(106, 107, 109);
            public static Color colorBtnActivado = Color.FromArgb(30, 30, 30);
            public static Color colorBtnBackOriginal = Color.FromArgb(45, 45, 48);
        }

        //Metodos
        private void ActivarBtn(object btn, Color color)
        {
            if(btn != null)
            {
                DesactivarBtn();
                //Creo Boton
                actualBtn = (IconButton)btn;
                actualBtn.BackColor = Colores.colorBtnActivado;
                actualBtn.ForeColor = color;
                actualBtn.TextAlign = ContentAlignment.MiddleCenter;
                actualBtn.IconColor = color;
                actualBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                actualBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Muevo a la izquierda
                bordeIzqBtn.BackColor = color;
                bordeIzqBtn.Location = new Point(0,actualBtn.Location.Y);
                bordeIzqBtn.Visible = true;
                bordeIzqBtn.BringToFront();
            }
        }
        private void DesactivarBtn()
        {
            if (actualBtn != null)
            {
                //Creo Boton
                actualBtn.BackColor = Colores.colorBtnBackOriginal;
                actualBtn.ForeColor = Color.Silver;
                actualBtn.TextAlign = ContentAlignment.MiddleLeft;
                actualBtn.IconColor = Color.Silver;
                actualBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                actualBtn.ImageAlign = ContentAlignment.MiddleLeft;           
            }
        }
        private void Reset()
        {
            DesactivarBtn();
            bordeIzqBtn.Visible = false;
        }
        private void AbrirFormHijo(Form formHijo)
        {
            if(formHijoActual != null)
            {
                formHijoActual.Close();
            }
            formHijoActual = formHijo;
            formHijo.TopLevel = false;
            panelPrincipal.Controls.Add(formHijo);
            formHijo.BringToFront();
            formHijo.Show();
        }
        
        //Eventos

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ActivarBtn(sender, Colores.colorBtnTxtOriginal);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivarBtn(sender, Colores.colorBtnTxtOriginal);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            ActivarBtn(sender, Colores.colorBtnTxtOriginal);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ActivarBtn(sender, Colores.colorBtnTxtOriginal);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ActivarBtn(sender, Colores.colorBtnTxtOriginal);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            ActivarBtn(sender, Colores.colorBtnTxtOriginal);
        }

        private void brnAdminUsuarios_Click(object sender, EventArgs e)
        {
            ActivarBtn(sender, Colores.colorBtnTxtOriginal);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
