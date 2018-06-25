using Atelie.Entidades;
using Atelie.Modelo;
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
    public partial class FormProvaConsulta : Form
    {
        public List<ProvaModelo> Provas { get; set; }

        ProvaServico provaServico;
        ClienteServico clienteServico;

        public FormProvaConsulta(int clienteId = 0)
        {
            InitializeComponent();
            provaServico = new ProvaServico();
            clienteServico = new ClienteServico();
            cmbCliente.DataSource = clienteServico.PesquisaClientes(string.Empty, string.Empty, string.Empty);

            if (clienteId > 0)
            {
                Provas = provaServico.ObterListagem(clienteId, DateTime.Now);
                AtualizarGridProvas();
                cmbCliente.Text = Provas.First().NomeCliente;
                cmbCliente.Enabled = dtpData.Enabled = btnPesquisar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pesquisar(int clienteId, DateTime data)
        {
            Provas = provaServico.ObterListagem(clienteId, data);
            AtualizarGridProvas();
        }

        private void AtualizarGridProvas()
        {
            dgvProva.DataSource = Provas;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int ClienteId = 0;
            DateTime data = DateTime.MinValue;
            string val = string.Empty;
            if (cmbCliente.SelectedValue != null)
                val = cmbCliente.SelectedValue.ToString();

            Int32.TryParse(val, out ClienteId);
            DateTime.TryParse(dtpData.Text, out data);

            Pesquisar(ClienteId, data);
        }
    }
}
