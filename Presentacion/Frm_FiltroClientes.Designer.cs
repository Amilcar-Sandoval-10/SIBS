namespace Presentacion
{
    partial class Frm_FiltroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FiltroClientes));
            this.dgvFiltroCliente = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFiltroCliente = new System.Windows.Forms.Button();
            this.cbapellido = new System.Windows.Forms.CheckBox();
            this.cbnombre = new System.Windows.Forms.CheckBox();
            this.cbcodigo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroCliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFiltroCliente
            // 
            this.dgvFiltroCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFiltroCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFiltroCliente.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvFiltroCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFiltroCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiltroCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFiltroCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltroCliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFiltroCliente.EnableHeadersVisualStyles = false;
            this.dgvFiltroCliente.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvFiltroCliente.Location = new System.Drawing.Point(0, 91);
            this.dgvFiltroCliente.Name = "dgvFiltroCliente";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvFiltroCliente.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFiltroCliente.Size = new System.Drawing.Size(592, 275);
            this.dgvFiltroCliente.TabIndex = 10;
            this.dgvFiltroCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltroCliente_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtapellido);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.txtcodigo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnFiltroCliente);
            this.panel1.Controls.Add(this.cbapellido);
            this.panel1.Controls.Add(this.cbnombre);
            this.panel1.Controls.Add(this.cbcodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 91);
            this.panel1.TabIndex = 11;
            // 
            // txtapellido
            // 
            this.txtapellido.Enabled = false;
            this.txtapellido.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(320, 50);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(114, 23);
            this.txtapellido.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(178, 50);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(108, 23);
            this.txtnombre.TabIndex = 6;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(33, 50);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(90, 23);
            this.txtcodigo.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(574, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 20);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFiltroCliente
            // 
            this.btnFiltroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroCliente.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroCliente.Location = new System.Drawing.Point(470, 29);
            this.btnFiltroCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltroCliente.Name = "btnFiltroCliente";
            this.btnFiltroCliente.Size = new System.Drawing.Size(82, 35);
            this.btnFiltroCliente.TabIndex = 4;
            this.btnFiltroCliente.Text = "Filtrar";
            this.btnFiltroCliente.UseVisualStyleBackColor = true;
            this.btnFiltroCliente.Click += new System.EventHandler(this.btnFiltroCliente_Click);
            // 
            // cbapellido
            // 
            this.cbapellido.AutoSize = true;
            this.cbapellido.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbapellido.Location = new System.Drawing.Point(328, 18);
            this.cbapellido.Margin = new System.Windows.Forms.Padding(2);
            this.cbapellido.Name = "cbapellido";
            this.cbapellido.Size = new System.Drawing.Size(88, 21);
            this.cbapellido.TabIndex = 1;
            this.cbapellido.Text = "Apellido";
            this.cbapellido.UseVisualStyleBackColor = true;
            this.cbapellido.CheckedChanged += new System.EventHandler(this.cbapellido_CheckedChanged);
            // 
            // cbnombre
            // 
            this.cbnombre.AutoSize = true;
            this.cbnombre.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnombre.Location = new System.Drawing.Point(191, 18);
            this.cbnombre.Margin = new System.Windows.Forms.Padding(2);
            this.cbnombre.Name = "cbnombre";
            this.cbnombre.Size = new System.Drawing.Size(87, 21);
            this.cbnombre.TabIndex = 2;
            this.cbnombre.Text = "Nombre";
            this.cbnombre.UseVisualStyleBackColor = true;
            this.cbnombre.CheckedChanged += new System.EventHandler(this.cbnombre_CheckedChanged);
            // 
            // cbcodigo
            // 
            this.cbcodigo.AutoSize = true;
            this.cbcodigo.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcodigo.Location = new System.Drawing.Point(43, 18);
            this.cbcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.cbcodigo.Name = "cbcodigo";
            this.cbcodigo.Size = new System.Drawing.Size(77, 21);
            this.cbcodigo.TabIndex = 3;
            this.cbcodigo.Text = "Codigo";
            this.cbcodigo.UseVisualStyleBackColor = true;
            this.cbcodigo.CheckedChanged += new System.EventHandler(this.cbcodigo_CheckedChanged);
            // 
            // Frm_FiltroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvFiltroCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_FiltroClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_FiltroClientes";
            this.Load += new System.EventHandler(this.Frm_FiltroClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFiltroCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFiltroCliente;
        private System.Windows.Forms.CheckBox cbapellido;
        private System.Windows.Forms.CheckBox cbnombre;
        private System.Windows.Forms.CheckBox cbcodigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcodigo;
    }
}