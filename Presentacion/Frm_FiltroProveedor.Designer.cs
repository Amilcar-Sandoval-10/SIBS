namespace Presentacion
{
    partial class Frm_FiltroProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FiltroProveedor));
            this.btnFiltroCliente = new System.Windows.Forms.Button();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.cbNombre = new System.Windows.Forms.CheckBox();
            this.cbcategoria = new System.Windows.Forms.CheckBox();
            this.cbcodigo = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvFiltroInventario = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltroCliente
            // 
            this.btnFiltroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroCliente.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroCliente.Location = new System.Drawing.Point(478, 22);
            this.btnFiltroCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltroCliente.Name = "btnFiltroCliente";
            this.btnFiltroCliente.Size = new System.Drawing.Size(82, 35);
            this.btnFiltroCliente.TabIndex = 27;
            this.btnFiltroCliente.Text = "Filtrar";
            this.btnFiltroCliente.UseVisualStyleBackColor = true;
            this.btnFiltroCliente.Click += new System.EventHandler(this.btnFiltroCliente_Click);
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.Enabled = false;
            this.cmbcategoria.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(307, 44);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbcategoria.TabIndex = 26;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(10, 44);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(90, 23);
            this.txtcodigo.TabIndex = 24;
            // 
            // cbNombre
            // 
            this.cbNombre.AutoSize = true;
            this.cbNombre.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNombre.Location = new System.Drawing.Point(170, 11);
            this.cbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(87, 21);
            this.cbNombre.TabIndex = 21;
            this.cbNombre.Text = "Nombre";
            this.cbNombre.UseVisualStyleBackColor = true;
            this.cbNombre.CheckedChanged += new System.EventHandler(this.cbNombre_CheckedChanged);
            // 
            // cbcategoria
            // 
            this.cbcategoria.AutoSize = true;
            this.cbcategoria.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcategoria.Location = new System.Drawing.Point(332, 11);
            this.cbcategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(96, 21);
            this.cbcategoria.TabIndex = 22;
            this.cbcategoria.Text = "Categoria";
            this.cbcategoria.UseVisualStyleBackColor = true;
            this.cbcategoria.CheckedChanged += new System.EventHandler(this.cbcategoria_CheckedChanged);
            // 
            // cbcodigo
            // 
            this.cbcodigo.AutoSize = true;
            this.cbcodigo.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcodigo.Location = new System.Drawing.Point(21, 11);
            this.cbcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.cbcodigo.Name = "cbcodigo";
            this.cbcodigo.Size = new System.Drawing.Size(77, 21);
            this.cbcodigo.TabIndex = 23;
            this.cbcodigo.Text = "Codigo";
            this.cbcodigo.UseVisualStyleBackColor = true;
            this.cbcodigo.CheckedChanged += new System.EventHandler(this.cbcodigo_CheckedChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(157, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 28;
            // 
            // dgvFiltroInventario
            // 
            this.dgvFiltroInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFiltroInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFiltroInventario.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvFiltroInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFiltroInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiltroInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFiltroInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltroInventario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFiltroInventario.EnableHeadersVisualStyles = false;
            this.dgvFiltroInventario.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvFiltroInventario.Location = new System.Drawing.Point(0, 90);
            this.dgvFiltroInventario.Name = "dgvFiltroInventario";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvFiltroInventario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFiltroInventario.Size = new System.Drawing.Size(592, 185);
            this.dgvFiltroInventario.TabIndex = 29;
            this.dgvFiltroInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltroInventario_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(573, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 20);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_FiltroProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvFiltroInventario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnFiltroCliente);
            this.Controls.Add(this.cmbcategoria);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.cbNombre);
            this.Controls.Add(this.cbcategoria);
            this.Controls.Add(this.cbcodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_FiltroProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_FiltroProveedor";
            this.Load += new System.EventHandler(this.Frm_FiltroProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltroCliente;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.CheckBox cbNombre;
        private System.Windows.Forms.CheckBox cbcategoria;
        private System.Windows.Forms.CheckBox cbcodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvFiltroInventario;
        private System.Windows.Forms.Button button1;
    }
}