namespace iCantina.Views
{
    partial class FormReserva
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
            this.listBox_estudantes = new System.Windows.Forms.ListBox();
            this.listBox_Professores = new System.Windows.Forms.ListBox();
            this.listBox_menus = new System.Windows.Forms.ListBox();
            this.menus = new System.Windows.Forms.Label();
            this.listBox_pratosdomenu = new System.Windows.Forms.ListBox();
            this.listBox_extrasdomenu = new System.Windows.Forms.ListBox();
            this.listBox_reserva = new System.Windows.Forms.ListBox();
            this.listBox_multas = new System.Windows.Forms.ListBox();
            this.label_multa = new System.Windows.Forms.Label();
            this.clientes = new System.Windows.Forms.Label();
            this.button_criarReserva = new Guna.UI2.WinForms.Guna2Button();
            this.button_apagar_reserva = new Guna.UI2.WinForms.Guna2Button();
            this.extras = new System.Windows.Forms.Label();
            this.pratos = new System.Windows.Forms.Label();
            this.btn_voltar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_fatura = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPrecoClienteSelecionado = new System.Windows.Forms.Label();
            this.Valor = new System.Windows.Forms.Label();
            this.button_efetuarReserva = new Guna.UI2.WinForms.Guna2Button();
            this.listBox_reservasUtilizadas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox_estudantes
            // 
            this.listBox_estudantes.FormattingEnabled = true;
            this.listBox_estudantes.Location = new System.Drawing.Point(244, 100);
            this.listBox_estudantes.Name = "listBox_estudantes";
            this.listBox_estudantes.Size = new System.Drawing.Size(170, 212);
            this.listBox_estudantes.TabIndex = 0;
            // 
            // listBox_Professores
            // 
            this.listBox_Professores.FormattingEnabled = true;
            this.listBox_Professores.Location = new System.Drawing.Point(69, 100);
            this.listBox_Professores.Name = "listBox_Professores";
            this.listBox_Professores.Size = new System.Drawing.Size(170, 212);
            this.listBox_Professores.TabIndex = 1;
            // 
            // listBox_menus
            // 
            this.listBox_menus.FormattingEnabled = true;
            this.listBox_menus.Location = new System.Drawing.Point(545, 66);
            this.listBox_menus.Name = "listBox_menus";
            this.listBox_menus.Size = new System.Drawing.Size(513, 82);
            this.listBox_menus.TabIndex = 3;
            this.listBox_menus.SelectedIndexChanged += new System.EventHandler(this.listBox_menus_SelectedIndexChanged);
            // 
            // menus
            // 
            this.menus.AutoSize = true;
            this.menus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menus.Location = new System.Drawing.Point(776, 32);
            this.menus.Name = "menus";
            this.menus.Size = new System.Drawing.Size(66, 22);
            this.menus.TabIndex = 4;
            this.menus.Text = "Menus";
            // 
            // listBox_pratosdomenu
            // 
            this.listBox_pratosdomenu.FormattingEnabled = true;
            this.listBox_pratosdomenu.Location = new System.Drawing.Point(69, 381);
            this.listBox_pratosdomenu.Name = "listBox_pratosdomenu";
            this.listBox_pratosdomenu.Size = new System.Drawing.Size(111, 121);
            this.listBox_pratosdomenu.TabIndex = 5;
            // 
            // listBox_extrasdomenu
            // 
            this.listBox_extrasdomenu.FormattingEnabled = true;
            this.listBox_extrasdomenu.Location = new System.Drawing.Point(186, 381);
            this.listBox_extrasdomenu.Name = "listBox_extrasdomenu";
            this.listBox_extrasdomenu.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_extrasdomenu.Size = new System.Drawing.Size(111, 121);
            this.listBox_extrasdomenu.TabIndex = 6;
            // 
            // listBox_reserva
            // 
            this.listBox_reserva.FormattingEnabled = true;
            this.listBox_reserva.Location = new System.Drawing.Point(545, 204);
            this.listBox_reserva.Name = "listBox_reserva";
            this.listBox_reserva.Size = new System.Drawing.Size(173, 264);
            this.listBox_reserva.TabIndex = 8;
            // 
            // listBox_multas
            // 
            this.listBox_multas.FormattingEnabled = true;
            this.listBox_multas.Location = new System.Drawing.Point(303, 381);
            this.listBox_multas.Name = "listBox_multas";
            this.listBox_multas.Size = new System.Drawing.Size(111, 121);
            this.listBox_multas.TabIndex = 11;
            // 
            // label_multa
            // 
            this.label_multa.AutoSize = true;
            this.label_multa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_multa.Location = new System.Drawing.Point(299, 356);
            this.label_multa.Name = "label_multa";
            this.label_multa.Size = new System.Drawing.Size(64, 22);
            this.label_multa.TabIndex = 12;
            this.label_multa.Text = "Multas";
            // 
            // clientes
            // 
            this.clientes.AutoSize = true;
            this.clientes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientes.Location = new System.Drawing.Point(200, 21);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(79, 22);
            this.clientes.TabIndex = 35;
            this.clientes.Text = "Clientes";
            // 
            // button_criarReserva
            // 
            this.button_criarReserva.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_criarReserva.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_criarReserva.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_criarReserva.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_criarReserva.FillColor = System.Drawing.Color.Green;
            this.button_criarReserva.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_criarReserva.ForeColor = System.Drawing.Color.White;
            this.button_criarReserva.Location = new System.Drawing.Point(493, 489);
            this.button_criarReserva.Name = "button_criarReserva";
            this.button_criarReserva.Size = new System.Drawing.Size(130, 40);
            this.button_criarReserva.TabIndex = 36;
            this.button_criarReserva.Text = "Criar";
            this.button_criarReserva.Click += new System.EventHandler(this.botton_criarReserva_Click_1);
            // 
            // button_apagar_reserva
            // 
            this.button_apagar_reserva.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_apagar_reserva.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_apagar_reserva.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_apagar_reserva.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_apagar_reserva.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_apagar_reserva.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_apagar_reserva.ForeColor = System.Drawing.Color.White;
            this.button_apagar_reserva.Location = new System.Drawing.Point(865, 489);
            this.button_apagar_reserva.Name = "button_apagar_reserva";
            this.button_apagar_reserva.Size = new System.Drawing.Size(130, 40);
            this.button_apagar_reserva.TabIndex = 37;
            this.button_apagar_reserva.Text = "Apagar";
            this.button_apagar_reserva.Click += new System.EventHandler(this.button_apagar_reserva_Click_1);
            // 
            // extras
            // 
            this.extras.AutoSize = true;
            this.extras.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extras.Location = new System.Drawing.Point(182, 356);
            this.extras.Name = "extras";
            this.extras.Size = new System.Drawing.Size(63, 22);
            this.extras.TabIndex = 38;
            this.extras.Text = "Extras";
            // 
            // pratos
            // 
            this.pratos.AutoSize = true;
            this.pratos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pratos.Location = new System.Drawing.Point(65, 356);
            this.pratos.Name = "pratos";
            this.pratos.Size = new System.Drawing.Size(65, 22);
            this.pratos.TabIndex = 39;
            this.pratos.Text = "Pratos";
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
            this.btn_voltar.TabIndex = 40;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_fatura
            // 
            this.btn_fatura.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_fatura.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_fatura.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_fatura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_fatura.FillColor = System.Drawing.Color.Teal;
            this.btn_fatura.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fatura.ForeColor = System.Drawing.Color.White;
            this.btn_fatura.Location = new System.Drawing.Point(149, 518);
            this.btn_fatura.Name = "btn_fatura";
            this.btn_fatura.Size = new System.Drawing.Size(180, 45);
            this.btn_fatura.TabIndex = 41;
            this.btn_fatura.Text = "Emitir Fatura";
            this.btn_fatura.Click += new System.EventHandler(this.btn_fatura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Professores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 43;
            this.label2.Text = "Estudantes";
            // 
            // labelPrecoClienteSelecionado
            // 
            this.labelPrecoClienteSelecionado.AutoSize = true;
            this.labelPrecoClienteSelecionado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecoClienteSelecionado.Location = new System.Drawing.Point(603, 160);
            this.labelPrecoClienteSelecionado.Name = "labelPrecoClienteSelecionado";
            this.labelPrecoClienteSelecionado.Size = new System.Drawing.Size(59, 22);
            this.labelPrecoClienteSelecionado.TabIndex = 9;
            this.labelPrecoClienteSelecionado.Text = "preco";
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor.Location = new System.Drawing.Point(541, 160);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(66, 22);
            this.Valor.TabIndex = 10;
            this.Valor.Text = "Preco:";
            // 
            // button_efetuarReserva
            // 
            this.button_efetuarReserva.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_efetuarReserva.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_efetuarReserva.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_efetuarReserva.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_efetuarReserva.FillColor = System.Drawing.Color.Orange;
            this.button_efetuarReserva.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_efetuarReserva.ForeColor = System.Drawing.Color.White;
            this.button_efetuarReserva.Location = new System.Drawing.Point(679, 489);
            this.button_efetuarReserva.Name = "button_efetuarReserva";
            this.button_efetuarReserva.Size = new System.Drawing.Size(130, 40);
            this.button_efetuarReserva.TabIndex = 44;
            this.button_efetuarReserva.Text = "Utilizar";
            this.button_efetuarReserva.Click += new System.EventHandler(this.button_efetuarReserva_Click);
            // 
            // listBox_reservasUtilizadas
            // 
            this.listBox_reservasUtilizadas.FormattingEnabled = true;
            this.listBox_reservasUtilizadas.Location = new System.Drawing.Point(771, 204);
            this.listBox_reservasUtilizadas.Name = "listBox_reservasUtilizadas";
            this.listBox_reservasUtilizadas.Size = new System.Drawing.Size(173, 264);
            this.listBox_reservasUtilizadas.TabIndex = 45;
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1077, 586);
            this.ControlBox = false;
            this.Controls.Add(this.listBox_reservasUtilizadas);
            this.Controls.Add(this.button_efetuarReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fatura);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.pratos);
            this.Controls.Add(this.extras);
            this.Controls.Add(this.button_apagar_reserva);
            this.Controls.Add(this.button_criarReserva);
            this.Controls.Add(this.clientes);
            this.Controls.Add(this.label_multa);
            this.Controls.Add(this.listBox_multas);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.labelPrecoClienteSelecionado);
            this.Controls.Add(this.listBox_reserva);
            this.Controls.Add(this.listBox_extrasdomenu);
            this.Controls.Add(this.listBox_pratosdomenu);
            this.Controls.Add(this.menus);
            this.Controls.Add(this.listBox_menus);
            this.Controls.Add(this.listBox_Professores);
            this.Controls.Add(this.listBox_estudantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario_Reserva";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_estudantes;
        private System.Windows.Forms.ListBox listBox_Professores;
        private System.Windows.Forms.ListBox listBox_menus;
        private System.Windows.Forms.Label menus;
        private System.Windows.Forms.ListBox listBox_pratosdomenu;
        private System.Windows.Forms.ListBox listBox_extrasdomenu;
        private System.Windows.Forms.ListBox listBox_reserva;
        private System.Windows.Forms.ListBox listBox_multas;
        private System.Windows.Forms.Label label_multa;
        private System.Windows.Forms.Label clientes;
        private Guna.UI2.WinForms.Guna2Button button_criarReserva;
        private Guna.UI2.WinForms.Guna2Button button_apagar_reserva;
        private System.Windows.Forms.Label extras;
        private System.Windows.Forms.Label pratos;
        private Guna.UI2.WinForms.Guna2Button btn_voltar;
        private Guna.UI2.WinForms.Guna2Button btn_fatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPrecoClienteSelecionado;
        private System.Windows.Forms.Label Valor;
        private Guna.UI2.WinForms.Guna2Button button_efetuarReserva;
        private System.Windows.Forms.ListBox listBox_reservasUtilizadas;
    }
}