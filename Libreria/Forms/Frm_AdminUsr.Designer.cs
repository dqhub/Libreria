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
            this.panelAltayModif = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_AltayModif = new System.Windows.Forms.Label();
            this.btn_Guardar = new FontAwesome.Sharp.IconButton();
            this.cmb_EstadoCuenta = new System.Windows.Forms.ComboBox();
            this.lbl_EstadoCuenta = new System.Windows.Forms.Label();
            this.cmb_TipoCuenta = new System.Windows.Forms.ComboBox();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.lbl_TipoCuenta = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Crear = new FontAwesome.Sharp.IconButton();
            this.panelAdminUsr = new System.Windows.Forms.Panel();
            this.panelAltayModif.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAdminUsr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAltayModif
            // 
            this.panelAltayModif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelAltayModif.Controls.Add(this.btn_Crear);
            this.panelAltayModif.Controls.Add(this.panel1);
            this.panelAltayModif.Controls.Add(this.btn_Guardar);
            this.panelAltayModif.Controls.Add(this.cmb_EstadoCuenta);
            this.panelAltayModif.Controls.Add(this.lbl_EstadoCuenta);
            this.panelAltayModif.Controls.Add(this.cmb_TipoCuenta);
            this.panelAltayModif.Controls.Add(this.lbl_Contraseña);
            this.panelAltayModif.Controls.Add(this.txt_Contraseña);
            this.panelAltayModif.Controls.Add(this.lbl_TipoCuenta);
            this.panelAltayModif.Controls.Add(this.txt_Usuario);
            this.panelAltayModif.Controls.Add(this.lbl_Usuario);
            this.panelAltayModif.Controls.Add(this.lbl_Nombre);
            this.panelAltayModif.Controls.Add(this.txt_Nombre);
            this.panelAltayModif.Location = new System.Drawing.Point(543, 35);
            this.panelAltayModif.Name = "panelAltayModif";
            this.panelAltayModif.Size = new System.Drawing.Size(421, 470);
            this.panelAltayModif.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_AltayModif);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 40);
            this.panel1.TabIndex = 13;
            // 
            // lbl_AltayModif
            // 
            this.lbl_AltayModif.AutoSize = true;
            this.lbl_AltayModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AltayModif.ForeColor = System.Drawing.Color.White;
            this.lbl_AltayModif.Location = new System.Drawing.Point(121, 8);
            this.lbl_AltayModif.Name = "lbl_AltayModif";
            this.lbl_AltayModif.Size = new System.Drawing.Size(194, 26);
            this.lbl_AltayModif.TabIndex = 12;
            this.lbl_AltayModif.Text = "Alta y Modificación";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Guardar.IconColor = System.Drawing.Color.Black;
            this.btn_Guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Guardar.Location = new System.Drawing.Point(30, 396);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(165, 39);
            this.btn_Guardar.TabIndex = 12;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            // 
            // cmb_EstadoCuenta
            // 
            this.cmb_EstadoCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmb_EstadoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_EstadoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_EstadoCuenta.ForeColor = System.Drawing.Color.White;
            this.cmb_EstadoCuenta.FormattingEnabled = true;
            this.cmb_EstadoCuenta.Items.AddRange(new object[] {
            "ACTIVADA",
            "DESACTIVADA"});
            this.cmb_EstadoCuenta.Location = new System.Drawing.Point(190, 314);
            this.cmb_EstadoCuenta.Name = "cmb_EstadoCuenta";
            this.cmb_EstadoCuenta.Size = new System.Drawing.Size(216, 28);
            this.cmb_EstadoCuenta.TabIndex = 11;
            // 
            // lbl_EstadoCuenta
            // 
            this.lbl_EstadoCuenta.AutoSize = true;
            this.lbl_EstadoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EstadoCuenta.ForeColor = System.Drawing.Color.White;
            this.lbl_EstadoCuenta.Location = new System.Drawing.Point(26, 314);
            this.lbl_EstadoCuenta.Name = "lbl_EstadoCuenta";
            this.lbl_EstadoCuenta.Size = new System.Drawing.Size(139, 20);
            this.lbl_EstadoCuenta.TabIndex = 10;
            this.lbl_EstadoCuenta.Text = "Estado de cuenta";
            // 
            // cmb_TipoCuenta
            // 
            this.cmb_TipoCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmb_TipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_TipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TipoCuenta.ForeColor = System.Drawing.Color.White;
            this.cmb_TipoCuenta.FormattingEnabled = true;
            this.cmb_TipoCuenta.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "EMPLEADO"});
            this.cmb_TipoCuenta.Location = new System.Drawing.Point(190, 253);
            this.cmb_TipoCuenta.Name = "cmb_TipoCuenta";
            this.cmb_TipoCuenta.Size = new System.Drawing.Size(216, 28);
            this.cmb_TipoCuenta.TabIndex = 9;
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contraseña.ForeColor = System.Drawing.Color.White;
            this.lbl_Contraseña.Location = new System.Drawing.Point(26, 192);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(95, 20);
            this.lbl_Contraseña.TabIndex = 8;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contraseña.ForeColor = System.Drawing.Color.White;
            this.txt_Contraseña.Location = new System.Drawing.Point(190, 192);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(216, 26);
            this.txt_Contraseña.TabIndex = 7;
            // 
            // lbl_TipoCuenta
            // 
            this.lbl_TipoCuenta.AutoSize = true;
            this.lbl_TipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoCuenta.ForeColor = System.Drawing.Color.White;
            this.lbl_TipoCuenta.Location = new System.Drawing.Point(26, 253);
            this.lbl_TipoCuenta.Name = "lbl_TipoCuenta";
            this.lbl_TipoCuenta.Size = new System.Drawing.Size(119, 20);
            this.lbl_TipoCuenta.TabIndex = 6;
            this.lbl_TipoCuenta.Text = "Tipo de cuenta";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.ForeColor = System.Drawing.Color.White;
            this.txt_Usuario.Location = new System.Drawing.Point(190, 131);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(216, 26);
            this.txt_Usuario.TabIndex = 5;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_Usuario.Location = new System.Drawing.Point(26, 131);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(67, 20);
            this.lbl_Usuario.TabIndex = 4;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_Nombre.Location = new System.Drawing.Point(26, 70);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(68, 20);
            this.lbl_Nombre.TabIndex = 3;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.ForeColor = System.Drawing.Color.White;
            this.txt_Nombre.Location = new System.Drawing.Point(190, 70);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(216, 26);
            this.txt_Nombre.TabIndex = 2;
            // 
            // btn_Crear
            // 
            this.btn_Crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_Crear.FlatAppearance.BorderSize = 0;
            this.btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Crear.ForeColor = System.Drawing.Color.White;
            this.btn_Crear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Crear.IconColor = System.Drawing.Color.Black;
            this.btn_Crear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Crear.Location = new System.Drawing.Point(241, 396);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(165, 39);
            this.btn_Crear.TabIndex = 14;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.UseVisualStyleBackColor = false;
            // 
            // panelAdminUsr
            // 
            this.panelAdminUsr.Controls.Add(this.panelAltayModif);
            this.panelAdminUsr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdminUsr.Location = new System.Drawing.Point(0, 0);
            this.panelAdminUsr.Name = "panelAdminUsr";
            this.panelAdminUsr.Size = new System.Drawing.Size(1003, 540);
            this.panelAdminUsr.TabIndex = 3;
            // 
            // Frm_AdminUsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1003, 540);
            this.Controls.Add(this.panelAdminUsr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_AdminUsr";
            this.Text = "Frm_AdminUsr";
            this.panelAltayModif.ResumeLayout(false);
            this.panelAltayModif.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAdminUsr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAltayModif;
        private System.Windows.Forms.ComboBox cmb_EstadoCuenta;
        private System.Windows.Forms.Label lbl_EstadoCuenta;
        private System.Windows.Forms.ComboBox cmb_TipoCuenta;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Label lbl_TipoCuenta;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_AltayModif;
        private FontAwesome.Sharp.IconButton btn_Guardar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Crear;
        private System.Windows.Forms.Panel panelAdminUsr;
    }
}