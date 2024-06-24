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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace iCantina.Views
{
    public partial class FormCliente : Form
    {
        private BindingList<Cliente> listaClientes = new BindingList<Cliente>();
        private BindingList<Professor> listaProfessor = new BindingList<Professor>();
        private BindingList<Estudante> listaAlunos = new BindingList<Estudante>();

        public CantinaContext db;
        private EstudanteController alunoController;
        private ProfessorController professorController;

        public FormCliente(CantinaContext db)
        {
            this.db = db;
            this.alunoController = new EstudanteController(this.db);
            this.professorController = new ProfessorController(this.db);
            InitializeComponent();
            ObterClientes();
        }

        private void ObterProfessores()
        {
            listaProfessor = new BindingList<Professor>(professorController.GetProfessores());
        }

        private void ObterAlunos()
        {
            listaAlunos = new BindingList<Estudante>(alunoController.GetEstudantes());
        }

        private void AtualizarListBox()
        {
            listBox_cliente.Items.Clear();

            foreach (Cliente c in listaClientes)
            {
                listBox_cliente.Items.Add(c);
            }
        }

        private void ObterClientes()
        {
            ObterProfessores();
            ObterAlunos();

            listaClientes.Clear();
            foreach (var professor in listaProfessor)
            {
                listaClientes.Add(professor);
            }

            foreach (var estudante in listaAlunos)
            {
                listaClientes.Add(estudante);
            }

            AtualizarListBox();
        }

        private void button_addEstudante_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (gcb_cat.SelectedItem.ToString() == "Estudante")
                {
                    Estudante estudante = this.alunoController.AdicionarEstudante(
                        textBox_nomeEstudante.Text,
                        int.Parse(textBox_nifEstudante.Text),
                        decimal.Parse(textBox_saldoEstudante.Text),
                        int.Parse(textBox_nEstudante.Text)
                    );

                    listaAlunos.Add(estudante);
                    listaClientes.Add(estudante);
                }
                else if (gcb_cat.SelectedItem.ToString() == "Professor")
                {
                    Professor professor = this.professorController.adicionarProfessor(
                        textBox_nomeEstudante.Text,
                        int.Parse(textBox_nifEstudante.Text),
                        decimal.Parse(textBox_saldoEstudante.Text),
                        email.Text
                    );

                    listaProfessor.Add(professor);
                    listaClientes.Add(professor);
                }

                AtualizarListBox();
                LimparCampos();

                MessageBox.Show("Cliente registado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_apagarEstudante_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)listBox_cliente.SelectedItem;

                if (cliente != null)
                {
                    if (cliente is Estudante)
                    {
                        alunoController.apagarEstudante(cliente.Id);
                        listaAlunos.Remove((Estudante)cliente);
                    }
                    else if (cliente is Professor)
                    {
                        professorController.apagarProfessor(cliente.Id);
                        listaProfessor.Remove((Professor)cliente);
                    }

                    listaClientes.Remove(cliente);
                    AtualizarListBox();
                }
                else
                {
                    MessageBox.Show("Selecione um cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            textBox_nifEstudante.Text = "";
            textBox_nEstudante.Text = "";
            textBox_nomeEstudante.Text = "";
            textBox_saldoEstudante.Text = "";
            email.Text = "";
            gcb_cat.Text = "Selecionar Estatuto";
        }

        private void button_editarEstudante_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)listBox_cliente.SelectedItem;

                if (cliente != null)
                {
                    if (cliente is Estudante estudante)
                    {
                        estudante.Name = textBox_nomeEstudante.Text;
                        estudante.NIF = int.Parse(textBox_nifEstudante.Text);
                        estudante.Saldo = decimal.Parse(textBox_saldoEstudante.Text);
                        estudante.NumEstudante = int.Parse(textBox_nEstudante.Text);
                        alunoController.atualizarEstudante(estudante.Id, estudante.Name, estudante.NIF, estudante.Saldo, estudante.NumEstudante);
                    }
                    else if (cliente is Professor professor)
                    {
                        professor.Name = textBox_nomeEstudante.Text;
                        professor.NIF = int.Parse(textBox_nifEstudante.Text);
                        professor.Saldo = decimal.Parse(textBox_saldoEstudante.Text);
                        professor.Email = email.Text;
                        professorController.atualizarProfessor(professor.Id, professor.Name, professor.NIF, professor.Saldo, professor.Email);
                    }

                    AtualizarListBox();
                }
                else
                {
                    MessageBox.Show("Selecione um cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal formularioPrincipal = new FormPrincipal(db);
            formularioPrincipal.Show();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gcb_cat.SelectedItem.ToString() == "Professor")
            {
                label_Nestudante.Enabled = false;
                textBox_nEstudante.Enabled = false;
                label2.Enabled = true;
                email.Enabled = true;
                textBox_nomeEstudante.Enabled = true;
                textBox_nEstudante.Enabled = false;
                textBox_saldoEstudante.Enabled = true;
                textBox_nifEstudante.Enabled = true;
            }
            else if (gcb_cat.SelectedItem.ToString() == "Estudante")
            {
                label2.Enabled = false;
                email.Enabled = false;
                label_Nestudante.Enabled = true;
                textBox_nEstudante.Enabled = true;
                textBox_nomeEstudante.Enabled = true;
                textBox_nEstudante.Enabled = true;
                textBox_saldoEstudante.Enabled = true;
                textBox_nifEstudante.Enabled = true;
            }
        }

        private void listBox_estudante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_cliente.SelectedItem != null)
            {
                Cliente clienteSelecionado = (Cliente)listBox_cliente.SelectedItem;

                if (clienteSelecionado != null)
                {
                    textBox_nomeEstudante.Text = clienteSelecionado.Name;
                    textBox_nifEstudante.Text = clienteSelecionado.NIF.ToString();
                    textBox_saldoEstudante.Text = clienteSelecionado.Saldo.ToString();

                    if (clienteSelecionado is Estudante estudante)
                    {
                        textBox_nEstudante.Text = estudante.NumEstudante.ToString();
                        email.Text = "";
                        gcb_cat.SelectedItem = "Estudante";
                    }
                    else if (clienteSelecionado is Professor professor)
                    {
                        email.Text = professor.Email;
                        gcb_cat.SelectedItem = "Professor";
                        textBox_nEstudante.Text = "";
                    }
                }
            }
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            label_Nestudante.Enabled = false;
            textBox_nEstudante.Enabled = false;
            label2.Enabled = false;
            email.Enabled = false;
            textBox_nomeEstudante.Enabled = false;
            textBox_nEstudante.Enabled = false;
            textBox_saldoEstudante.Enabled = false;
            textBox_nifEstudante.Enabled = false;
        }
    }
}
