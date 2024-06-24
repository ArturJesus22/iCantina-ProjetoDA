namespace iCantina.Views
{
    partial class FormExtra
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
            this.textBox_precoExtra = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_descricaoExtra = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_atualizarExtra = new Guna.UI2.WinForms.Guna2Button();
            this.button_deleteExtra = new Guna.UI2.WinForms.Guna2Button();
            this.button_criarExtra = new Guna.UI2.WinForms.Guna2Button();
            this.listBox_Extras = new System.Windows.Forms.ListBox();
            this.label_precoExtra = new System.Windows.Forms.Label();
            this.label_descricaoExtra = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btn_voltar.TabIndex = 31;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // textBox_precoExtra
            // 
            this.textBox_precoExtra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_precoExtra.DefaultText = "";
            this.textBox_precoExtra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_precoExtra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_precoExtra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_precoExtra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_precoExtra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_precoExtra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_precoExtra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_precoExtra.Location = new System.Drawing.Point(137, 240);
            this.textBox_precoExtra.Name = "textBox_precoExtra";
            this.textBox_precoExtra.PasswordChar = '\0';
            this.textBox_precoExtra.PlaceholderText = "";
            this.textBox_precoExtra.SelectedText = "";
            this.textBox_precoExtra.Size = new System.Drawing.Size(200, 36);
            this.textBox_precoExtra.TabIndex = 30;
            // 
            // textBox_descricaoExtra
            // 
            this.textBox_descricaoExtra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_descricaoExtra.DefaultText = "";
            this.textBox_descricaoExtra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_descricaoExtra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_descricaoExtra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_descricaoExtra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_descricaoExtra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_descricaoExtra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_descricaoExtra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_descricaoExtra.Location = new System.Drawing.Point(137, 174);
            this.textBox_descricaoExtra.Name = "textBox_descricaoExtra";
            this.textBox_descricaoExtra.PasswordChar = '\0';
            this.textBox_descricaoExtra.PlaceholderText = "";
            this.textBox_descricaoExtra.SelectedText = "";
            this.textBox_descricaoExtra.Size = new System.Drawing.Size(273, 36);
            this.textBox_descricaoExtra.TabIndex = 29;
            // 
            // button_atualizarExtra
            // 
            this.button_atualizarExtra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_atualizarExtra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_atualizarExtra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_atualizarExtra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_atualizarExtra.FillColor = System.Drawing.Color.Orange;
            this.button_atualizarExtra.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_atualizarExtra.ForeColor = System.Drawing.Color.White;
            this.button_atualizarExtra.Location = new System.Drawing.Point(472, 516);
            this.button_atualizarExtra.Name = "button_atualizarExtra";
            this.button_atualizarExtra.Size = new System.Drawing.Size(130, 40);
            this.button_atualizarExtra.TabIndex = 28;
            this.button_atualizarExtra.Text = "Atualizar";
            this.button_atualizarExtra.Click += new System.EventHandler(this.button_atualizarExtra_Click);
            // 
            // button_deleteExtra
            // 
            this.button_deleteExtra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_deleteExtra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_deleteExtra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_deleteExtra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_deleteExtra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_deleteExtra.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteExtra.ForeColor = System.Drawing.Color.White;
            this.button_deleteExtra.Location = new System.Drawing.Point(636, 516);
            this.button_deleteExtra.Name = "button_deleteExtra";
            this.button_deleteExtra.Size = new System.Drawing.Size(130, 40);
            this.button_deleteExtra.TabIndex = 27;
            this.button_deleteExtra.Text = "Apagar";
            this.button_deleteExtra.Click += new System.EventHandler(this.button_deleteExtra_Click);
            // 
            // button_criarExtra
            // 
            this.button_criarExtra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_criarExtra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_criarExtra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_criarExtra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_criarExtra.FillColor = System.Drawing.Color.Green;
            this.button_criarExtra.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_criarExtra.ForeColor = System.Drawing.Color.White;
            this.button_criarExtra.Location = new System.Drawing.Point(303, 516);
            this.button_criarExtra.Name = "button_criarExtra";
            this.button_criarExtra.Size = new System.Drawing.Size(130, 40);
            this.button_criarExtra.TabIndex = 26;
            this.button_criarExtra.Text = "Criar";
            this.button_criarExtra.Click += new System.EventHandler(this.button_criarExtra_Click);
            // 
            // listBox_Extras
            // 
            this.listBox_Extras.FormattingEnabled = true;
            this.listBox_Extras.Location = new System.Drawing.Point(571, 72);
            this.listBox_Extras.Name = "listBox_Extras";
            this.listBox_Extras.Size = new System.Drawing.Size(249, 277);
            this.listBox_Extras.TabIndex = 25;
            this.listBox_Extras.SelectedIndexChanged += new System.EventHandler(this.listBox_Extras_SelectedIndexChanged);
            // 
            // label_precoExtra
            // 
            this.label_precoExtra.AutoSize = true;
            this.label_precoExtra.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label_precoExtra.Location = new System.Drawing.Point(61, 246);
            this.label_precoExtra.Name = "label_precoExtra";
            this.label_precoExtra.Size = new System.Drawing.Size(66, 22);
            this.label_precoExtra.TabIndex = 24;
            this.label_precoExtra.Text = "Preco:";
            // 
            // label_descricaoExtra
            // 
            this.label_descricaoExtra.AutoSize = true;
            this.label_descricaoExtra.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label_descricaoExtra.Location = new System.Drawing.Point(77, 180);
            this.label_descricaoExtra.Name = "label_descricaoExtra";
            this.label_descricaoExtra.Size = new System.Drawing.Size(50, 22);
            this.label_descricaoExtra.TabIndex = 23;
            this.label_descricaoExtra.Text = "Total";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.checkBox1.Location = new System.Drawing.Point(137, 307);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 26);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Ativar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.Location = new System.Drawing.Point(61, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Estado:";
            // 
            // FormExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1077, 586);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.textBox_precoExtra);
            this.Controls.Add(this.textBox_descricaoExtra);
            this.Controls.Add(this.button_atualizarExtra);
            this.Controls.Add(this.button_deleteExtra);
            this.Controls.Add(this.button_criarExtra);
            this.Controls.Add(this.listBox_Extras);
            this.Controls.Add(this.label_precoExtra);
            this.Controls.Add(this.label_descricaoExtra);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExtra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario_Extras";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_voltar;
        private Guna.UI2.WinForms.Guna2TextBox textBox_precoExtra;
        private Guna.UI2.WinForms.Guna2TextBox textBox_descricaoExtra;
        private Guna.UI2.WinForms.Guna2Button button_atualizarExtra;
        private Guna.UI2.WinForms.Guna2Button button_deleteExtra;
        private Guna.UI2.WinForms.Guna2Button button_criarExtra;
        private System.Windows.Forms.ListBox listBox_Extras;
        private System.Windows.Forms.Label label_precoExtra;
        private System.Windows.Forms.Label label_descricaoExtra;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
    }
}