namespace Presentacion
{
    partial class Frm_FiltroEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FiltroEmpleado));
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnFiltroEmpledos = new System.Windows.Forms.Button();
            this.cbapellido = new System.Windows.Forms.CheckBox();
            this.cbnombre = new System.Windows.Forms.CheckBox();
            this.cbcodigo = new System.Windows.Forms.CheckBox();
            this.dgvFiltroEmpleado = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtapellido
            // 
            this.txtapellido.Enabled = false;
            this.txtapellido.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(320, 56);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(114, 23);
            this.txtapellido.TabIndex = 11;
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(178, 56);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(108, 23);
            this.txtnombre.TabIndex = 12;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(33, 56);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(90, 23);
            this.txtcodigo.TabIndex = 13;
            // 
            // btnFiltroEmpledos
            // 
            this.btnFiltroEmpledos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroEmpledos.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroEmpledos.Location = new System.Drawing.Point(470, 35);
            this.btnFiltroEmpledos.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltroEmpledos.Name = "btnFiltroEmpledos";
            this.btnFiltroEmpledos.Size = new System.Drawing.Size(82, 35);
            this.btnFiltroEmpledos.TabIndex = 10;
            this.btnFiltroEmpledos.Text = "Filtrar";
            this.btnFiltroEmpledos.UseVisualStyleBackColor = true;
            this.btnFiltroEmpledos.Click += new System.EventHandler(this.btnFiltroEmpledos_Click);
            // 
            // cbapellido
            // 
            this.cbapellido.AutoSize = true;
            this.cbapellido.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbapellido.Location = new System.Drawing.Point(328, 24);
            this.cbapellido.Margin = new System.Windows.Forms.Padding(2);
            this.cbapellido.Name = "cbapellido";
            this.cbapellido.Size = new System.Drawing.Size(88, 21);
            this.cbapellido.TabIndex = 7;
            this.cbapellido.Text = "Apellido";
            this.cbapellido.UseVisualStyleBackColor = true;
            this.cbapellido.CheckedChanged += new System.EventHandler(this.cbapellido_CheckedChanged);
            // 
            // cbnombre
            // 
            this.cbnombre.AutoSize = true;
            this.cbnombre.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnombre.Location = new System.Drawing.Point(191, 24);
            this.cbnombre.Margin = new System.Windows.Forms.Padding(2);
            this.cbnombre.Name = "cbnombre";
            this.cbnombre.Size = new System.Drawing.Size(87, 21);
            this.cbnombre.TabIndex = 8;
            this.cbnombre.Text = "Nombre";
            this.cbnombre.UseVisualStyleBackColor = true;
            this.cbnombre.CheckedChanged += new System.EventHandler(this.cbnombre_CheckedChanged);
            // 
            // cbcodigo
            // 
            this.cbcodigo.AutoSize = true;
            this.cbcodigo.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcodigo.Location = new System.Drawing.Point(43, 24);
            this.cbcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.cbcodigo.Name = "cbcodigo";
            this.cbcodigo.Size = new System.Drawing.Size(77, 21);
            this.cbcodigo.TabIndex = 9;
            this.cbcodigo.Text = "Codigo";
            this.cbcodigo.UseVisualStyleBackColor = true;
            this.cbcodigo.CheckedChanged += new System.EventHandler(this.cbcodigo_CheckedChanged);
            // 
            // dgvFiltroEmpleado
            // 
            this.dgvFiltroEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFiltroEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFiltroEmpleado.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvFiltroEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFiltroEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiltroEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFiltroEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltroEmpleado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFiltroEmpleado.EnableHeadersVisualStyles = false;
            this.dgvFiltroEmpleado.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvFiltroEmpleado.Location = new System.Drawing.Point(0, 91);
            this.dgvFiltroEmpleado.Name = "dgvFiltroEmpleado";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvFiltroEmpleado.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFiltroEmpleado.Size = new System.Drawing.Size(592, 275);
            this.dgvFiltroEmpleado.TabIndex = 14;
            this.dgvFiltroEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltroEmpleado_CellClick);
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
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_FiltroEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvFiltroEmpleado);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.btnFiltroEmpledos);
            this.Controls.Add(this.cbapellido);
            this.Controls.Add(this.cbnombre);
            this.Controls.Add(this.cbcodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_FiltroEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_FiltroEmpleado";
            this.Load += new System.EventHandler(this.Frm_FiltroEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnFiltroEmpledos;
        private System.Windows.Forms.CheckBox cbapellido;
        private System.Windows.Forms.CheckBox cbnombre;
        private System.Windows.Forms.CheckBox cbcodigo;
        private System.Windows.Forms.DataGridView dgvFiltroEmpleado;
        private System.Windows.Forms.Button button1;
    }
}