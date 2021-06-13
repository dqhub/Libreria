namespace Libreria.Forms
{
    partial class Frm_Compras
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
            this.txt_ProvNombre = new System.Windows.Forms.TextBox();
            this.lbl_ProvNombre = new System.Windows.Forms.Label();
            this.cmb_ProvCUIT = new System.Windows.Forms.ComboBox();
            this.lbl_ProvCUIT = new System.Windows.Forms.Label();
            this.lbl_CompFecha = new System.Windows.Forms.Label();
            this.lbl_ProdDescripcion = new System.Windows.Forms.Label();
            this.txt_ProdDescripcion = new System.Windows.Forms.TextBox();
            this.lbl_ProdCodigo = new System.Windows.Forms.Label();
            this.lbl_ProdPrecioCompra = new System.Windows.Forms.Label();
            this.txt_ProdPrecioCompra = new System.Windows.Forms.TextBox();
            this.lbl_ProdCantidad = new System.Windows.Forms.Label();
            this.txt_ProdCantidad = new System.Windows.Forms.TextBox();
            this.lbl_CompTipoFactura = new System.Windows.Forms.Label();
            this.txt_CompNroFactura = new System.Windows.Forms.TextBox();
            this.lbl_CompCondVenta = new System.Windows.Forms.Label();
            this.dgv_CompLista = new System.Windows.Forms.DataGridView();
            this.btn_CompEliminar = new FontAwesome.Sharp.IconButton();
            this.btn_CompGuardar = new FontAwesome.Sharp.IconButton();
            this.btn_CompAgregar = new FontAwesome.Sharp.IconButton();
            this.dtp_CompFecha = new System.Windows.Forms.DateTimePicker();
            this.cmb_ProdCodigo = new System.Windows.Forms.ComboBox();
            this.cmb_CompTipoFactura = new System.Windows.Forms.ComboBox();
            this.lbl_CompNroFactura = new System.Windows.Forms.Label();
            this.lbl_CompTotalPrecio = new System.Windows.Forms.Label();
            this.lbl_CompTotal = new System.Windows.Forms.Label();
            this.lbl_CompItems = new System.Windows.Forms.Label();
            this.lbl_CompItemsCant = new System.Windows.Forms.Label();
            this.cmb_CompCondVenta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CompLista)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ProvNombre
            // 
            this.txt_ProvNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProvNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProvNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProvNombre.ForeColor = System.Drawing.Color.White;
            this.txt_ProvNombre.Location = new System.Drawing.Point(204, 57);
            this.txt_ProvNombre.Name = "txt_ProvNombre";
            this.txt_ProvNombre.Size = new System.Drawing.Size(216, 26);
            this.txt_ProvNombre.TabIndex = 0;
            // 
            // lbl_ProvNombre
            // 
            this.lbl_ProvNombre.AutoSize = true;
            this.lbl_ProvNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProvNombre.ForeColor = System.Drawing.Color.White;
            this.lbl_ProvNombre.Location = new System.Drawing.Point(15, 63);
            this.lbl_ProvNombre.Name = "lbl_ProvNombre";
            this.lbl_ProvNombre.Size = new System.Drawing.Size(172, 20);
            this.lbl_ProvNombre.TabIndex = 1;
            this.lbl_ProvNombre.Text = "Nombre de Proveedor";
            // 
            // cmb_ProvCUIT
            // 
            this.cmb_ProvCUIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_ProvCUIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_ProvCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProvCUIT.ForeColor = System.Drawing.Color.White;
            this.cmb_ProvCUIT.FormattingEnabled = true;
            this.cmb_ProvCUIT.Location = new System.Drawing.Point(204, 12);
            this.cmb_ProvCUIT.Name = "cmb_ProvCUIT";
            this.cmb_ProvCUIT.Size = new System.Drawing.Size(216, 28);
            this.cmb_ProvCUIT.TabIndex = 11;
            // 
            // lbl_ProvCUIT
            // 
            this.lbl_ProvCUIT.AutoSize = true;
            this.lbl_ProvCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProvCUIT.ForeColor = System.Drawing.Color.White;
            this.lbl_ProvCUIT.Location = new System.Drawing.Point(15, 20);
            this.lbl_ProvCUIT.Name = "lbl_ProvCUIT";
            this.lbl_ProvCUIT.Size = new System.Drawing.Size(128, 20);
            this.lbl_ProvCUIT.TabIndex = 10;
            this.lbl_ProvCUIT.Text = "Proveedor CUIT";
            // 
            // lbl_CompFecha
            // 
            this.lbl_CompFecha.AutoSize = true;
            this.lbl_CompFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompFecha.ForeColor = System.Drawing.Color.White;
            this.lbl_CompFecha.Location = new System.Drawing.Point(15, 108);
            this.lbl_CompFecha.Name = "lbl_CompFecha";
            this.lbl_CompFecha.Size = new System.Drawing.Size(118, 20);
            this.lbl_CompFecha.TabIndex = 12;
            this.lbl_CompFecha.Text = "Fecha emisión";
            // 
            // lbl_ProdDescripcion
            // 
            this.lbl_ProdDescripcion.AutoSize = true;
            this.lbl_ProdDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdDescripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_ProdDescripcion.Location = new System.Drawing.Point(15, 194);
            this.lbl_ProdDescripcion.Name = "lbl_ProdDescripcion";
            this.lbl_ProdDescripcion.Size = new System.Drawing.Size(99, 20);
            this.lbl_ProdDescripcion.TabIndex = 21;
            this.lbl_ProdDescripcion.Text = "Descripcion";
            // 
            // txt_ProdDescripcion
            // 
            this.txt_ProdDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProdDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProdDescripcion.ForeColor = System.Drawing.Color.White;
            this.txt_ProdDescripcion.Location = new System.Drawing.Point(204, 188);
            this.txt_ProdDescripcion.Name = "txt_ProdDescripcion";
            this.txt_ProdDescripcion.Size = new System.Drawing.Size(216, 26);
            this.txt_ProdDescripcion.TabIndex = 20;
            // 
            // lbl_ProdCodigo
            // 
            this.lbl_ProdCodigo.AutoSize = true;
            this.lbl_ProdCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdCodigo.ForeColor = System.Drawing.Color.White;
            this.lbl_ProdCodigo.Location = new System.Drawing.Point(15, 151);
            this.lbl_ProdCodigo.Name = "lbl_ProdCodigo";
            this.lbl_ProdCodigo.Size = new System.Drawing.Size(131, 20);
            this.lbl_ProdCodigo.TabIndex = 25;
            this.lbl_ProdCodigo.Text = "Código producto";
            // 
            // lbl_ProdPrecioCompra
            // 
            this.lbl_ProdPrecioCompra.AutoSize = true;
            this.lbl_ProdPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdPrecioCompra.ForeColor = System.Drawing.Color.White;
            this.lbl_ProdPrecioCompra.Location = new System.Drawing.Point(15, 237);
            this.lbl_ProdPrecioCompra.Name = "lbl_ProdPrecioCompra";
            this.lbl_ProdPrecioCompra.Size = new System.Drawing.Size(135, 20);
            this.lbl_ProdPrecioCompra.TabIndex = 39;
            this.lbl_ProdPrecioCompra.Text = "Precio Compra $";
            // 
            // txt_ProdPrecioCompra
            // 
            this.txt_ProdPrecioCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProdPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProdPrecioCompra.ForeColor = System.Drawing.Color.White;
            this.txt_ProdPrecioCompra.Location = new System.Drawing.Point(204, 231);
            this.txt_ProdPrecioCompra.Name = "txt_ProdPrecioCompra";
            this.txt_ProdPrecioCompra.Size = new System.Drawing.Size(216, 26);
            this.txt_ProdPrecioCompra.TabIndex = 38;
            // 
            // lbl_ProdCantidad
            // 
            this.lbl_ProdCantidad.AutoSize = true;
            this.lbl_ProdCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdCantidad.ForeColor = System.Drawing.Color.White;
            this.lbl_ProdCantidad.Location = new System.Drawing.Point(15, 280);
            this.lbl_ProdCantidad.Name = "lbl_ProdCantidad";
            this.lbl_ProdCantidad.Size = new System.Drawing.Size(75, 20);
            this.lbl_ProdCantidad.TabIndex = 41;
            this.lbl_ProdCantidad.Text = "Cantidad";
            // 
            // txt_ProdCantidad
            // 
            this.txt_ProdCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProdCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProdCantidad.ForeColor = System.Drawing.Color.White;
            this.txt_ProdCantidad.Location = new System.Drawing.Point(204, 274);
            this.txt_ProdCantidad.Name = "txt_ProdCantidad";
            this.txt_ProdCantidad.Size = new System.Drawing.Size(216, 26);
            this.txt_ProdCantidad.TabIndex = 40;
            // 
            // lbl_CompTipoFactura
            // 
            this.lbl_CompTipoFactura.AutoSize = true;
            this.lbl_CompTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompTipoFactura.ForeColor = System.Drawing.Color.White;
            this.lbl_CompTipoFactura.Location = new System.Drawing.Point(15, 411);
            this.lbl_CompTipoFactura.Name = "lbl_CompTipoFactura";
            this.lbl_CompTipoFactura.Size = new System.Drawing.Size(103, 20);
            this.lbl_CompTipoFactura.TabIndex = 45;
            this.lbl_CompTipoFactura.Text = "Tipo Factura";
            // 
            // txt_CompNroFactura
            // 
            this.txt_CompNroFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_CompNroFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CompNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CompNroFactura.ForeColor = System.Drawing.Color.White;
            this.txt_CompNroFactura.Location = new System.Drawing.Point(204, 448);
            this.txt_CompNroFactura.Name = "txt_CompNroFactura";
            this.txt_CompNroFactura.Size = new System.Drawing.Size(216, 26);
            this.txt_CompNroFactura.TabIndex = 44;
            // 
            // lbl_CompCondVenta
            // 
            this.lbl_CompCondVenta.AutoSize = true;
            this.lbl_CompCondVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompCondVenta.ForeColor = System.Drawing.Color.White;
            this.lbl_CompCondVenta.Location = new System.Drawing.Point(15, 363);
            this.lbl_CompCondVenta.Name = "lbl_CompCondVenta";
            this.lbl_CompCondVenta.Size = new System.Drawing.Size(170, 20);
            this.lbl_CompCondVenta.TabIndex = 43;
            this.lbl_CompCondVenta.Text = "Condición de Compra";
            // 
            // dgv_CompLista
            // 
            this.dgv_CompLista.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_CompLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CompLista.Location = new System.Drawing.Point(448, 12);
            this.dgv_CompLista.Name = "dgv_CompLista";
            this.dgv_CompLista.Size = new System.Drawing.Size(532, 371);
            this.dgv_CompLista.TabIndex = 50;
            // 
            // btn_CompEliminar
            // 
            this.btn_CompEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_CompEliminar.FlatAppearance.BorderSize = 0;
            this.btn_CompEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CompEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CompEliminar.ForeColor = System.Drawing.Color.White;
            this.btn_CompEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_CompEliminar.IconColor = System.Drawing.Color.Black;
            this.btn_CompEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CompEliminar.Location = new System.Drawing.Point(448, 499);
            this.btn_CompEliminar.Name = "btn_CompEliminar";
            this.btn_CompEliminar.Size = new System.Drawing.Size(165, 39);
            this.btn_CompEliminar.TabIndex = 49;
            this.btn_CompEliminar.Text = "Eliminar";
            this.btn_CompEliminar.UseVisualStyleBackColor = false;
            // 
            // btn_CompGuardar
            // 
            this.btn_CompGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_CompGuardar.FlatAppearance.BorderSize = 0;
            this.btn_CompGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CompGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CompGuardar.ForeColor = System.Drawing.Color.White;
            this.btn_CompGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_CompGuardar.IconColor = System.Drawing.Color.Black;
            this.btn_CompGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CompGuardar.Location = new System.Drawing.Point(815, 499);
            this.btn_CompGuardar.Name = "btn_CompGuardar";
            this.btn_CompGuardar.Size = new System.Drawing.Size(165, 39);
            this.btn_CompGuardar.TabIndex = 32;
            this.btn_CompGuardar.Text = "Guardar Compra";
            this.btn_CompGuardar.UseVisualStyleBackColor = false;
            this.btn_CompGuardar.Click += new System.EventHandler(this.btn_GuardarVenta_Click);
            // 
            // btn_CompAgregar
            // 
            this.btn_CompAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_CompAgregar.FlatAppearance.BorderSize = 0;
            this.btn_CompAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CompAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CompAgregar.ForeColor = System.Drawing.Color.White;
            this.btn_CompAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_CompAgregar.IconColor = System.Drawing.Color.Black;
            this.btn_CompAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CompAgregar.Location = new System.Drawing.Point(19, 499);
            this.btn_CompAgregar.Name = "btn_CompAgregar";
            this.btn_CompAgregar.Size = new System.Drawing.Size(165, 39);
            this.btn_CompAgregar.TabIndex = 31;
            this.btn_CompAgregar.Text = "Agregar";
            this.btn_CompAgregar.UseVisualStyleBackColor = false;
            // 
            // dtp_CompFecha
            // 
            this.dtp_CompFecha.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtp_CompFecha.Location = new System.Drawing.Point(204, 107);
            this.dtp_CompFecha.Name = "dtp_CompFecha";
            this.dtp_CompFecha.Size = new System.Drawing.Size(216, 20);
            this.dtp_CompFecha.TabIndex = 56;
            // 
            // cmb_ProdCodigo
            // 
            this.cmb_ProdCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmb_ProdCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_ProdCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProdCodigo.ForeColor = System.Drawing.Color.White;
            this.cmb_ProdCodigo.FormattingEnabled = true;
            this.cmb_ProdCodigo.Location = new System.Drawing.Point(204, 143);
            this.cmb_ProdCodigo.Name = "cmb_ProdCodigo";
            this.cmb_ProdCodigo.Size = new System.Drawing.Size(216, 28);
            this.cmb_ProdCodigo.TabIndex = 57;
            // 
            // cmb_CompTipoFactura
            // 
            this.cmb_CompTipoFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmb_CompTipoFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_CompTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CompTipoFactura.ForeColor = System.Drawing.Color.White;
            this.cmb_CompTipoFactura.FormattingEnabled = true;
            this.cmb_CompTipoFactura.Items.AddRange(new object[] {
            "FACTURA A",
            "FACTURA B",
            "FACTURA C"});
            this.cmb_CompTipoFactura.Location = new System.Drawing.Point(204, 403);
            this.cmb_CompTipoFactura.Name = "cmb_CompTipoFactura";
            this.cmb_CompTipoFactura.Size = new System.Drawing.Size(216, 28);
            this.cmb_CompTipoFactura.TabIndex = 58;
            // 
            // lbl_CompNroFactura
            // 
            this.lbl_CompNroFactura.AutoSize = true;
            this.lbl_CompNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompNroFactura.ForeColor = System.Drawing.Color.White;
            this.lbl_CompNroFactura.Location = new System.Drawing.Point(15, 454);
            this.lbl_CompNroFactura.Name = "lbl_CompNroFactura";
            this.lbl_CompNroFactura.Size = new System.Drawing.Size(148, 20);
            this.lbl_CompNroFactura.TabIndex = 59;
            this.lbl_CompNroFactura.Text = "Número de factura";
            // 
            // lbl_CompTotalPrecio
            // 
            this.lbl_CompTotalPrecio.AutoSize = true;
            this.lbl_CompTotalPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompTotalPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_CompTotalPrecio.Location = new System.Drawing.Point(777, 411);
            this.lbl_CompTotalPrecio.Name = "lbl_CompTotalPrecio";
            this.lbl_CompTotalPrecio.Size = new System.Drawing.Size(203, 47);
            this.lbl_CompTotalPrecio.TabIndex = 60;
            this.lbl_CompTotalPrecio.Text = "$ 1245,30";
            // 
            // lbl_CompTotal
            // 
            this.lbl_CompTotal.AutoSize = true;
            this.lbl_CompTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompTotal.ForeColor = System.Drawing.Color.White;
            this.lbl_CompTotal.Location = new System.Drawing.Point(781, 391);
            this.lbl_CompTotal.Name = "lbl_CompTotal";
            this.lbl_CompTotal.Size = new System.Drawing.Size(46, 20);
            this.lbl_CompTotal.TabIndex = 61;
            this.lbl_CompTotal.Text = "Total";
            // 
            // lbl_CompItems
            // 
            this.lbl_CompItems.AutoSize = true;
            this.lbl_CompItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompItems.ForeColor = System.Drawing.Color.White;
            this.lbl_CompItems.Location = new System.Drawing.Point(444, 391);
            this.lbl_CompItems.Name = "lbl_CompItems";
            this.lbl_CompItems.Size = new System.Drawing.Size(50, 20);
            this.lbl_CompItems.TabIndex = 62;
            this.lbl_CompItems.Text = "Items";
            // 
            // lbl_CompItemsCant
            // 
            this.lbl_CompItemsCant.AutoSize = true;
            this.lbl_CompItemsCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompItemsCant.ForeColor = System.Drawing.Color.SkyBlue;
            this.lbl_CompItemsCant.Location = new System.Drawing.Point(440, 411);
            this.lbl_CompItemsCant.Name = "lbl_CompItemsCant";
            this.lbl_CompItemsCant.Size = new System.Drawing.Size(74, 31);
            this.lbl_CompItemsCant.TabIndex = 63;
            this.lbl_CompItemsCant.Text = "#123";
            // 
            // cmb_CompCondVenta
            // 
            this.cmb_CompCondVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmb_CompCondVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_CompCondVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CompCondVenta.ForeColor = System.Drawing.Color.White;
            this.cmb_CompCondVenta.FormattingEnabled = true;
            this.cmb_CompCondVenta.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA CRÉDITO",
            "TARJETA DÉBITO"});
            this.cmb_CompCondVenta.Location = new System.Drawing.Point(204, 355);
            this.cmb_CompCondVenta.Name = "cmb_CompCondVenta";
            this.cmb_CompCondVenta.Size = new System.Drawing.Size(216, 28);
            this.cmb_CompCondVenta.TabIndex = 64;
            // 
            // Frm_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1003, 550);
            this.Controls.Add(this.cmb_CompCondVenta);
            this.Controls.Add(this.lbl_CompItemsCant);
            this.Controls.Add(this.lbl_CompItems);
            this.Controls.Add(this.lbl_CompTotal);
            this.Controls.Add(this.lbl_CompTotalPrecio);
            this.Controls.Add(this.lbl_CompNroFactura);
            this.Controls.Add(this.cmb_CompTipoFactura);
            this.Controls.Add(this.cmb_ProdCodigo);
            this.Controls.Add(this.dtp_CompFecha);
            this.Controls.Add(this.dgv_CompLista);
            this.Controls.Add(this.btn_CompEliminar);
            this.Controls.Add(this.lbl_CompTipoFactura);
            this.Controls.Add(this.txt_CompNroFactura);
            this.Controls.Add(this.lbl_CompCondVenta);
            this.Controls.Add(this.lbl_ProdCantidad);
            this.Controls.Add(this.txt_ProdCantidad);
            this.Controls.Add(this.lbl_ProdPrecioCompra);
            this.Controls.Add(this.txt_ProdPrecioCompra);
            this.Controls.Add(this.btn_CompGuardar);
            this.Controls.Add(this.btn_CompAgregar);
            this.Controls.Add(this.lbl_ProdCodigo);
            this.Controls.Add(this.lbl_ProdDescripcion);
            this.Controls.Add(this.txt_ProdDescripcion);
            this.Controls.Add(this.lbl_CompFecha);
            this.Controls.Add(this.cmb_ProvCUIT);
            this.Controls.Add(this.lbl_ProvCUIT);
            this.Controls.Add(this.lbl_ProvNombre);
            this.Controls.Add(this.txt_ProvNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Compras";
            this.Text = "Frm_Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CompLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ProvNombre;
        private System.Windows.Forms.Label lbl_ProvNombre;
        private System.Windows.Forms.ComboBox cmb_ProvCUIT;
        private System.Windows.Forms.Label lbl_ProvCUIT;
        private System.Windows.Forms.Label lbl_CompFecha;
        private System.Windows.Forms.Label lbl_ProdDescripcion;
        private System.Windows.Forms.TextBox txt_ProdDescripcion;
        private System.Windows.Forms.Label lbl_ProdCodigo;
        private FontAwesome.Sharp.IconButton btn_CompAgregar;
        private FontAwesome.Sharp.IconButton btn_CompGuardar;
        private System.Windows.Forms.Label lbl_ProdPrecioCompra;
        private System.Windows.Forms.TextBox txt_ProdPrecioCompra;
        private System.Windows.Forms.Label lbl_ProdCantidad;
        private System.Windows.Forms.TextBox txt_ProdCantidad;
        private System.Windows.Forms.Label lbl_CompTipoFactura;
        private System.Windows.Forms.TextBox txt_CompNroFactura;
        private System.Windows.Forms.Label lbl_CompCondVenta;
        private System.Windows.Forms.DataGridView dgv_CompLista;
        private FontAwesome.Sharp.IconButton btn_CompEliminar;
        private System.Windows.Forms.DateTimePicker dtp_CompFecha;
        private System.Windows.Forms.ComboBox cmb_ProdCodigo;
        private System.Windows.Forms.ComboBox cmb_CompTipoFactura;
        private System.Windows.Forms.Label lbl_CompNroFactura;
        private System.Windows.Forms.Label lbl_CompTotalPrecio;
        private System.Windows.Forms.Label lbl_CompTotal;
        private System.Windows.Forms.Label lbl_CompItems;
        private System.Windows.Forms.Label lbl_CompItemsCant;
        private System.Windows.Forms.ComboBox cmb_CompCondVenta;
    }
}