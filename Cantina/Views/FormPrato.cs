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
    public partial class FormPrato : Form
    {
        private BindingList<Prato> listaPratos = new BindingList<Prato>();
        public CantinaContext db;
        private PratoController pratoController;
        public FormPrato(CantinaContext db)
        {
            this.db = db;
            this.pratoController = new PratoController(this.db);
            InitializeComponent();
            ObterPratos();
        }

        private void ObterPratos()
        {
            listaPratos = pratoController.GetPratos();
            AtualizarListBoxPratos();
        }

        private void AtualizarListBoxPratos()
        {
            listBox_Pratos.Items.Clear();

            foreach (Prato pr in listaPratos)
            {
                listBox_Pratos.Items.Add(pr);
            }
        }

        private void button_registarPrato1_Click(object sender, EventArgs e)
        {
            try
            {
                Prato prato = this.pratoController.adicionarPrato(gtb_descricaoPrato.Text, gcb__tipoPrato.Text, checkBox1.Checked);

                listaPratos.Add(prato);
                AtualizarListBoxPratos();

                MessageBox.Show("Prato registado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_apagarPrato1_Click(object sender, EventArgs e)
        {
            try
            {
                Prato prato = (Prato)listBox_Pratos.SelectedItem;

                if (prato != null)
                {
                    pratoController.apagarPrato(prato.ID);
                    listaPratos.Remove(prato);
                    AtualizarListBoxPratos();
                }
                else
                {
                    MessageBox.Show("Selecione um prato");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_editarPrato1_Click(object sender, EventArgs e)
        {
            try
            {
                Prato prato = (Prato)listBox_Pratos.SelectedItem;

                if (prato != null)
                {
                    prato.Descricao = gtb_descricaoPrato.Text;
                    prato.Tipo = gcb__tipoPrato.Text;
                    prato.Ativo = checkBox1.Checked;
                    pratoController.atualizarPrato(prato.ID, prato.Descricao, prato.Tipo, prato.Ativo);
                    AtualizarListBoxPratos();
                }
                else
                {
                    MessageBox.Show("Selecione um prato");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox_Pratos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se algum prato está selecionado
            if (listBox_Pratos.SelectedItem != null)
            {
                // Obtém o prato selecionado no ListBox
                Prato pratoSelecionado = (Prato)listBox_Pratos.SelectedItem;


                gtb_descricaoPrato.Text = pratoSelecionado.Descricao;
                gcb__tipoPrato.Text = pratoSelecionado.Tipo;
                checkBox1.Checked = pratoSelecionado.Ativo;
            }
            else
            {
                // Limpa os controles se nenhum item estiver selecionado
                LimparControles();
            }
        }

        private void LimparControles()
        {
            gtb_descricaoPrato.Text = string.Empty;
            gcb__tipoPrato.SelectedIndex = -1;
            checkBox1.Checked = false;
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