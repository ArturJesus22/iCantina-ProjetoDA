namespace iCantina.Views
{
    partial class FormMenu
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
            this.listBox_pratos = new System.Windows.Forms.ListBox();
            this.listBox_extras = new System.Windows.Forms.ListBox();
            this.hora = new System.Windows.Forms.Label();
            this.lista_pratos = new System.Windows.Forms.Label();
            this.lista_extras = new System.Windows.Forms.Label();
            this.label_preco_estudante = new System.Windows.Forms.Label();
            this.label_preco_prof = new System.Windows.Forms.Label();
            this.listBox_menu = new System.Windows.Forms.ListBox();
            this.label_menu = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.textBox_precoest = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_precoprof = new Guna.UI2.WinForms.Guna2TextBox();
            this.data = new System.Windows.Forms.Label();
            this.button_criar_menu = new Guna.UI2.WinForms.Guna2Button();
            this.button_apagar_menu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_voltar = new Guna.UI2.WinForms.Guna2Button();
            this.button_atualizar_menu = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // listBox_pratos
            // 
            this.listBox_pratos.FormattingEnabled = true;
            this.listBox_pratos.Location = new System.Drawing.Point(35, 169);
            this.listBox_pratos.Name = "listBox_pratos";
            this.listBox_pratos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_pratos.Size = new System.Drawing.Size(170, 303);
            this.listBox_pratos.TabIndex = 0;
            // 
            // listBox_extras
            // 
            this.listBox_extras.FormattingEnabled = true;
            this.listBox_extras.Location = new System.Drawing.Point(229, 169);
            this.listBox_extras.Name = "listBox_extras";
            this.listBox_extras.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_extras.Size = new System.Drawing.Size(170, 303);
            this.listBox_extras.TabIndex = 1;
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.Location = new System.Drawing.Point(14, 66);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(50, 22);
            this.hora.TabIndex = 5;
            this.hora.Text = "Hora";
            // 
            // lista_pratos
            // 
            this.lista_pratos.AutoSize = true;
            this.lista_pratos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_pratos.Location = new System.Drawing.Point(31, 144);
            this.lista_pratos.Name = "lista_pratos";
            this.lista_pratos.Size = new System.Drawing.Size(65, 22);
            this.lista_pratos.TabIndex = 6;
            this.lista_pratos.Text = "Pratos";
            // 
            // lista_extras
            // 
            this.lista_extras.AutoSize = true;
            this.lista_extras.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_extras.Location = new System.Drawing.Point(225, 144);
            this.lista_extras.Name = "lista_extras";
            this.lista_extras.Size = new System.Drawing.Size(63, 22);
            this.lista_extras.TabIndex = 7;
            this.lista_extras.Text = "Extras";
            // 
            // label_preco_estudante
            // 
            this.label_preco_estudante.AutoSize = true;
            this.label_preco_estudante.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_preco_estudante.Location = new System.Drawing.Point(463, 19);
            this.label_preco_estudante.Name = "label_preco_estudante";
            this.label_preco_estudante.Size = new System.Drawing.Size(151, 22);
            this.label_preco_estudante.TabIndex = 10;
            this.label_preco_estudante.Text = "Preço Estudante";
            // 
            // label_preco_prof
            // 
            this.label_preco_prof.AutoSize = true;
            this.label_preco_prof.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_preco_prof.Location = new System.Drawing.Point(464, 66);
            this.label_preco_prof.Name = "label_preco_prof";
            this.label_preco_prof.Size = new System.Drawing.Size(150, 22);
            this.label_preco_prof.TabIndex = 11;
            this.label_preco_prof.Text = "Preço Professor";
            // 
            // listBox_menu
            // 
            this.listBox_menu.FormattingEnabled = true;
            this.listBox_menu.Location = new System.Drawing.Point(468, 169);
            this.listBox_menu.Name = "listBox_menu";
            this.listBox_menu.Size = new System.Drawing.Size(559, 303);
            this.listBox_menu.TabIndex = 14;
            this.listBox_menu.SelectedIndexChanged += new System.EventHandler(this.listBox_menu_SelectedIndexChanged);
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.Location = new System.Drawing.Point(464, 144);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(66, 22);
            this.label_menu.TabIndex = 15;
            this.label_menu.Text = "Menus";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = true;
            this.dateTimePicker2.FillColor = System.Drawing.Color.White;
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(70, 66);
            this.dateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(170, 25);
            this.dateTimePicker2.TabIndex = 20;
            this.dateTimePicker2.Value = new System.DateTime(2024, 6, 19, 15, 13, 52, 427);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BackColor = System.Drawing.Color.White;
            this.dateTimePicker1.Checked = true;
            this.dateTimePicker1.FillColor = System.Drawing.Color.White;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 19);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 25);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2024, 6, 19, 15, 14, 19, 783);
            // 
            // textBox_precoest
            // 
            this.textBox_precoest.Animated = true;
            this.textBox_precoest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_precoest.DefaultText = "";
            this.textBox_precoest.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_precoest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_precoest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_precoest.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_precoest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_precoest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_precoest.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_precoest.Location = new System.Drawing.Point(620, 21);
            this.textBox_precoest.Name = "textBox_precoest";
            this.textBox_precoest.PasswordChar = '\0';
            this.textBox_precoest.PlaceholderText = "";
            this.textBox_precoest.SelectedText = "";
            this.textBox_precoest.Size = new System.Drawing.Size(56, 23);
            this.textBox_precoest.TabIndex = 22;
            // 
            // textBox_precoprof
            // 
            this.textBox_precoprof.Animated = true;
            this.textBox_precoprof.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_precoprof.DefaultText = "";
            this.textBox_precoprof.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_precoprof.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_precoprof.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_precoprof.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_precoprof.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_precoprof.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_precoprof.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_precoprof.Location = new System.Drawing.Point(620, 68);
            this.textBox_precoprof.Name = "textBox_precoprof";
            this.textBox_precoprof.PasswordChar = '\0';
            this.textBox_precoprof.PlaceholderText = "";
            this.textBox_precoprof.SelectedText = "";
            this.textBox_precoprof.Size = new System.Drawing.Size(56, 23);
            this.textBox_precoprof.TabIndex = 23;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Location = new System.Drawing.Point(15, 19);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(49, 22);
            this.data.TabIndex = 4;
            this.data.Text = "Data";
            // 
            // button_criar_menu
            // 
            this.button_criar_menu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_criar_menu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_criar_menu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_criar_menu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_criar_menu.FillColor = System.Drawing.Color.Green;
            this.button_criar_menu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_criar_menu.ForeColor = System.Drawing.Color.White;
            this.button_criar_menu.Location = new System.Drawing.Point(303, 516);
            this.button_criar_menu.Name = "button_criar_menu";
            this.button_criar_menu.PressedColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_criar_menu.Size = new System.Drawing.Size(130, 40);
            this.button_criar_menu.TabIndex = 24;
            this.button_criar_menu.Text = "Criar";
            this.button_criar_menu.Click += new System.EventHandler(this.button_criar_menu_Click_1);
            // 
            // button_apagar_menu
            // 
            this.button_apagar_menu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_apagar_menu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_apagar_menu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_apagar_menu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_apagar_menu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_apagar_menu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_apagar_menu.ForeColor = System.Drawing.Color.White;
            this.button_apagar_menu.Location = new System.Drawing.Point(636, 516);
            this.button_apagar_menu.Name = "button_apagar_menu";
            this.button_apagar_menu.Size = new System.Drawing.Size(130, 40);
            this.button_apagar_menu.TabIndex = 25;
            this.button_apagar_menu.Text = "Apagar";
            this.button_apagar_menu.Click += new System.EventHandler(this.button_apagar_menu_Click_1);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BorderRadius = 15;
            this.btn_voltar.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btn_voltar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_voltar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_voltar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_voltar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_voltar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(921, 10);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(144, 45);
            this.btn_voltar.TabIndex = 37;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // button_atualizar_menu
            // 
            this.button_atualizar_menu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_atualizar_menu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_atualizar_menu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_atualizar_menu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_atualizar_menu.FillColor = System.Drawing.Color.Orange;
            this.button_atualizar_menu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_atualizar_menu.ForeColor = System.Drawing.Color.White;
            this.button_atualizar_menu.Location = new System.Drawing.Point(472, 516);
            this.button_atualizar_menu.Name = "button_atualizar_menu";
            this.button_atualizar_menu.PressedColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_atualizar_menu.Size = new System.Drawing.Size(130, 40);
            this.button_atualizar_menu.TabIndex = 38;
            this.button_atualizar_menu.Text = "Atualizar";
            this.button_atualizar_menu.Click += new System.EventHandler(this.button_atualizar_menu_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1077, 586);
            this.ControlBox = false;
            this.Controls.Add(this.button_atualizar_menu);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.button_apagar_menu);
            this.Controls.Add(this.button_criar_menu);
            this.Controls.Add(this.textBox_precoprof);
            this.Controls.Add(this.textBox_precoest);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label_menu);
            this.Controls.Add(this.listBox_menu);
            this.Controls.Add(this.label_preco_prof);
            this.Controls.Add(this.label_preco_estudante);
            this.Controls.Add(this.lista_extras);
            this.Controls.Add(this.lista_pratos);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.data);
            this.Controls.Add(this.listBox_extras);
            this.Controls.Add(this.listBox_pratos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario_Menu";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_pratos;
        private System.Windows.Forms.ListBox listBox_extras;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label lista_pratos;
        private System.Windows.Forms.Label lista_extras;
        private System.Windows.Forms.Label label_preco_estudante;
        private System.Windows.Forms.Label label_preco_prof;
        private System.Windows.Forms.ListBox listBox_menu;
        private System.Windows.Forms.Label label_menu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker1;
        private Guna.UI2.WinForms.Guna2TextBox textBox_precoest;
        private Guna.UI2.WinForms.Guna2TextBox textBox_precoprof;
        private System.Windows.Forms.Label data;
        private Guna.UI2.WinForms.Guna2Button button_criar_menu;
        private Guna.UI2.WinForms.Guna2Button button_apagar_menu;
        private Guna.UI2.WinForms.Guna2Button btn_voltar;
        private Guna.UI2.WinForms.Guna2Button button_atualizar_menu;
    }
}