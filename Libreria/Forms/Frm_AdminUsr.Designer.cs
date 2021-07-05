namespace Libreria.Forms
{
    partial class Frm_AdminUsr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_UserCuenta = new System.Windows.Forms.TextBox();
            this.lbl_UserCuenta = new System.Windows.Forms.Label();
            this.cmb_UserTipoCuenta = new System.Windows.Forms.ComboBox();
            this.lbl_UserTipoCuenta = new System.Windows.Forms.Label();
            this.cmb_UserEstadoCuenta = new System.Windows.Forms.ComboBox();
            this.dgv_UserLista = new System.Windows.Forms.DataGridView();
            this.lbl_UserNombre = new System.Windows.Forms.Label();
            this.txt_UserNombre = new System.Windows.Forms.TextBox();
            this.lbl_UserEstadoCuenta = new System.Windows.Forms.Label();
            this.btn_UserEliminar = new FontAwesome.Sharp.IconButton();
            this.btn_UserEditar = new FontAwesome.Sharp.IconButton();
            this.btn_UserGuardar = new FontAwesome.Sharp.IconButton();
            this.txt_UserContraseña = new System.Windows.Forms.TextBox();
            this.lbl_UserContraseña = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserLista)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_UserCuenta
            // 
            this.txt_UserCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_UserCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserCuenta.ForeColor = System.Drawing.Color.White;
            this.txt_UserCuenta.Location = new System.Drawing.Point(204, 57);
            this.txt_UserCuenta.Name = "txt_UserCuenta";
            this.txt_UserCuenta.Size = new System.Drawing.Size(216, 26);
            this.txt_UserCuenta.TabIndex = 1;
            this.txt_UserCuenta.TextChanged += new System.EventHandler(this.txt_UserCuenta_TextChanged);
            // 
            // lbl_UserCuenta
            // 
            this.lbl_UserCuenta.AutoSize = true;
            this.lbl_UserCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserCuenta.ForeColor = System.Drawing.Color.White;
            this.lbl_UserCuenta.Location = new System.Drawing.Point(15, 63);
            this.lbl_UserCuenta.Name = "lbl_UserCuenta";
            this.lbl_UserCuenta.Size = new System.Drawing.Size(149, 20);
            this.lbl_UserCuenta.TabIndex = 1;
            this.lbl_UserCuenta.Text = "Nombre de Cuenta";
            // 
            // cmb_UserTipoCuenta
            // 
            this.cmb_UserTipoCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_UserTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UserTipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_UserTipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UserTipoCuenta.ForeColor = System.Drawing.Color.White;
            this.cmb_UserTipoCuenta.FormattingEnabled = true;
            this.cmb_UserTipoCuenta.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cmb_UserTipoCuenta.Location = new System.Drawing.Point(204, 143);
            this.cmb_UserTipoCuenta.Name = "cmb_UserTipoCuenta";
            this.cmb_UserTipoCuenta.Size = new System.Drawing.Size(216, 28);
            this.cmb_UserTipoCuenta.TabIndex = 3;
            this.cmb_UserTipoCuenta.Tag = "";
            this.cmb_UserTipoCuenta.TextChanged += new System.EventHandler(this.cmb_UserTipoCuenta_TextChanged);
            // 
            // lbl_UserTipoCuenta
            // 
            this.lbl_UserTipoCuenta.AutoSize = true;
            this.lbl_UserTipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserTipoCuenta.ForeColor = System.Drawing.Color.White;
            this.lbl_UserTipoCuenta.Location = new System.Drawing.Point(15, 151);
            this.lbl_UserTipoCuenta.Name = "lbl_UserTipoCuenta";
            this.lbl_UserTipoCuenta.Size = new System.Drawing.Size(96, 20);
            this.lbl_UserTipoCuenta.TabIndex = 12;
            this.lbl_UserTipoCuenta.Text = "Tipo cuenta";
            // 
            // cmb_UserEstadoCuenta
            // 
            this.cmb_UserEstadoCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_UserEstadoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UserEstadoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_UserEstadoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UserEstadoCuenta.ForeColor = System.Drawing.Color.White;
            this.cmb_UserEstadoCuenta.FormattingEnabled = true;
            this.cmb_UserEstadoCuenta.Items.AddRange(new object[] {
            "Activa",
            "Desactivada"});
            this.cmb_UserEstadoCuenta.Location = new System.Drawing.Point(204, 186);
            this.cmb_UserEstadoCuenta.Name = "cmb_UserEstadoCuenta";
            this.cmb_UserEstadoCuenta.Size = new System.Drawing.Size(216, 28);
            this.cmb_UserEstadoCuenta.TabIndex = 4;
            this.cmb_UserEstadoCuenta.TextChanged += new System.EventHandler(this.cmb_UserEstadoCuenta_TextChanged);
            // 
            // dgv_UserLista
            // 
            this.dgv_UserLista.AllowUserToAddRows = false;
            this.dgv_UserLista.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_UserLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_UserLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_UserLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UserLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_UserLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_UserLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_UserLista.EnableHeadersVisualStyles = false;
            this.dgv_UserLista.Location = new System.Drawing.Point(448, 12);
            this.dgv_UserLista.Name = "dgv_UserLista";
            this.dgv_UserLista.ReadOnly = true;
            this.dgv_UserLista.RowHeadersVisible = false;
            this.dgv_UserLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UserLista.Size = new System.Drawing.Size(532, 462);
            this.dgv_UserLista.TabIndex = 50;
            this.dgv_UserLista.Click += new System.EventHandler(this.dgv_UserLista_Click);
            // 
            // lbl_UserNombre
            // 
            this.lbl_UserNombre.AutoSize = true;
            this.lbl_UserNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserNombre.ForeColor = System.Drawing.Color.White;
            this.lbl_UserNombre.Location = new System.Drawing.Point(15, 20);
            this.lbl_UserNombre.Name = "lbl_UserNombre";
            this.lbl_UserNombre.Size = new System.Drawing.Size(68, 20);
            this.lbl_UserNombre.TabIndex = 10;
            this.lbl_UserNombre.Text = "Nombre";
            // 
            // txt_UserNombre
            // 
            this.txt_UserNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_UserNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserNombre.ForeColor = System.Drawing.Color.White;
            this.txt_UserNombre.Location = new System.Drawing.Point(204, 14);
            this.txt_UserNombre.Name = "txt_UserNombre";
            this.txt_UserNombre.Size = new System.Drawing.Size(216, 26);
            this.txt_UserNombre.TabIndex = 0;
            this.txt_UserNombre.TextChanged += new System.EventHandler(this.txt_UserNombre_TextChanged);
            // 
            // lbl_UserEstadoCuenta
            // 
            this.lbl_UserEstadoCuenta.AutoSize = true;
            this.lbl_UserEstadoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserEstadoCuenta.ForeColor = System.Drawing.Color.White;
            this.lbl_UserEstadoCuenta.Location = new System.Drawing.Point(15, 194);
            this.lbl_UserEstadoCuenta.Name = "lbl_UserEstadoCuenta";
            this.lbl_UserEstadoCuenta.Size = new System.Drawing.Size(139, 20);
            this.lbl_UserEstadoCuenta.TabIndex = 21;
            this.lbl_UserEstadoCuenta.Text = "Estado de cuenta";
            // 
            // btn_UserEliminar
            // 
            this.btn_UserEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_UserEliminar.FlatAppearance.BorderSize = 0;
            this.btn_UserEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UserEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserEliminar.ForeColor = System.Drawing.Color.White;
            this.btn_UserEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_UserEliminar.IconColor = System.Drawing.Color.Black;
            this.btn_UserEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_UserEliminar.Location = new System.Drawing.Point(448, 499);
            this.btn_UserEliminar.Name = "btn_UserEliminar";
            this.btn_UserEliminar.Size = new System.Drawing.Size(165, 39);
            this.btn_UserEliminar.TabIndex = 6;
            this.btn_UserEliminar.Text = "Eliminar";
            this.btn_UserEliminar.UseVisualStyleBackColor = false;
            this.btn_UserEliminar.Click += new System.EventHandler(this.btn_UserEliminar_Click);
            // 
            // btn_UserEditar
            // 
            this.btn_UserEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_UserEditar.FlatAppearance.BorderSize = 0;
            this.btn_UserEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UserEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserEditar.ForeColor = System.Drawing.Color.White;
            this.btn_UserEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_UserEditar.IconColor = System.Drawing.Color.Black;
            this.btn_UserEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_UserEditar.Location = new System.Drawing.Point(815, 499);
            this.btn_UserEditar.Name = "btn_UserEditar";
            this.btn_UserEditar.Size = new System.Drawing.Size(165, 39);
            this.btn_UserEditar.TabIndex = 7;
            this.btn_UserEditar.Text = "Editar";
            this.btn_UserEditar.UseVisualStyleBackColor = false;
            this.btn_UserEditar.Click += new System.EventHandler(this.btn_UserEditar_Click);
            // 
            // btn_UserGuardar
            // 
            this.btn_UserGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_UserGuardar.FlatAppearance.BorderSize = 0;
            this.btn_UserGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UserGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserGuardar.ForeColor = System.Drawing.Color.White;
            this.btn_UserGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_UserGuardar.IconColor = System.Drawing.Color.Black;
            this.btn_UserGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_UserGuardar.Location = new System.Drawing.Point(19, 499);
            this.btn_UserGuardar.Name = "btn_UserGuardar";
            this.btn_UserGuardar.Size = new System.Drawing.Size(165, 39);
            this.btn_UserGuardar.TabIndex = 5;
            this.btn_UserGuardar.Text = "Guardar";
            this.btn_UserGuardar.UseVisualStyleBackColor = false;
            this.btn_UserGuardar.Click += new System.EventHandler(this.btn_UserGuardar_Click);
            // 
            // txt_UserContraseña
            // 
            this.txt_UserContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_UserContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserContraseña.ForeColor = System.Drawing.Color.White;
            this.txt_UserContraseña.Location = new System.Drawing.Point(204, 102);
            this.txt_UserContraseña.Name = "txt_UserContraseña";
            this.txt_UserContraseña.Size = new System.Drawing.Size(216, 26);
            this.txt_UserContraseña.TabIndex = 2;
            this.txt_UserContraseña.UseSystemPasswordChar = true;
            this.txt_UserContraseña.TextChanged += new System.EventHandler(this.txt_UserContraseña_TextChanged);
            // 
            // lbl_UserContraseña
            // 
            this.lbl_UserContraseña.AutoSize = true;
            this.lbl_UserContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserContraseña.ForeColor = System.Drawing.Color.White;
            this.lbl_UserContraseña.Location = new System.Drawing.Point(15, 108);
            this.lbl_UserContraseña.Name = "lbl_UserContraseña";
            this.lbl_UserContraseña.Size = new System.Drawing.Size(95, 20);
            this.lbl_UserContraseña.TabIndex = 53;
            this.lbl_UserContraseña.Text = "Contraseña";
            // 
            // Frm_AdminUsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1003, 550);
            this.Controls.Add(this.lbl_UserContraseña);
            this.Controls.Add(this.txt_UserContraseña);
            this.Controls.Add(this.txt_UserNombre);
            this.Controls.Add(this.dgv_UserLista);
            this.Controls.Add(this.btn_UserEliminar);
            this.Controls.Add(this.btn_UserEditar);
            this.Controls.Add(this.btn_UserGuardar);
            this.Controls.Add(this.lbl_UserEstadoCuenta);
            this.Controls.Add(this.cmb_UserEstadoCuenta);
            this.Controls.Add(this.cmb_UserTipoCuenta);
            this.Controls.Add(this.lbl_UserTipoCuenta);
            this.Controls.Add(this.lbl_UserNombre);
            this.Controls.Add(this.lbl_UserCuenta);
            this.Controls.Add(this.txt_UserCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_AdminUsr";
            this.Text = "Frm_Ventas";
            this.Load += new System.EventHandler(this.Frm_AdminUsr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_UserCuenta;
        private System.Windows.Forms.Label lbl_UserCuenta;
        private System.Windows.Forms.ComboBox cmb_UserTipoCuenta;
        private System.Windows.Forms.Label lbl_UserTipoCuenta;
        private System.Windows.Forms.ComboBox cmb_UserEstadoCuenta;
        private FontAwesome.Sharp.IconButton btn_UserGuardar;
        private System.Windows.Forms.DataGridView dgv_UserLista;
        private FontAwesome.Sharp.IconButton btn_UserEliminar;
        private FontAwesome.Sharp.IconButton btn_UserEditar;
        private System.Windows.Forms.Label lbl_UserNombre;
        private System.Windows.Forms.TextBox txt_UserNombre;
        private System.Windows.Forms.Label lbl_UserEstadoCuenta;
        private System.Windows.Forms.TextBox txt_UserContraseña;
        private System.Windows.Forms.Label lbl_UserContraseña;
    }
}