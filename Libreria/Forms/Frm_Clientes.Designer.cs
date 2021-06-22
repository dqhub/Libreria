namespace Libreria.Forms
{
    partial class Frm_Clientes
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
            this.lbl_ClieCUIT = new System.Windows.Forms.Label();
            this.lbl_ClieDomicilio = new System.Windows.Forms.Label();
            this.lbl_ClieCondicionIVA = new System.Windows.Forms.Label();
            this.lbl_ClieIngBrutos = new System.Windows.Forms.Label();
            this.txt_ClieIngBrutos = new System.Windows.Forms.TextBox();
            this.lbl_ClieContacto = new System.Windows.Forms.Label();
            this.txt_ClieContacto = new System.Windows.Forms.TextBox();
            this.lbl_ClieMail = new System.Windows.Forms.Label();
            this.txt_ClieMail = new System.Windows.Forms.TextBox();
            this.lbl_ClieTelefono2 = new System.Windows.Forms.Label();
            this.txt_ClieTelefono2 = new System.Windows.Forms.TextBox();
            this.lbl_ClieTelefono1 = new System.Windows.Forms.Label();
            this.txt_ClieTelefono1 = new System.Windows.Forms.TextBox();
            this.dgv_ClieLista = new System.Windows.Forms.DataGridView();
            this.txt_ClieDomicilio = new System.Windows.Forms.TextBox();
            this.btn_ClieEliminar = new FontAwesome.Sharp.IconButton();
            this.btn_ClieEditar = new FontAwesome.Sharp.IconButton();
            this.btn_ClieGuardar = new FontAwesome.Sharp.IconButton();
            this.cmb_ClieCondicionIVA = new System.Windows.Forms.ComboBox();
            this.txt_ClieCUIT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClieLista)).BeginInit();
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
            this.txt_ClieNombre.TextChanged += new System.EventHandler(this.txt_ClieNombre_TextChanged);
            // 
            // lbl_ClieNombre
            // 
            this.lbl_ClieNombre.AutoSize = true;
            this.lbl_ClieNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClieNombre.ForeColor = System.Drawing.Color.White;
            this.lbl_ClieNombre.Location = new System.Drawing.Point(15, 63);
            this.lbl_ClieNombre.Name = "lbl_ClieNombre";
            this.lbl_ClieNombre.Size = new System.Drawing.Size(182, 20);
            this.lbl_ClieNombre.TabIndex = 1;
            this.lbl_ClieNombre.Text = "Nombre / Razón Social";
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
            // lbl_ClieDomicilio
            // 
            this.lbl_ClieDomicilio.AutoSize = true;
            this.lbl_ClieDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClieDomicilio.ForeColor = System.Drawing.Color.White;
            this.lbl_ClieDomicilio.Location = new System.Drawing.Point(15, 108);
            this.lbl_ClieDomicilio.Name = "lbl_ClieDomicilio";
            this.lbl_ClieDomicilio.Size = new System.Drawing.Size(79, 20);
            this.lbl_ClieDomicilio.TabIndex = 12;
            this.lbl_ClieDomicilio.Text = "Domicilio";
            // 
            // lbl_ClieCondicionIVA
            // 
            this.lbl_ClieCondicionIVA.AutoSize = true;
            this.lbl_ClieCondicionIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClieCondicionIVA.ForeColor = System.Drawing.Color.White;
            this.lbl_ClieCondicionIVA.Location = new System.Drawing.Point(15, 194);
            this.lbl_ClieCondicionIVA.Name = "lbl_ClieCondicionIVA";
            this.lbl_ClieCondicionIVA.Size = new System.Drawing.Size(114, 20);
            this.lbl_ClieCondicionIVA.TabIndex = 21;
            this.lbl_ClieCondicionIVA.Text = "Condicion IVA";
            // 
            // lbl_ClieIngBrutos
            // 
            this.lbl_ClieIngBrutos.AutoSize = true;
            this.lbl_ClieIngBrutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClieIngBrutos.ForeColor = System.Drawing.Color.White;
            this.lbl_ClieIngBrutos.Location = new System.Drawing.Point(15, 151);
            this.lbl_ClieIngBrutos.Name = "lbl_ClieIngBrutos";
            this.lbl_ClieIngBrutos.Size = new System.Drawing.Size(90, 20);
            this.lbl_ClieIngBrutos.TabIndex = 25;
            this.lbl_ClieIngBrutos.Text = "Ing. Brutos";
            // 
            // txt_ClieIngBrutos
            // 
            this.txt_ClieIngBrutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ClieIngBrutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ClieIngBrutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClieIngBrutos.ForeColor = System.Drawing.Color.White;
            this.txt_ClieIngBrutos.Location = new System.Drawing.Point(204, 145);
            this.txt_ClieIngBrutos.Name = "txt_ClieIngBrutos";
            this.txt_ClieIngBrutos.Size = new System.Drawing.Size(216, 26);
            this.txt_ClieIngBrutos.TabIndex = 24;
            this.txt_ClieIngBrutos.TextChanged += new System.EventHandler(this.txt_ClieIngBrutos_TextChanged);
            // 
            // lbl_ClieContacto
            // 
            this.lbl_ClieContacto.AutoSize = true;
            this.lbl_ClieContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClieContacto.ForeColor = System.Drawing.Color.White;
            this.lbl_ClieContacto.Location = new System.Drawing.Point(15, 237);
            this.lbl_ClieContacto.Name = "lbl_ClieContacto";
            this.lbl_ClieContacto.Size = new System.Drawing.Size(137, 20);
            this.lbl_ClieContacto.TabIndex = 39;
            this.lbl_ClieContacto.Text = "Nombre contacto";
            // 
            // txt_ClieContacto
            // 
            this.txt_ClieContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ClieContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ClieContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClieContacto.ForeColor = System.Drawing.Color.White;
            this.txt_ClieContacto.Location = new System.Drawing.Point(204, 231);
            this.txt_ClieContacto.Name = "txt_ClieContacto";
            this.txt_ClieContacto.Size = new System.Drawing.Size(216, 26);
            this.txt_ClieContacto.TabIndex = 38;
            this.txt_ClieContacto.TextChanged += new System.EventHandler(this.txt_ClieContacto_TextChanged);
            // 
            // lbl_ClieMail
            // 
            this.lbl_ClieMail.AutoSize = true;
            this.lbl_ClieMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClieMail.ForeColor = System.Drawing.Color.White;
            this.lbl_ClieMail.Location = new System.Drawing.Point(15, 280);
            this.lbl_ClieMail.Name = "lbl_ClieMail";
            this.lbl_ClieMail.Size = new System.Drawing.Size(40, 20);
            this.lbl_ClieMail.TabIndex = 41;
            this.lbl_ClieMail.Text = "Mail";
            // 
            // txt_ClieMail
            // 
            this.txt_ClieMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ClieMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ClieMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClieMail.ForeColor = System.Drawing.Color.White;
            this.txt_ClieMail.Location = new System.Drawing.Point(204, 274);
            this.txt_ClieMail.Name = "txt_ClieMail";
            this.txt_ClieMail.Size = new System.Drawing.Size(216, 26);
            this.txt_ClieMail.TabIndex = 40;
            this.txt_ClieMail.TextChanged += new System.EventHandler(this.txt_ClieMail_TextChanged);
            // 
            // lbl_ClieTelefono2
            // 
            this.lbl_ClieTelefono2.AutoSize = true;
            this.lbl_ClieTelefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClieTelefono2.ForeColor = System.Drawing.Color.White;
            this.lbl_ClieTelefono2.Location = new System.Drawing.Point(15, 366);
            this.lbl_ClieTelefono2.Name = "lbl_ClieTelefono2";
            this.lbl_ClieTelefono2.Size = new System.Drawing.Size(87, 20);
            this.lbl_ClieTelefono2.TabIndex = 45;
            this.lbl_ClieTelefono2.Text = "Telefono 2";
            // 
            // txt_ClieTelefono2
            // 
            this.txt_ClieTelefono2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ClieTelefono2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ClieTelefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClieTelefono2.ForeColor = System.Drawing.Color.White;
            this.txt_ClieTelefono2.Location = new System.Drawing.Point(204, 360);
            this.txt_ClieTelefono2.Name = "txt_ClieTelefono2";
            this.txt_ClieTelefono2.Size = new System.Drawing.Size(216, 26);
            this.txt_ClieTelefono2.TabIndex = 44;
            this.txt_ClieTelefono2.TextChanged += new System.EventHandler(this.txt_ClieTelefono2_TextChanged);
            // 
            // lbl_ClieTelefono1
            // 
            this.lbl_ClieTelefono1.AutoSize = true;
            this.lbl_ClieTelefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClieTelefono1.ForeColor = System.Drawing.Color.White;
            this.lbl_ClieTelefono1.Location = new System.Drawing.Point(15, 323);
            this.lbl_ClieTelefono1.Name = "lbl_ClieTelefono1";
            this.lbl_ClieTelefono1.Size = new System.Drawing.Size(87, 20);
            this.lbl_ClieTelefono1.TabIndex = 43;
            this.lbl_ClieTelefono1.Text = "Telefono 1";
            // 
            // txt_ClieTelefono1
            // 
            this.txt_ClieTelefono1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ClieTelefono1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ClieTelefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClieTelefono1.ForeColor = System.Drawing.Color.White;
            this.txt_ClieTelefono1.Location = new System.Drawing.Point(204, 317);
            this.txt_ClieTelefono1.Name = "txt_ClieTelefono1";
            this.txt_ClieTelefono1.Size = new System.Drawing.Size(216, 26);
            this.txt_ClieTelefono1.TabIndex = 42;
            this.txt_ClieTelefono1.TextChanged += new System.EventHandler(this.txt_ClieTelefono1_TextChanged);
            // 
            // dgv_ClieLista
            // 
            this.dgv_ClieLista.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_ClieLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ClieLista.Location = new System.Drawing.Point(448, 12);
            this.dgv_ClieLista.Name = "dgv_ClieLista";
            this.dgv_ClieLista.Size = new System.Drawing.Size(532, 462);
            this.dgv_ClieLista.TabIndex = 50;
            this.dgv_ClieLista.Click += new System.EventHandler(this.dgv_ClieLista_Click);
            // 
            // txt_ClieDomicilio
            // 
            this.txt_ClieDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ClieDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ClieDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClieDomicilio.ForeColor = System.Drawing.Color.White;
            this.txt_ClieDomicilio.Location = new System.Drawing.Point(204, 102);
            this.txt_ClieDomicilio.Name = "txt_ClieDomicilio";
            this.txt_ClieDomicilio.Size = new System.Drawing.Size(216, 26);
            this.txt_ClieDomicilio.TabIndex = 51;
            this.txt_ClieDomicilio.TextChanged += new System.EventHandler(this.txt_ClieDomicilio_TextChanged);
            // 
            // btn_ClieEliminar
            // 
            this.btn_ClieEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_ClieEliminar.FlatAppearance.BorderSize = 0;
            this.btn_ClieEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClieEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClieEliminar.ForeColor = System.Drawing.Color.White;
            this.btn_ClieEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_ClieEliminar.IconColor = System.Drawing.Color.Black;
            this.btn_ClieEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ClieEliminar.Location = new System.Drawing.Point(448, 499);
            this.btn_ClieEliminar.Name = "btn_ClieEliminar";
            this.btn_ClieEliminar.Size = new System.Drawing.Size(165, 39);
            this.btn_ClieEliminar.TabIndex = 49;
            this.btn_ClieEliminar.Text = "Eliminar";
            this.btn_ClieEliminar.UseVisualStyleBackColor = false;
            this.btn_ClieEliminar.Click += new System.EventHandler(this.btn_ClieEliminar_Click);
            // 
            // btn_ClieEditar
            // 
            this.btn_ClieEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_ClieEditar.FlatAppearance.BorderSize = 0;
            this.btn_ClieEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClieEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClieEditar.ForeColor = System.Drawing.Color.White;
            this.btn_ClieEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_ClieEditar.IconColor = System.Drawing.Color.Black;
            this.btn_ClieEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ClieEditar.Location = new System.Drawing.Point(815, 499);
            this.btn_ClieEditar.Name = "btn_ClieEditar";
            this.btn_ClieEditar.Size = new System.Drawing.Size(165, 39);
            this.btn_ClieEditar.TabIndex = 48;
            this.btn_ClieEditar.Text = "Editar";
            this.btn_ClieEditar.UseVisualStyleBackColor = false;
            this.btn_ClieEditar.Click += new System.EventHandler(this.btn_ClieEditar_Click);
            // 
            // btn_ClieGuardar
            // 
            this.btn_ClieGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_ClieGuardar.FlatAppearance.BorderSize = 0;
            this.btn_ClieGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClieGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClieGuardar.ForeColor = System.Drawing.Color.White;
            this.btn_ClieGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_ClieGuardar.IconColor = System.Drawing.Color.Black;
            this.btn_ClieGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ClieGuardar.Location = new System.Drawing.Point(19, 499);
            this.btn_ClieGuardar.Name = "btn_ClieGuardar";
            this.btn_ClieGuardar.Size = new System.Drawing.Size(165, 39);
            this.btn_ClieGuardar.TabIndex = 32;
            this.btn_ClieGuardar.Text = "Guardar";
            this.btn_ClieGuardar.UseVisualStyleBackColor = false;
            this.btn_ClieGuardar.Click += new System.EventHandler(this.btn_ClieGuardar_Click);
            // 
            // cmb_ClieCondicionIVA
            // 
            this.cmb_ClieCondicionIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_ClieCondicionIVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_ClieCondicionIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ClieCondicionIVA.ForeColor = System.Drawing.Color.White;
            this.cmb_ClieCondicionIVA.FormattingEnabled = true;
            this.cmb_ClieCondicionIVA.Location = new System.Drawing.Point(204, 186);
            this.cmb_ClieCondicionIVA.Name = "cmb_ClieCondicionIVA";
            this.cmb_ClieCondicionIVA.Size = new System.Drawing.Size(216, 28);
            this.cmb_ClieCondicionIVA.TabIndex = 52;
            this.cmb_ClieCondicionIVA.TextChanged += new System.EventHandler(this.cmb_ClieCondicionIVA_TextChanged);
            // 
            // txt_ClieCUIT
            // 
            this.txt_ClieCUIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ClieCUIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ClieCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClieCUIT.ForeColor = System.Drawing.Color.White;
            this.txt_ClieCUIT.Location = new System.Drawing.Point(204, 14);
            this.txt_ClieCUIT.Name = "txt_ClieCUIT";
            this.txt_ClieCUIT.Size = new System.Drawing.Size(216, 26);
            this.txt_ClieCUIT.TabIndex = 53;
            this.txt_ClieCUIT.TextChanged += new System.EventHandler(this.txt_ClieCUIT_TextChanged);
            // 
            // Frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1003, 550);
            this.Controls.Add(this.txt_ClieCUIT);
            this.Controls.Add(this.cmb_ClieCondicionIVA);
            this.Controls.Add(this.txt_ClieDomicilio);
            this.Controls.Add(this.dgv_ClieLista);
            this.Controls.Add(this.btn_ClieEliminar);
            this.Controls.Add(this.btn_ClieEditar);
            this.Controls.Add(this.lbl_ClieTelefono2);
            this.Controls.Add(this.txt_ClieTelefono2);
            this.Controls.Add(this.lbl_ClieTelefono1);
            this.Controls.Add(this.txt_ClieTelefono1);
            this.Controls.Add(this.lbl_ClieMail);
            this.Controls.Add(this.txt_ClieMail);
            this.Controls.Add(this.lbl_ClieContacto);
            this.Controls.Add(this.txt_ClieContacto);
            this.Controls.Add(this.btn_ClieGuardar);
            this.Controls.Add(this.lbl_ClieIngBrutos);
            this.Controls.Add(this.txt_ClieIngBrutos);
            this.Controls.Add(this.lbl_ClieCondicionIVA);
            this.Controls.Add(this.lbl_ClieDomicilio);
            this.Controls.Add(this.lbl_ClieCUIT);
            this.Controls.Add(this.lbl_ClieNombre);
            this.Controls.Add(this.txt_ClieNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Clientes";
            this.Text = "Frm_Clientes";
            this.Load += new System.EventHandler(this.Frm_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClieLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ClieNombre;
        private System.Windows.Forms.Label lbl_ClieNombre;
        private System.Windows.Forms.Label lbl_ClieCUIT;
        private System.Windows.Forms.Label lbl_ClieDomicilio;
        private System.Windows.Forms.Label lbl_ClieCondicionIVA;
        private System.Windows.Forms.Label lbl_ClieIngBrutos;
        private System.Windows.Forms.TextBox txt_ClieIngBrutos;
        private FontAwesome.Sharp.IconButton btn_ClieGuardar;
        private System.Windows.Forms.Label lbl_ClieContacto;
        private System.Windows.Forms.TextBox txt_ClieContacto;
        private System.Windows.Forms.Label lbl_ClieMail;
        private System.Windows.Forms.TextBox txt_ClieMail;
        private System.Windows.Forms.Label lbl_ClieTelefono2;
        private System.Windows.Forms.TextBox txt_ClieTelefono2;
        private System.Windows.Forms.Label lbl_ClieTelefono1;
        private System.Windows.Forms.TextBox txt_ClieTelefono1;
        private System.Windows.Forms.DataGridView dgv_ClieLista;
        private FontAwesome.Sharp.IconButton btn_ClieEliminar;
        private FontAwesome.Sharp.IconButton btn_ClieEditar;
        private System.Windows.Forms.TextBox txt_ClieDomicilio;
        private System.Windows.Forms.ComboBox cmb_ClieCondicionIVA;
        private System.Windows.Forms.TextBox txt_ClieCUIT;
    }
}