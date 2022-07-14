namespace Presentacion
{
    partial class Frm_FiltroInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FiltroInventario));
            this.dgvFiltroInventario = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.cbProducto = new System.Windows.Forms.CheckBox();
            this.cbcategoria = new System.Windows.Forms.CheckBox();
            this.cbcodigo = new System.Windows.Forms.CheckBox();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.btnFiltroCliente = new System.Windows.Forms.Button();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroInventario)).BeginInit();
            this.SuspendLayout();
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
            this.dgvFiltroInventario.TabIndex = 11;
            this.dgvFiltroInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltroInventario_CellClick);            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(573, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 20);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(11, 44);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(90, 23);
            this.txtcodigo.TabIndex = 18;
            // 
            // cbProducto
            // 
            this.cbProducto.AutoSize = true;
            this.cbProducto.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducto.Location = new System.Drawing.Point(307, 11);
            this.cbProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(94, 21);
            this.cbProducto.TabIndex = 13;
            this.cbProducto.Text = "Producto";
            this.cbProducto.UseVisualStyleBackColor = true;
            this.cbProducto.CheckedChanged += new System.EventHandler(this.cbProducto_CheckedChanged);
            // 
            // cbcategoria
            // 
            this.cbcategoria.AutoSize = true;
            this.cbcategoria.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcategoria.Location = new System.Drawing.Point(155, 11);
            this.cbcategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(96, 21);
            this.cbcategoria.TabIndex = 14;
            this.cbcategoria.Text = "Categoria";
            this.cbcategoria.UseVisualStyleBackColor = true;
            this.cbcategoria.CheckedChanged += new System.EventHandler(this.cbkcategoria_CheckedChanged);
            // 
            // cbcodigo
            // 
            this.cbcodigo.AutoSize = true;
            this.cbcodigo.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcodigo.Location = new System.Drawing.Point(22, 11);
            this.cbcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.cbcodigo.Name = "cbcodigo";
            this.cbcodigo.Size = new System.Drawing.Size(77, 21);
            this.cbcodigo.TabIndex = 15;
            this.cbcodigo.Text = "Codigo";
            this.cbcodigo.UseVisualStyleBackColor = true;
            this.cbcodigo.CheckedChanged += new System.EventHandler(this.cbcodigo_CheckedChanged);
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.Enabled = false;
            this.cmbcategoria.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(143, 43);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbcategoria.TabIndex = 19;
            // 
            // btnFiltroCliente
            // 
            this.btnFiltroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroCliente.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroCliente.Location = new System.Drawing.Point(458, 21);
            this.btnFiltroCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltroCliente.Name = "btnFiltroCliente";
            this.btnFiltroCliente.Size = new System.Drawing.Size(82, 35);
            this.btnFiltroCliente.TabIndex = 20;
            this.btnFiltroCliente.Text = "Filtrar";
            this.btnFiltroCliente.UseVisualStyleBackColor = true;
            this.btnFiltroCliente.Click += new System.EventHandler(this.btnFiltroCliente_Click);
            // 
            // cmbProducto
            // 
            this.cmbProducto.Enabled = false;
            this.cmbProducto.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(292, 43);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 24);
            this.cmbProducto.TabIndex = 19;
            // 
            // Frm_FiltroInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 275);
            this.Controls.Add(this.btnFiltroCliente);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.cmbcategoria);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.cbcategoria);
            this.Controls.Add(this.cbcodigo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvFiltroInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_FiltroInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_FiltroInventario";
            this.Load += new System.EventHandler(this.Frm_FiltroInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFiltroInventario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.CheckBox cbProducto;
        private System.Windows.Forms.CheckBox cbcategoria;
        private System.Windows.Forms.CheckBox cbcodigo;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.Button btnFiltroCliente;
        private System.Windows.Forms.ComboBox cmbProducto;
    }
}