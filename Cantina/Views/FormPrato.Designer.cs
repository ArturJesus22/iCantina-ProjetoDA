namespace iCantina.Views
{
    partial class FormPrato
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
            this.gtb_descricaoPrato = new Guna.UI2.WinForms.Guna2TextBox();
            this.gcb__tipoPrato = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button_editarPrato1 = new Guna.UI2.WinForms.Guna2Button();
            this.button_apagarPrato1 = new Guna.UI2.WinForms.Guna2Button();
            this.button_registarPrato1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Pratos = new System.Windows.Forms.ListBox();
            this.label_TipoPrato = new System.Windows.Forms.Label();
            this.label_descricaoPrato = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btn_voltar.TabIndex = 26;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // gtb_descricaoPrato
            // 
            this.gtb_descricaoPrato.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_descricaoPrato.DefaultText = "";
            this.gtb_descricaoPrato.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtb_descricaoPrato.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtb_descricaoPrato.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_descricaoPrato.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_descricaoPrato.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_descricaoPrato.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtb_descricaoPrato.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_descricaoPrato.Location = new System.Drawing.Point(237, 150);
            this.gtb_descricaoPrato.Name = "gtb_descricaoPrato";
            this.gtb_descricaoPrato.PasswordChar = '\0';
            this.gtb_descricaoPrato.PlaceholderText = "";
            this.gtb_descricaoPrato.SelectedText = "";
            this.gtb_descricaoPrato.Size = new System.Drawing.Size(200, 36);
            this.gtb_descricaoPrato.TabIndex = 25;
            // 
            // gcb__tipoPrato
            // 
            this.gcb__tipoPrato.BackColor = System.Drawing.Color.Transparent;
            this.gcb__tipoPrato.BorderRadius = 10;
            this.gcb__tipoPrato.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcb__tipoPrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcb__tipoPrato.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcb__tipoPrato.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcb__tipoPrato.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gcb__tipoPrato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gcb__tipoPrato.ItemHeight = 30;
            this.gcb__tipoPrato.Items.AddRange(new object[] {
            "Carne",
            "Peixe",
            "Vegetariano"});
            this.gcb__tipoPrato.Location = new System.Drawing.Point(237, 216);
            this.gcb__tipoPrato.Name = "gcb__tipoPrato";
            this.gcb__tipoPrato.Size = new System.Drawing.Size(200, 36);
            this.gcb__tipoPrato.TabIndex = 24;
            // 
            // button_editarPrato1
            // 
            this.button_editarPrato1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_editarPrato1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_editarPrato1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_editarPrato1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_editarPrato1.FillColor = System.Drawing.Color.Orange;
            this.button_editarPrato1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editarPrato1.ForeColor = System.Drawing.Color.White;
            this.button_editarPrato1.Location = new System.Drawing.Point(472, 516);
            this.button_editarPrato1.Name = "button_editarPrato1";
            this.button_editarPrato1.Size = new System.Drawing.Size(130, 40);
            this.button_editarPrato1.TabIndex = 23;
            this.button_editarPrato1.Text = "Atualizar";
            this.button_editarPrato1.Click += new System.EventHandler(this.button_editarPrato1_Click);
            // 
            // button_apagarPrato1
            // 
            this.button_apagarPrato1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_apagarPrato1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_apagarPrato1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_apagarPrato1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_apagarPrato1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_apagarPrato1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_apagarPrato1.ForeColor = System.Drawing.Color.White;
            this.button_apagarPrato1.Location = new System.Drawing.Point(636, 516);
            this.button_apagarPrato1.Name = "button_apagarPrato1";
            this.button_apagarPrato1.Size = new System.Drawing.Size(130, 40);
            this.button_apagarPrato1.TabIndex = 22;
            this.button_apagarPrato1.Text = "Apagar";
            this.button_apagarPrato1.Click += new System.EventHandler(this.button_apagarPrato1_Click);
            // 
            // button_registarPrato1
            // 
            this.button_registarPrato1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_registarPrato1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_registarPrato1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_registarPrato1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_registarPrato1.FillColor = System.Drawing.Color.Green;
            this.button_registarPrato1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_registarPrato1.ForeColor = System.Drawing.Color.White;
            this.button_registarPrato1.Location = new System.Drawing.Point(303, 516);
            this.button_registarPrato1.Name = "button_registarPrato1";
            this.button_registarPrato1.Size = new System.Drawing.Size(130, 40);
            this.button_registarPrato1.TabIndex = 21;
            this.button_registarPrato1.Text = "Criar";
            this.button_registarPrato1.Click += new System.EventHandler(this.button_registarPrato1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.Location = new System.Drawing.Point(155, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Estado:";
            // 
            // listBox_Pratos
            // 
            this.listBox_Pratos.FormattingEnabled = true;
            this.listBox_Pratos.Location = new System.Drawing.Point(722, 117);
            this.listBox_Pratos.Name = "listBox_Pratos";
            this.listBox_Pratos.Size = new System.Drawing.Size(250, 329);
            this.listBox_Pratos.TabIndex = 19;
            this.listBox_Pratos.SelectedIndexChanged += new System.EventHandler(this.listBox_Pratos_SelectedIndexChanged);
            // 
            // label_TipoPrato
            // 
            this.label_TipoPrato.AutoSize = true;
            this.label_TipoPrato.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TipoPrato.Location = new System.Drawing.Point(178, 223);
            this.label_TipoPrato.Name = "label_TipoPrato";
            this.label_TipoPrato.Size = new System.Drawing.Size(52, 22);
            this.label_TipoPrato.TabIndex = 18;
            this.label_TipoPrato.Text = "Tipo:";
            // 
            // label_descricaoPrato
            // 
            this.label_descricaoPrato.AutoSize = true;
            this.label_descricaoPrato.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label_descricaoPrato.Location = new System.Drawing.Point(128, 158);
            this.label_descricaoPrato.Name = "label_descricaoPrato";
            this.label_descricaoPrato.Size = new System.Drawing.Size(101, 22);
            this.label_descricaoPrato.TabIndex = 17;
            this.label_descricaoPrato.Text = "Descricao:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.checkBox1.Location = new System.Drawing.Point(238, 283);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 26);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Ativar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label2.Location = new System.Drawing.Point(718, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Pratos";
            // 
            // FormPrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1077, 586);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.gtb_descricaoPrato);
            this.Controls.Add(this.gcb__tipoPrato);
            this.Controls.Add(this.button_editarPrato1);
            this.Controls.Add(this.button_apagarPrato1);
            this.Controls.Add(this.button_registarPrato1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Pratos);
            this.Controls.Add(this.label_TipoPrato);
            this.Controls.Add(this.label_descricaoPrato);
            this.Controls.Add(this.checkBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario_Prato";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_voltar;
        private Guna.UI2.WinForms.Guna2TextBox gtb_descricaoPrato;
        private Guna.UI2.WinForms.Guna2ComboBox gcb__tipoPrato;
        private Guna.UI2.WinForms.Guna2Button button_editarPrato1;
        private Guna.UI2.WinForms.Guna2Button button_apagarPrato1;
        private Guna.UI2.WinForms.Guna2Button button_registarPrato1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Pratos;
        private System.Windows.Forms.Label label_TipoPrato;
        private System.Windows.Forms.Label label_descricaoPrato;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
    }
}