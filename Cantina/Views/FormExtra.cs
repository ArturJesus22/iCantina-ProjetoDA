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
    public partial class FormExtra : Form
    {
        private BindingList<Extra> listaExtras = new BindingList<Extra>();
        public CantinaContext db;
        private ExtraController extraController;
        public FormExtra(CantinaContext db)
        {
            this.db = db;
            this.extraController = new ExtraController(this.db);
            InitializeComponent();
            ObterExtras();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Este extra está ativo");
            }
            else
            {
                MessageBox.Show("Este extra não está ativo");
            }
        }


        private void ObterExtras()
        {
            listaExtras = extraController.GetExtras();
            AtualizarListBoxExtras();
        }

        private void AtualizarListBoxExtras()
        {
            listBox_Extras.Items.Clear();

            foreach (Extra ex in listaExtras)
            {
                listBox_Extras.Items.Add(ex);
            }
        }

        private void button_criarExtra_Click(object sender, EventArgs e)
        {
            try
            {
                Extra extra = this.extraController.adicionarExtra(textBox_descricaoExtra.Text, decimal.Parse(textBox_precoExtra.Text), checkBox1.Checked);

                listaExtras.Add(extra);
                AtualizarListBoxExtras();

                MessageBox.Show("Extra registado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_atualizarExtra_Click(object sender, EventArgs e)
        {
            try
            {
                Extra extra = (Extra)listBox_Extras.SelectedItem;

                if (extra != null)
                {
                    extra.Descricao = textBox_descricaoExtra.Text;
                    extra.Preco = decimal.Parse(textBox_precoExtra.Text);
                    extra.Ativo = checkBox1.Checked;
                    extraController.atualizarExtra(extra.ID, extra.Descricao, extra.Preco, extra.Ativo);
                    AtualizarListBoxExtras();
                }
                else
                {
                    MessageBox.Show("Selecione um extra");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_deleteExtra_Click(object sender, EventArgs e)
        {

            try
            {
                Extra extra = (Extra)listBox_Extras.SelectedItem;

                if (extra != null)
                {
                    extraController.apagarExtra(extra.ID);
                    listaExtras.Remove(extra);
                    AtualizarListBoxExtras();
                }
                else
                {
                    MessageBox.Show("Selecione um extra");
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

        private void listBox_Extras_SelectedIndexChanged(object sender, EventArgs e)
        {
            Extra extra = (Extra)listBox_Extras.SelectedItem;

            if (extra != null)
            {
                textBox_descricaoExtra.Text = extra.Descricao;
                textBox_precoExtra.Text = extra.Preco.ToString();
                checkBox1.Checked = extra.Ativo;
            }

        }
    }
}