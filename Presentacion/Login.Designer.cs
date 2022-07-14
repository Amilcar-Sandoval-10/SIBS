namespace Presentacion
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.cbcontraseña = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.BtnAcceso = new System.Windows.Forms.Button();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.lberror = new System.Windows.Forms.Label();
            this.lbIntentos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // cbcontraseña
            // 
            this.cbcontraseña.AutoSize = true;
            this.cbcontraseña.BackColor = System.Drawing.Color.Transparent;
            this.cbcontraseña.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcontraseña.ForeColor = System.Drawing.Color.Blue;
            this.cbcontraseña.Location = new System.Drawing.Point(327, 330);
            this.cbcontraseña.Name = "cbcontraseña";
            this.cbcontraseña.Size = new System.Drawing.Size(150, 20);
            this.cbcontraseña.TabIndex = 21;
            this.cbcontraseña.Text = "Mostrar Contraseña";
            this.cbcontraseña.UseVisualStyleBackColor = false;
            this.cbcontraseña.CheckedChanged += new System.EventHandler(this.cbcontraseña_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(458, 358);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 33);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // BtnAcceso
            // 
            this.BtnAcceso.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcceso.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcceso.ForeColor = System.Drawing.Color.Black;
            this.BtnAcceso.Location = new System.Drawing.Point(324, 358);
            this.BtnAcceso.Name = "BtnAcceso";
            this.BtnAcceso.Size = new System.Drawing.Size(112, 33);
            this.BtnAcceso.TabIndex = 20;
            this.BtnAcceso.Text = "INGRESAR";
            this.BtnAcceso.UseVisualStyleBackColor = false;
            this.BtnAcceso.Click += new System.EventHandler(this.BtnAcceso_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(323, 219);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(240, 21);
            this.txtusuario.TabIndex = 17;
            this.txtusuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtusuario_KeyDown);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.Location = new System.Drawing.Point(323, 274);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(240, 21);
            this.txtcontraseña.TabIndex = 18;
            this.txtcontraseña.UseSystemPasswordChar = true;
            this.txtcontraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontraseña_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.ImageKey = "(ninguno)";
            this.label2.Location = new System.Drawing.Point(321, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "CONTRASEÑA:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "USUARIO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // errorUsuario
            // 
            this.errorUsuario.ContainerControl = this;
            // 
            // errorContraseña
            // 
            this.errorContraseña.ContainerControl = this;
            // 
            // lberror
            // 
            this.lberror.AutoSize = true;
            this.lberror.BackColor = System.Drawing.Color.Transparent;
            this.lberror.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberror.ForeColor = System.Drawing.Color.Red;
            this.lberror.Location = new System.Drawing.Point(324, 307);
            this.lberror.Name = "lberror";
            this.lberror.Size = new System.Drawing.Size(242, 16);
            this.lberror.TabIndex = 22;
            this.lberror.Text = "Usuario ó Contraseña incorrecta";
            this.lberror.Visible = false;
            // 
            // lbIntentos
            // 
            this.lbIntentos.AutoSize = true;
            this.lbIntentos.BackColor = System.Drawing.Color.Transparent;
            this.lbIntentos.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntentos.ForeColor = System.Drawing.Color.Red;
            this.lbIntentos.Location = new System.Drawing.Point(95, 368);
            this.lbIntentos.Name = "lbIntentos";
            this.lbIntentos.Size = new System.Drawing.Size(71, 16);
            this.lbIntentos.TabIndex = 22;
            this.lbIntentos.Text = "Intentos";
            this.lbIntentos.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "TIPO DE USUARIO:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(324, 161);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(239, 23);
            this.cmbTipo.TabIndex = 23;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 431);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lbIntentos);
            this.Controls.Add(this.lberror);
            this.Controls.Add(this.cbcontraseña);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.BtnAcceso);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbcontraseña;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button BtnAcceso;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorUsuario;
        private System.Windows.Forms.ErrorProvider errorContraseña;
        private System.Windows.Forms.Label lberror;
        private System.Windows.Forms.Label lbIntentos;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label3;
    }
}