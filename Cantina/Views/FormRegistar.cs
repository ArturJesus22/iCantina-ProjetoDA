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
    public partial class FormRegistar : Form
    {
        private CantinaContext db;

        public static string username_global;

        public static int nif;

        private AuthController _authController;

        private FuncionarioController _funcionarioController;

        public FormRegistar(CantinaContext db)
        {
            InitializeComponent();
            _authController = new AuthController();
            this.db = db;
            this._funcionarioController = new FuncionarioController(this.db);
            db = Program.DbContext;
        }

        private void btn_registar_Click(object sender, EventArgs e)
        {
            username_global = txt_username.Text;
            nif = int.Parse(txt_nif.Text);

            if (string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_nome.Text) || string.IsNullOrEmpty(txt_nif.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (_authController.IsUsernameValid(username_global))
                    {
                        if (_authController.IsNifValid(nif))
                        {

                            Funcionario funcionario = this._funcionarioController.adicionarFuncionario(txt_nome.Text, int.Parse(txt_nif.Text), txt_username.Text);
                            MessageBox.Show("Conta Criada com Sucesso!");
                            var FormLogin = new FormLogin(db);
                            FormLogin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("NIF já está a ser usado.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nome de utilizador já está a ser usado.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
    }
}
