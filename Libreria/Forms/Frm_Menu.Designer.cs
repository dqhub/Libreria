namespace Libreria
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
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.brnAdminUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnCompras = new FontAwesome.Sharp.IconButton();
            this.btnProveedores = new FontAwesome.Sharp.IconButton();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.btnInformes = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.brnAdminUsuarios);
            this.panelMenu.Controls.Add(this.btnCompras);
            this.panelMenu.Controls.Add(this.btnProveedores);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.btnInformes);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.panelLogo);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.ForeColor = System.Drawing.Color.Silver;
            this.panelMenu.Name = "panelMenu";
            // 
            // btnSalir
            // 
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.ForeColor = System.Drawing.Color.Silver;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSalir.IconColor = System.Drawing.Color.Silver;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // brnAdminUsuarios
            // 
            resources.ApplyResources(this.brnAdminUsuarios, "brnAdminUsuarios");
            this.brnAdminUsuarios.FlatAppearance.BorderSize = 0;
            this.brnAdminUsuarios.ForeColor = System.Drawing.Color.Silver;
            this.brnAdminUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.brnAdminUsuarios.IconColor = System.Drawing.Color.Silver;
            this.brnAdminUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.brnAdminUsuarios.Name = "brnAdminUsuarios";
            this.brnAdminUsuarios.UseVisualStyleBackColor = true;
            this.brnAdminUsuarios.Click += new System.EventHandler(this.brnAdminUsuarios_Click);
            // 
            // btnCompras
            // 
            resources.ApplyResources(this.btnCompras, "btnCompras");
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.ForeColor = System.Drawing.Color.Silver;
            this.btnCompras.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.btnCompras.IconColor = System.Drawing.Color.Silver;
            this.btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnProveedores
            // 
            resources.ApplyResources(this.btnProveedores, "btnProveedores");
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.ForeColor = System.Drawing.Color.Silver;
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnProveedores.IconColor = System.Drawing.Color.Silver;
            this.btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnProductos
            // 
            resources.ApplyResources(this.btnProductos, "btnProductos");
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.ForeColor = System.Drawing.Color.Silver;
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btnProductos.IconColor = System.Drawing.Color.Silver;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnInformes
            // 
            resources.ApplyResources(this.btnInformes, "btnInformes");
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.ForeColor = System.Drawing.Color.Silver;
            this.btnInformes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnInformes.IconColor = System.Drawing.Color.Silver;
            this.btnInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnClientes
            // 
            resources.ApplyResources(this.btnClientes, "btnClientes");
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.ForeColor = System.Drawing.Color.Silver;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnClientes.IconColor = System.Drawing.Color.Silver;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVentas
            // 
            resources.ApplyResources(this.btnVentas, "btnVentas");
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnVentas.IconColor = System.Drawing.Color.White;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.ForeColor = System.Drawing.Color.Silver;
            this.panelLogo.Name = "panelLogo";
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
            this.panelContenedor.Controls.Add(this.panelTitulo);
            this.panelContenedor.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panelContenedor, "panelContenedor");
            this.panelContenedor.Name = "panelContenedor";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.Name = "btnHome";
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnCompras;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnInformes;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton brnAdminUsuarios;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitulo;
    }
}

