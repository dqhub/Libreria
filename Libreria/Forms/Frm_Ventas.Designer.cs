namespace Libreria.Forms
{
    partial class Frm_Ventas
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
            this.txt_ClieNombre = new System.Windows.Forms.TextBox();
            this.lbl_ClieNombre = new System.Windows.Forms.Label();
            this.cmb_ClieCUIT = new System.Windows.Forms.ComboBox();
            this.lbl_ClieCUIT = new System.Windows.Forms.Label();
            this.lbl_VentFecha = new System.Windows.Forms.Label();
            this.lbl_ProdDescripcion = new System.Windows.Forms.Label();
            this.txt_ProdDescripcion = new System.Windows.Forms.TextBox();
            this.lbl_ProdCodigo = new System.Windows.Forms.Label();
            this.lbl_ProdPrecioVenta = new System.Windows.Forms.Label();
            this.txt_ProdPrecioVenta = new System.Windows.Forms.TextBox();
            this.lbl_ProdCantidad = new System.Windows.Forms.Label();
            this.txt_ProdCantidad = new System.Windows.Forms.TextBox();
            this.lbl_VentTipoFactura = new System.Windows.Forms.Label();
            this.txt_VentNroFactura = new System.Windows.Forms.TextBox();
            this.lbl_VentCondVenta = new System.Windows.Forms.Label();
            this.dgv_VentLista = new System.Windows.Forms.DataGridView();
            this.btn_VentEliminar = new FontAwesome.Sharp.IconButton();
            this.btn_VentGuardar = new FontAwesome.Sharp.IconButton();
            this.btn_VentAgregar = new FontAwesome.Sharp.IconButton();
            this.dtp_VentFecha = new System.Windows.Forms.DateTimePicker();
            this.cmb_ProdCodigo = new System.Windows.Forms.ComboBox();
            this.cmb_VentTipoFactura = new System.Windows.Forms.ComboBox();
            this.lbl_VentNroFactura = new System.Windows.Forms.Label();
            this.lbl_VentTotalPrecio = new System.Windows.Forms.Label();
            this.lbl_VentTotal = new System.Windows.Forms.Label();
            this.lbl_VentItems = new System.Windows.Forms.Label();
            this.lbl_VentItemsCant = new System.Windows.Forms.Label();
            this.cmb_VentCondVenta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VentLista)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ClieNombre
            // 
            this.txt_ClieNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ClieNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ClieNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClieNombre.ForeColor = System.Drawing.Color.White;
            this.txt_ClieNombre.Location = new System.Drawing.Point(204, 57);
            this.txt_ClieNombre.Name = "txt_ClieNombre";
            this.txt_ClieNombre.Size = new System.Drawing.Size(216, 26);
            this.txt_ClieNombre.TabIndex = 0;
            // 
            // lbl_ClieNombre
            // 
            this.lbl_ClieNombre.AutoSize = true;
            this.lbl_ClieNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClieNombre.ForeColor = System.Drawing.Color.White;
            this.lbl_ClieNombre.Location = new System.Drawing.Point(15, 63);
            this.lbl_ClieNombre.Name = "lbl_ClieNombre";
            this.lbl_ClieNombre.Size = new System.Drawing.Size(148, 20);
            this.lbl_ClieNombre.TabIndex = 1;
            this.lbl_ClieNombre.Text = "Nombre de Cliente";
            // 
            // cmb_ClieCUIT
            // 
            this.cmb_ClieCUIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_ClieCUIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_ClieCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ClieCUIT.ForeColor = System.Drawing.Color.White;
            this.cmb_ClieCUIT.FormattingEnabled = true;
            this.cmb_ClieCUIT.Location = new System.Drawing.Point(204, 12);
            this.cmb_ClieCUIT.Name = "cmb_ClieCUIT";
            this.cmb_ClieCUIT.Size = new System.Drawing.Size(216, 28);
            this.cmb_ClieCUIT.TabIndex = 11;
            // 
            // lbl_ClieCUIT
            // 
            this.lbl_ClieCUIT.AutoSize = true;
            this.lbl_ClieCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClieCUIT.ForeColor = System.Drawing.Color.White;
            this.lbl_ClieCUIT.Location = new System.Drawing.Point(15, 20);
            this.lbl_ClieCUIT.Name = "lbl_ClieCUIT";
            this.lbl_ClieCUIT.Size = new System.Drawing.Size(104, 20);
            this.lbl_ClieCUIT.TabIndex = 10;
            this.lbl_ClieCUIT.Text = "Cliente CUIT";
            // 
            // lbl_VentFecha
            // 
            this.lbl_VentFecha.AutoSize = true;
            this.lbl_VentFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentFecha.ForeColor = System.Drawing.Color.White;
            this.lbl_VentFecha.Location = new System.Drawing.Point(15, 108);
            this.lbl_VentFecha.Name = "lbl_VentFecha";
            this.lbl_VentFecha.Size = new System.Drawing.Size(118, 20);
            this.lbl_VentFecha.TabIndex = 12;
            this.lbl_VentFecha.Text = "Fecha emisión";
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
            // lbl_ProdPrecioVenta
            // 
            this.lbl_ProdPrecioVenta.AutoSize = true;
            this.lbl_ProdPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdPrecioVenta.ForeColor = System.Drawing.Color.White;
            this.lbl_ProdPrecioVenta.Location = new System.Drawing.Point(15, 237);
            this.lbl_ProdPrecioVenta.Name = "lbl_ProdPrecioVenta";
            this.lbl_ProdPrecioVenta.Size = new System.Drawing.Size(119, 20);
            this.lbl_ProdPrecioVenta.TabIndex = 39;
            this.lbl_ProdPrecioVenta.Text = "Precio Venta $";
            // 
            // txt_ProdPrecioVenta
            // 
            this.txt_ProdPrecioVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProdPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProdPrecioVenta.ForeColor = System.Drawing.Color.White;
            this.txt_ProdPrecioVenta.Location = new System.Drawing.Point(204, 231);
            this.txt_ProdPrecioVenta.Name = "txt_ProdPrecioVenta";
            this.txt_ProdPrecioVenta.Size = new System.Drawing.Size(216, 26);
            this.txt_ProdPrecioVenta.TabIndex = 38;
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
            // lbl_VentTipoFactura
            // 
            this.lbl_VentTipoFactura.AutoSize = true;
            this.lbl_VentTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentTipoFactura.ForeColor = System.Drawing.Color.White;
            this.lbl_VentTipoFactura.Location = new System.Drawing.Point(15, 411);
            this.lbl_VentTipoFactura.Name = "lbl_VentTipoFactura";
            this.lbl_VentTipoFactura.Size = new System.Drawing.Size(103, 20);
            this.lbl_VentTipoFactura.TabIndex = 45;
            this.lbl_VentTipoFactura.Text = "Tipo Factura";
            // 
            // txt_VentNroFactura
            // 
            this.txt_VentNroFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_VentNroFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_VentNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VentNroFactura.ForeColor = System.Drawing.Color.White;
            this.txt_VentNroFactura.Location = new System.Drawing.Point(204, 448);
            this.txt_VentNroFactura.Name = "txt_VentNroFactura";
            this.txt_VentNroFactura.Size = new System.Drawing.Size(216, 26);
            this.txt_VentNroFactura.TabIndex = 44;
            // 
            // lbl_VentCondVenta
            // 
            this.lbl_VentCondVenta.AutoSize = true;
            this.lbl_VentCondVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentCondVenta.ForeColor = System.Drawing.Color.White;
            this.lbl_VentCondVenta.Location = new System.Drawing.Point(15, 363);
            this.lbl_VentCondVenta.Name = "lbl_VentCondVenta";
            this.lbl_VentCondVenta.Size = new System.Drawing.Size(154, 20);
            this.lbl_VentCondVenta.TabIndex = 43;
            this.lbl_VentCondVenta.Text = "Condición de Venta";
            // 
            // dgv_VentLista
            // 
            this.dgv_VentLista.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_VentLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VentLista.Location = new System.Drawing.Point(448, 12);
            this.dgv_VentLista.Name = "dgv_VentLista";
            this.dgv_VentLista.Size = new System.Drawing.Size(532, 371);
            this.dgv_VentLista.TabIndex = 50;
            // 
            // btn_VentEliminar
            // 
            this.btn_VentEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_VentEliminar.FlatAppearance.BorderSize = 0;
            this.btn_VentEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VentEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VentEliminar.ForeColor = System.Drawing.Color.White;
            this.btn_VentEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_VentEliminar.IconColor = System.Drawing.Color.Black;
            this.btn_VentEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_VentEliminar.Location = new System.Drawing.Point(448, 499);
            this.btn_VentEliminar.Name = "btn_VentEliminar";
            this.btn_VentEliminar.Size = new System.Drawing.Size(165, 39);
            this.btn_VentEliminar.TabIndex = 49;
            this.btn_VentEliminar.Text = "Eliminar";
            this.btn_VentEliminar.UseVisualStyleBackColor = false;
            // 
            // btn_VentGuardar
            // 
            this.btn_VentGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_VentGuardar.FlatAppearance.BorderSize = 0;
            this.btn_VentGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VentGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VentGuardar.ForeColor = System.Drawing.Color.White;
            this.btn_VentGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_VentGuardar.IconColor = System.Drawing.Color.Black;
            this.btn_VentGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_VentGuardar.Location = new System.Drawing.Point(815, 499);
            this.btn_VentGuardar.Name = "btn_VentGuardar";
            this.btn_VentGuardar.Size = new System.Drawing.Size(165, 39);
            this.btn_VentGuardar.TabIndex = 32;
            this.btn_VentGuardar.Text = "Guardar Venta";
            this.btn_VentGuardar.UseVisualStyleBackColor = false;
            this.btn_VentGuardar.Click += new System.EventHandler(this.btn_GuardarVenta_Click);
            // 
            // btn_VentAgregar
            // 
            this.btn_VentAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_VentAgregar.FlatAppearance.BorderSize = 0;
            this.btn_VentAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VentAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VentAgregar.ForeColor = System.Drawing.Color.White;
            this.btn_VentAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_VentAgregar.IconColor = System.Drawing.Color.Black;
            this.btn_VentAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_VentAgregar.Location = new System.Drawing.Point(19, 499);
            this.btn_VentAgregar.Name = "btn_VentAgregar";
            this.btn_VentAgregar.Size = new System.Drawing.Size(165, 39);
            this.btn_VentAgregar.TabIndex = 31;
            this.btn_VentAgregar.Text = "Agregar";
            this.btn_VentAgregar.UseVisualStyleBackColor = false;
            // 
            // dtp_VentFecha
            // 
            this.dtp_VentFecha.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtp_VentFecha.Location = new System.Drawing.Point(204, 107);
            this.dtp_VentFecha.Name = "dtp_VentFecha";
            this.dtp_VentFecha.Size = new System.Drawing.Size(216, 20);
            this.dtp_VentFecha.TabIndex = 56;
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
            // cmb_VentTipoFactura
            // 
            this.cmb_VentTipoFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmb_VentTipoFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_VentTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_VentTipoFactura.ForeColor = System.Drawing.Color.White;
            this.cmb_VentTipoFactura.FormattingEnabled = true;
            this.cmb_VentTipoFactura.Items.AddRange(new object[] {
            "FACTURA A",
            "FACTURA B",
            "FACTURA C"});
            this.cmb_VentTipoFactura.Location = new System.Drawing.Point(204, 403);
            this.cmb_VentTipoFactura.Name = "cmb_VentTipoFactura";
            this.cmb_VentTipoFactura.Size = new System.Drawing.Size(216, 28);
            this.cmb_VentTipoFactura.TabIndex = 58;
            // 
            // lbl_VentNroFactura
            // 
            this.lbl_VentNroFactura.AutoSize = true;
            this.lbl_VentNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentNroFactura.ForeColor = System.Drawing.Color.White;
            this.lbl_VentNroFactura.Location = new System.Drawing.Point(15, 454);
            this.lbl_VentNroFactura.Name = "lbl_VentNroFactura";
            this.lbl_VentNroFactura.Size = new System.Drawing.Size(148, 20);
            this.lbl_VentNroFactura.TabIndex = 59;
            this.lbl_VentNroFactura.Text = "Número de factura";
            // 
            // lbl_VentTotalPrecio
            // 
            this.lbl_VentTotalPrecio.AutoSize = true;
            this.lbl_VentTotalPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentTotalPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_VentTotalPrecio.Location = new System.Drawing.Point(777, 411);
            this.lbl_VentTotalPrecio.Name = "lbl_VentTotalPrecio";
            this.lbl_VentTotalPrecio.Size = new System.Drawing.Size(203, 47);
            this.lbl_VentTotalPrecio.TabIndex = 60;
            this.lbl_VentTotalPrecio.Text = "$ 1245,30";
            // 
            // lbl_VentTotal
            // 
            this.lbl_VentTotal.AutoSize = true;
            this.lbl_VentTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentTotal.ForeColor = System.Drawing.Color.White;
            this.lbl_VentTotal.Location = new System.Drawing.Point(781, 391);
            this.lbl_VentTotal.Name = "lbl_VentTotal";
            this.lbl_VentTotal.Size = new System.Drawing.Size(46, 20);
            this.lbl_VentTotal.TabIndex = 61;
            this.lbl_VentTotal.Text = "Total";
            // 
            // lbl_VentItems
            // 
            this.lbl_VentItems.AutoSize = true;
            this.lbl_VentItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentItems.ForeColor = System.Drawing.Color.White;
            this.lbl_VentItems.Location = new System.Drawing.Point(444, 391);
            this.lbl_VentItems.Name = "lbl_VentItems";
            this.lbl_VentItems.Size = new System.Drawing.Size(50, 20);
            this.lbl_VentItems.TabIndex = 62;
            this.lbl_VentItems.Text = "Items";
            // 
            // lbl_VentItemsCant
            // 
            this.lbl_VentItemsCant.AutoSize = true;
            this.lbl_VentItemsCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VentItemsCant.ForeColor = System.Drawing.Color.SkyBlue;
            this.lbl_VentItemsCant.Location = new System.Drawing.Point(440, 411);
            this.lbl_VentItemsCant.Name = "lbl_VentItemsCant";
            this.lbl_VentItemsCant.Size = new System.Drawing.Size(74, 31);
            this.lbl_VentItemsCant.TabIndex = 63;
            this.lbl_VentItemsCant.Text = "#123";
            // 
            // cmb_VentCondVenta
            // 
            this.cmb_VentCondVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmb_VentCondVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_VentCondVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_VentCondVenta.ForeColor = System.Drawing.Color.White;
            this.cmb_VentCondVenta.FormattingEnabled = true;
            this.cmb_VentCondVenta.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA CRÉDITO",
            "TARJETA DÉBITO"});
            this.cmb_VentCondVenta.Location = new System.Drawing.Point(204, 355);
            this.cmb_VentCondVenta.Name = "cmb_VentCondVenta";
            this.cmb_VentCondVenta.Size = new System.Drawing.Size(216, 28);
            this.cmb_VentCondVenta.TabIndex = 64;
            // 
            // Frm_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1003, 550);
            this.Controls.Add(this.cmb_VentCondVenta);
            this.Controls.Add(this.lbl_VentItemsCant);
            this.Controls.Add(this.lbl_VentItems);
            this.Controls.Add(this.lbl_VentTotal);
            this.Controls.Add(this.lbl_VentTotalPrecio);
            this.Controls.Add(this.lbl_VentNroFactura);
            this.Controls.Add(this.cmb_VentTipoFactura);
            this.Controls.Add(this.cmb_ProdCodigo);
            this.Controls.Add(this.dtp_VentFecha);
            this.Controls.Add(this.dgv_VentLista);
            this.Controls.Add(this.btn_VentEliminar);
            this.Controls.Add(this.lbl_VentTipoFactura);
            this.Controls.Add(this.txt_VentNroFactura);
            this.Controls.Add(this.lbl_VentCondVenta);
            this.Controls.Add(this.lbl_ProdCantidad);
            this.Controls.Add(this.txt_ProdCantidad);
            this.Controls.Add(this.lbl_ProdPrecioVenta);
            this.Controls.Add(this.txt_ProdPrecioVenta);
            this.Controls.Add(this.btn_VentGuardar);
            this.Controls.Add(this.btn_VentAgregar);
            this.Controls.Add(this.lbl_ProdCodigo);
            this.Controls.Add(this.lbl_ProdDescripcion);
            this.Controls.Add(this.txt_ProdDescripcion);
            this.Controls.Add(this.lbl_VentFecha);
            this.Controls.Add(this.cmb_ClieCUIT);
            this.Controls.Add(this.lbl_ClieCUIT);
            this.Controls.Add(this.lbl_ClieNombre);
            this.Controls.Add(this.txt_ClieNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Ventas";
            this.Text = "Frm_Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VentLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ClieNombre;
        private System.Windows.Forms.Label lbl_ClieNombre;
        private System.Windows.Forms.ComboBox cmb_ClieCUIT;
        private System.Windows.Forms.Label lbl_ClieCUIT;
        private System.Windows.Forms.Label lbl_VentFecha;
        private System.Windows.Forms.Label lbl_ProdDescripcion;
        private System.Windows.Forms.TextBox txt_ProdDescripcion;
        private System.Windows.Forms.Label lbl_ProdCodigo;
        private FontAwesome.Sharp.IconButton btn_VentAgregar;
        private FontAwesome.Sharp.IconButton btn_VentGuardar;
        private System.Windows.Forms.Label lbl_ProdPrecioVenta;
        private System.Windows.Forms.TextBox txt_ProdPrecioVenta;
        private System.Windows.Forms.Label lbl_ProdCantidad;
        private System.Windows.Forms.TextBox txt_ProdCantidad;
        private System.Windows.Forms.Label lbl_VentTipoFactura;
        private System.Windows.Forms.TextBox txt_VentNroFactura;
        private System.Windows.Forms.Label lbl_VentCondVenta;
        private System.Windows.Forms.DataGridView dgv_VentLista;
        private FontAwesome.Sharp.IconButton btn_VentEliminar;
        private System.Windows.Forms.DateTimePicker dtp_VentFecha;
        private System.Windows.Forms.ComboBox cmb_ProdCodigo;
        private System.Windows.Forms.ComboBox cmb_VentTipoFactura;
        private System.Windows.Forms.Label lbl_VentNroFactura;
        private System.Windows.Forms.Label lbl_VentTotalPrecio;
        private System.Windows.Forms.Label lbl_VentTotal;
        private System.Windows.Forms.Label lbl_VentItems;
        private System.Windows.Forms.Label lbl_VentItemsCant;
        private System.Windows.Forms.ComboBox cmb_VentCondVenta;
    }
}