using Atelie.Entidades;
using Atelie.Servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelie.Forms
{
    public partial class FormEncomendaConsulta : Form
    {
        private const int indexColunaEditar = 0;
        private const int indexColunaEncomendaId = 4;
        private const int indexColunaClienteId = 5;

        public FormEncomenda formEncomenda { get; set; } = new FormEncomenda();

        EncomendaServico encomendaServico;
        ClienteServico clienteServico;

        public List<Encomenda> Encomendas { get; set; } = new List<Encomenda>();
        public Cliente cliente { get; set; } = new Cliente();

        public FormEncomendaConsulta(int ClienteId = 0)
        {
            InitializeComponent();
            encomendaServico = new EncomendaServico();
            clienteServico = new ClienteServico();

            if (ClienteId > 0)
            {
                Pesquisar(ClienteId, DateTime.MinValue);
                cliente = clienteServico.RetornaCliente(ClienteId);
                AtualizarGridEncomendas();
            }
        }

        private void dgvEncomenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int EncomendaId = Convert.ToInt32(dgvEncomenda.Rows[e.RowIndex].Cells[indexColunaEncomendaId].Value);
            int ClienteId = Convert.ToInt32(dgvEncomenda.Rows[e.RowIndex].Cells[indexColunaClienteId].Value);
            
            if (e.ColumnIndex == indexColunaEditar)
            {
                formEncomenda = new FormEncomenda(EncomendaId, ClienteId);
                formEncomenda.ShowDialog();
            }
        }

        private void Pesquisar(int clienteId, DateTime dataEntrega)
        {
            Encomendas = encomendaServico.Pesquisa(clienteId, dataEntrega);
            AtualizarGridEncomendas();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //TODO

            int ClienteId = 0;
            DateTime dataEntrega = DateTime.MinValue;

            Int32.TryParse(cmbCliente.SelectedValue.ToString(), out ClienteId);
            DateTime.TryParse(dtpDataEntrega.Text, out dataEntrega);

            Pesquisar(ClienteId, dataEntrega);
        }

        private void AtualizarGridEncomendas()
        {
            dgvEncomenda.DataSource = (from e in Encomendas select new {
                NomeCliente = cliente.Nome
                , DataEntrega = e.DataEntregaPrevista
                , Descricao = e.Descricao
                , EncomendaId = e.Id
                , ClienteId = cliente.Id}).ToList();

            if (Encomendas.Any())
            {
                dgvEncomenda.Columns["NomeCliente"].DisplayIndex = 0;
                dgvEncomenda.Columns["DataEntregaPrev"].DisplayIndex = 1;
                dgvEncomenda.Columns["Descricao"].DisplayIndex = 2;
                dgvEncomenda.Columns["Editar"].DisplayIndex = 3;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
