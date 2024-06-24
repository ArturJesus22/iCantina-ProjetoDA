using iCantina.Controllers;
using iCantina.Models;
using System.ComponentModel;
using System.Windows.Forms;
using System;

namespace iCantina.Views
{
    public partial class FormPrincipal : Form
    {
        private BindingList<Funcionario> listaFuncionario = new BindingList<Funcionario>();
        private CantinaContext db;
        private FuncionarioController funcController;
        private Funcionario funcionarioSelecionado;

        public FormPrincipal(CantinaContext db)
        {
            this.db = db;
            this.funcController = new FuncionarioController(this.db);
            InitializeComponent();
        }



        private void btn_Pratos_Click(object sender, EventArgs e)
        {
            // Instancia o formulário FormPratos
            this.Close();
            FormPrato formPratos = new FormPrato(db);

            // Exibe o formulário
            formPratos.Show();
        }

        private void bt_extras_Click(object sender, EventArgs e)
        {
            // Instancia o formulário FormExtras
            this.Close();
            FormExtra formExtra = new FormExtra(db);

            // Exibe o formulário
            formExtra.Show();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            // Instancia o formulário FormMenu
            this.Close();
            FormMenu formMenu = new FormMenu(db);

            // Exibe o formulário
            formMenu.Show();
        }

        private void bt_Multas_Click(object sender, EventArgs e)
        {
            // Instancia o formulário FormMultas
            this.Close();
            FormMulta formMulta = new FormMulta(db);

            // Exibe o formulário
            formMulta.Show();
        }

        private void bt_Reservas_Click(object sender, EventArgs e)
        {
            // Instancia o formulário FormReserva
            this.Close();
            FormReserva formReserva = new FormReserva(db);

            // Exibe o formulário
            formReserva.Show();
        }

        private void bt_Funcionarios_Click(object sender, EventArgs e)
        {
            this.Close();
            FormFuncionario f_f = new FormFuncionario(db);
            // Adicionar um evento para atualizar a lista de funcionários quando o formulário de funcionários for fechado
            f_f.ShowDialog();
        }

        private void bt_Estudantes_Click(object sender, EventArgs e)
        {
            this.Close();
            // Instancia o formulário Estutdante
            FormCliente formEstudantes = new FormCliente(db);

            // Exibe o formulário
            formEstudantes.Show();
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lbUsername.Text = FormLogin.username_global;
            string dia = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lb_data.Text = dia;
        }
    }
}

