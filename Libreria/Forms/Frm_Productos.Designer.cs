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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_ProdCodigo = new System.Windows.Forms.Label();
            this.lbl_ProdDescripcion = new System.Windows.Forms.Label();
            this.lbl_ProMargenGanancia = new System.Windows.Forms.Label();
            this.lbl_ProdUnidadMed = new System.Windows.Forms.Label();
            this.lbl_ProdCantStock = new System.Windows.Forms.Label();
            this.txt_ProdCantStock = new System.Windows.Forms.TextBox();
            this.lbl_ProdPrecioVenta = new System.Windows.Forms.Label();
            this.txt_ProdPrecioVenta = new System.Windows.Forms.TextBox();
            this.txt_ProdMargenGanancia = new System.Windows.Forms.TextBox();
            this.dgv_ProdLista = new System.Windows.Forms.DataGridView();
            this.txt_ProdDescripcion = new System.Windows.Forms.TextBox();
            this.btn_ProdEliminar = new FontAwesome.Sharp.IconButton();
            this.btn_ProdEditar = new FontAwesome.Sharp.IconButton();
            this.btn_ProdGuardar = new FontAwesome.Sharp.IconButton();
            this.txt_ProdCodigo = new System.Windows.Forms.TextBox();
            this.cmb_ProdUnidadMed = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdLista)).BeginInit();
            this.SuspendLayout();
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
            this.lbl_ProdDescripcion.Location = new System.Drawing.Point(15, 63);
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
            this.lbl_ProMargenGanancia.Location = new System.Drawing.Point(15, 192);
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
            this.lbl_ProdUnidadMed.Location = new System.Drawing.Point(15, 149);
            this.lbl_ProdUnidadMed.Name = "lbl_ProdUnidadMed";
            this.lbl_ProdUnidadMed.Size = new System.Drawing.Size(143, 20);
            this.lbl_ProdUnidadMed.TabIndex = 21;
            this.lbl_ProdUnidadMed.Text = "Unidad de Medida";
            // 
            // lbl_ProdCantStock
            // 
            this.lbl_ProdCantStock.AutoSize = true;
            this.lbl_ProdCantStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdCantStock.ForeColor = System.Drawing.Color.White;
            this.lbl_ProdCantStock.Location = new System.Drawing.Point(15, 106);
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
            this.txt_ProdCantStock.Location = new System.Drawing.Point(204, 100);
            this.txt_ProdCantStock.Name = "txt_ProdCantStock";
            this.txt_ProdCantStock.Size = new System.Drawing.Size(216, 26);
            this.txt_ProdCantStock.TabIndex = 24;
            this.txt_ProdCantStock.TextChanged += new System.EventHandler(this.txt_ProdCantStock_TextChanged);
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
            // txt_ProdMargenGanancia
            // 
            this.txt_ProdMargenGanancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProdMargenGanancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdMargenGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProdMargenGanancia.ForeColor = System.Drawing.Color.White;
            this.txt_ProdMargenGanancia.Location = new System.Drawing.Point(204, 186);
            this.txt_ProdMargenGanancia.Name = "txt_ProdMargenGanancia";
            this.txt_ProdMargenGanancia.Size = new System.Drawing.Size(216, 26);
            this.txt_ProdMargenGanancia.TabIndex = 38;
            this.txt_ProdMargenGanancia.TextChanged += new System.EventHandler(this.txt_ProdMargenGanancia_TextChanged);
            // 
            // dgv_ProdLista
            // 
            this.dgv_ProdLista.AllowUserToAddRows = false;
            this.dgv_ProdLista.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_ProdLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ProdLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_ProdLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProdLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ProdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ProdLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ProdLista.EnableHeadersVisualStyles = false;
            this.dgv_ProdLista.Location = new System.Drawing.Point(448, 12);
            this.dgv_ProdLista.Name = "dgv_ProdLista";
            this.dgv_ProdLista.ReadOnly = true;
            this.dgv_ProdLista.RowHeadersVisible = false;
            this.dgv_ProdLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProdLista.Size = new System.Drawing.Size(532, 462);
            this.dgv_ProdLista.TabIndex = 50;
            this.dgv_ProdLista.Click += new System.EventHandler(this.dgv_ProdLista_Click);
            // 
            // txt_ProdDescripcion
            // 
            this.txt_ProdDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProdDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProdDescripcion.ForeColor = System.Drawing.Color.White;
            this.txt_ProdDescripcion.Location = new System.Drawing.Point(204, 57);
            this.txt_ProdDescripcion.Name = "txt_ProdDescripcion";
            this.txt_ProdDescripcion.Size = new System.Drawing.Size(216, 26);
            this.txt_ProdDescripcion.TabIndex = 51;
            this.txt_ProdDescripcion.TextChanged += new System.EventHandler(this.txt_ProdDescripcion_TextChanged);
            // 
            // btn_ProdEliminar
            // 
            this.btn_ProdEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_ProdEliminar.FlatAppearance.BorderSize = 0;
            this.btn_ProdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProdEliminar.ForeColor = System.Drawing.Color.White;
            this.btn_ProdEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_ProdEliminar.IconColor = System.Drawing.Color.Black;
            this.btn_ProdEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ProdEliminar.Location = new System.Drawing.Point(448, 499);
            this.btn_ProdEliminar.Name = "btn_ProdEliminar";
            this.btn_ProdEliminar.Size = new System.Drawing.Size(165, 39);
            this.btn_ProdEliminar.TabIndex = 49;
            this.btn_ProdEliminar.Text = "Eliminar";
            this.btn_ProdEliminar.UseVisualStyleBackColor = false;
            this.btn_ProdEliminar.Click += new System.EventHandler(this.btn_ProdEliminar_Click);
            // 
            // btn_ProdEditar
            // 
            this.btn_ProdEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_ProdEditar.FlatAppearance.BorderSize = 0;
            this.btn_ProdEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProdEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProdEditar.ForeColor = System.Drawing.Color.White;
            this.btn_ProdEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_ProdEditar.IconColor = System.Drawing.Color.Black;
            this.btn_ProdEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ProdEditar.Location = new System.Drawing.Point(815, 499);
            this.btn_ProdEditar.Name = "btn_ProdEditar";
            this.btn_ProdEditar.Size = new System.Drawing.Size(165, 39);
            this.btn_ProdEditar.TabIndex = 48;
            this.btn_ProdEditar.Text = "Editar";
            this.btn_ProdEditar.UseVisualStyleBackColor = false;
            this.btn_ProdEditar.Click += new System.EventHandler(this.btn_ProdEditar_Click);
            // 
            // btn_ProdGuardar
            // 
            this.btn_ProdGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_ProdGuardar.FlatAppearance.BorderSize = 0;
            this.btn_ProdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProdGuardar.ForeColor = System.Drawing.Color.White;
            this.btn_ProdGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_ProdGuardar.IconColor = System.Drawing.Color.Black;
            this.btn_ProdGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ProdGuardar.Location = new System.Drawing.Point(19, 499);
            this.btn_ProdGuardar.Name = "btn_ProdGuardar";
            this.btn_ProdGuardar.Size = new System.Drawing.Size(165, 39);
            this.btn_ProdGuardar.TabIndex = 32;
            this.btn_ProdGuardar.Text = "Guardar";
            this.btn_ProdGuardar.UseVisualStyleBackColor = false;
            this.btn_ProdGuardar.Click += new System.EventHandler(this.btn_ProdGuardar_Click);
            // 
            // txt_ProdCodigo
            // 
            this.txt_ProdCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_ProdCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProdCodigo.ForeColor = System.Drawing.Color.White;
            this.txt_ProdCodigo.Location = new System.Drawing.Point(204, 14);
            this.txt_ProdCodigo.Name = "txt_ProdCodigo";
            this.txt_ProdCodigo.Size = new System.Drawing.Size(216, 26);
            this.txt_ProdCodigo.TabIndex = 52;
            this.txt_ProdCodigo.TextChanged += new System.EventHandler(this.txt_ProdCodigo_TextChanged);
            // 
            // cmb_ProdUnidadMed
            // 
            this.cmb_ProdUnidadMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_ProdUnidadMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_ProdUnidadMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProdUnidadMed.ForeColor = System.Drawing.Color.White;
            this.cmb_ProdUnidadMed.FormattingEnabled = true;
            this.cmb_ProdUnidadMed.Items.AddRange(new object[] {
            "Litro",
            "Kilogramo"});
            this.cmb_ProdUnidadMed.Location = new System.Drawing.Point(204, 141);
            this.cmb_ProdUnidadMed.Name = "cmb_ProdUnidadMed";
            this.cmb_ProdUnidadMed.Size = new System.Drawing.Size(216, 28);
            this.cmb_ProdUnidadMed.TabIndex = 53;
            // 
            // Frm_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1003, 550);
            this.Controls.Add(this.cmb_ProdUnidadMed);
            this.Controls.Add(this.txt_ProdCodigo);
            this.Controls.Add(this.txt_ProdDescripcion);
            this.Controls.Add(this.dgv_ProdLista);
            this.Controls.Add(this.btn_ProdEliminar);
            this.Controls.Add(this.btn_ProdEditar);
            this.Controls.Add(this.txt_ProdMargenGanancia);
            this.Controls.Add(this.lbl_ProdPrecioVenta);
            this.Controls.Add(this.txt_ProdPrecioVenta);
            this.Controls.Add(this.btn_ProdGuardar);
            this.Controls.Add(this.lbl_ProdCantStock);
            this.Controls.Add(this.txt_ProdCantStock);
            this.Controls.Add(this.lbl_ProdUnidadMed);
            this.Controls.Add(this.lbl_ProMargenGanancia);
            this.Controls.Add(this.lbl_ProdDescripcion);
            this.Controls.Add(this.lbl_ProdCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Productos";
            this.Text = "Frm_Ventas";
            this.Load += new System.EventHandler(this.Frm_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ProdCodigo;
        private System.Windows.Forms.Label lbl_ProdDescripcion;
        private System.Windows.Forms.Label lbl_ProMargenGanancia;
        private System.Windows.Forms.Label lbl_ProdUnidadMed;
        private System.Windows.Forms.Label lbl_ProdCantStock;
        private System.Windows.Forms.TextBox txt_ProdCantStock;
        private FontAwesome.Sharp.IconButton btn_ProdGuardar;
        private System.Windows.Forms.Label lbl_ProdPrecioVenta;
        private System.Windows.Forms.TextBox txt_ProdPrecioVenta;
        private System.Windows.Forms.TextBox txt_ProdMargenGanancia;
        private System.Windows.Forms.DataGridView dgv_ProdLista;
        private FontAwesome.Sharp.IconButton btn_ProdEliminar;
        private FontAwesome.Sharp.IconButton btn_ProdEditar;
        private System.Windows.Forms.TextBox txt_ProdDescripcion;
        private System.Windows.Forms.TextBox txt_ProdCodigo;
        private System.Windows.Forms.ComboBox cmb_ProdUnidadMed;
    }
}