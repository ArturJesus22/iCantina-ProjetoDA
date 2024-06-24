using iCantina.Controllers;
using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Views
{
    public partial class FormMenu : Form
    {
        private CantinaContext db;
        private PratoController pratoController;
        private MenuController menuController;
        private ExtraController extraController;
        private BindingList<Models.Menu> lista_menu = new BindingList<Models.Menu>();
        public FormMenu(CantinaContext db)
        {
            InitializeComponent();
            this.db = db;
            this.pratoController = new PratoController(this.db);
            this.menuController = new MenuController(this.db);
            this.extraController = new ExtraController(this.db);
            CarregarPratosAtivos();
            CarregarExtrasAtivos();
            ObterMenus();
            this.listBox_menu.SelectedIndexChanged += new System.EventHandler(this.listBox_menu_SelectedIndexChanged);
        }

        public void CarregarPratosAtivos()
        {
            try
            {
                BindingList<Prato> pratosAtivos = pratoController.GetPratosAtivos();
                listBox_pratos.Items.Clear();
                foreach (var prato in pratosAtivos)
                {
                    listBox_pratos.Items.Add(prato);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CarregarExtrasAtivos()
        {
            try
            {
                BindingList<Extra> extrasAtivos = extraController.GetExtrasAtivos();
                listBox_extras.Items.Clear();
                foreach (var extra in extrasAtivos)
                {
                    listBox_extras.Items.Add(extra);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObterMenus()
        {
            try
            {
                lista_menu = menuController.GetMenus();
                AtualizarListBoxMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter os menus: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarListBoxMenu()
        {
            try
            {
               // lista_menu = menuController.GetMenus();
                listBox_menu.Items.Clear();
                foreach (var menu in lista_menu)
                {
                    listBox_menu.Items.Add(menu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar a lista de menus: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_criar_menu_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime data = dateTimePicker1.Value;
                DateTime hora = dateTimePicker2.Value;

                DateTime dataHora = new DateTime(data.Year, data.Month, data.Day, hora.Hour, hora.Minute, hora.Second);

                decimal precoEstudante = decimal.Parse(textBox_precoest.Text);
                decimal precoProfessor = decimal.Parse(textBox_precoprof.Text);

                List<Prato> pratosSelecionados = listBox_pratos.SelectedItems.Cast<Prato>().ToList();
                List<Extra> extrasSelecionados = listBox_extras.SelectedItems.Cast<Extra>().ToList();

                if (pratosSelecionados.Count != 3)
                {
                    MessageBox.Show("Selecione exatamente 3 pratos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool temCarne = pratosSelecionados.Any(p => p.Tipo.ToLower() == "carne");
                bool temPeixe = pratosSelecionados.Any(p => p.Tipo.ToLower() == "peixe");
                bool temVegetariano = pratosSelecionados.Any(p => p.Tipo.ToLower() == "vegetariano");

                if (!temCarne || !temPeixe || !temVegetariano)
                {
                    MessageBox.Show("Selecione um prato de cada tipo: Carne, Peixe e Vegetariano.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                BindingList<Prato> bindingPratosSelecionados = new BindingList<Prato>(pratosSelecionados);
                BindingList<Extra> bindingExtrasSelecionados = new BindingList<Extra>(extrasSelecionados);

                iCantina.Models.Menu menu = new iCantina.Models.Menu
                {
                    DataHora = dataHora,
                    PrecoEstudante = precoEstudante,
                    PrecoProfessor = precoProfessor,
                    Pratos = bindingPratosSelecionados,
                    Extras = bindingExtrasSelecionados
                };

                menuController.adicionarMenu(menu.DataHora, menu.PrecoEstudante, menu.PrecoProfessor, menu.Pratos, menu.Extras);

                lista_menu.Add(menu);
                AtualizarListBoxMenu();

                MessageBox.Show("Menu criado com sucesso!");
            }
            catch (DbUpdateException ex)
            {
                // Exibir a mensagem da exceção interna
                MessageBox.Show($"Erro ao salvar/atualizar no banco de dados: {ex.InnerException.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar o menu: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_apagar_menu_Click_1(object sender, EventArgs e)
        {
            try
            {
                iCantina.Models.Menu menu = (iCantina.Models.Menu)listBox_menu.SelectedItem;

                if (menu != null)
                {
                    menuController.apagarMenu(menu.Id);
                    lista_menu.Remove(menu); // Remove da lista local

                    // Atualiza a listBox_menu
                    AtualizarListBoxMenu();

                    MessageBox.Show("Menu apagado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Selecione um menu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao apagar o menu: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button_atualizar_menu_Click(object sender, EventArgs e)
        {
            try
            {
                iCantina.Models.Menu menu = (iCantina.Models.Menu)listBox_menu.SelectedItem;

                if (menu != null)
                {
                    DateTime data = dateTimePicker1.Value;
                    DateTime hora = dateTimePicker2.Value;
                    DateTime dataHora = new DateTime(data.Year, data.Month, data.Day, hora.Hour, hora.Minute, hora.Second);
                    decimal precoEstudante = decimal.Parse(textBox_precoest.Text);
                    decimal precoProfessor = decimal.Parse(textBox_precoprof.Text);
                    List<Prato> pratosSelecionados = listBox_pratos.SelectedItems.Cast<Prato>().ToList();
                    List<Extra> extrasSelecionados = listBox_extras.SelectedItems.Cast<Extra>().ToList();

                    if (pratosSelecionados.Count != 3)
                    {
                        MessageBox.Show("Selecione exatamente 3 pratos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool temCarne = pratosSelecionados.Any(p => p.Tipo.ToLower() == "carne");
                    bool temPeixe = pratosSelecionados.Any(p => p.Tipo.ToLower() == "peixe");
                    bool temVegetariano = pratosSelecionados.Any(p => p.Tipo.ToLower() == "vegetariano");

                    if (!temCarne || !temPeixe || !temVegetariano)
                    {
                        MessageBox.Show("Selecione um prato de cada tipo: Carne, Peixe e Vegetariano.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    BindingList<Prato> bindingPratosSelecionados = new BindingList<Prato>(pratosSelecionados);
                    BindingList<Extra> bindingExtrasSelecionados = new BindingList<Extra>(extrasSelecionados);

                    menu.DataHora = dataHora;
                    menu.PrecoEstudante = precoEstudante;
                    menu.PrecoProfessor = precoProfessor;
                    menu.Pratos = bindingPratosSelecionados;
                    menu.Extras = bindingExtrasSelecionados;

                    menuController.atualizarMenu(menu);

                    // Atualiza a listBox_menu
                    AtualizarListBoxMenu();

                    MessageBox.Show("Menu atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Selecione um menu para atualizar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o menu: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            iCantina.Models.Menu menu = (iCantina.Models.Menu)listBox_menu.SelectedItem;
            if (menu != null)
            {
                // Preencher os controles com os dados do menu selecionado
                dateTimePicker1.Value = menu.DataHora.Date;
                dateTimePicker2.Value = menu.DataHora;
                textBox_precoest.Text = menu.PrecoEstudante.ToString();
                textBox_precoprof.Text = menu.PrecoProfessor.ToString();

                // Preencher a seleção de pratos
                for (int i = 0; i < listBox_pratos.Items.Count; i++)
                {
                    Prato prato = (Prato)listBox_pratos.Items[i];
                    if (menu.Pratos.Contains(prato))
                    {
                        listBox_pratos.SetSelected(i, true);
                    }
                    else
                    {
                        listBox_pratos.SetSelected(i, false);
                    }
                }

                // Preencher a seleção de extras
                for (int i = 0; i < listBox_extras.Items.Count; i++)
                {
                    Extra extra = (Extra)listBox_extras.Items[i];
                    if (menu.Extras.Contains(extra))
                    {
                        listBox_extras.SetSelected(i, true);
                    }
                    else
                    {
                        listBox_extras.SetSelected(i, false);
                    }
                }
            }
        }
    }
}
