namespace Libreria.Forms
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_Salir = new FontAwesome.Sharp.IconButton();
            this.btn_AdminUsr = new FontAwesome.Sharp.IconButton();
            this.btn_Compras = new FontAwesome.Sharp.IconButton();
            this.btn_Proveedores = new FontAwesome.Sharp.IconButton();
            this.btn_Productos = new FontAwesome.Sharp.IconButton();
            this.btn_Informes = new FontAwesome.Sharp.IconButton();
            this.btn_Clientes = new FontAwesome.Sharp.IconButton();
            this.btn_Ventas = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelMenu.Controls.Add(this.btn_Salir);
            this.panelMenu.Controls.Add(this.btn_AdminUsr);
            this.panelMenu.Controls.Add(this.btn_Compras);
            this.panelMenu.Controls.Add(this.btn_Proveedores);
            this.panelMenu.Controls.Add(this.btn_Productos);
            this.panelMenu.Controls.Add(this.btn_Informes);
            this.panelMenu.Controls.Add(this.btn_Clientes);
            this.panelMenu.Controls.Add(this.btn_Ventas);
            this.panelMenu.Controls.Add(this.panelLogo);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.ForeColor = System.Drawing.Color.Silver;
            this.panelMenu.Name = "panelMenu";
            // 
            // btn_Salir
            // 
            resources.ApplyResources(this.btn_Salir, "btn_Salir");
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.ForeColor = System.Drawing.Color.Silver;
            this.btn_Salir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_Salir.IconColor = System.Drawing.Color.Silver;
            this.btn_Salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btn_AdminUsr
            // 
            resources.ApplyResources(this.btn_AdminUsr, "btn_AdminUsr");
            this.btn_AdminUsr.FlatAppearance.BorderSize = 0;
            this.btn_AdminUsr.ForeColor = System.Drawing.Color.Silver;
            this.btn_AdminUsr.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btn_AdminUsr.IconColor = System.Drawing.Color.Silver;
            this.btn_AdminUsr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AdminUsr.Name = "btn_AdminUsr";
            this.btn_AdminUsr.UseVisualStyleBackColor = true;
            this.btn_AdminUsr.Click += new System.EventHandler(this.brnAdminUsuarios_Click);
            // 
            // btn_Compras
            // 
            resources.ApplyResources(this.btn_Compras, "btn_Compras");
            this.btn_Compras.FlatAppearance.BorderSize = 0;
            this.btn_Compras.ForeColor = System.Drawing.Color.Silver;
            this.btn_Compras.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.btn_Compras.IconColor = System.Drawing.Color.Silver;
            this.btn_Compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Compras.Name = "btn_Compras";
            this.btn_Compras.UseVisualStyleBackColor = true;
            this.btn_Compras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btn_Proveedores
            // 
            resources.ApplyResources(this.btn_Proveedores, "btn_Proveedores");
            this.btn_Proveedores.FlatAppearance.BorderSize = 0;
            this.btn_Proveedores.ForeColor = System.Drawing.Color.Silver;
            this.btn_Proveedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btn_Proveedores.IconColor = System.Drawing.Color.Silver;
            this.btn_Proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Proveedores.Name = "btn_Proveedores";
            this.btn_Proveedores.UseVisualStyleBackColor = true;
            this.btn_Proveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btn_Productos
            // 
            resources.ApplyResources(this.btn_Productos, "btn_Productos");
            this.btn_Productos.FlatAppearance.BorderSize = 0;
            this.btn_Productos.ForeColor = System.Drawing.Color.Silver;
            this.btn_Productos.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btn_Productos.IconColor = System.Drawing.Color.Silver;
            this.btn_Productos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.UseVisualStyleBackColor = true;
            this.btn_Productos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btn_Informes
            // 
            resources.ApplyResources(this.btn_Informes, "btn_Informes");
            this.btn_Informes.FlatAppearance.BorderSize = 0;
            this.btn_Informes.ForeColor = System.Drawing.Color.Silver;
            this.btn_Informes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btn_Informes.IconColor = System.Drawing.Color.Silver;
            this.btn_Informes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Informes.Name = "btn_Informes";
            this.btn_Informes.UseVisualStyleBackColor = true;
            this.btn_Informes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btn_Clientes
            // 
            resources.ApplyResources(this.btn_Clientes, "btn_Clientes");
            this.btn_Clientes.FlatAppearance.BorderSize = 0;
            this.btn_Clientes.ForeColor = System.Drawing.Color.Silver;
            this.btn_Clientes.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btn_Clientes.IconColor = System.Drawing.Color.Silver;
            this.btn_Clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btn_Ventas
            // 
            resources.ApplyResources(this.btn_Ventas, "btn_Ventas");
            this.btn_Ventas.FlatAppearance.BorderSize = 0;
            this.btn_Ventas.ForeColor = System.Drawing.Color.White;
            this.btn_Ventas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btn_Ventas.IconColor = System.Drawing.Color.White;
            this.btn_Ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.UseVisualStyleBackColor = true;
            this.btn_Ventas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.ForeColor = System.Drawing.Color.Silver;
            this.panelLogo.Name = "panelLogo";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.Name = "btnHome";
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelContenedor.Controls.Add(this.panelPrincipal);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Controls.Add(this.panelTitulo);
            this.panelContenedor.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panelContenedor, "panelContenedor");
            this.panelContenedor.Name = "panelContenedor";
            // 
            // panelPrincipal
            // 
            resources.ApplyResources(this.panelPrincipal, "panelPrincipal");
            this.panelPrincipal.Name = "panelPrincipal";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panelTitulo, "panelTitulo");
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // frmMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_Compras;
        private FontAwesome.Sharp.IconButton btn_Proveedores;
        private FontAwesome.Sharp.IconButton btn_Productos;
        private FontAwesome.Sharp.IconButton btn_Informes;
        private FontAwesome.Sharp.IconButton btn_Clientes;
        private FontAwesome.Sharp.IconButton btn_Ventas;
        private FontAwesome.Sharp.IconButton btn_Salir;
        private FontAwesome.Sharp.IconButton btn_AdminUsr;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panel1;
    }
}

