namespace iCantina.Views
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lb_data = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lb_bemvindo = new System.Windows.Forms.Label();
            this.btn_Pratos = new Guna.UI2.WinForms.Guna2Button();
            this.bt_extras = new Guna.UI2.WinForms.Guna2Button();
            this.btn_menu = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Multas = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Reservas = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Funcionarios = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Estudantes = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label3.Location = new System.Drawing.Point(242, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "Data:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(207, -19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(3, 800);
            this.label4.TabIndex = 39;
            this.label4.Text = "label4";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(227, 23);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(243, 93);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 38;
            this.logo.TabStop = false;
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lb_data.Location = new System.Drawing.Point(291, 322);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(71, 22);
            this.lb_data.TabIndex = 37;
            this.lb_data.Text = "<Data>";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(295, 221);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(196, 22);
            this.lbUsername.TabIndex = 36;
            this.lbUsername.Text = "<nomeFuncionario>";
            // 
            // lb_bemvindo
            // 
            this.lb_bemvindo.AutoSize = true;
            this.lb_bemvindo.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lb_bemvindo.Location = new System.Drawing.Point(242, 180);
            this.lb_bemvindo.Name = "lb_bemvindo";
            this.lb_bemvindo.Size = new System.Drawing.Size(110, 22);
            this.lb_bemvindo.TabIndex = 35;
            this.lb_bemvindo.Text = "Bem-Vindo,";
            // 
            // btn_Pratos
            // 
            this.btn_Pratos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Pratos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Pratos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Pratos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Pratos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Pratos.ForeColor = System.Drawing.Color.White;
            this.btn_Pratos.Location = new System.Drawing.Point(21, 86);
            this.btn_Pratos.Name = "btn_Pratos";
            this.btn_Pratos.Size = new System.Drawing.Size(180, 45);
            this.btn_Pratos.TabIndex = 34;
            this.btn_Pratos.Text = "Pratos";
            this.btn_Pratos.Click += new System.EventHandler(this.btn_Pratos_Click);
            // 
            // bt_extras
            // 
            this.bt_extras.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_extras.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_extras.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_extras.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_extras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_extras.ForeColor = System.Drawing.Color.White;
            this.bt_extras.Location = new System.Drawing.Point(21, 146);
            this.bt_extras.Name = "bt_extras";
            this.bt_extras.Size = new System.Drawing.Size(180, 45);
            this.bt_extras.TabIndex = 33;
            this.bt_extras.Text = "Extras";
            this.bt_extras.Click += new System.EventHandler(this.bt_extras_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_menu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_menu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_menu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Location = new System.Drawing.Point(21, 206);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(180, 45);
            this.btn_menu.TabIndex = 32;
            this.btn_menu.Text = "Menu";
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // bt_Multas
            // 
            this.bt_Multas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Multas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Multas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Multas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Multas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_Multas.ForeColor = System.Drawing.Color.White;
            this.bt_Multas.Location = new System.Drawing.Point(21, 326);
            this.bt_Multas.Name = "bt_Multas";
            this.bt_Multas.Size = new System.Drawing.Size(180, 45);
            this.bt_Multas.TabIndex = 31;
            this.bt_Multas.Text = "Multas";
            this.bt_Multas.Click += new System.EventHandler(this.bt_Multas_Click);
            // 
            // bt_Reservas
            // 
            this.bt_Reservas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Reservas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Reservas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Reservas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Reservas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_Reservas.ForeColor = System.Drawing.Color.White;
            this.bt_Reservas.Location = new System.Drawing.Point(21, 266);
            this.bt_Reservas.Name = "bt_Reservas";
            this.bt_Reservas.Size = new System.Drawing.Size(180, 45);
            this.bt_Reservas.TabIndex = 30;
            this.bt_Reservas.Text = "Reservas";
            this.bt_Reservas.Click += new System.EventHandler(this.bt_Reservas_Click);
            // 
            // bt_Funcionarios
            // 
            this.bt_Funcionarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Funcionarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Funcionarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Funcionarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Funcionarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_Funcionarios.ForeColor = System.Drawing.Color.White;
            this.bt_Funcionarios.Location = new System.Drawing.Point(21, 448);
            this.bt_Funcionarios.Name = "bt_Funcionarios";
            this.bt_Funcionarios.Size = new System.Drawing.Size(180, 45);
            this.bt_Funcionarios.TabIndex = 29;
            this.bt_Funcionarios.Text = "Funcionarios";
            this.bt_Funcionarios.Click += new System.EventHandler(this.bt_Funcionarios_Click);
            // 
            // bt_Estudantes
            // 
            this.bt_Estudantes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Estudantes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Estudantes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Estudantes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Estudantes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_Estudantes.ForeColor = System.Drawing.Color.White;
            this.bt_Estudantes.Location = new System.Drawing.Point(21, 386);
            this.bt_Estudantes.Name = "bt_Estudantes";
            this.bt_Estudantes.Size = new System.Drawing.Size(180, 45);
            this.bt_Estudantes.TabIndex = 28;
            this.bt_Estudantes.Text = "Clientes";
            this.bt_Estudantes.Click += new System.EventHandler(this.bt_Estudantes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 26;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1077, 586);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lb_bemvindo);
            this.Controls.Add(this.btn_Pratos);
            this.Controls.Add(this.bt_extras);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.bt_Multas);
            this.Controls.Add(this.bt_Reservas);
            this.Controls.Add(this.bt_Funcionarios);
            this.Controls.Add(this.bt_Estudantes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário_Principal";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lb_bemvindo;
        private Guna.UI2.WinForms.Guna2Button btn_Pratos;
        private Guna.UI2.WinForms.Guna2Button bt_extras;
        private Guna.UI2.WinForms.Guna2Button btn_menu;
        private Guna.UI2.WinForms.Guna2Button bt_Multas;
        private Guna.UI2.WinForms.Guna2Button bt_Reservas;
        private Guna.UI2.WinForms.Guna2Button bt_Funcionarios;
        private Guna.UI2.WinForms.Guna2Button bt_Estudantes;
        private System.Windows.Forms.Label label5;
    }
}

