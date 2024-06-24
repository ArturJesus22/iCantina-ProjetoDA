namespace iCantina.Views
{
    partial class FormCliente
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
            this.label_nomeEstudante = new System.Windows.Forms.Label();
            this.label_nifEstudante = new System.Windows.Forms.Label();
            this.label_saldoEstudante = new System.Windows.Forms.Label();
            this.label_Nestudante = new System.Windows.Forms.Label();
            this.listBox_cliente = new System.Windows.Forms.ListBox();
            this.button_addEstudante = new Guna.UI2.WinForms.Guna2Button();
            this.button_apagarEstudante = new Guna.UI2.WinForms.Guna2Button();
            this.button_editarEstudante = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nomeEstudante = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_nifEstudante = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_nEstudante = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_saldoEstudante = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_voltar = new Guna.UI2.WinForms.Guna2Button();
            this.email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gcb_cat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_nomeEstudante
            // 
            this.label_nomeEstudante.AutoSize = true;
            this.label_nomeEstudante.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomeEstudante.Location = new System.Drawing.Point(83, 139);
            this.label_nomeEstudante.Name = "label_nomeEstudante";
            this.label_nomeEstudante.Size = new System.Drawing.Size(149, 22);
            this.label_nomeEstudante.TabIndex = 3;
            this.label_nomeEstudante.Text = "Nome Completo";
            // 
            // label_nifEstudante
            // 
            this.label_nifEstudante.AutoSize = true;
            this.label_nifEstudante.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nifEstudante.Location = new System.Drawing.Point(191, 185);
            this.label_nifEstudante.Name = "label_nifEstudante";
            this.label_nifEstudante.Size = new System.Drawing.Size(41, 22);
            this.label_nifEstudante.TabIndex = 4;
            this.label_nifEstudante.Text = "NIF";
            // 
            // label_saldoEstudante
            // 
            this.label_saldoEstudante.AutoSize = true;
            this.label_saldoEstudante.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_saldoEstudante.Location = new System.Drawing.Point(173, 228);
            this.label_saldoEstudante.Name = "label_saldoEstudante";
            this.label_saldoEstudante.Size = new System.Drawing.Size(59, 22);
            this.label_saldoEstudante.TabIndex = 5;
            this.label_saldoEstudante.Text = "Saldo";
            // 
            // label_Nestudante
            // 
            this.label_Nestudante.AutoSize = true;
            this.label_Nestudante.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nestudante.Location = new System.Drawing.Point(65, 271);
            this.label_Nestudante.Name = "label_Nestudante";
            this.label_Nestudante.Size = new System.Drawing.Size(167, 22);
            this.label_Nestudante.TabIndex = 6;
            this.label_Nestudante.Text = "Numero Estudante";
            // 
            // listBox_cliente
            // 
            this.listBox_cliente.FormattingEnabled = true;
            this.listBox_cliente.Location = new System.Drawing.Point(712, 75);
            this.listBox_cliente.Name = "listBox_cliente";
            this.listBox_cliente.Size = new System.Drawing.Size(287, 381);
            this.listBox_cliente.TabIndex = 11;
            this.listBox_cliente.SelectedIndexChanged += new System.EventHandler(this.listBox_estudante_SelectedIndexChanged);
            // 
            // button_addEstudante
            // 
            this.button_addEstudante.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_addEstudante.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_addEstudante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_addEstudante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_addEstudante.FillColor = System.Drawing.Color.Green;
            this.button_addEstudante.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addEstudante.ForeColor = System.Drawing.Color.White;
            this.button_addEstudante.Location = new System.Drawing.Point(303, 516);
            this.button_addEstudante.Name = "button_addEstudante";
            this.button_addEstudante.Size = new System.Drawing.Size(130, 40);
            this.button_addEstudante.TabIndex = 12;
            this.button_addEstudante.Text = "Registar";
            this.button_addEstudante.Click += new System.EventHandler(this.button_addEstudante_Click_1);
            // 
            // button_apagarEstudante
            // 
            this.button_apagarEstudante.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_apagarEstudante.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_apagarEstudante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_apagarEstudante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_apagarEstudante.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_apagarEstudante.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_apagarEstudante.ForeColor = System.Drawing.Color.White;
            this.button_apagarEstudante.Location = new System.Drawing.Point(636, 516);
            this.button_apagarEstudante.Name = "button_apagarEstudante";
            this.button_apagarEstudante.Size = new System.Drawing.Size(130, 40);
            this.button_apagarEstudante.TabIndex = 13;
            this.button_apagarEstudante.Text = "Apagar";
            this.button_apagarEstudante.Click += new System.EventHandler(this.button_apagarEstudante_Click_1);
            // 
            // button_editarEstudante
            // 
            this.button_editarEstudante.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_editarEstudante.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_editarEstudante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_editarEstudante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_editarEstudante.FillColor = System.Drawing.Color.Orange;
            this.button_editarEstudante.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editarEstudante.ForeColor = System.Drawing.Color.White;
            this.button_editarEstudante.Location = new System.Drawing.Point(472, 516);
            this.button_editarEstudante.Name = "button_editarEstudante";
            this.button_editarEstudante.Size = new System.Drawing.Size(130, 40);
            this.button_editarEstudante.TabIndex = 14;
            this.button_editarEstudante.Text = "Atualizar";
            this.button_editarEstudante.Click += new System.EventHandler(this.button_editarEstudante_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(708, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Clientes";
            // 
            // textBox_nomeEstudante
            // 
            this.textBox_nomeEstudante.Animated = true;
            this.textBox_nomeEstudante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_nomeEstudante.DefaultText = "";
            this.textBox_nomeEstudante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_nomeEstudante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_nomeEstudante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_nomeEstudante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_nomeEstudante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_nomeEstudante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_nomeEstudante.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_nomeEstudante.Location = new System.Drawing.Point(241, 140);
            this.textBox_nomeEstudante.Name = "textBox_nomeEstudante";
            this.textBox_nomeEstudante.PasswordChar = '\0';
            this.textBox_nomeEstudante.PlaceholderText = "";
            this.textBox_nomeEstudante.SelectedText = "";
            this.textBox_nomeEstudante.Size = new System.Drawing.Size(260, 30);
            this.textBox_nomeEstudante.TabIndex = 23;
            // 
            // textBox_nifEstudante
            // 
            this.textBox_nifEstudante.Animated = true;
            this.textBox_nifEstudante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_nifEstudante.DefaultText = "";
            this.textBox_nifEstudante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_nifEstudante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_nifEstudante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_nifEstudante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_nifEstudante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_nifEstudante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_nifEstudante.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_nifEstudante.Location = new System.Drawing.Point(241, 182);
            this.textBox_nifEstudante.Name = "textBox_nifEstudante";
            this.textBox_nifEstudante.PasswordChar = '\0';
            this.textBox_nifEstudante.PlaceholderText = "";
            this.textBox_nifEstudante.SelectedText = "";
            this.textBox_nifEstudante.Size = new System.Drawing.Size(260, 30);
            this.textBox_nifEstudante.TabIndex = 24;
            // 
            // textBox_nEstudante
            // 
            this.textBox_nEstudante.Animated = true;
            this.textBox_nEstudante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_nEstudante.DefaultText = "";
            this.textBox_nEstudante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_nEstudante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_nEstudante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_nEstudante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_nEstudante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_nEstudante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_nEstudante.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_nEstudante.Location = new System.Drawing.Point(241, 268);
            this.textBox_nEstudante.Name = "textBox_nEstudante";
            this.textBox_nEstudante.PasswordChar = '\0';
            this.textBox_nEstudante.PlaceholderText = "";
            this.textBox_nEstudante.SelectedText = "";
            this.textBox_nEstudante.Size = new System.Drawing.Size(260, 30);
            this.textBox_nEstudante.TabIndex = 25;
            // 
            // textBox_saldoEstudante
            // 
            this.textBox_saldoEstudante.Animated = true;
            this.textBox_saldoEstudante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_saldoEstudante.DefaultText = "";
            this.textBox_saldoEstudante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_saldoEstudante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_saldoEstudante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_saldoEstudante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_saldoEstudante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_saldoEstudante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_saldoEstudante.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_saldoEstudante.Location = new System.Drawing.Point(241, 225);
            this.textBox_saldoEstudante.Name = "textBox_saldoEstudante";
            this.textBox_saldoEstudante.PasswordChar = '\0';
            this.textBox_saldoEstudante.PlaceholderText = "";
            this.textBox_saldoEstudante.SelectedText = "";
            this.textBox_saldoEstudante.Size = new System.Drawing.Size(260, 30);
            this.textBox_saldoEstudante.TabIndex = 26;
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
            this.btn_voltar.TabIndex = 32;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // email
            // 
            this.email.Animated = true;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.DefaultText = "";
            this.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.Location = new System.Drawing.Point(241, 311);
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.PlaceholderText = "";
            this.email.SelectedText = "";
            this.email.Size = new System.Drawing.Size(260, 30);
            this.email.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Email";
            // 
            // gcb_cat
            // 
            this.gcb_cat.BackColor = System.Drawing.Color.Transparent;
            this.gcb_cat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcb_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcb_cat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcb_cat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcb_cat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gcb_cat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gcb_cat.ItemHeight = 30;
            this.gcb_cat.Items.AddRange(new object[] {
            "Professor",
            "Estudante"});
            this.gcb_cat.Location = new System.Drawing.Point(242, 89);
            this.gcb_cat.Name = "gcb_cat";
            this.gcb_cat.Size = new System.Drawing.Size(140, 36);
            this.gcb_cat.TabIndex = 35;
            this.gcb_cat.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tipo";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1077, 586);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gcb_cat);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.textBox_saldoEstudante);
            this.Controls.Add(this.textBox_nEstudante);
            this.Controls.Add(this.textBox_nifEstudante);
            this.Controls.Add(this.textBox_nomeEstudante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_editarEstudante);
            this.Controls.Add(this.button_apagarEstudante);
            this.Controls.Add(this.button_addEstudante);
            this.Controls.Add(this.listBox_cliente);
            this.Controls.Add(this.label_Nestudante);
            this.Controls.Add(this.label_saldoEstudante);
            this.Controls.Add(this.label_nifEstudante);
            this.Controls.Add(this.label_nomeEstudante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario_Estudante";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_nomeEstudante;
        private System.Windows.Forms.Label label_nifEstudante;
        private System.Windows.Forms.Label label_saldoEstudante;
        private System.Windows.Forms.Label label_Nestudante;
        private System.Windows.Forms.ListBox listBox_cliente;
        private Guna.UI2.WinForms.Guna2Button button_addEstudante;
        private Guna.UI2.WinForms.Guna2Button button_apagarEstudante;
        private Guna.UI2.WinForms.Guna2Button button_editarEstudante;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBox_nomeEstudante;
        private Guna.UI2.WinForms.Guna2TextBox textBox_nifEstudante;
        private Guna.UI2.WinForms.Guna2TextBox textBox_nEstudante;
        private Guna.UI2.WinForms.Guna2TextBox textBox_saldoEstudante;
        private Guna.UI2.WinForms.Guna2Button btn_voltar;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox gcb_cat;
        private System.Windows.Forms.Label label3;
    }
}