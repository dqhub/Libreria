namespace Libreria.Forms
{
    partial class Frm_Proveedores
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
            this.lbl_ProvDomicilio = new System.Windows.Forms.Label();
            this.cmb_ProvCondicionVenta = new System.Windows.Forms.ComboBox();
            this.lbl_ProvCondicionVenta = new System.Windows.Forms.Label();
            this.lbl_ProvCondicionIVA = new System.Windows.Forms.Label();
            this.txt_ProvCondicionIVA = new System.Windows.Forms.TextBox();
            this.lbl_ProvIngBrutos = new System.Windows.Forms.Label();
            this.txt_ProvIngBrutos = new System.Windows.Forms.TextBox();
            this.lbl_ProvInicioActividad = new System.Windows.Forms.Label();
            this.txt_ProvInicioActividad = new System.Windows.Forms.TextBox();
            this.lbl_ProvContacto = new System.Windows.Forms.Label();
            this.txt_ProvContacto = new System.Windows.Forms.TextBox();
            this.lbl_ProvMail = new System.Windows.Forms.Label();
            this.txt_ProvMail = new System.Windows.Forms.TextBox();
            this.lbl_ProvTelefono2 = new System.Windows.Forms.Label();
            this.txt_ProvTelefono2 = new System.Windows.Forms.TextBox();
            this.lbl_ProvTelefono1 = new System.Windows.Forms.Label();
            this.txt_ProvTelefono1 = new System.Windows.Forms.TextBox();
            this.dgv_ProvLista = new System.Windows.Forms.DataGridView();
            this.txt_ProvDomicilio = new System.Windows.Forms.TextBox();
            this.btn_ProvEliminar = new FontAwesome.Sharp.IconButton();
            this.btn_ProvEditar = new FontAwesome.Sharp.IconButton();
            this.btn_ProvGuardar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProvLista)).BeginInit();
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
            this.lbl_ProvNombre.Size = new System.Drawing.Size(182, 20);
            this.lbl_ProvNombre.TabIndex = 1;
            this.lbl_ProvNombre.Text = "Nombre / Razón Social";
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
            // lbl_ProvDomicilio
            // 
            this.lbl_ProvDomicilio.AutoSize = true;
            this.lbl_ProvDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProvDomicilio.ForeColor = System.Drawing.Color.White;
            this.lbl_ProvDomicilio.Location = new System.Drawing.Point(15, 108);
            this.lbl_ProvDomicilio.Name = "lbl_ProvDomicilio";
            this.lbl_ProvDomicilio.Size = new System.Drawing.Size(79, 20);
            this.lbl_ProvDomicilio.TabIndex = 12;
            this.lbl_ProvDomicilio.Text = "Domicilio";
            // 
            // cmb_ProvCondicionVenta
            // 
            this.cmb_ProvCondicionVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_ProvCondicionVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_ProvCondicionVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProvCondicionVenta.ForeColor = System.Drawing.Color.White;
            this.cmb_ProvCondicionVenta.FormattingEnabled = true;
            this.cmb_ProvCondicionVenta.Items.AddRange(new object[] {
            "CONTADO",
            "TARJETA",
            "DEBITO"});
            this.cmb_ProvCondicionVenta.Location = new System.Drawing.Point(204, 274);
            this.cmb_ProvCondicionVenta.Name = "cmb_ProvCondicionVenta";
            this.cmb_ProvCondicionVenta.Size = new System.Drawing.Size(216, 28);
            this.cmb_ProvCondicionVenta.TabIndex = 19;
            // 
            // lbl_ProvCondicionVenta
            // 
            this.lbl_ProvCondicionVenta.AutoSize = true;
            this.lbl_ProvCondicionVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProvCondicionVenta.ForeColor = System.Drawing.Color.White;
            this.lbl_ProvCondicionVenta.Location = new System.Drawing.Point(15, 282);
            this.lbl_ProvCondicionVenta.Name = "lbl_ProvCondicionVenta";
            this.lbl_ProvCondicionVenta.Size = new System.Drawing.Size(154, 20);
            this.lbl_ProvCondicionVenta.TabIndex = 18;
            this.lbl_ProvCondicionVenta.Text = "Condición de Venta";
            // 
            // lbl_ProvCondicionIVA
            // 
            this.lbl_ProvCondicionIVA.AutoSize = true;
            this.lbl_ProvCondicionIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProvCondicionIVA.ForeColor = System.Drawing.Color.White;
            this.lbl_ProvCondicionIVA.Location = new System.Drawing.Point(15, 194);
            this.lbl_ProvCondicionIVA.Name = "lbl_ProvCondicionIVA";
            this.lbl_ProvCondicionIVA.Size = new System.Drawing.Size(114, 20);
            this.lbl_ProvCondicionIVA.TabIndex = 21;
            this.lbl_ProvCondicionIVA.Text = "Condicion IVA";
            // 
            // txt_ProvCondicionIVA
            // 
            this.txt_ProvCondicionIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProvCondicionIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProvCondicionIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProvCondicionIVA.ForeColor = System.Drawing.Color.White;
            this.txt_ProvCondicionIVA.Location = new System.Drawing.Point(204, 188);
            this.txt_ProvCondicionIVA.Name = "txt_ProvCondicionIVA";
            this.txt_ProvCondicionIVA.Size = new System.Drawing.Size(216, 26);
            this.txt_ProvCondicionIVA.TabIndex = 20;
            // 
            // lbl_ProvIngBrutos
            // 
            this.lbl_ProvIngBrutos.AutoSize = true;
            this.lbl_ProvIngBrutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProvIngBrutos.ForeColor = System.Drawing.Color.White;
            this.lbl_ProvIngBrutos.Location = new System.Drawing.Point(15, 151);
            this.lbl_ProvIngBrutos.Name = "lbl_ProvIngBrutos";
            this.lbl_ProvIngBrutos.Size = new System.Drawing.Size(90, 20);
            this.lbl_ProvIngBrutos.TabIndex = 25;
            this.lbl_ProvIngBrutos.Text = "Ing. Brutos";
            // 
            // txt_ProvIngBrutos
            // 
            this.txt_ProvIngBrutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProvIngBrutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProvIngBrutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProvIngBrutos.ForeColor = System.Drawing.Color.White;
            this.txt_ProvIngBrutos.Location = new System.Drawing.Point(204, 145);
            this.txt_ProvIngBrutos.Name = "txt_ProvIngBrutos";
            this.txt_ProvIngBrutos.Size = new System.Drawing.Size(216, 26);
            this.txt_ProvIngBrutos.TabIndex = 24;
            // 
            // lbl_ProvInicioActividad
            // 
            this.lbl_ProvInicioActividad.AutoSize = true;
            this.lbl_ProvInicioActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProvInicioActividad.ForeColor = System.Drawing.Color.White;
            this.lbl_ProvInicioActividad.Location = new System.Drawing.Point(15, 237);
            this.lbl_ProvInicioActividad.Name = "lbl_ProvInicioActividad";
            this.lbl_ProvInicioActividad.Size = new System.Drawing.Size(121, 20);
            this.lbl_ProvInicioActividad.TabIndex = 37;
            this.lbl_ProvInicioActividad.Text = "Inicio Actividad";
            // 
            // txt_ProvInicioActividad
            // 
            this.txt_ProvInicioActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProvInicioActividad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProvInicioActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProvInicioActividad.ForeColor = System.Drawing.Color.White;
            this.txt_ProvInicioActividad.Location = new System.Drawing.Point(204, 231);
            this.txt_ProvInicioActividad.Name = "txt_ProvInicioActividad";
            this.txt_ProvInicioActividad.Size = new System.Drawing.Size(216, 26);
            this.txt_ProvInicioActividad.TabIndex = 36;
            // 
            // lbl_ProvContacto
            // 
            this.lbl_ProvContacto.AutoSize = true;
            this.lbl_ProvContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProvContacto.ForeColor = System.Drawing.Color.White;
            this.lbl_ProvContacto.Location = new System.Drawing.Point(15, 325);
            this.lbl_ProvContacto.Name = "lbl_ProvContacto";
            this.lbl_ProvContacto.Size = new System.Drawing.Size(137, 20);
            this.lbl_ProvContacto.TabIndex = 39;
            this.lbl_ProvContacto.Text = "Nombre contacto";
            // 
            // txt_ProvContacto
            // 
            this.txt_ProvContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProvContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProvContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProvContacto.ForeColor = System.Drawing.Color.White;
            this.txt_ProvContacto.Location = new System.Drawing.Point(204, 319);
            this.txt_ProvContacto.Name = "txt_ProvContacto";
            this.txt_ProvContacto.Size = new System.Drawing.Size(216, 26);
            this.txt_ProvContacto.TabIndex = 38;
            // 
            // lbl_ProvMail
            // 
            this.lbl_ProvMail.AutoSize = true;
            this.lbl_ProvMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProvMail.ForeColor = System.Drawing.Color.White;
            this.lbl_ProvMail.Location = new System.Drawing.Point(15, 368);
            this.lbl_ProvMail.Name = "lbl_ProvMail";
            this.lbl_ProvMail.Size = new System.Drawing.Size(40, 20);
            this.lbl_ProvMail.TabIndex = 41;
            this.lbl_ProvMail.Text = "Mail";
            // 
            // txt_ProvMail
            // 
            this.txt_ProvMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProvMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProvMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProvMail.ForeColor = System.Drawing.Color.White;
            this.txt_ProvMail.Location = new System.Drawing.Point(204, 362);
            this.txt_ProvMail.Name = "txt_ProvMail";
            this.txt_ProvMail.Size = new System.Drawing.Size(216, 26);
            this.txt_ProvMail.TabIndex = 40;
            // 
            // lbl_ProvTelefono2
            // 
            this.lbl_ProvTelefono2.AutoSize = true;
            this.lbl_ProvTelefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProvTelefono2.ForeColor = System.Drawing.Color.White;
            this.lbl_ProvTelefono2.Location = new System.Drawing.Point(15, 454);
            this.lbl_ProvTelefono2.Name = "lbl_ProvTelefono2";
            this.lbl_ProvTelefono2.Size = new System.Drawing.Size(87, 20);
            this.lbl_ProvTelefono2.TabIndex = 45;
            this.lbl_ProvTelefono2.Text = "Telefono 2";
            // 
            // txt_ProvTelefono2
            // 
            this.txt_ProvTelefono2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProvTelefono2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProvTelefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProvTelefono2.ForeColor = System.Drawing.Color.White;
            this.txt_ProvTelefono2.Location = new System.Drawing.Point(204, 448);
            this.txt_ProvTelefono2.Name = "txt_ProvTelefono2";
            this.txt_ProvTelefono2.Size = new System.Drawing.Size(216, 26);
            this.txt_ProvTelefono2.TabIndex = 44;
            // 
            // lbl_ProvTelefono1
            // 
            this.lbl_ProvTelefono1.AutoSize = true;
            this.lbl_ProvTelefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProvTelefono1.ForeColor = System.Drawing.Color.White;
            this.lbl_ProvTelefono1.Location = new System.Drawing.Point(15, 411);
            this.lbl_ProvTelefono1.Name = "lbl_ProvTelefono1";
            this.lbl_ProvTelefono1.Size = new System.Drawing.Size(87, 20);
            this.lbl_ProvTelefono1.TabIndex = 43;
            this.lbl_ProvTelefono1.Text = "Telefono 1";
            // 
            // txt_ProvTelefono1
            // 
            this.txt_ProvTelefono1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProvTelefono1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProvTelefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProvTelefono1.ForeColor = System.Drawing.Color.White;
            this.txt_ProvTelefono1.Location = new System.Drawing.Point(204, 405);
            this.txt_ProvTelefono1.Name = "txt_ProvTelefono1";
            this.txt_ProvTelefono1.Size = new System.Drawing.Size(216, 26);
            this.txt_ProvTelefono1.TabIndex = 42;
            // 
            // dgv_ProvLista
            // 
            this.dgv_ProvLista.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_ProvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProvLista.Location = new System.Drawing.Point(448, 12);
            this.dgv_ProvLista.Name = "dgv_ProvLista";
            this.dgv_ProvLista.Size = new System.Drawing.Size(532, 462);
            this.dgv_ProvLista.TabIndex = 50;
            // 
            // txt_ProvDomicilio
            // 
            this.txt_ProvDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProvDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProvDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProvDomicilio.ForeColor = System.Drawing.Color.White;
            this.txt_ProvDomicilio.Location = new System.Drawing.Point(204, 102);
            this.txt_ProvDomicilio.Name = "txt_ProvDomicilio";
            this.txt_ProvDomicilio.Size = new System.Drawing.Size(216, 26);
            this.txt_ProvDomicilio.TabIndex = 51;
            // 
            // btn_ProvEliminar
            // 
            this.btn_ProvEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_ProvEliminar.FlatAppearance.BorderSize = 0;
            this.btn_ProvEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProvEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProvEliminar.ForeColor = System.Drawing.Color.White;
            this.btn_ProvEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_ProvEliminar.IconColor = System.Drawing.Color.Black;
            this.btn_ProvEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ProvEliminar.Location = new System.Drawing.Point(448, 499);
            this.btn_ProvEliminar.Name = "btn_ProvEliminar";
            this.btn_ProvEliminar.Size = new System.Drawing.Size(165, 39);
            this.btn_ProvEliminar.TabIndex = 49;
            this.btn_ProvEliminar.Text = "Eliminar";
            this.btn_ProvEliminar.UseVisualStyleBackColor = false;
            // 
            // btn_ProvEditar
            // 
            this.btn_ProvEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_ProvEditar.FlatAppearance.BorderSize = 0;
            this.btn_ProvEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProvEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProvEditar.ForeColor = System.Drawing.Color.White;
            this.btn_ProvEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_ProvEditar.IconColor = System.Drawing.Color.Black;
            this.btn_ProvEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ProvEditar.Location = new System.Drawing.Point(815, 499);
            this.btn_ProvEditar.Name = "btn_ProvEditar";
            this.btn_ProvEditar.Size = new System.Drawing.Size(165, 39);
            this.btn_ProvEditar.TabIndex = 48;
            this.btn_ProvEditar.Text = "Editar";
            this.btn_ProvEditar.UseVisualStyleBackColor = false;
            // 
            // btn_ProvGuardar
            // 
            this.btn_ProvGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_ProvGuardar.FlatAppearance.BorderSize = 0;
            this.btn_ProvGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProvGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProvGuardar.ForeColor = System.Drawing.Color.White;
            this.btn_ProvGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_ProvGuardar.IconColor = System.Drawing.Color.Black;
            this.btn_ProvGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ProvGuardar.Location = new System.Drawing.Point(19, 499);
            this.btn_ProvGuardar.Name = "btn_ProvGuardar";
            this.btn_ProvGuardar.Size = new System.Drawing.Size(165, 39);
            this.btn_ProvGuardar.TabIndex = 32;
            this.btn_ProvGuardar.Text = "Guardar";
            this.btn_ProvGuardar.UseVisualStyleBackColor = false;
            this.btn_ProvGuardar.Click += new System.EventHandler(this.btn_GuardarVenta_Click);
            // 
            // Frm_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1003, 550);
            this.Controls.Add(this.txt_ProvDomicilio);
            this.Controls.Add(this.dgv_ProvLista);
            this.Controls.Add(this.btn_ProvEliminar);
            this.Controls.Add(this.btn_ProvEditar);
            this.Controls.Add(this.lbl_ProvTelefono2);
            this.Controls.Add(this.txt_ProvTelefono2);
            this.Controls.Add(this.lbl_ProvTelefono1);
            this.Controls.Add(this.txt_ProvTelefono1);
            this.Controls.Add(this.lbl_ProvMail);
            this.Controls.Add(this.txt_ProvMail);
            this.Controls.Add(this.lbl_ProvContacto);
            this.Controls.Add(this.txt_ProvContacto);
            this.Controls.Add(this.lbl_ProvInicioActividad);
            this.Controls.Add(this.txt_ProvInicioActividad);
            this.Controls.Add(this.btn_ProvGuardar);
            this.Controls.Add(this.lbl_ProvIngBrutos);
            this.Controls.Add(this.txt_ProvIngBrutos);
            this.Controls.Add(this.lbl_ProvCondicionIVA);
            this.Controls.Add(this.txt_ProvCondicionIVA);
            this.Controls.Add(this.cmb_ProvCondicionVenta);
            this.Controls.Add(this.lbl_ProvCondicionVenta);
            this.Controls.Add(this.lbl_ProvDomicilio);
            this.Controls.Add(this.cmb_ProvCUIT);
            this.Controls.Add(this.lbl_ProvCUIT);
            this.Controls.Add(this.lbl_ProvNombre);
            this.Controls.Add(this.txt_ProvNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Proveedores";
            this.Text = "Frm_Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ProvNombre;
        private System.Windows.Forms.Label lbl_ProvNombre;
        private System.Windows.Forms.ComboBox cmb_ProvCUIT;
        private System.Windows.Forms.Label lbl_ProvCUIT;
        private System.Windows.Forms.Label lbl_ProvDomicilio;
        private System.Windows.Forms.ComboBox cmb_ProvCondicionVenta;
        private System.Windows.Forms.Label lbl_ProvCondicionVenta;
        private System.Windows.Forms.Label lbl_ProvCondicionIVA;
        private System.Windows.Forms.TextBox txt_ProvCondicionIVA;
        private System.Windows.Forms.Label lbl_ProvIngBrutos;
        private System.Windows.Forms.TextBox txt_ProvIngBrutos;
        private FontAwesome.Sharp.IconButton btn_ProvGuardar;
        private System.Windows.Forms.Label lbl_ProvInicioActividad;
        private System.Windows.Forms.TextBox txt_ProvInicioActividad;
        private System.Windows.Forms.Label lbl_ProvContacto;
        private System.Windows.Forms.TextBox txt_ProvContacto;
        private System.Windows.Forms.Label lbl_ProvMail;
        private System.Windows.Forms.TextBox txt_ProvMail;
        private System.Windows.Forms.Label lbl_ProvTelefono2;
        private System.Windows.Forms.TextBox txt_ProvTelefono2;
        private System.Windows.Forms.Label lbl_ProvTelefono1;
        private System.Windows.Forms.TextBox txt_ProvTelefono1;
        private System.Windows.Forms.DataGridView dgv_ProvLista;
        private FontAwesome.Sharp.IconButton btn_ProvEliminar;
        private FontAwesome.Sharp.IconButton btn_ProvEditar;
        private System.Windows.Forms.TextBox txt_ProvDomicilio;
    }
}