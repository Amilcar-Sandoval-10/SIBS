namespace Presentacion
{
    partial class Frm_FiltroUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FiltroUsuario));
            this.dgvFiltroUsuario = new System.Windows.Forms.DataGridView();
            this.cbUsuario = new System.Windows.Forms.CheckBox();
            this.cbTipo = new System.Windows.Forms.CheckBox();
            this.btnFiltroCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFiltroUsuario
            // 
            this.dgvFiltroUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFiltroUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFiltroUsuario.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvFiltroUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFiltroUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiltroUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFiltroUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltroUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFiltroUsuario.EnableHeadersVisualStyles = false;
            this.dgvFiltroUsuario.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvFiltroUsuario.Location = new System.Drawing.Point(0, 91);
            this.dgvFiltroUsuario.Name = "dgvFiltroUsuario";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvFiltroUsuario.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFiltroUsuario.Size = new System.Drawing.Size(592, 275);
            this.dgvFiltroUsuario.TabIndex = 12;
            // 
            // cbUsuario
            // 
            this.cbUsuario.AutoSize = true;
            this.cbUsuario.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsuario.Location = new System.Drawing.Point(43, 18);
            this.cbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(84, 21);
            this.cbUsuario.TabIndex = 3;
            this.cbUsuario.Text = "Usuario";
            this.cbUsuario.UseVisualStyleBackColor = true;
            this.cbUsuario.CheckedChanged += new System.EventHandler(this.cbUsuario_CheckedChanged);
            // 
            // cbTipo
            // 
            this.cbTipo.AutoSize = true;
            this.cbTipo.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.Location = new System.Drawing.Point(257, 18);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(61, 21);
            this.cbTipo.TabIndex = 2;
            this.cbTipo.Text = "Tipo";
            this.cbTipo.UseVisualStyleBackColor = true;
            this.cbTipo.CheckedChanged += new System.EventHandler(this.cbTipo_CheckedChanged);
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
            // cmbTipo
            // 
            this.cmbTipo.Enabled = false;
            this.cmbTipo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(220, 51);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(151, 24);
            this.cmbTipo.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.txtcodigo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnFiltroCliente);
            this.panel1.Controls.Add(this.cbTipo);
            this.panel1.Controls.Add(this.cbUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 91);
            this.panel1.TabIndex = 13;
            // 
            // Frm_FiltroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvFiltroUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_FiltroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_FiltroUsuario";
            this.Load += new System.EventHandler(this.Frm_FiltroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFiltroUsuario;
        private System.Windows.Forms.CheckBox cbUsuario;
        private System.Windows.Forms.CheckBox cbTipo;
        private System.Windows.Forms.Button btnFiltroCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Panel panel1;
    }
}