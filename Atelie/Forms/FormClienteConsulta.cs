using Atelie.Entidades;
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

        public FormClienteConsulta()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //TODO 
            clientes.Add(new Cliente { Nome = "Maria", Telefone = "(14) 99878-4456", CPF = "8789976" });
            AtualizarGridClientes();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == indexColunaConsultarEncomendas)
            {

            }else if (e.ColumnIndex == indexColunaConsultarProvas)
            {

            }else if (e.ColumnIndex == indexColunaEditar)
            {

            }else if (e.ColumnIndex == indexColunaExcluir)
            {

            }
        }

        private void AtualizarGridClientes()
        {
            dgvCliente.DataSource = (from c in clientes select new { Nome = c.Nome, CPF = c.CPF, Telefone = c.Telefone}).ToList();
        }
    }
}
