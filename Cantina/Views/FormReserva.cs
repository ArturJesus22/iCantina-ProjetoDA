using iCantina.Controllers;
using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace iCantina.Views
{
    public partial class FormReserva : Form
    {
        private BindingList<Reserva> listaReservas = new BindingList<Reserva>();
        private BindingList<Models.Menu> lista_menu;
        private BindingList<Multa> listaMultas = new BindingList<Multa>();
        private BindingList<Extra> extrasSelecionados = new BindingList<Extra>();
        private EstudanteController estudanteController;
        private ProfessorController professorController;
        private MenuController menuController;
        private ReservaController reservaController;
        private MultaController multaController;
        private Models.Menu menuSelecionado;
        public CantinaContext db;
        private BindingList<Reserva> listaReservasUtilizadas = new BindingList<Reserva>();

        public FormReserva(CantinaContext db)
        {
            this.db = db;
            this.reservaController = new ReservaController(this.db);
            this.menuController = new MenuController(this.db);
            this.estudanteController = new EstudanteController(this.db);
            this.professorController = new ProfessorController(this.db);
            this.multaController = new MultaController(this.db);
            InitializeComponent();
            ObterMenus();
            ObterEstudante();
            ObterProfessor();
            ObterMultas();
            ObterReservas();
        }

        private void ObterMenus()
        {
            lista_menu = menuController.GetMenus();
            AtualizarListBoxMenu();
        }

        private void ObterEstudante()
        {
            try
            {
                BindingList<Estudante> estudantes = estudanteController.GetEstudantes();
                listBox_estudantes.Items.Clear();
                foreach (var estudante in estudantes)
                {
                    listBox_estudantes.Items.Add(estudante);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar estudantes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObterProfessor()
        {
            try
            {
                BindingList<Professor> professores = professorController.GetProfessores();
                listBox_Professores.Items.Clear();
                foreach (var professor in professores)
                {
                    listBox_Professores.Items.Add(professor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar professores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObterMultas()
        {
            try
            {
                listaMultas = multaController.GetMultas();
                listBox_multas.Items.Clear();
                foreach (var multa in listaMultas)
                {
                    listBox_multas.Items.Add(multa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar multas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarListBoxMenu()
        {
            try
            {
                lista_menu = menuController.GetMenus();
                listBox_menus.Items.Clear();
                foreach (var menu in lista_menu)
                {
                    listBox_menus.Items.Add(menu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar a lista de menus: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox_menus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_menus.SelectedItem is Models.Menu menu)
            {
                menuSelecionado = menu; // Renomear para menuSelecionado (local)
                AtualizarListBoxPratos(menu);
                AtualizarListBoxExtras(menu);
            }
        }

        private void AtualizarListBoxPratos(Models.Menu menu)
        {
            listBox_pratosdomenu.Items.Clear();
            foreach (var prato in menu.Pratos)
            {
                listBox_pratosdomenu.Items.Add(prato);
            }
        }

        private void AtualizarListBoxExtras(Models.Menu menu)
        {
            listBox_extrasdomenu.Items.Clear();
            foreach (var extra in menu.Extras)
            {
                listBox_extrasdomenu.Items.Add(extra);
            }
        }

        private bool ValidarReserva(out Cliente cliente, out Prato pratoSelecionado, out BindingList<Extra> extrasSelecionados, out Multa multaSelecionada, out decimal totalGasto)
        {
            cliente = null;
            pratoSelecionado = null;
            extrasSelecionados = new BindingList<Extra>();
            multaSelecionada = null;
            totalGasto = 0;

            // Verificar se foi selecionado pelo menos um cliente (estudante ou professor)
            bool estudanteSelecionado = listBox_estudantes.SelectedItems.Count > 0;
            bool professorSelecionado = listBox_Professores.SelectedItems.Count > 0;

            if (!estudanteSelecionado && !professorSelecionado)
            {
                MessageBox.Show("Selecione pelo menos um cliente (estudante ou professor).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar se foi selecionado mais de um cliente (não pode selecionar ambos)
            if (estudanteSelecionado && professorSelecionado)
            {
                MessageBox.Show("Selecione apenas um cliente (estudante ou professor).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar se foi selecionado exatamente um prato
            if (listBox_pratosdomenu.SelectedItems.Count != 1)
            {
                MessageBox.Show("Selecione exatamente um prato.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar se foram selecionados no máximo três extras
            if (listBox_extrasdomenu.SelectedItems.Count > 3)
            {
                MessageBox.Show("Selecione no máximo três extras.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Obter o cliente selecionado
            if (listBox_estudantes.SelectedItems.Count > 0)
            {
                cliente = (Estudante)listBox_estudantes.SelectedItem;
            }
            else if (listBox_Professores.SelectedItems.Count > 0)
            {
                cliente = (Professor)listBox_Professores.SelectedItem;
            }

            // Obter o prato selecionado
            pratoSelecionado = (Prato)listBox_pratosdomenu.SelectedItem;

            // Adicionar os extras selecionados à BindingList
            foreach (var extraSelecionado in listBox_extrasdomenu.SelectedItems)
            {
                Extra extra = (Extra)extraSelecionado;
                extrasSelecionados.Add(extra);
            }

            // Obter a multa selecionada
            multaSelecionada = (Multa)listBox_multas.SelectedItem;

            // Calcula o total gasto com base no cliente, prato selecionado, extras e multa
            totalGasto = CalcularTotalGasto(cliente, pratoSelecionado, extrasSelecionados, multaSelecionada);

            // Verifica se o saldo do cliente é suficiente para cobrir o total gasto
            if (cliente.Saldo < totalGasto)
            {
                MessageBox.Show("Saldo insuficiente para realizar a reserva.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ObterReservas()
        {
            try
            {
                // Chama o método GetAllReservas do ReservaController
                BindingList<Reserva> reservas = reservaController.GetReservas();

                // Limpa a lista atual de reservas
                listaReservas.Clear();
                listaReservasUtilizadas.Clear();

                // Adiciona todas as reservas retornadas à lista de reservas do formulário
                foreach (var reserva in reservas)
                {
                    if (reserva.Utilizada)
                    {
                        listaReservasUtilizadas.Add(reserva);
                    }
                    else
                    {
                        listaReservas.Add(reserva);
                    }
                }

                // Atualiza as listBox_reserva e listBox_reservasUtilizadas para exibir os dados das reservas
                AtualizarListBoxReservas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter reservas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarListBoxReservas()
        {
            listBox_reserva.Items.Clear();
            listBox_reservasUtilizadas.Items.Clear();

            foreach (var reserva in listaReservas)
            {
                listBox_reserva.Items.Add(reserva);
            }

            foreach (var reserva in listaReservasUtilizadas)
            {
                listBox_reservasUtilizadas.Items.Add(reserva);
            }
        }

        private void botton_criarReserva_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validar a reserva
                if (!ValidarReserva(out Cliente cliente, out Prato pratoSelecionado, out BindingList<Extra> extrasSelecionados, out Multa multaSelecionada, out decimal totalGasto))
                {
                    return;
                }

                // Atualizar o saldo do cliente na base de dados
                cliente.Saldo -= totalGasto;
                AtualizarSaldoCliente(cliente);

                // Adicionar a reserva usando o método do ReservaController
                Reserva reserva = reservaController.adicionarReserva(cliente, pratoSelecionado, extrasSelecionados, totalGasto, multaSelecionada);
                reserva.TotalGasto = totalGasto; // Atribui o total gasto calculado à reserva

                // Adicionar a reserva à lista de reservas por efetuar
                listaReservas.Add(reserva);

                // Atualiza a listBox_reserva para exibir os dados da reserva
                AtualizarListBoxReservas();

                MessageBox.Show("Reserva criada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button_apagar_reserva_Click_1(object sender, EventArgs e)
        {
            if (listBox_reserva.SelectedItem is Reserva reserva)
            {
                try
                {
                    // Chama o método RemoveReserva do ReservaController
                    reservaController.removerReserva(reserva.Id);

                    // Remove a reserva da lista de reservas do formulário
                    listaReservas.Remove(reserva);

                    // Atualiza a listBox_reserva para exibir os dados das reservas
                    AtualizarListBoxReservas();

                    MessageBox.Show("Reserva apagada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao apagar reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (listBox_reservasUtilizadas.SelectedItem is Reserva reservaUtilizada)
            {
                MessageBox.Show("Esta reserva já foi utilizada e não pode ser cancelada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Selecione uma reserva para apagar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_fatura_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se uma reserva foi selecionada
                if (listBox_reserva.SelectedItem is Reserva reserva)
                {
                    // Obtém o cliente da reserva
                    Cliente cliente = reserva.Cliente;

                    // Obtém o prato da reserva
                    Prato pratoSelecionado = reserva.Prato;

                    // Obtém os extras da reserva
                    extrasSelecionados.Clear();
                    foreach (var extra in reserva.Extras)
                    {
                        extrasSelecionados.Add(extra);
                    }

                    // Obtém a multa da reserva
                    Multa multaSelecionada = reserva.Multa;

                    // Calcula o total gasto com base nos dados da reserva
                    decimal totalGasto = reserva.TotalGasto;

                    // Gerar a fatura
                    string fatura = GerarFatura(cliente, pratoSelecionado, extrasSelecionados, multaSelecionada, totalGasto);

                    // Nomear o arquivo PDF com o nome do cliente da reserva
                    string nomeCliente = cliente.Name.Replace(" ", "_");
                    string caminhoFatura = $"Fatura_{nomeCliente}_{DateTime.Now:yyyyMMddHHmmss}.pdf";

                    // Salvar a fatura em um arquivo PDF
                    string diretorioAtual = Directory.GetCurrentDirectory();
                    string caminhoCompletoFatura = Path.Combine(diretorioAtual, caminhoFatura);
                    GerarPdfFatura(fatura, caminhoCompletoFatura);

                    MessageBox.Show($"Fatura gerada com sucesso!\nCaminho: {caminhoCompletoFatura}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selecione uma reserva para gerar a fatura.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar fatura: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void GerarPdfFatura(string fatura, string caminhoCompletoFatura)
        {
            using (FileStream fs = new FileStream(caminhoCompletoFatura, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                // Adiciona o conteúdo da fatura ao documento PDF
                document.Add(new Paragraph(fatura));

                document.Close();
                writer.Close();
            }
        }

        private string GerarFatura(Cliente cliente, Prato prato, BindingList<Extra> extras, Multa multa, decimal totalGasto)
        {
            StringBuilder fatura = new StringBuilder();

            fatura.AppendLine("----- iCantina -----");
            fatura.AppendLine("");
            fatura.AppendLine("----- Fatura -----");
            fatura.AppendLine($"Cliente: {cliente.Name}");
            fatura.AppendLine($"Tipo: {(cliente is Estudante ? "Estudante" : "Professor")}");
            fatura.AppendLine($"Prato: {prato.Descricao}");
            decimal precoMenu = cliente is Estudante ? prato.Menu.PrecoEstudante : prato.Menu.PrecoProfessor;
            fatura.AppendLine($"Preço Menu: {precoMenu:C}");
            fatura.AppendLine("Extras:");
            if (extras.Count > 0)
            {
                foreach (var extra in extras)
                {
                    fatura.AppendLine($"- {extra.Descricao}: {extra.Preco:C}");
                }
            }
            else
            {
                fatura.AppendLine("- Nenhum extra selecionado");
            }
            if (multa != null)
            {
                fatura.AppendLine($"Multa: {multa.Valor:C}");
            }
            else
            {
                fatura.AppendLine("Multa: Nenhuma");
            }
            fatura.AppendLine($"Total Gasto: {totalGasto:C}");
            fatura.AppendLine("------------------");
            fatura.AppendLine("Programa Desenvolvido Por:");
            fatura.AppendLine("Artur Jesus - 2220866");
            fatura.AppendLine("Diogo Fernandes - 2231657");

            return fatura.ToString();
        }

        private decimal CalcularTotalGasto(Cliente cliente, Prato prato, BindingList<Extra> extras, Multa multa)
        {
            decimal totalGasto = 0;

            // Adiciona o preço do prato com base no tipo de cliente (estudante ou professor)
            if (cliente is Estudante)
            {
                totalGasto += prato.Menu.PrecoEstudante;
            }
            else if (cliente is Professor)
            {
                totalGasto += prato.Menu.PrecoProfessor;
            }

            // Adiciona o preço de cada extra
            foreach (var extra in extras)
            {
                totalGasto += extra.Preco;
            }

            // Verifica se há uma multa selecionada e adiciona o valor da multa ao total gasto
            if (multa != null)
            {
                // Verificar a hora atual e a hora limite para aplicação da multa
                DateTime horaAtual = DateTime.Now;
                DateTime horaLimiteMulta = prato.Menu.DataHora.AddHours(-multa.NumHoras);

                // Se estiver dentro do tempo limite para aplicar a multa
                if (horaAtual > horaLimiteMulta)
                {
                    totalGasto += multa.Valor;
                }
            }

            return totalGasto;
        }

        private void AtualizarSaldoCliente(Cliente cliente)
        {
            try
            {
                if (cliente is Estudante estudante)
                {
                    estudanteController.AtualizarSaldo(estudante.Id, estudante.Saldo);
                }
                else if (cliente is Professor professor)
                {
                    professorController.AtualizarSaldo(professor.Id, professor.Saldo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar saldo do cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_efetuarReserva_Click(object sender, EventArgs e)
        {
            // Verificar se uma reserva foi selecionada
            if (listBox_reserva.SelectedItem is Reserva reservaSelecionada)
            {
                // Verificar se a reserva já foi utilizada
                if (reservaSelecionada.Utilizada)
                {
                    MessageBox.Show("Esta reserva já foi utilizada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Marcar a reserva como utilizada
                reservaSelecionada.Utilizada = true;

                // Atualizar a reserva na base de dados
                reservaController.AtualizarReserva(reservaSelecionada);

                // Remover a reserva da lista de reservas por efetuar e adicionar à lista de reservas utilizadas
                listaReservas.Remove(reservaSelecionada);
                listaReservasUtilizadas.Add(reservaSelecionada);

                // Atualizar as listas de reservas
                AtualizarListBoxReservas();

                MessageBox.Show("Reserva marcada como utilizada com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione uma reserva para marcar como utilizada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
