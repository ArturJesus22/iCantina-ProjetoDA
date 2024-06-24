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
    public partial class FormMulta : Form
    {
        private BindingList<Multa> listaMulta = new BindingList<Multa>();
        public CantinaContext db;
        private MultaController multaController;

        public FormMulta(CantinaContext db)
        {
            this.db = db;
            this.multaController = new MultaController(this.db);
            InitializeComponent();
            ObterMultas();
        }



        private void AtualizarListBoxMultas()
        {
            listBox_Multas.Items.Clear();
            foreach (Multa mu in listaMulta)
            {
                listBox_Multas.Items.Add(mu);
            }
        }

        private void ObterMultas()
        {
            try
            {
                listaMulta = new BindingList<Multa>(multaController.GetMultas().ToList());
                AtualizarListBoxMultas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter as multas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_criarMulta_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valor = decimal.Parse(gtb_valorMulta.Text);
                int numHoras = int.Parse(gtb_horasMulta.Text);

                Multa multa = this.multaController.adicionarMulta(valor, numHoras);

                listaMulta.Add(multa);
                AtualizarListBoxMultas();

                MessageBox.Show("Multa registrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_atualizarMulta_Click(object sender, EventArgs e)
        {
            try
            {
                Multa multa = (Multa)listBox_Multas.SelectedItem;

                if (multa != null)
                {
                    multa.Valor = decimal.Parse(gtb_valorMulta.Text);
                    multa.NumHoras = int.Parse(gtb_horasMulta.Text);
                    multaController.atualizarMulta(multa.ID, multa.Valor, multa.NumHoras);

                    AtualizarListBoxMultas();
                }
                else
                {
                    MessageBox.Show("Selecione uma multa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_deleteMulta_Click(object sender, EventArgs e)
        {
            try
            {
                Multa multa = (Multa)listBox_Multas.SelectedItem;

                if (multa != null)
                {
                    multaController.apagarMulta(multa.ID);
                    listaMulta.Remove(multa);

                    AtualizarListBoxMultas();
                }
                else
                {
                    MessageBox.Show("Selecione uma multa");
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

        private void listBox_Multas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se um item foi selecionado
            if (listBox_Multas.SelectedItem != null)
            {
                // Converte o item selecionado para o tipo Multa
                Multa multaSelecionada = (Multa)listBox_Multas.SelectedItem;

                // Atualiza os campos de texto com os detalhes da multa selecionada
                gtb_valorMulta.Text = multaSelecionada.Valor.ToString();
                gtb_horasMulta.Text = multaSelecionada.NumHoras.ToString();
            }
        }

    }
}
