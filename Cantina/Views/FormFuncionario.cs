using iCantina.Controllers;
using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace iCantina.Views
{
    public partial class FormFuncionario : Form
    {
        private BindingList<Funcionario> listaFuncionario = new BindingList<Funcionario>();
        public CantinaContext db;
        private FuncionarioController funcController;
        public FormFuncionario(CantinaContext db)
        {
            this.db = db;
            this.funcController = new FuncionarioController(this.db);
            InitializeComponent();
            ObterFuncionarios();
        }



        private void listBoxFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se algum item está selecionado
            if (listBoxFuncionarios.SelectedItem != null)
            {
                // Obtém o funcionário selecionado no ListBox
                Funcionario funcionarioSelecionado = (Funcionario)listBoxFuncionarios.SelectedItem;

                // Atualiza os TextBoxes com os dados do funcionário selecionado
                gtb_Nome.Text = funcionarioSelecionado.Name;
                gtb_NIF.Text = funcionarioSelecionado.NIF.ToString();
                gtb_username.Text = funcionarioSelecionado.Username;
            }
            else
            {
                // Limpa os TextBoxes se nenhum item estiver selecionado
                LimparTextBoxes();
            }
        }

        private void LimparTextBoxes()
        {
            gtb_Nome.Text = string.Empty;
            gtb_NIF.Text = string.Empty;
            gtb_username.Text = string.Empty;
        }


        private void ObterFuncionarios()
        {
            listaFuncionario = funcController.GetFuncionarios();
            AtualizarListBoxFuncionarios();
        }

        private void AtualizarListBoxFuncionarios()
        {
            listBoxFuncionarios.Items.Clear();

            foreach (Funcionario f in listaFuncionario)
            {
                listBoxFuncionarios.Items.Add(f);
            }
        }

        private void button_criarFunc_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = this.funcController.adicionarFuncionario(gtb_Nome.Text, int.Parse(gtb_NIF.Text), gtb_username.Text);

                listaFuncionario.Add(funcionario);
                AtualizarListBoxFuncionarios();

                MessageBox.Show("Funcionário registrado com sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button_atualizarFunc_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;

                if (funcionario != null)
                {
                    funcionario.Name = gtb_Nome.Text;
                    funcionario.NIF = int.Parse(gtb_NIF.Text);
                    funcionario.Username = gtb_username.Text;
                    funcController.atualizarFuncionario(funcionario.Id, funcionario.Name, funcionario.NIF, funcionario.Username);
                    AtualizarListBoxFuncionarios();
                }
                else
                {
                    MessageBox.Show("Selecione um funcionario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_deleteFunc_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;

                if (funcionario != null)
                {
                    funcController.apagarFuncionario(funcionario.Id);
                    listaFuncionario.Remove(funcionario);
                    AtualizarListBoxFuncionarios();
                }
                else
                {
                    MessageBox.Show("Selecione um funcionário");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            // Fecha o formulário atual (FormProfessores)
            this.Close();

            // Exibe novamente o formulário principal (Formulario_Principal)
            FormPrincipal formularioPrincipal = new FormPrincipal(db); // Certifique-se de passar o contexto do banco de dados aqui, se necessário
            formularioPrincipal.Show();
        }
    }
}
