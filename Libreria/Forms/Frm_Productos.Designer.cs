namespace Libreria.Forms
{
    partial class Frm_Productos
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
            this.txt_ProdMarca = new System.Windows.Forms.TextBox();
            this.lbl_ProdMarca = new System.Windows.Forms.Label();
            this.cmb_ProdCodigo = new System.Windows.Forms.ComboBox();
            this.lbl_ProdCodigo = new System.Windows.Forms.Label();
            this.lbl_ProdDescripcion = new System.Windows.Forms.Label();
            this.lbl_ProMargenGanancia = new System.Windows.Forms.Label();
            this.lbl_ProdUnidadMed = new System.Windows.Forms.Label();
            this.txt_ProdUnidadMed = new System.Windows.Forms.TextBox();
            this.lbl_ProdCantStock = new System.Windows.Forms.Label();
            this.txt_ProdCantStock = new System.Windows.Forms.TextBox();
            this.lbl_ProdPrecioVenta = new System.Windows.Forms.Label();
            this.txt_ProdPrecioVenta = new System.Windows.Forms.TextBox();
            this.txt_ProMargenGanancia = new System.Windows.Forms.TextBox();
            this.dgv_ProvLista = new System.Windows.Forms.DataGridView();
            this.txt_ProdDescripcion = new System.Windows.Forms.TextBox();
            this.btn_ProvEliminar = new FontAwesome.Sharp.IconButton();
            this.btn_ProvEditar = new FontAwesome.Sharp.IconButton();
            this.btn_ProvGuardar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ProdMarca
            // 
            this.txt_ProdMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProdMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProdMarca.ForeColor = System.Drawing.Color.White;
            this.txt_ProdMarca.Location = new System.Drawing.Point(204, 57);
            this.txt_ProdMarca.Name = "txt_ProdMarca";
            this.txt_ProdMarca.Size = new System.Drawing.Size(216, 26);
            this.txt_ProdMarca.TabIndex = 0;
            // 
            // lbl_ProdMarca
            // 
            this.lbl_ProdMarca.AutoSize = true;
            this.lbl_ProdMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdMarca.ForeColor = System.Drawing.Color.White;
            this.lbl_ProdMarca.Location = new System.Drawing.Point(15, 63);
            this.lbl_ProdMarca.Name = "lbl_ProdMarca";
            this.lbl_ProdMarca.Size = new System.Drawing.Size(56, 20);
            this.lbl_ProdMarca.TabIndex = 1;
            this.lbl_ProdMarca.Text = "Marca";
            // 
            // cmb_ProdCodigo
            // 
            this.cmb_ProdCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_ProdCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_ProdCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProdCodigo.ForeColor = System.Drawing.Color.White;
            this.cmb_ProdCodigo.FormattingEnabled = true;
            this.cmb_ProdCodigo.Location = new System.Drawing.Point(204, 12);
            this.cmb_ProdCodigo.Name = "cmb_ProdCodigo";
            this.cmb_ProdCodigo.Size = new System.Drawing.Size(216, 28);
            this.cmb_ProdCodigo.TabIndex = 11;
            // 
            // lbl_ProdCodigo
            // 
            this.lbl_ProdCodigo.AutoSize = true;
            this.lbl_ProdCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdCodigo.ForeColor = System.Drawing.Color.White;
            this.lbl_ProdCodigo.Location = new System.Drawing.Point(15, 20);
            this.lbl_ProdCodigo.Name = "lbl_ProdCodigo";
            this.lbl_ProdCodigo.Size = new System.Drawing.Size(131, 20);
            this.lbl_ProdCodigo.TabIndex = 10;
            this.lbl_ProdCodigo.Text = "Código producto";
            // 
            // lbl_ProdDescripcion
            // 
            this.lbl_ProdDescripcion.AutoSize = true;
            this.lbl_ProdDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdDescripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_ProdDescripcion.Location = new System.Drawing.Point(15, 108);
            this.lbl_ProdDescripcion.Name = "lbl_ProdDescripcion";
            this.lbl_ProdDescripcion.Size = new System.Drawing.Size(99, 20);
            this.lbl_ProdDescripcion.TabIndex = 12;
            this.lbl_ProdDescripcion.Text = "Descripcion";
            // 
            // lbl_ProMargenGanancia
            // 
            this.lbl_ProMargenGanancia.AutoSize = true;
            this.lbl_ProMargenGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProMargenGanancia.ForeColor = System.Drawing.Color.White;
            this.lbl_ProMargenGanancia.Location = new System.Drawing.Point(15, 282);
            this.lbl_ProMargenGanancia.Name = "lbl_ProMargenGanancia";
            this.lbl_ProMargenGanancia.Size = new System.Drawing.Size(184, 20);
            this.lbl_ProMargenGanancia.TabIndex = 18;
            this.lbl_ProMargenGanancia.Text = "Margen de Ganancia %";
            // 
            // lbl_ProdUnidadMed
            // 
            this.lbl_ProdUnidadMed.AutoSize = true;
            this.lbl_ProdUnidadMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdUnidadMed.ForeColor = System.Drawing.Color.White;
            this.lbl_ProdUnidadMed.Location = new System.Drawing.Point(15, 194);
            this.lbl_ProdUnidadMed.Name = "lbl_ProdUnidadMed";
            this.lbl_ProdUnidadMed.Size = new System.Drawing.Size(143, 20);
            this.lbl_ProdUnidadMed.TabIndex = 21;
            this.lbl_ProdUnidadMed.Text = "Unidad de Medida";
            // 
            // txt_ProdUnidadMed
            // 
            this.txt_ProdUnidadMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProdUnidadMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdUnidadMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProdUnidadMed.ForeColor = System.Drawing.Color.White;
            this.txt_ProdUnidadMed.Location = new System.Drawing.Point(204, 188);
            this.txt_ProdUnidadMed.Name = "txt_ProdUnidadMed";
            this.txt_ProdUnidadMed.Size = new System.Drawing.Size(216, 26);
            this.txt_ProdUnidadMed.TabIndex = 20;
            // 
            // lbl_ProdCantStock
            // 
            this.lbl_ProdCantStock.AutoSize = true;
            this.lbl_ProdCantStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdCantStock.ForeColor = System.Drawing.Color.White;
            this.lbl_ProdCantStock.Location = new System.Drawing.Point(15, 151);
            this.lbl_ProdCantStock.Name = "lbl_ProdCantStock";
            this.lbl_ProdCantStock.Size = new System.Drawing.Size(145, 20);
            this.lbl_ProdCantStock.TabIndex = 25;
            this.lbl_ProdCantStock.Text = "Cantidad en Stock";
            // 
            // txt_ProdCantStock
            // 
            this.txt_ProdCantStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProdCantStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdCantStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProdCantStock.ForeColor = System.Drawing.Color.White;
            this.txt_ProdCantStock.Location = new System.Drawing.Point(204, 145);
            this.txt_ProdCantStock.Name = "txt_ProdCantStock";
            this.txt_ProdCantStock.Size = new System.Drawing.Size(216, 26);
            this.txt_ProdCantStock.TabIndex = 24;
            // 
            // lbl_ProdPrecioVenta
            // 
            this.lbl_ProdPrecioVenta.AutoSize = true;
            this.lbl_ProdPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdPrecioVenta.ForeColor = System.Drawing.Color.White;
            this.lbl_ProdPrecioVenta.Location = new System.Drawing.Point(15, 237);
            this.lbl_ProdPrecioVenta.Name = "lbl_ProdPrecioVenta";
            this.lbl_ProdPrecioVenta.Size = new System.Drawing.Size(119, 20);
            this.lbl_ProdPrecioVenta.TabIndex = 37;
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
            this.txt_ProdPrecioVenta.TabIndex = 36;
            // 
            // txt_ProMargenGanancia
            // 
            this.txt_ProMargenGanancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProMargenGanancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProMargenGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProMargenGanancia.ForeColor = System.Drawing.Color.White;
            this.txt_ProMargenGanancia.Location = new System.Drawing.Point(204, 276);
            this.txt_ProMargenGanancia.Name = "txt_ProMargenGanancia";
            this.txt_ProMargenGanancia.Size = new System.Drawing.Size(216, 26);
            this.txt_ProMargenGanancia.TabIndex = 38;
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
            // txt_ProdDescripcion
            // 
            this.txt_ProdDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProdDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProdDescripcion.ForeColor = System.Drawing.Color.White;
            this.txt_ProdDescripcion.Location = new System.Drawing.Point(204, 102);
            this.txt_ProdDescripcion.Name = "txt_ProdDescripcion";
            this.txt_ProdDescripcion.Size = new System.Drawing.Size(216, 26);
            this.txt_ProdDescripcion.TabIndex = 51;
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
            // Frm_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1003, 550);
            this.Controls.Add(this.txt_ProdDescripcion);
            this.Controls.Add(this.dgv_ProvLista);
            this.Controls.Add(this.btn_ProvEliminar);
            this.Controls.Add(this.btn_ProvEditar);
            this.Controls.Add(this.txt_ProMargenGanancia);
            this.Controls.Add(this.lbl_ProdPrecioVenta);
            this.Controls.Add(this.txt_ProdPrecioVenta);
            this.Controls.Add(this.btn_ProvGuardar);
            this.Controls.Add(this.lbl_ProdCantStock);
            this.Controls.Add(this.txt_ProdCantStock);
            this.Controls.Add(this.lbl_ProdUnidadMed);
            this.Controls.Add(this.txt_ProdUnidadMed);
            this.Controls.Add(this.lbl_ProMargenGanancia);
            this.Controls.Add(this.lbl_ProdDescripcion);
            this.Controls.Add(this.cmb_ProdCodigo);
            this.Controls.Add(this.lbl_ProdCodigo);
            this.Controls.Add(this.lbl_ProdMarca);
            this.Controls.Add(this.txt_ProdMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Productos";
            this.Text = "Frm_Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ProdMarca;
        private System.Windows.Forms.Label lbl_ProdMarca;
        private System.Windows.Forms.ComboBox cmb_ProdCodigo;
        private System.Windows.Forms.Label lbl_ProdCodigo;
        private System.Windows.Forms.Label lbl_ProdDescripcion;
        private System.Windows.Forms.Label lbl_ProMargenGanancia;
        private System.Windows.Forms.Label lbl_ProdUnidadMed;
        private System.Windows.Forms.TextBox txt_ProdUnidadMed;
        private System.Windows.Forms.Label lbl_ProdCantStock;
        private System.Windows.Forms.TextBox txt_ProdCantStock;
        private FontAwesome.Sharp.IconButton btn_ProvGuardar;
        private System.Windows.Forms.Label lbl_ProdPrecioVenta;
        private System.Windows.Forms.TextBox txt_ProdPrecioVenta;
        private System.Windows.Forms.TextBox txt_ProMargenGanancia;
        private System.Windows.Forms.DataGridView dgv_ProvLista;
        private FontAwesome.Sharp.IconButton btn_ProvEliminar;
        private FontAwesome.Sharp.IconButton btn_ProvEditar;
        private System.Windows.Forms.TextBox txt_ProdDescripcion;
    }
}