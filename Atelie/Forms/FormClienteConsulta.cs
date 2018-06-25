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
    public partial class FormClienteConsulta : Form
    {
        private const int indexColunaConsultarEncomendas = 0;
        private const int indexColunaConsultarProvas = 1;
        private const int indexColunaEditar = 2;
        private const int indexColunaExcluir = 3;

        public List<Cliente> clientes { get; set; } = new List<Cliente>();

        public ClienteServico clienteServico = new ClienteServico();

        FormCliente formCliente;
        FormEncomendaConsulta formEncomendaConsulta;
        
        public FormClienteConsulta()
        {
            InitializeComponent();
            Pesquisar();
        }

        private void Pesquisar()
        {
            clientes = clienteServico.PesquisaClientes(txtNome.Text, txtCPF.Text, txtTelefone.Text);
            AtualizarGridClientes();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int clienteId = 1;
            if (e.ColumnIndex == indexColunaConsultarEncomendas)
            {
                formEncomendaConsulta = new FormEncomendaConsulta(clienteId);
                formEncomendaConsulta.Show();
            }else if (e.ColumnIndex == indexColunaConsultarProvas)
            {
                
            }else if (e.ColumnIndex == indexColunaEditar)
            {
                formCliente = new FormCliente(clienteId);
                formCliente.Show();
            }else if (e.ColumnIndex == indexColunaExcluir)
            {

            }
        }

        private void AtualizarGridClientes()
        {
            dgvCliente.DataSource = (from c in clientes select new { Nome = c.Nome, CPF = c.CPF, Telefone = c.Telefone, Id = c.Id}).ToList();
        }

        private void tbnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
