namespace iCantina.Views
{
    partial class FormFuncionario
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
            this.btn_voltar = new Guna.UI2.WinForms.Guna2Button();
            this.gtb_NIF = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gtb_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gtb_Nome = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_atualizarFunc = new Guna.UI2.WinForms.Guna2Button();
            this.button_deleteFunc = new Guna.UI2.WinForms.Guna2Button();
            this.button_criarFunc = new Guna.UI2.WinForms.Guna2Button();
            this.listBoxFuncionarios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.BorderRadius = 15;
            this.btn_voltar.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btn_voltar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_voltar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_voltar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_voltar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_voltar.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(921, 10);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(144, 45);
            this.btn_voltar.TabIndex = 36;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // gtb_NIF
            // 
            this.gtb_NIF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_NIF.DefaultText = "";
            this.gtb_NIF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtb_NIF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtb_NIF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_NIF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_NIF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_NIF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtb_NIF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_NIF.Location = new System.Drawing.Point(100, 301);
            this.gtb_NIF.Name = "gtb_NIF";
            this.gtb_NIF.PasswordChar = '\0';
            this.gtb_NIF.PlaceholderText = "";
            this.gtb_NIF.SelectedText = "";
            this.gtb_NIF.Size = new System.Drawing.Size(200, 36);
            this.gtb_NIF.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label5.Location = new System.Drawing.Point(96, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "NIF:";
            // 
            // gtb_username
            // 
            this.gtb_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_username.DefaultText = "";
            this.gtb_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtb_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtb_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtb_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_username.Location = new System.Drawing.Point(100, 221);
            this.gtb_username.Name = "gtb_username";
            this.gtb_username.PasswordChar = '\0';
            this.gtb_username.PlaceholderText = "";
            this.gtb_username.SelectedText = "";
            this.gtb_username.Size = new System.Drawing.Size(200, 36);
            this.gtb_username.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.Location = new System.Drawing.Point(96, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Username:";
            // 
            // gtb_Nome
            // 
            this.gtb_Nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_Nome.DefaultText = "";
            this.gtb_Nome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtb_Nome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtb_Nome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_Nome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_Nome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_Nome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtb_Nome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_Nome.Location = new System.Drawing.Point(100, 136);
            this.gtb_Nome.Name = "gtb_Nome";
            this.gtb_Nome.PasswordChar = '\0';
            this.gtb_Nome.PlaceholderText = "";
            this.gtb_Nome.SelectedText = "";
            this.gtb_Nome.Size = new System.Drawing.Size(200, 36);
            this.gtb_Nome.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label4.Location = new System.Drawing.Point(96, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nome:";
            // 
            // button_atualizarFunc
            // 
            this.button_atualizarFunc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_atualizarFunc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_atualizarFunc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_atualizarFunc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_atualizarFunc.FillColor = System.Drawing.Color.Orange;
            this.button_atualizarFunc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_atualizarFunc.ForeColor = System.Drawing.Color.White;
            this.button_atualizarFunc.Location = new System.Drawing.Point(472, 516);
            this.button_atualizarFunc.Name = "button_atualizarFunc";
            this.button_atualizarFunc.Size = new System.Drawing.Size(130, 40);
            this.button_atualizarFunc.TabIndex = 29;
            this.button_atualizarFunc.Text = "Atualizar";
            this.button_atualizarFunc.Click += new System.EventHandler(this.button_atualizarFunc_Click);
            // 
            // button_deleteFunc
            // 
            this.button_deleteFunc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_deleteFunc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_deleteFunc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_deleteFunc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_deleteFunc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_deleteFunc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteFunc.ForeColor = System.Drawing.Color.White;
            this.button_deleteFunc.Location = new System.Drawing.Point(636, 516);
            this.button_deleteFunc.Name = "button_deleteFunc";
            this.button_deleteFunc.Size = new System.Drawing.Size(130, 40);
            this.button_deleteFunc.TabIndex = 28;
            this.button_deleteFunc.Text = "Apagar";
            this.button_deleteFunc.Click += new System.EventHandler(this.button_deleteFunc_Click);
            // 
            // button_criarFunc
            // 
            this.button_criarFunc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_criarFunc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_criarFunc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_criarFunc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_criarFunc.FillColor = System.Drawing.Color.Green;
            this.button_criarFunc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_criarFunc.ForeColor = System.Drawing.Color.White;
            this.button_criarFunc.Location = new System.Drawing.Point(303, 516);
            this.button_criarFunc.Name = "button_criarFunc";
            this.button_criarFunc.Size = new System.Drawing.Size(130, 40);
            this.button_criarFunc.TabIndex = 27;
            this.button_criarFunc.Text = "Criar";
            this.button_criarFunc.Click += new System.EventHandler(this.button_criarFunc_Click);
            // 
            // listBoxFuncionarios
            // 
            this.listBoxFuncionarios.FormattingEnabled = true;
            this.listBoxFuncionarios.Location = new System.Drawing.Point(372, 64);
            this.listBoxFuncionarios.Name = "listBoxFuncionarios";
            this.listBoxFuncionarios.Size = new System.Drawing.Size(415, 394);
            this.listBoxFuncionarios.TabIndex = 26;
            this.listBoxFuncionarios.SelectedIndexChanged += new System.EventHandler(this.listBoxFuncionarios_SelectedIndexChanged);
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1077, 586);
            this.ControlBox = false;
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.gtb_NIF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gtb_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gtb_Nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_atualizarFunc);
            this.Controls.Add(this.button_deleteFunc);
            this.Controls.Add(this.button_criarFunc);
            this.Controls.Add(this.listBoxFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário_Funcionário";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_voltar;
        private Guna.UI2.WinForms.Guna2TextBox gtb_NIF;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox gtb_username;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox gtb_Nome;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button button_atualizarFunc;
        private Guna.UI2.WinForms.Guna2Button button_deleteFunc;
        private Guna.UI2.WinForms.Guna2Button button_criarFunc;
        private System.Windows.Forms.ListBox listBoxFuncionarios;
    }
}