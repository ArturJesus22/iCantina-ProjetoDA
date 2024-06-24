using iCantina.Controllers;
using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Views
{
    public partial class FormLogin : Form
    {
        private CantinaContext db;
        public static string username_global;
        private AuthController _authController;
        private FuncionarioController _funcionarioController;

        public FormLogin(CantinaContext db)
        {
            InitializeComponent();
            this.db = db;
            this._funcionarioController = new FuncionarioController(this.db);
            _authController = new AuthController();
        }

        private void btn_registar_Click(object sender, EventArgs e)
        {
            var formRegistar = new FormRegistar(db);
            formRegistar.Show();
            this.Hide();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
             username_global = txt_username.Text;

            if (string.IsNullOrEmpty(txt_username.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    _authController.loginUser(username_global);
                    MessageBox.Show("Login com sucesso.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var mainForm = new FormPrincipal(db);
                    mainForm.Show();
                    this.Hide();

                    // Proceda para a próxima janela ou funcionalidade da aplicação
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensagem = "Para aceder ao sistema, basta inserir utilizador e password. Se não tiver uma conta, clique em 'Registar' para se registar.\n\nPara obter ajuda adicional, entre em contato connosco em:\nE-mail: iCantina-Suporte@icantina.com";
            MessageBox.Show(mensagem, "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
