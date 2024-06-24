namespace iCantina.Views
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_utilizador = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_registar = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvidoPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arturJesusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diogoFernandes2231657ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-196, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(956, 708);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(805, 42);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(243, 93);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 20;
            this.logo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(873, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 45);
            this.label2.TabIndex = 16;
            this.label2.Text = "Login";
            // 
            // lb_utilizador
            // 
            this.lb_utilizador.AutoSize = true;
            this.lb_utilizador.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_utilizador.Location = new System.Drawing.Point(23, 31);
            this.lb_utilizador.Name = "lb_utilizador";
            this.lb_utilizador.Size = new System.Drawing.Size(74, 19);
            this.lb_utilizador.TabIndex = 4;
            this.lb_utilizador.Text = "Utilizador";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 2);
            this.label5.TabIndex = 7;
            this.label5.Text = "Utilizador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_utilizador);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(822, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 96);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Funcionário";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_username.Location = new System.Drawing.Point(27, 53);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(109, 13);
            this.txt_username.TabIndex = 1;
            // 
            // btn_registar
            // 
            this.btn_registar.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_registar.Location = new System.Drawing.Point(876, 413);
            this.btn_registar.Name = "btn_registar";
            this.btn_registar.Size = new System.Drawing.Size(92, 32);
            this.btn_registar.TabIndex = 18;
            this.btn_registar.Text = "Registar";
            this.btn_registar.UseVisualStyleBackColor = true;
            this.btn_registar.Click += new System.EventHandler(this.btn_registar_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(861, 362);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(123, 38);
            this.btn_entrar.TabIndex = 17;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_sair.Location = new System.Drawing.Point(973, 542);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(92, 32);
            this.btn_sair.TabIndex = 26;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informaçõesToolStripMenuItem
            // 
            this.informaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desenvolvidoPorToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.informaçõesToolStripMenuItem.Name = "informaçõesToolStripMenuItem";
            this.informaçõesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.informaçõesToolStripMenuItem.Text = "Informações";
            // 
            // desenvolvidoPorToolStripMenuItem
            // 
            this.desenvolvidoPorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arturJesusToolStripMenuItem,
            this.diogoFernandes2231657ToolStripMenuItem});
            this.desenvolvidoPorToolStripMenuItem.Name = "desenvolvidoPorToolStripMenuItem";
            this.desenvolvidoPorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desenvolvidoPorToolStripMenuItem.Text = "Desenvolvido Por:";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // arturJesusToolStripMenuItem
            // 
            this.arturJesusToolStripMenuItem.Name = "arturJesusToolStripMenuItem";
            this.arturJesusToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.arturJesusToolStripMenuItem.Text = "Artur Jesus - 2220866";
            // 
            // diogoFernandes2231657ToolStripMenuItem
            // 
            this.diogoFernandes2231657ToolStripMenuItem.Name = "diogoFernandes2231657ToolStripMenuItem";
            this.diogoFernandes2231657ToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.diogoFernandes2231657ToolStripMenuItem.Text = "Diogo Fernandes - 2231657";
            // 
            // lb_info
            // 
            this.lb_info.Location = new System.Drawing.Point(802, 486);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(246, 40);
            this.lb_info.TabIndex = 28;
            this.lb_info.Text = "Em caso de duvida, clique no canto superior esquerdo \"Informações\"";
            this.lb_info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1077, 586);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_registar);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_utilizador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_registar;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenvolvidoPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arturJesusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diogoFernandes2231657ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.Label lb_info;
    }
}