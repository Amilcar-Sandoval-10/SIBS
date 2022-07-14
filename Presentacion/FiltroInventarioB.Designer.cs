namespace Presentacion
{
    partial class FiltroInventarioB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroInventarioB));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFiltroCliente = new System.Windows.Forms.Button();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.cbProducto = new System.Windows.Forms.CheckBox();
            this.cbcategoria = new System.Windows.Forms.CheckBox();
            this.cbcodigo = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvFiltroInventario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltroCliente
            // 
            this.btnFiltroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroCliente.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroCliente.Location = new System.Drawing.Point(464, 19);
            this.btnFiltroCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltroCliente.Name = "btnFiltroCliente";
            this.btnFiltroCliente.Size = new System.Drawing.Size(82, 35);
            this.btnFiltroCliente.TabIndex = 27;
            this.btnFiltroCliente.Text = "Filtrar";
            this.btnFiltroCliente.UseVisualStyleBackColor = true;
            this.btnFiltroCliente.Click += new System.EventHandler(this.btnFiltroCliente_Click_1);
            // 
            // cmbProducto
            // 
            this.cmbProducto.Enabled = false;
            this.cmbProducto.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(297, 41);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 24);
            this.cmbProducto.TabIndex = 25;
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.Enabled = false;
            this.cmbcategoria.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(148, 41);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbcategoria.TabIndex = 26;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(16, 41);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(90, 23);
            this.txtcodigo.TabIndex = 24;
            // 
            // cbProducto
            // 
            this.cbProducto.AutoSize = true;
            this.cbProducto.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducto.Location = new System.Drawing.Point(312, 9);
            this.cbProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(94, 21);
            this.cbProducto.TabIndex = 21;
            this.cbProducto.Text = "Producto";
            this.cbProducto.UseVisualStyleBackColor = true;
            this.cbProducto.CheckedChanged += new System.EventHandler(this.cbProducto_CheckedChanged_1);
            // 
            // cbcategoria
            // 
            this.cbcategoria.AutoSize = true;
            this.cbcategoria.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcategoria.Location = new System.Drawing.Point(160, 9);
            this.cbcategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.cbcodigo.Location = new System.Drawing.Point(27, 9);
            this.cbcodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbcodigo.Name = "cbcodigo";
            this.cbcodigo.Size = new System.Drawing.Size(77, 21);
            this.cbcodigo.TabIndex = 23;
            this.cbcodigo.Text = "Codigo";
            this.cbcodigo.UseVisualStyleBackColor = true;
            this.cbcodigo.CheckedChanged += new System.EventHandler(this.cbcodigo_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(568, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 20);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvFiltroInventario
            // 
            this.dgvFiltroInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFiltroInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFiltroInventario.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvFiltroInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFiltroInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiltroInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFiltroInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltroInventario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFiltroInventario.EnableHeadersVisualStyles = false;
            this.dgvFiltroInventario.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvFiltroInventario.Location = new System.Drawing.Point(0, 90);
            this.dgvFiltroInventario.Name = "dgvFiltroInventario";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvFiltroInventario.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFiltroInventario.Size = new System.Drawing.Size(592, 185);
            this.dgvFiltroInventario.TabIndex = 29;
            this.dgvFiltroInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltroInventario_CellClick_1);
            // 
            // FiltroInventarioB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 275);
            this.Controls.Add(this.dgvFiltroInventario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFiltroCliente);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.cmbcategoria);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.cbcategoria);
            this.Controls.Add(this.cbcodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FiltroInventarioB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiltroInventarioB";
            this.Load += new System.EventHandler(this.FiltroInventarioB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltroCliente;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.CheckBox cbProducto;
        private System.Windows.Forms.CheckBox cbcategoria;
        private System.Windows.Forms.CheckBox cbcodigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvFiltroInventario;
    }
}