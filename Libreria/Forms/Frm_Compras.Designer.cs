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
            this.lbl_ProvCUIT = new System.Windows.Forms.Label();
            this.lbl_CompFecha = new System.Windows.Forms.Label();
            this.lbl_CompCantidadProd = new System.Windows.Forms.Label();
            this.txt_CompCantidadProd = new System.Windows.Forms.TextBox();
            this.lbl_CompFacturaTipo = new System.Windows.Forms.Label();
            this.lbl_CompCondCompra = new System.Windows.Forms.Label();
            this.dgv_CompLista = new System.Windows.Forms.DataGridView();
            this.btn_CompEliminarItem = new FontAwesome.Sharp.IconButton();
            this.btn_CompTerminar = new FontAwesome.Sharp.IconButton();
            this.btn_CompAgregarItem = new FontAwesome.Sharp.IconButton();
            this.dtp_CompFecha = new System.Windows.Forms.DateTimePicker();
            this.cmb_CompFacturaTipo = new System.Windows.Forms.ComboBox();
            this.lbl_CompItems = new System.Windows.Forms.Label();
            this.lbl_CompItemsCant = new System.Windows.Forms.Label();
            this.cmb_CompCondCompra = new System.Windows.Forms.ComboBox();
            this.txt_ProvCUIT = new System.Windows.Forms.TextBox();
            this.txt_ProdCodigo = new System.Windows.Forms.TextBox();
            this.lbl_ProdCodigo = new System.Windows.Forms.Label();
            this.lbl_CompFacturaNro = new System.Windows.Forms.Label();
            this.txt_CompFacturaPuntoVenta = new System.Windows.Forms.TextBox();
            this.lbl_CompPrecioUnitProd = new System.Windows.Forms.Label();
            this.txt_CompPrecioUnitProd = new System.Windows.Forms.TextBox();
            this.lbl_ProdDescripcion = new System.Windows.Forms.Label();
            this.txt_ProdDescripcion = new System.Windows.Forms.TextBox();
            this.btn_CompEditar = new FontAwesome.Sharp.IconButton();
            this.txt_CompFacturaNroComprobante = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CompLista)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ProvNombre
            // 
            this.txt_ProvNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProvNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProvNombre.Enabled = false;
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
            // lbl_CompCantidadProd
            // 
            this.lbl_CompCantidadProd.AutoSize = true;
            this.lbl_CompCantidadProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompCantidadProd.ForeColor = System.Drawing.Color.White;
            this.lbl_CompCantidadProd.Location = new System.Drawing.Point(15, 411);
            this.lbl_CompCantidadProd.Name = "lbl_CompCantidadProd";
            this.lbl_CompCantidadProd.Size = new System.Drawing.Size(75, 20);
            this.lbl_CompCantidadProd.TabIndex = 41;
            this.lbl_CompCantidadProd.Text = "Cantidad";
            // 
            // txt_CompCantidadProd
            // 
            this.txt_CompCantidadProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_CompCantidadProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CompCantidadProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CompCantidadProd.ForeColor = System.Drawing.Color.White;
            this.txt_CompCantidadProd.Location = new System.Drawing.Point(204, 405);
            this.txt_CompCantidadProd.Name = "txt_CompCantidadProd";
            this.txt_CompCantidadProd.Size = new System.Drawing.Size(216, 26);
            this.txt_CompCantidadProd.TabIndex = 40;
            this.txt_CompCantidadProd.TextChanged += new System.EventHandler(this.txt_CompCantidadProd_TextChanged);
            // 
            // lbl_CompFacturaTipo
            // 
            this.lbl_CompFacturaTipo.AutoSize = true;
            this.lbl_CompFacturaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompFacturaTipo.ForeColor = System.Drawing.Color.White;
            this.lbl_CompFacturaTipo.Location = new System.Drawing.Point(15, 151);
            this.lbl_CompFacturaTipo.Name = "lbl_CompFacturaTipo";
            this.lbl_CompFacturaTipo.Size = new System.Drawing.Size(103, 20);
            this.lbl_CompFacturaTipo.TabIndex = 45;
            this.lbl_CompFacturaTipo.Text = "Tipo Factura";
            // 
            // lbl_CompCondCompra
            // 
            this.lbl_CompCondCompra.AutoSize = true;
            this.lbl_CompCondCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompCondCompra.ForeColor = System.Drawing.Color.White;
            this.lbl_CompCondCompra.Location = new System.Drawing.Point(15, 237);
            this.lbl_CompCondCompra.Name = "lbl_CompCondCompra";
            this.lbl_CompCondCompra.Size = new System.Drawing.Size(170, 20);
            this.lbl_CompCondCompra.TabIndex = 43;
            this.lbl_CompCondCompra.Text = "Condición de Compra";
            // 
            // dgv_CompLista
            // 
            this.dgv_CompLista.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_CompLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CompLista.Location = new System.Drawing.Point(448, 12);
            this.dgv_CompLista.Name = "dgv_CompLista";
            this.dgv_CompLista.Size = new System.Drawing.Size(532, 371);
            this.dgv_CompLista.TabIndex = 50;
            this.dgv_CompLista.Click += new System.EventHandler(this.dgv_CompLista_Click);
            // 
            // btn_CompEliminarItem
            // 
            this.btn_CompEliminarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_CompEliminarItem.FlatAppearance.BorderSize = 0;
            this.btn_CompEliminarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CompEliminarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CompEliminarItem.ForeColor = System.Drawing.Color.White;
            this.btn_CompEliminarItem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_CompEliminarItem.IconColor = System.Drawing.Color.Black;
            this.btn_CompEliminarItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CompEliminarItem.Location = new System.Drawing.Point(255, 499);
            this.btn_CompEliminarItem.Name = "btn_CompEliminarItem";
            this.btn_CompEliminarItem.Size = new System.Drawing.Size(165, 39);
            this.btn_CompEliminarItem.TabIndex = 49;
            this.btn_CompEliminarItem.Text = "Eliminar Item";
            this.btn_CompEliminarItem.UseVisualStyleBackColor = false;
            this.btn_CompEliminarItem.Click += new System.EventHandler(this.btn_CompEliminarItem_Click);
            // 
            // btn_CompTerminar
            // 
            this.btn_CompTerminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_CompTerminar.FlatAppearance.BorderSize = 0;
            this.btn_CompTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CompTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CompTerminar.ForeColor = System.Drawing.Color.White;
            this.btn_CompTerminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_CompTerminar.IconColor = System.Drawing.Color.Black;
            this.btn_CompTerminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CompTerminar.Location = new System.Drawing.Point(608, 499);
            this.btn_CompTerminar.Name = "btn_CompTerminar";
            this.btn_CompTerminar.Size = new System.Drawing.Size(165, 39);
            this.btn_CompTerminar.TabIndex = 32;
            this.btn_CompTerminar.Text = "Terminar Compra";
            this.btn_CompTerminar.UseVisualStyleBackColor = false;
            this.btn_CompTerminar.Click += new System.EventHandler(this.btn_CompTerminar_Click);
            // 
            // btn_CompAgregarItem
            // 
            this.btn_CompAgregarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_CompAgregarItem.FlatAppearance.BorderSize = 0;
            this.btn_CompAgregarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CompAgregarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CompAgregarItem.ForeColor = System.Drawing.Color.White;
            this.btn_CompAgregarItem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_CompAgregarItem.IconColor = System.Drawing.Color.Black;
            this.btn_CompAgregarItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CompAgregarItem.Location = new System.Drawing.Point(19, 499);
            this.btn_CompAgregarItem.Name = "btn_CompAgregarItem";
            this.btn_CompAgregarItem.Size = new System.Drawing.Size(165, 39);
            this.btn_CompAgregarItem.TabIndex = 31;
            this.btn_CompAgregarItem.Text = "Agregar Item";
            this.btn_CompAgregarItem.UseVisualStyleBackColor = false;
            this.btn_CompAgregarItem.Click += new System.EventHandler(this.btn_CompAgregarItem_Click);
            // 
            // dtp_CompFecha
            // 
            this.dtp_CompFecha.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtp_CompFecha.Location = new System.Drawing.Point(204, 107);
            this.dtp_CompFecha.Name = "dtp_CompFecha";
            this.dtp_CompFecha.Size = new System.Drawing.Size(216, 20);
            this.dtp_CompFecha.TabIndex = 56;
            // 
            // cmb_CompFacturaTipo
            // 
            this.cmb_CompFacturaTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmb_CompFacturaTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_CompFacturaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CompFacturaTipo.ForeColor = System.Drawing.Color.White;
            this.cmb_CompFacturaTipo.FormattingEnabled = true;
            this.cmb_CompFacturaTipo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmb_CompFacturaTipo.Location = new System.Drawing.Point(204, 143);
            this.cmb_CompFacturaTipo.Name = "cmb_CompFacturaTipo";
            this.cmb_CompFacturaTipo.Size = new System.Drawing.Size(216, 28);
            this.cmb_CompFacturaTipo.TabIndex = 58;
            this.cmb_CompFacturaTipo.SelectedIndexChanged += new System.EventHandler(this.cmb_CompFacturaTipo_SelectedIndexChanged);
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
            // cmb_CompCondCompra
            // 
            this.cmb_CompCondCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmb_CompCondCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_CompCondCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CompCondCompra.ForeColor = System.Drawing.Color.White;
            this.cmb_CompCondCompra.FormattingEnabled = true;
            this.cmb_CompCondCompra.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA CRÉDITO",
            "TARJETA DÉBITO"});
            this.cmb_CompCondCompra.Location = new System.Drawing.Point(204, 229);
            this.cmb_CompCondCompra.Name = "cmb_CompCondCompra";
            this.cmb_CompCondCompra.Size = new System.Drawing.Size(216, 28);
            this.cmb_CompCondCompra.TabIndex = 64;
            this.cmb_CompCondCompra.SelectedIndexChanged += new System.EventHandler(this.cmb_CompCondCompra_SelectedIndexChanged);
            // 
            // txt_ProvCUIT
            // 
            this.txt_ProvCUIT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_ProvCUIT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_ProvCUIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProvCUIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProvCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProvCUIT.ForeColor = System.Drawing.Color.White;
            this.txt_ProvCUIT.Location = new System.Drawing.Point(204, 14);
            this.txt_ProvCUIT.Name = "txt_ProvCUIT";
            this.txt_ProvCUIT.Size = new System.Drawing.Size(216, 26);
            this.txt_ProvCUIT.TabIndex = 65;
            this.txt_ProvCUIT.TextChanged += new System.EventHandler(this.txt_ProvCUIT_TextChanged);
            // 
            // txt_ProdCodigo
            // 
            this.txt_ProdCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_ProdCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_ProdCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProdCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProdCodigo.ForeColor = System.Drawing.Color.White;
            this.txt_ProdCodigo.Location = new System.Drawing.Point(204, 315);
            this.txt_ProdCodigo.Name = "txt_ProdCodigo";
            this.txt_ProdCodigo.Size = new System.Drawing.Size(216, 26);
            this.txt_ProdCodigo.TabIndex = 67;
            this.txt_ProdCodigo.TextChanged += new System.EventHandler(this.txt_ProdCodigo_TextChanged);
            // 
            // lbl_ProdCodigo
            // 
            this.lbl_ProdCodigo.AutoSize = true;
            this.lbl_ProdCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdCodigo.ForeColor = System.Drawing.Color.White;
            this.lbl_ProdCodigo.Location = new System.Drawing.Point(15, 321);
            this.lbl_ProdCodigo.Name = "lbl_ProdCodigo";
            this.lbl_ProdCodigo.Size = new System.Drawing.Size(131, 20);
            this.lbl_ProdCodigo.TabIndex = 68;
            this.lbl_ProdCodigo.Text = "Código producto";
            // 
            // lbl_CompFacturaNro
            // 
            this.lbl_CompFacturaNro.AutoSize = true;
            this.lbl_CompFacturaNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompFacturaNro.ForeColor = System.Drawing.Color.White;
            this.lbl_CompFacturaNro.Location = new System.Drawing.Point(15, 194);
            this.lbl_CompFacturaNro.Name = "lbl_CompFacturaNro";
            this.lbl_CompFacturaNro.Size = new System.Drawing.Size(148, 20);
            this.lbl_CompFacturaNro.TabIndex = 69;
            this.lbl_CompFacturaNro.Text = "Número de factura";
            // 
            // txt_CompFacturaPuntoVenta
            // 
            this.txt_CompFacturaPuntoVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_CompFacturaPuntoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CompFacturaPuntoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CompFacturaPuntoVenta.ForeColor = System.Drawing.Color.White;
            this.txt_CompFacturaPuntoVenta.Location = new System.Drawing.Point(204, 188);
            this.txt_CompFacturaPuntoVenta.Name = "txt_CompFacturaPuntoVenta";
            this.txt_CompFacturaPuntoVenta.Size = new System.Drawing.Size(59, 26);
            this.txt_CompFacturaPuntoVenta.TabIndex = 70;
            this.txt_CompFacturaPuntoVenta.TextChanged += new System.EventHandler(this.txt_CompFacturaPuntoVenta_TextChanged);
            // 
            // lbl_CompPrecioUnitProd
            // 
            this.lbl_CompPrecioUnitProd.AutoSize = true;
            this.lbl_CompPrecioUnitProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompPrecioUnitProd.ForeColor = System.Drawing.Color.White;
            this.lbl_CompPrecioUnitProd.Location = new System.Drawing.Point(15, 454);
            this.lbl_CompPrecioUnitProd.Name = "lbl_CompPrecioUnitProd";
            this.lbl_CompPrecioUnitProd.Size = new System.Drawing.Size(135, 20);
            this.lbl_CompPrecioUnitProd.TabIndex = 75;
            this.lbl_CompPrecioUnitProd.Text = "Precio Compra $";
            // 
            // txt_CompPrecioUnitProd
            // 
            this.txt_CompPrecioUnitProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_CompPrecioUnitProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CompPrecioUnitProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CompPrecioUnitProd.ForeColor = System.Drawing.Color.White;
            this.txt_CompPrecioUnitProd.Location = new System.Drawing.Point(204, 448);
            this.txt_CompPrecioUnitProd.Name = "txt_CompPrecioUnitProd";
            this.txt_CompPrecioUnitProd.Size = new System.Drawing.Size(216, 26);
            this.txt_CompPrecioUnitProd.TabIndex = 76;
            this.txt_CompPrecioUnitProd.TextChanged += new System.EventHandler(this.txt_CompPrecioUnitProd_TextChanged);
            // 
            // lbl_ProdDescripcion
            // 
            this.lbl_ProdDescripcion.AutoSize = true;
            this.lbl_ProdDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdDescripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_ProdDescripcion.Location = new System.Drawing.Point(15, 364);
            this.lbl_ProdDescripcion.Name = "lbl_ProdDescripcion";
            this.lbl_ProdDescripcion.Size = new System.Drawing.Size(99, 20);
            this.lbl_ProdDescripcion.TabIndex = 77;
            this.lbl_ProdDescripcion.Text = "Descripcion";
            // 
            // txt_ProdDescripcion
            // 
            this.txt_ProdDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProdDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdDescripcion.Enabled = false;
            this.txt_ProdDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProdDescripcion.ForeColor = System.Drawing.Color.White;
            this.txt_ProdDescripcion.Location = new System.Drawing.Point(204, 358);
            this.txt_ProdDescripcion.Name = "txt_ProdDescripcion";
            this.txt_ProdDescripcion.Size = new System.Drawing.Size(216, 26);
            this.txt_ProdDescripcion.TabIndex = 78;
            // 
            // btn_CompEditar
            // 
            this.btn_CompEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_CompEditar.FlatAppearance.BorderSize = 0;
            this.btn_CompEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CompEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CompEditar.ForeColor = System.Drawing.Color.White;
            this.btn_CompEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_CompEditar.IconColor = System.Drawing.Color.Black;
            this.btn_CompEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CompEditar.Location = new System.Drawing.Point(815, 499);
            this.btn_CompEditar.Name = "btn_CompEditar";
            this.btn_CompEditar.Size = new System.Drawing.Size(165, 39);
            this.btn_CompEditar.TabIndex = 79;
            this.btn_CompEditar.Text = "Editar";
            this.btn_CompEditar.UseVisualStyleBackColor = false;
            this.btn_CompEditar.Click += new System.EventHandler(this.btn_CompEditar_Click);
            // 
            // txt_CompFacturaNroComprobante
            // 
            this.txt_CompFacturaNroComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_CompFacturaNroComprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CompFacturaNroComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CompFacturaNroComprobante.ForeColor = System.Drawing.Color.White;
            this.txt_CompFacturaNroComprobante.Location = new System.Drawing.Point(269, 188);
            this.txt_CompFacturaNroComprobante.Name = "txt_CompFacturaNroComprobante";
            this.txt_CompFacturaNroComprobante.Size = new System.Drawing.Size(151, 26);
            this.txt_CompFacturaNroComprobante.TabIndex = 80;
            this.txt_CompFacturaNroComprobante.TextChanged += new System.EventHandler(this.txt_CompFacturaNroComprobante_TextChanged);
            // 
            // Frm_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1003, 550);
            this.Controls.Add(this.txt_CompFacturaNroComprobante);
            this.Controls.Add(this.btn_CompEditar);
            this.Controls.Add(this.txt_ProdDescripcion);
            this.Controls.Add(this.lbl_ProdDescripcion);
            this.Controls.Add(this.txt_CompPrecioUnitProd);
            this.Controls.Add(this.lbl_CompPrecioUnitProd);
            this.Controls.Add(this.txt_CompFacturaPuntoVenta);
            this.Controls.Add(this.lbl_CompFacturaNro);
            this.Controls.Add(this.lbl_ProdCodigo);
            this.Controls.Add(this.txt_ProdCodigo);
            this.Controls.Add(this.txt_ProvCUIT);
            this.Controls.Add(this.cmb_CompCondCompra);
            this.Controls.Add(this.lbl_CompItemsCant);
            this.Controls.Add(this.lbl_CompItems);
            this.Controls.Add(this.cmb_CompFacturaTipo);
            this.Controls.Add(this.dtp_CompFecha);
            this.Controls.Add(this.dgv_CompLista);
            this.Controls.Add(this.btn_CompEliminarItem);
            this.Controls.Add(this.lbl_CompFacturaTipo);
            this.Controls.Add(this.lbl_CompCondCompra);
            this.Controls.Add(this.lbl_CompCantidadProd);
            this.Controls.Add(this.txt_CompCantidadProd);
            this.Controls.Add(this.btn_CompTerminar);
            this.Controls.Add(this.btn_CompAgregarItem);
            this.Controls.Add(this.lbl_CompFecha);
            this.Controls.Add(this.lbl_ProvCUIT);
            this.Controls.Add(this.lbl_ProvNombre);
            this.Controls.Add(this.txt_ProvNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Compras";
            this.Text = "Frm_Ventas";
            this.Load += new System.EventHandler(this.Frm_Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CompLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ProvNombre;
        private System.Windows.Forms.Label lbl_ProvNombre;
        private System.Windows.Forms.Label lbl_ProvCUIT;
        private System.Windows.Forms.Label lbl_CompFecha;
        private FontAwesome.Sharp.IconButton btn_CompAgregarItem;
        private FontAwesome.Sharp.IconButton btn_CompTerminar;
        private System.Windows.Forms.Label lbl_CompCantidadProd;
        private System.Windows.Forms.TextBox txt_CompCantidadProd;
        private System.Windows.Forms.Label lbl_CompFacturaTipo;
        private System.Windows.Forms.Label lbl_CompCondCompra;
        private System.Windows.Forms.DataGridView dgv_CompLista;
        private FontAwesome.Sharp.IconButton btn_CompEliminarItem;
        private System.Windows.Forms.DateTimePicker dtp_CompFecha;
        private System.Windows.Forms.ComboBox cmb_CompFacturaTipo;
        private System.Windows.Forms.Label lbl_CompItems;
        private System.Windows.Forms.Label lbl_CompItemsCant;
        private System.Windows.Forms.ComboBox cmb_CompCondCompra;
        private System.Windows.Forms.TextBox txt_ProvCUIT;
        private System.Windows.Forms.TextBox txt_ProdCodigo;
        private System.Windows.Forms.Label lbl_ProdCodigo;
        private System.Windows.Forms.Label lbl_CompFacturaNro;
        private System.Windows.Forms.TextBox txt_CompFacturaPuntoVenta;
        private System.Windows.Forms.Label lbl_CompPrecioUnitProd;
        private System.Windows.Forms.TextBox txt_CompPrecioUnitProd;
        private System.Windows.Forms.Label lbl_ProdDescripcion;
        private System.Windows.Forms.TextBox txt_ProdDescripcion;
        private FontAwesome.Sharp.IconButton btn_CompEditar;
        private System.Windows.Forms.TextBox txt_CompFacturaNroComprobante;
    }
}